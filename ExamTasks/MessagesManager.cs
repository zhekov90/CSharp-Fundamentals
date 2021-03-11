using System;
using System.Linq;
using System.Collections.Generic;


namespace Messages_Manager
{
    public class User
    {
        public string Name { get; set; }
        public int Sent { get; set; }
        public int Received { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            List<User> users = new List<User>();


            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Statistics")
            {
                string[] arr = command.Split('=').ToArray();
                if (arr[0] == "Add")
                {
                    if (!(UserExists(arr[1], users)))
                    {
                        User user = new User();
                        user.Name = arr[1];
                        user.Sent = int.Parse(arr[2]);
                        user.Received = int.Parse(arr[3]);
                        users.Add(user);
                    }
                }
                else if (arr[0] == "Message")
                {
                    if (UserExists(arr[1], users) && UserExists(arr[2], users))
                    {
                        UserAddSentMessages(arr[1], users);
                        UserAddReceivedMessages(arr[2], users);
                        if (ExceedsLimit(arr[1], users, limit))
                        {
                            Console.WriteLine($"{arr[1]} reached the capacity!");
                            RemoveUser(arr[1], users);
                        }
                        if (ExceedsLimit(arr[2], users, limit))
                        {
                            RemoveUser(arr[2], users);
                            Console.WriteLine($"{arr[2]} reached the capacity!");
                        }
                    }
                }
                else if (arr[0] == "Empty")
                {
                    if (arr[1] != "All")
                    {
                        RemoveUser(arr[1], users);
                    }
                    else
                    {
                        users = new List<User>();
                    }
                }
            }

            Console.WriteLine($"Users count: {users.Count}");
            foreach (var user in users.OrderByDescending(x => x.Received).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{user.Name} - {user.Received + user.Sent}");
            }
        }

        static bool UserExists(string user, List<User> users)
        {
            foreach (var person in users)
            {
                if (person.Name == user)
                {
                    return true;
                }
            }
            return false;
        }

        static void UserAddSentMessages(string user, List<User> users)
        {
            foreach (var person in users)
            {
                if (person.Name == user)
                {
                    person.Sent += 1;
                }
            }
        }
        static void UserAddReceivedMessages(string user, List<User> users)
        {
            foreach (var person in users)
            {
                if (person.Name == user)
                {
                    person.Received += 1;
                }
            }
        }

        static void RemoveUser(string user, List<User> users)
        {
            foreach (var person in users)
            {
                if (person.Name == user)
                {
                    users.Remove(person);
                    return;
                }
            }
        }

        static bool ExceedsLimit(string user, List<User> users, int limit)
        {
            foreach (var person in users)
            {
                if (person.Name == user)
                {
                    if (person.Received + person.Sent >= limit)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}