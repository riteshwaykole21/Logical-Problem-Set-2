using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class ComputeSum
    {
        public void Number()
        {
            Console.WriteLine("Enter A First Number");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Second Number");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            int Sum = Num1 + Num2;  
            if(Num1 == Num2)
            {
                Console.WriteLine($"Both Number Are Same {Sum * 3}");
            }
            else
            {
                Console.WriteLine($"Both Number Are Not Same {Sum}");
            }
        }
    }
}
