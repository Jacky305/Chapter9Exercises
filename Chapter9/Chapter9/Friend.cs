using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    class Friend : IComparable
    {
        private string name;
        private string phoneNumber;
        private int birthday;

        public string Name { get { return name; } set { name = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public int Birthday { get { return birthday; } set { birthday = value; } }

        int IComparable.CompareTo(object obj)
        {
            int x;
            Friend temp = (Friend)obj;

            x = this.name.CompareTo(temp.name);
            return x;
        }
    }
}
