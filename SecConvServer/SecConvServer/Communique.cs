using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Net;
using System.Net.Sockets;

namespace SecConvServer
{
    class Communique
    {
        static Dictionary<int, Delegate> communiqueDictionary = new Dictionary<int, Delegate>();

        public static void AddDelegateToDictionary()
        {
            //in, out
            communiqueDictionary[0] = new Func<List<string>, string> (Communique.Register);
            communiqueDictionary[1] = new Func<List<string>,Socket, string>(Communique.LogIn);
            communiqueDictionary[2] = new Func<List<string>, string>(Communique.LogOut);
            communiqueDictionary[3] = new Func<List<string>, string>(Communique.AccDel);
            communiqueDictionary[4] = new Func<List<string>, string>(Communique.PassChng);
            communiqueDictionary[8] = new Func<List<string>, string>(Communique.AddFriend);
            communiqueDictionary[9] = new Func<List<string>, string>(Communique.DelFriend);
            communiqueDictionary[11] = new Func<List<string>, string>(Communique.CallState);
            communiqueDictionary[13] = new Func<long, string>(Communique.History);
            communiqueDictionary[15] = new Func<List<string>, string>(Communique.Iam);
            
        }
        //Incoming messages
        public static string Register(List<string> param)
        {
            //Communication with DB
            using (var ctx = new SecConvDBEntities())
            {
                var newUser = new Users();
                string login= param[0];//login

                int loginUnique = ctx.Users.Where(x => x.Login == login).Count(); //check if login is unique
                if (loginUnique == 0)
                {
                    newUser.Login = login;
                    newUser.Password = Utilities.hashBytePassHex(param[1]+login); //256 bit hash password          
                    newUser.LastLogoutDate = DateTime.Now;
                    newUser.RegistrationDate = DateTime.Now;

                    ctx.Users.Add(newUser);
                    try
                    {
                        ctx.SaveChanges();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        return Fail(); ;
                    }
                }
                else
                {
                    return Fail() ;
                }
            }
            //OK
            return OK();

        }
        public static string LogIn(List<string> param, Socket client)
        {
            string login = param[0];

            string password = Utilities.hashBytePassHex(param[1]+login);

            //users -> online
            using (var ctx = new SecConvDBEntities())
            {
                var user = ctx.Users.Where(x => x.Login == login && x.Password == password).FirstOrDefault();
                if (user!=null)
                {
                    if (Program.onlineUsers.ContainsKey(user.UserID))
                    {
                        return Fail();
                    }
                    ConnectedClient connectedClient = new ConnectedClient();
                    connectedClient.login = login;
                    connectedClient.iAM = DateTime.Now;
                    connectedClient.addressIP = ((IPEndPoint)client.RemoteEndPoint).Address.ToString();
                    //add to dictionary
                    Program.onlineUsers[user.UserID] = connectedClient;
                    return OK();
                }
                else
                {
                    return Fail();
                }
            }
        }
        public static string LogOut(List<string> param)
        {
            string login = param[0];

            using (var ctx = new SecConvDBEntities())
            {
                var userToLogOut = ctx.Users.Where(x => x.Login == login).FirstOrDefault();
                if (userToLogOut != null)
                {
                    userToLogOut.LastLogoutDate = DateTime.Now;
                    try
                    {
                        Program.onlineUsers.Remove(userToLogOut.UserID); //delete from dictionary
                        ctx.Entry(userToLogOut).State = System.Data.Entity.EntityState.Modified;
                        ctx.SaveChanges();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        return Fail();
                    }
                }
                else
                {
                    return Fail();
                }
            }
                return OK();
        }
        public static string AccDel(List<string> param)
        {
            string login = param[0];
            string password = Utilities.hashBytePassHex(param[1]+login);
            using (var ctx = new SecConvDBEntities())
            {
                var userToDelete = ctx.Users.Where(x => x.Login == login && x.Password == password).FirstOrDefault();
                if (userToDelete!=null)
                {
                    try
                    {
                        //1. set, in history, id to null, it can be first or second
                        var userHistory = ctx.Histories.Where(x => x.UserReceiverID == userToDelete.UserID);//first
                        foreach (var item in userHistory)
                        {
                            item.UserReceiverID = null;
                            ctx.Entry(item).State = System.Data.Entity.EntityState.Modified;
                        }
                        userHistory = ctx.Histories.Where(x => x.UserSenderID == userToDelete.UserID);//second
                        foreach (var item in userHistory)
                        {
                            item.UserSenderID = null;
                            ctx.Entry(item).State = System.Data.Entity.EntityState.Modified;
                        }

                        //2. delete acquaintances in both directions
                        var userAcquaintances=ctx.Friends.Where(x => x.UserID1 == userToDelete.UserID);//first
                        foreach (var item in userAcquaintances)
                        {
                            ctx.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                        }
                        userAcquaintances = ctx.Friends.Where(x => x.UserID2 == userToDelete.UserID);
                        foreach (var item in userAcquaintances)
                        {
                            ctx.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                        }

                        //3. delete user
                        ctx.Entry(userToDelete).State = System.Data.Entity.EntityState.Deleted;

                        ctx.SaveChanges();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        return Fail();
                    }
                }
                else
                {
                    return Fail();
                }
            }
            return OK();
        }
        public static string PassChng(List <string> param)
        {
            string login = param[0];
            string password1 = Utilities.hashBytePassHex(param[1]+login);
            using (var ctx = new SecConvDBEntities())
            {
                var userToChngPasswd = ctx.Users.Where(x => x.Login == login && x.Password == password1).FirstOrDefault();
                if (userToChngPasswd!=null)
                {
                    userToChngPasswd.Password = Utilities.hashBytePassHex(param[2]+login);
                    try
                    {
                        ctx.Entry(userToChngPasswd).State = System.Data.Entity.EntityState.Modified;
                        ctx.SaveChanges();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        return Fail();
                    }
                }
                else
                {
                    return Fail();
                }
            }
            return OK();
        }
        public static string AddFriend(List<string> param)
        {
            string login1 = param[0]; //user logged in
            string login2 = param[1]; //friend of logged in user
            using (var ctx = new SecConvDBEntities())
            {
                var acquaintance = new Friends();
                //find users IDs
                var userID1 = ctx.Users.Where(x => x.Login == login1).Select(x => x.UserID).FirstOrDefault();
                if (userID1!=0)
                {
                    var userID2 = ctx.Users.Where(x => x.Login == login2).Select(x=>x.UserID).FirstOrDefault();
                    if (userID2!=0)
                    {
                        var acq = ctx.Friends.Where(x => x.UserID1 == userID1 && x.UserID2 == userID2).FirstOrDefault();
                        if (acq == null)
                        {
                            acquaintance.UserID1 = userID1;
                            acquaintance.UserID2 = userID2;
                            try
                            {
                                ctx.Friends.Add(acquaintance);
                                ctx.SaveChanges();
                            }
                            catch (DbUpdateConcurrencyException)
                            {
                                return Fail();
                            }
                        }
                        else
                        {
                            return Fail();
                        }
                    }
                    else
                    {
                        return Fail();
                    }
                }
                else
                {
                    return Fail();
                }
            }
            return OK();
        }
        public static string DelFriend(List<string> param)
        {
            string login1 = param[0]; //logged in user
            string login2 = param[1];

            using (var ctx = new SecConvDBEntities())
            {
                var userLoggedInID1 = ctx.Users.Where(x => x.Login == login1).Select(x => x.UserID).FirstOrDefault();
                if (userLoggedInID1!=0)
                {
                    var user1FriendID = ctx.Users.Where(x => x.Login == login2).Select(x => x.UserID).FirstOrDefault();
                    if (user1FriendID!=0)
                    {
                        var friend = ctx.Friends.Where(x => x.UserID1 == userLoggedInID1 && x.UserID2 == user1FriendID).FirstOrDefault();
                        ctx.Entry(friend).State = System.Data.Entity.EntityState.Deleted;
                        try
                        {
                            ctx.SaveChanges();
                        }
                        catch (DbUpdateConcurrencyException)
                        {
                            return Fail();
                        }
                    }
                    else
                    {
                        return Fail();
                    }
                }
                else
                {
                    return Fail();
                }
            }
            return OK();
        }
        public static string CallState(List<string> param)
        {
            //kto 
            //do kogo
            //data rozpoczecia
            //czas trwania //00:00:00 -> null

            string login1 = param[0];
            string login2 = param[1];

            using (var ctx = new SecConvDBEntities())
            {
                var SenderID = ctx.Users.Where(x => x.Login == login1).Select(x => x.UserID).FirstOrDefault();
                if (SenderID != 0)
                {
                    var ReceiverID = ctx.Users.Where(x => x.Login == login2).Select(x => x.UserID).FirstOrDefault();
                    if (ReceiverID != 0)
                    {
                        var history = new Histories();
                        history.UserSenderID = SenderID;
                        history.UserReceiverID = ReceiverID;
                        //yyyy-MM-dd-HH:mm:ss
                        history.Start = DateTime.ParseExact(param[2], "yyyy-MM-dd-HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                        
                        //HH:mm:ss
                        //TimeSpan duration = TimeSpan.Parse(param[3]);
                        history.Duration = new DateTime().Add(TimeSpan.Parse(param[3]));
                        try
                        {
                            ctx.Histories.Add(history);
                            ctx.SaveChanges();
                        }
                        catch (DbUpdateConcurrencyException)
                        {
                            return Fail();
                        }
                    }
                    else
                    {
                        return Fail();
                    }
                }
                else
                {
                    return Fail();
                }
            }
            return OK();
        }   
        public static string Iam(List<string> param)
        {
            string login = string.Empty;
            login = param[0];

            //check if user exists
            using (var ctx = new SecConvDBEntities())
            {
                var user = ctx.Users.Where(x => x.Login == login).FirstOrDefault();
                if (user != null)
                {
                    Program.onlineUsers[user.UserID].iAM=DateTime.Now;
                }
            }
            return "1";            
        }
        //Outgoing messages
        public static string OK()
        {
            return ((char)5).ToString()+"<EOF>";
        }
         public static string Fail()
        {
            return ((char)6).ToString() + "<EOF>";

        }
        public static string LogIP(long userID)
        {
            using (var ctx = new SecConvDBEntities())
            {
                var user = ctx.Users.Where(x => x.UserID == userID).FirstOrDefault();
                if (user!=null)
                {
                    string message = string.Empty;
                    //0111 login_1 status_1 IP_1 login_2 status_2 IP_2...login_n status_n IP_n)
                    message = ((char)7).ToString() + ' ';
                    var friends = ctx.Friends.Where(x => x.UserID1 == userID);//all friends
                    
                    foreach (var item in friends)
                    {
                        var friendLogin = ctx.Users.Where(x => x.UserID == item.UserID2).Select(x=>x.Login).FirstOrDefault();
                        if (friendLogin!=null)
                        {
                            message += friendLogin+ " ";
                            if (Program.onlineUsers.ContainsKey(item.UserID2))
                            {
                                message += "1 ";
                                message += Program.onlineUsers[item.UserID2].addressIP+ " ";
                            }
                            else
                            {
                                message += "0 ";
                                message += "0 ";
                            }
                            message += "<EOF>";

                        }
                        else
                        {
                            return Fail();
                        }
                    }
                    return message;
                }
                else
                {
                    return Fail();
                }
            }        
        }

        public static string History(long userID)
        {
            string history = string.Empty;
            history = ((char)13).ToString() + ' ';
            using (var ctx = new SecConvDBEntities())
            {
                var histories = ctx.Histories.Where(x => x.UserSenderID == userID || x.UserReceiverID == userID).OrderBy(x=>x.Start).ToList();
                if (histories.Count != 0)
                {
                    foreach (var item in histories)
                    {
                        if (item.UserSenderID==userID)//userID is sender
                        {
                            var friendLoginR = ctx.Users.Where(x => x.UserID == item.UserReceiverID).Select(x => x.Login).FirstOrDefault();
                            if (friendLoginR != null)
                            {
                                history +=friendLoginR + " " + item.Start.ToString() + " " + item.Duration.ToString()+ " ";
                            }
                        }
                        else //userID is receiver
                        {
                            var friendLoginS = ctx.Users.Where(x => x.UserID == item.UserSenderID).Select(x => x.Login).FirstOrDefault();
                            if (friendLoginS != null)
                            {
                                history += friendLoginS + " " + item.Start.ToString() + " " + item.Duration.ToString() + " ";
                            }
                        }
                    }
                }
                return history+"<EOF>";
            }
        }
        public static void StateChng(long userID) //ma byc pomocnicza //wyslac do innych 14
        {
            //delete from dictionary
            if (Program.onlineUsers.ContainsKey(userID))
            {
                Program.onlineUsers.Remove(userID);
            }

            //informa everybody that this person log out
            
        }

        public static string ChooseCommunique(string message, Socket client)
        {
            //odszyfruj   
            string decryptedMessage = message;

            string decryptedMessageBits = Utilities.getBinaryMessage(decryptedMessage);
            //take 8 bits to recognize the communique
            int bits8 = Convert.ToInt32(decryptedMessageBits.Substring(0, 8), 2);//decimal value

            //parameters to send
            string[] sParameters = decryptedMessage.Split(' ');
            List<string> parameters = new List<string>();
            for (int i = 0; i < sParameters.Length; i++)
            {
                //0 has bits to recognize the communique
                if (i != 0)
                {
                    parameters.Add(sParameters[i]);
                }
            }

            string result = string.Empty;
            if (bits8!=1) //if it isn't login
            {
                //http://stackoverflow.com/a/4233539
                //call proper method
                result=(string)communiqueDictionary[bits8].DynamicInvoke(parameters);
            }
            else
            {
                result= (string)communiqueDictionary[bits8].DynamicInvoke(parameters, client);
            }
            return result;
        }

        public static long getUserIDHavingAdressIP(string addressIP)
        {
            long userID = -1;

            foreach (KeyValuePair<long, ConnectedClient> item in Program.onlineUsers)
            {            
                if(item.Value.addressIP==addressIP)
                {
                    userID = item.Key;
                }
            }
            return userID;
        }
    }
}
