using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.Abstract
{
    abstract class Data
    {
        abstract public void GetDetails(string x, string y, int z);
    }
    class User : Data
    {
        public override void GetDetails(string a, string b, int c)
        {
            Console.WriteLine("Name: {0}", a);
            Console.WriteLine("Location: {0}", b);
            Console.WriteLine("Age: {0}", b);
        }
    }
}
