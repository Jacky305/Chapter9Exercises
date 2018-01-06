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

            //Binary Search
            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine("Enter friend name to find their birth date:");

            string tempString;
            Friend tempFriend = new Friend();
            tempString = Console.ReadLine();
            
            foreach(Friend friend in friendsList)
            {
                //Compare name
                if (friend.Name == tempString)
                {
                    tempFriend = friend;
                    break;
                }
            }

            int index = Array.BinarySearch(friendsList, tempFriend); //Returns an index
            if (index < 0)
                Console.WriteLine("{0} does not exist.", tempString);
            else
                Console.WriteLine("{0}'s birthday is {1}", friendsList[index].Name, friendsList[index].Birthday);
        }
    }
}
