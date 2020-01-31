using System;

namespace Calculator
{
    public class Calculations
    {
        /// <summary>
        /// Addition
        /// </summary>
        /// <param name="operand1"></param>
        /// <param name="operand2"></param>
        /// <returns>sum</returns>
        public int Add(int operand1, int operand2)
        {
            return operand1 + operand2;
        }
        /// <summary>
        /// Subtraction
        /// </summary>
        /// <param name="operand1"></param>
        /// <param name="operand2"></param>
        /// <returns>difference</returns>
        public int Subtract(int operand1, int operand2)
        {
            return operand1 - operand2;
        }
        /// <summary>
        /// Multiplication
        /// </summary>
        /// <param name="operand1"></param>
        /// <param name="operand2"></param>
        /// <returns>Product</returns>
        public int Multiply(int operand1, int operand2)
        {

           int result=0;
            try
            {
                if(operand1==0||operand2==0)
                {
                    //throwing exception
                    throw new MultiplyByZeroException("Operand should not be zero");
                }
                result = operand1 * operand2;
                
            }
            //catching exception
            catch(MultiplyByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
        public double Divide(int operand1, int operand2)
        {
            double result = 0;
            try
            {
                result=operand1 / operand2;
               
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine(ex.Message);
            }
            return result;
        }
    
    
    }
    /// <summary>
    /// Creating user defined exception
    /// </summary>
    public class MultiplyByZeroException:Exception
    {
        public MultiplyByZeroException():base()
        {

        }
        public MultiplyByZeroException(String message) : base(message)
        {

        }
    }
}
