using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    class FriendsList
    {
        public static void Run(string[] args)
        {
            Friend[] friendsList = new Friend[4];

            for(int x=0; x<friendsList.Length; x++)
            {
                Console.WriteLine("------------------------------------------");
                friendsList[x] = new Friend();
                Console.WriteLine("Enter name for Friend {0}: ",x);
                friendsList[x].Name = Console.ReadLine();
                Console.WriteLine("Enter phone number for Friend {0}: ", x);
                friendsList[x].PhoneNumber = Console.ReadLine();
                Console.WriteLine("Enter birthday for Friend {0}: ", x);
                friendsList[x].Birthday = int.Parse(Console.ReadLine());
            }

            Array.Sort(friendsList);
            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine("Sorted by first name:");
            foreach(Friend friend in friendsList)
            {
                Console.WriteLine("{0}", friend.Name);
            }
        }
    }
}
