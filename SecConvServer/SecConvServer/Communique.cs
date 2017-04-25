using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;

namespace SecConvServer
{
    class Communique
    {
        static Dictionary<int, Delegate> communiqueDictionary = new Dictionary<int, Delegate>(); //nalezy dodac do niego metody komunikatow

        static void addDelegateToDictionary()
        {
            communiqueDictionary[0] = new Action<List<string>>(Communique.Register);
            communiqueDictionary[1] = new Action<List<string>>(Communique.LogIn);
            communiqueDictionary[2] = new Action<List<string>>(Communique.LogOut);
            communiqueDictionary[3] = new Action<List<string>>(Communique.AccDel);
            communiqueDictionary[4] = new Action<List<string>>(Communique.PassChng);
            communiqueDictionary[8] = new Action<List<string>>(Communique.AddFriend);
            communiqueDictionary[9] = new Action<List<string>>(Communique.DelFriend);
            communiqueDictionary[11] = new Action<List<string>>(Communique.CallState);
            communiqueDictionary[15] = new Action<List<string>>(Communique.Iam);
        }
        //Incoming messages
        public static void Register(List<string> param)
        {
            //Communication with DB
            using (var ctx = new SecConvDBEntities1())
            {
                var newUser = new Users();
                string login= param[0];//login

                int loginUnique = ctx.Users.Where(x => x.Login == login).Count(); //check if login is unique
                if (loginUnique == 0)
                {
                    newUser.Login = login;
                    newUser.Password = Utilities.hashBytePassHex(param[1]); //256 bit hash password          
                    newUser.Online = false;
                    newUser.LastLogoutDate = DateTime.Now;
                    newUser.RegistrationDate = DateTime.Now;

                    ctx.Users.Add(newUser);
                    try
                    {
                        ctx.SaveChanges();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        Console.WriteLine("FAIL1");
                        //FAIL
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("FAIL2");
                    //FAIL
                    return;
                }
            }
            //OK
            Console.WriteLine("OK");

        }
        public static void LogIn(List<string> param)
        {
            string login = param[0];
            string password = Utilities.hashBytePassHex(param[1]);

            //users -> online
            using (var ctx = new SecConvDBEntities1())
            {
                var userToEdit = ctx.Users.Where(x => x.Login == login && x.Password == password).FirstOrDefault();
                if (userToEdit!=null)
                {
                    userToEdit.Online = true;
                    try
                    {
                        ctx.Entry(userToEdit).State = System.Data.Entity.EntityState.Modified;
                        ctx.SaveChanges();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        Console.WriteLine("FAIL1");
                        //FAIL
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("FAIL2");
                    //FAIL
                    return;
                }
            }
            //OK
            Console.WriteLine("OK");
        }
        public static void LogOut(List<string> param)
        {
            string login = param[0];

            using (var ctx = new SecConvDBEntities1())
            {
                var userToLogOut = ctx.Users.Where(x => x.Login == login).FirstOrDefault();
                if (userToLogOut != null)
                {
                    userToLogOut.Online = false;
                    userToLogOut.LastLogoutDate = DateTime.Now;
                    try
                    {
                        ctx.Entry(userToLogOut).State = System.Data.Entity.EntityState.Modified;
                        ctx.SaveChanges();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        Console.WriteLine("FAIL1");
                        //FAIL
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("FAIL2");
                    //FAIL
                    return;
                }
                //OK
                Console.WriteLine("OK");
            }
        }
        public static void AccDel(List<string> param)
        {
            string login = param[0];
            string password = Utilities.hashBytePassHex(param[1]);
            using (var ctx = new SecConvDBEntities1())
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
                        Console.WriteLine("FAIL1");
                        //FAIL
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("FAIL1");
                    //FAIL
                    return;
                }
            }
            Console.WriteLine("OK");
            //OK
        }
        public static void PassChng(List <string> param)
        {
            string login = param[0];
            string password1 = Utilities.hashBytePassHex(param[1]);
            using (var ctx = new SecConvDBEntities1())
            {
                var userToChngPasswd = ctx.Users.Where(x => x.Login == login && x.Password == password1).FirstOrDefault();
                if (userToChngPasswd!=null)
                {
                    userToChngPasswd.Password = Utilities.hashBytePassHex(param[2]);
                    try
                    {
                        ctx.Entry(userToChngPasswd).State = System.Data.Entity.EntityState.Modified;
                        ctx.SaveChanges();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        Console.WriteLine("FAIL1");
                        //FAIL
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("FAIL2");
                    //FAIL
                    return;
                }
            }
            Console.WriteLine("OK");
            //OK
        }
        public static void AddFriend(List<string> param)
        {
            string login1 = param[0]; //user logged in
            string login2 = param[1]; //friend of logged in user
            using (var ctx = new SecConvDBEntities1())
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
                                Console.WriteLine("FAIL1");
                                //FAIL
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("FAIL2");
                            //FAIL
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAIL3");
                        //FAIL
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("FAIL4");
                    //FAIL
                    return;
                }
            }
            //OK
            Console.WriteLine("OK");
        }
        public static void DelFriend(List<string> param)
        {
            string login1 = param[0];
            string login2 = param[1];
        }
        public static void CallState(List<string> param)
        {
            string login1 = param[0];
            string login2 = param[1];
            //yyyy-MM-dd-HH:mm:ss
            DateTime start = DateTime.ParseExact(param[2], "yyyy-MM-dd-HH:mm:ss",System.Globalization.CultureInfo.InvariantCulture);
            //HH:mm:ss
            TimeSpan duration = TimeSpan.Parse(param[3]);

            //Console.WriteLine("L1: " + login1 + "\nL2: " + login2 + "\nS: " + start + "\nD: " + duration);
        }   
        public static void Iam(List<string> param)
        {
            string login = string.Empty;
        }


        //Outgoing messages
        static void OK()
        {
        }
         static void Fail()
        {
        }
        static void LogIP()
        {
        }

        static void History()
        {
        }
        static void StateChng()
        {
        }
        public static void Bye(List<string> param)
        {
        }
        void chooseCommunique(string message)
        {
            //odszyfruj   
            string decryptedMessage = "";

            string decryptedMessageBits = string.Empty; //message in binary form
            foreach (char ch in decryptedMessage)
            {
                decryptedMessageBits += Convert.ToString((int)ch, 2);
            }
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
            //http://stackoverflow.com/a/4233539
            //call proper method
            communiqueDictionary[bits8].DynamicInvoke(parameters);
        }
    }
}
