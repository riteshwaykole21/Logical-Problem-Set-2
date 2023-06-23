using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class IntegerPair
    {
        public void Number()
        {
            Console.WriteLine("Enter A One Number");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Second Number");
            int Num2 = Convert.ToInt32(Console.ReadLine()); 
            if(Num1 < 0)
            {
                if(Num2 > 0)
                {
                    Console.WriteLine(true);
                }
            }
            else if(Num1 > 0)
            {
                if(Num2 < 0)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }
    }
}
