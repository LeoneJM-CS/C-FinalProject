using System;
using System.Threading.Tasks;

namespace FinalProj
{
    class FinalProj()
    {
        public class User()
        {
            private string? password;
            private string? userName;
            private SortedDictionary<string, string> users;
            public string? Password
            {
                get { return password; }
                set
                {
                    if (value == null)
                    {
                        Console.WriteLine("Please Try Again\n");
                    }
                    else
                    {
                        password = value;
                    }
                }
            }
            public string? UserName
            {
                get { return userName; }
                set
                {
                    if (value == null)
                    {
                        Console.WriteLine("Please Try Again\n");
                    }
                    else
                    {
                        userName = value;
                    }
                }
            }
            public SortedDictionary<string, string> Users
            {
                get { return users; }
                set
                {
                    users.Add(userName, password);
                }
            }
        }
        internal class MainProgram
        {
            static void Main(string[] args)
            {
                User user = new User();
                while (true)
                {
                    Console.WriteLine("Enter Your option: \n1. Login\n2. Sign up\n3. View users\n4. Exit Program");
                    int? userIn = Convert.ToInt32(Console.ReadLine());
                    if (userIn == 1)
                    {
                        Console.WriteLine("Enter Your username: ");
                        string? username = Console.ReadLine();
                        Console.WriteLine("Enter Your password: ");
                        string? pass = Console.ReadLine();
                        foreach (KeyValuePair<string, string> kvp in user.Users)
                        {
                            if ((kvp.Key == username) && (kvp.Value == pass))
                            {
                                Console.WriteLine("Welcome " + kvp.Key);
                            }
                            else if ((kvp.Key != username) | (kvp.Value != pass))
                            {
                                Console.WriteLine("UserName or password incorrect");
                            }
                        }
                    }

                    else if (userIn == 2)
                    {
                        Console.WriteLine("Enter Your username: ");
                        string? username = Console.ReadLine();
                        Console.WriteLine("Enter Your password: ");
                        string? pass = Console.ReadLine();
                        user.Password = pass;
                        user.UserName = username;
                        user.Users.Add(pass, username);
                    }

                    else if (userIn == 3)
                    {
                        foreach (KeyValuePair<string, string> kv in user.Users)
                        {
                            Console.WriteLine(kv.Key + " " + kv.Value);
                        }
                    }

                    else if (userIn == 4)
                    {
                        Console.WriteLine("Exiting Program");
                        break;
                    }
                }
            }
        }
    }
}
