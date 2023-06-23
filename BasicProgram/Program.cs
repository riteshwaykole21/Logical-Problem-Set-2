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
            Console.WriteLine("3 : Enter The Number");
            Console.WriteLine("4 : Conversion Kelvin");
            Console.WriteLine("5 : Remove Specific Character");
            Console.WriteLine("6 : Change Position Of Char");
            Console.WriteLine("7 : First Char Of String Add Front And Back Also");
            Console.WriteLine("8 : Check Condition Of If Else");
            Console.WriteLine("9 : Triple Their Sum");
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
                case 3:
                    Reactangle reactangle = new Reactangle();
                    reactangle.Number();
                    break;
                case 4:
                    Kelvin kelvin = new Kelvin();
                    kelvin.Number();
                    break;
                case 5:
                    IndexOfChar ch = new IndexOfChar();
                    ch.Number();
                    break;
                case 6:
                    ChangePosition changePosition = new ChangePosition();
                    changePosition.Number();
                    break;
                case 7:
                    FrontandBack frontandBack = new FrontandBack();
                    frontandBack.Number();  
                    break;
                case 8:
                    IntegerPair integerPair = new IntegerPair();
                    integerPair.Number();   
                    break;
                case 9:
                    ComputeSum computeSum = new ComputeSum();   
                    computeSum.Number();
                    break;
            }
            Console.ReadLine();
        }
    }
}
