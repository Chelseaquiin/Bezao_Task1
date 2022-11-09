using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string user;
            string password;
            
                Console.Write("Username: ");
                user = Console.ReadLine();

                Console.Write("Password: ");
                password = Console.ReadLine();

                Dictionary<string, string> list = new Dictionary<string, string>();

                list.Add(user, password);
            while (true)
            {
                Console.WriteLine("Log in");
                string user1 = Console.ReadLine();

                Console.WriteLine("Password");
                string password1 = Console.ReadLine();  

                foreach(string key in list.Keys)
                {

                    if (!key.Contains(user1))
                    {
                        Console.WriteLine("User not registered");
                    }

                    else if (user1 == user && password1 == password)
                    {
                        Console.WriteLine("Login Successful");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Incorrect password");
                    }
                }
            }


               


        
              
        
            }
        }
    }

