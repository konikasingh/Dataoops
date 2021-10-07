using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.Abstract
{
    abstract class Abstractm
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to Program");
        }
        public int age = 32;
        public abstract void GetDetails(string x, string y);
    }

    internal class Use : Abstractm
    {
        public override void GetDetails(string a, string b)
        {
            Welcome();
            Console.WriteLine("Name: {0}", a);
            Console.WriteLine("Location: {0}", b);
            Console.WriteLine("Age: {0}", age);
        }
    }
}
