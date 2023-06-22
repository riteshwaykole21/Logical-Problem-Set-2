using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class Kelvin
    {
        public void Number()
        {
            Console.WriteLine("Enter A Amount Of celsius");
            int celsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Kelvin = {celsius + 273}");
            Console.WriteLine($"Fahrenheit = {celsius * 18 /10+32}");
        }
    }
}
