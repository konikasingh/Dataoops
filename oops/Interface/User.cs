using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.Interface
{
    interface IUser
    {
        void GetDetails(string x);
    }
    class User : IUser
    {
        public void GetDetails(string a)
        {
            Console.WriteLine("Name: {0}", a);
        }
    }
    class User1 : IUser
    {
        public void GetDetails(string a)
        {
            Console.WriteLine("Location: {0}", a);
        }
    }
}
