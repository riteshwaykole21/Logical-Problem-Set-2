using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class FrontandBack
    {
        public void Number()
        {
            Console.WriteLine("Enter a one String");
            string Name = Console.ReadLine();   
            string A = Name.Substring(0,1);
            string B = Name.Substring(1,Name.Length - 1);
            Console.WriteLine(A+A+B+A);

        }
    }
}
