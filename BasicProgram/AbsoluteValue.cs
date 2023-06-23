using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class AbsoluteValue
    {
        public void Number()
        {
            Console.WriteLine("Enter A First Number");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Second Number");
            int Second = Convert.ToInt32(Console.ReadLine());
            if(First < Second)
            {
                Console.WriteLine(Second - First);
            }
            else if (Second < First)
            {
                Console.WriteLine((First - Second) * 2);
            }
        }
    }
}
