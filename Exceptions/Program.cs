using System;
using Calculator;
namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int op1, op2,ch;
            Calculations cal = new Calculations();
            //Reading operand1
            Console.WriteLine("enter first number");
            op1=Convert.ToInt32(Console.ReadLine());
            //Reading operand2
            Console.WriteLine("enter second number");
            op2= Convert.ToInt32(Console.ReadLine());
            //Reading choice
            Console.WriteLine("1.Addition 2.Subtraction 3.Multiplication 4.Division");
            Console.WriteLine("Enter choice");
            ch= Convert.ToInt32(Console.ReadLine());
            if (ch== 1)
                Console.WriteLine(cal.Add(op1,op2));
            if (ch == 2)
                Console.WriteLine(cal.Subtract(op1, op2));
            if (ch == 3)
                Console.WriteLine(cal.Multiply(op1, op2));
            if (ch == 4)
                Console.WriteLine(cal.Divide(op1, op2));
        }
    }
}
