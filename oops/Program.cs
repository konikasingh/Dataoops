//using oops.AccessModifier;
//using oops.Abstraction;
//using oops.Encapsulation;
//using oops.Inheritance;
//using oops.MethodOverloading;
//using oops.polymorphism;
//using oops.Interface;
using oops.Abstract;
using System;

namespace Uc1
{
    class Program
    {
        static void Main(string[] args)
            // Abstract Method Example
        {
            Use u = new Use();
            Console.WriteLine("****Abstract Class Example****");
            u.GetDetails("Konika Singh", "Nagpur");
            Console.ReadLine();
        }
        //Abstract Class example
        /*{
            User u = new User();
            Console.WriteLine("****Abstract Class Example****");
            u.GetDetails("Pallavi Singh", "Ahmedabad", 28);
            Console.ReadLine();
        }*/

        // Interface Example
        /* {
             IUser u = new User();
             u.GetDetails("Shikha Singh");
             IUser u1 = new User1();
             u1.GetDetails("Nagpur");
             Console.WriteLine("\nPress Enter Key to Exit..");
             Console.ReadLine();
         }*/



        //RunTime polymorphism Example
        /* {

             Drawing circle = new Circle();
             Console.WriteLine("Area :" + circle.Area());

             Drawing square = new Square();
             Console.WriteLine("Area :" + square.Area());

             Drawing rectangle = new Rectangle();
             Console.WriteLine("Area :" + rectangle.Area());
         }*/



        //Compiletime Polymorphism example
        /* {
             Poly c = new Poly();
             c.AddNumbers(5, 9);
             c.AddNumbers(6, 2, 4);
             Console.WriteLine("\nPress Enter Key to Exit..");
             Console.ReadLine();
         }*/

        // Method Overriding Example
        /*{
            Methodd obj1 = new subClass();
            obj1.Greetings();
            Console.ReadLine();
        }*/
        //  Method Overloading Example
        /*{
            Method c = new Method();
            c.AddNumbers(1, 2);
            c.AddNumbers(1, 2, 3);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }*/


        //Inheritance Example
        /* {
             // creating object of derived class
             GeeksforGeeks g = new GeeksforGeeks();

             // calling the method of base class 
             // using the derived class object
             g.readers("Konika", "C#");
         }*/




        //         Abstraction Example    

        /* {
               //Creating an instance of Car
               Car c = new Car();
               //Accessing the Public Properties and methods
               string CarName = c.CarName;
               string CarColur =c.CarColur;
               c.Brakes();
               c.Gear();
               c.Steering();
               //Try to access the private variables and methods
               //Compiler Error, 'Car._CarName' is inaccessible due to its protection level
              // c._CarName;
               //Compiler Error, 'Car.CarEngine' is inaccessible due to its protection level
              // c.CarEngine();
           }*/



        //    Encapsultion Example

        /*{
            Encap e = new Encap();
            // set accessor will invoke
            e.Name = "Sanjay Singh";
            // set accessor will invoke
            e.Location = "Nagpur";
            // get accessor will invoke
            Console.WriteLine("Name: " + e.Name);
            // get accessor will invoke
            Console.WriteLine("Location: " + e.Location);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }*/



        //      Access Modifier example

        /*{
            Access a = new Access();
            a.Name = "Konika Singh";
            a.Location = "Nagpur";
            a.Age = 25;
            a.GetAccessDetails();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }*/


    }
}