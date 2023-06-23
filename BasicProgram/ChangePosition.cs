using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class ChangePosition
    {
        public void Number()
        {
            Console.WriteLine("Enter a One String");
            string Name = Console.ReadLine();
            string b = Name.Substring(0,1);
            string c = Name.Substring(1,Name.Length-2);   
            string d = Name.Substring(Name.Length - 1);
            Console.WriteLine(d+c+b);
            
        }
    }
}
