using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.Inheritance
{
    class GFG
    {

        // data members
        public string name;
        public string subject;

        // public method of base class 
        public void readers(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("Myself: " + name);
            Console.WriteLine("My Favorite Subject is: " + subject);
        }
    }

    // inheriting the GFG class using : 
    class GeeksforGeeks : GFG
    {

        // constructor of derived class
        public GeeksforGeeks()
        {
            Console.WriteLine("GeeksforGeeks");
        }
    }
}
