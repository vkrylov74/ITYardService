using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITYardService
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define users and create repository
            var repo = new UserRepository();
            var usr1 = new User("Yuriy","Password1");
	        var usr2 = new User("Max", "Password2");
            var usr3 = new User("Andriy", "Password3");
	        repo.Insert(usr1);
	        repo.Insert(usr2);
            repo.Insert(usr3);

            //GetById sample
            Console.WriteLine("GetById sample:");
            repo.GetById(usr1._id).DisplayUserInfo();
            Console.WriteLine("------------------");

            //Update sample
            Console.WriteLine("Update sample:");
            usr3.DisplayUserInfo();
            repo.Update(usr3._id,"Egor","Password4");
            usr3.DisplayUserInfo();
            Console.WriteLine("------------------");

            //Delete sample
            Console.WriteLine("Delete sample:");
            DisplayRepository(repo);
            //Delete
            Console.WriteLine("Delete usr3:");
            repo.Delete(usr2._id);            
            DisplayRepository(repo);
            Console.WriteLine(String.Format("Repository user count after delete: {0}", repo.Count));
            //Add back
            Console.WriteLine("Add back usr3:");
            repo.Insert(usr2);
            DisplayRepository(repo);
            Console.WriteLine(String.Format("Repository user count after add back: {0}", repo.Count));
            Console.WriteLine("------------------");

            //DisplayUserInfo sample
            Console.WriteLine("DisplayUserInfo sample:");
            usr1.DisplayUserInfo();
            Console.WriteLine("------------------");
            
            //DisplayUserInfo by user sample
            Console.WriteLine("DisplayUserInfo by user sample:");
            DisplayUserInfo(usr1);
            Console.WriteLine("------------------");
            
            //Encrypt sample
            Console.WriteLine("Encrypt sample:");
            usr1.DisplayUserInfo();
            usr1.Encrypt(12);   //Key 12 for example
            usr1.DisplayUserInfo();
            Console.WriteLine("------------------");

            //Decrypt sample
            Console.WriteLine("Decrypt sample:");
            usr1.DisplayUserInfo();
            usr1.Encrypt(12);   //The same key
            usr1.DisplayUserInfo();
            Console.WriteLine("------------------");
            
            //Pause
            Console.ReadLine();
        }

        //DisplayUserInfo by user
        public static void DisplayUserInfo(User user)
        {
            user.DisplayUserInfo();
        }

        //DisplayRepository
        static int DisplayRepository(UserRepository repo)
        {   
            var users = repo.All();
            foreach (var user in users)
            {
                Console.WriteLine(String.Format("User name - {0}, user password - {1}", user._userName, user._password));
            }
            return 0;  
        }
    }
}
