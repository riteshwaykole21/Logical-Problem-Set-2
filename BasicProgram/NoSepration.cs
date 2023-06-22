using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class NoSepration
    {
        public void Number()
        {
            Console.WriteLine("Enter A Number");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{X} {X} {X} {X}");
            Console.WriteLine($"{X}{X}{X}{X}");
            Console.WriteLine($"{X} {X} {X} {X}");
            Console.WriteLine($"{X}{X}{X}{X}");
        }
    }
}
