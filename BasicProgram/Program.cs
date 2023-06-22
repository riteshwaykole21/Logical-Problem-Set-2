using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : Enter Your Age");
            Console.WriteLine("2 : Enter A Number");
            Console.WriteLine("Enter A Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Age age = new Age();
                    age.Number();
                    break;
                case 2:
                    NoSepration noSepration = new NoSepration();
                    noSepration.Number();   
                    break;
            }
            Console.ReadLine();
        }
    }
}
