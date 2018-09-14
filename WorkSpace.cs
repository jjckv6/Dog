using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum Gender
{
   Male,
   Female
}
namespace Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string owner;
            int age;
            Gender gender;

            Dog.Bark(2);
        }


        public class Dog
        {      
            public int i;
            public int k;
            public void Bark(int i)
            {
               for (k = 0; k >= i; ++k)
                {
                    Console.WriteLine("Woof!");
                }
            }

            public string GetTag()
            {
                string x = Console.WriteLine("If Lost call {0}. {1} name is {2} and {3} is {4} {5} old", );
                return x;
            }

        }
               
    }
}
    
