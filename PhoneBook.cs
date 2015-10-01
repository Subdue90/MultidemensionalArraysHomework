using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class PhoneBook
    {
        static void Main()
        {
            Dictionary<string, HashSet<string>> phonebook = new Dictionary<string, HashSet<string>>();

            string command = "";
            while (command != "search")
            {
                string[] input = Console.ReadLine().Split('-');

                if (input[0] == "search")
                {
                    command = "search";
                }
                else
                {
                    if (!phonebook.ContainsKey(input[0]))
                    {
                        phonebook[input[0]] = new HashSet<string>();
                        phonebook[input[0]].Add(input[1]);
                    }
                    else
                    {
                        phonebook[input[0]].Add(input[1]);
                    }
                }
            }

            while (true)
            {
                command = Console.ReadLine();
                if (phonebook.ContainsKey(command))
                {
                    foreach (var value in phonebook[command])
                    {
                        Console.WriteLine("{0} -> {1}", command, value);
                    }
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", command);
                }
            }
        }
    }

