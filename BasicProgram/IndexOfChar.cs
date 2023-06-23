using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class IndexOfChar
    {
        public void Number()
        {
            Console.WriteLine("Enter A One string");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter A Index Which is Remove");
            int R = Convert.ToInt32(Console.ReadLine());
            string Char = Name.Remove(R ,1);
            Console.WriteLine($"{Char}");
        }
    }
}
