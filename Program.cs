using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTreeHouse_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a variable
            var number = 4; //number variable
            var greeting = "hello"; //string variable

            //Outputting the variable.
            Console.WriteLine(greeting);
            Console.WriteLine(number);

            //Adding and subtracting from the variable.
            Console.WriteLine(number + 2);
            Console.WriteLine(number - 5);

            //Reassigning the variable.
            number = 10;

            //Using the new number after reassingment.
            Console.WriteLine(number + 3);

            //Cannot declare a variable more than once, for reassigning the variable just use the variable name and not the keyword type.
            //Example cannot use (var number) again, instead you would usejust the name (number).

            //Ways to get the type of variable you would use
            Console.WriteLine(4.GetType()); //Prints an int
            Console.WriteLine(3.1415.GetType()); //Prints a double 
            Console.WriteLine(true.GetType()); //Prints a boolean
            Console.WriteLine("hello".GetType()); //Prints a string
            Console.WriteLine('z'.GetType()); //Prints a char

            //Types specify what a value can be used for.

            //Declaring a variable.
            int numberTwo;
            string greetingTwo;

            //Assinging a value
            numberTwo = 3;
            greetingTwo = "Hey";

            Console.WriteLine($"The variable numberTwo is ({numberTwo}), and the variable greetingTwo is ({greetingTwo}).");

            //Namespaces.
            /*
             using System;
                using System.Collections.Generic;
                using System.Linq;
                using System.Text;
                using System.Threading.Tasks;
             */

            //using (System) - System is a namespace, without it you have to type System.Console.WriteLine(), instead of just Concole.WriteLine().

            Console.Clear();

            Console.WriteLine("Welcome to the cat food store!");

            //Methods
            //Console.WriteLine(); is a method
            //GetType(); is a method
            //.ToUpper(); is a method

            //To call a method you type its name followed by ().

            //A sleep method
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("I'm awake!");

            Console.Clear();

            //void - This is a keyword that means there is no return value

            //The method body goes in between the curly braces.
            //In order to call to a method the method name needs to be called to.
            //Example: oputside of the main there is a Method called Hello.  To call this method type
            //hello();

            hello();

            //Methods can be called within other methods.


        }

        static void hello()
        {
            Console.WriteLine("Hello, and welcome to my notes");
            helloAgain();
        }


        static void helloAgain()
        {
            Console.WriteLine("Just another method");
        }
    }
}
