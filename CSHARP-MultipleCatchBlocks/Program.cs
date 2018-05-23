using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_MultipleCatchBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 1;
                int b = 0;
                int c = a / b;
                Console.WriteLine(c);
                Console.ReadKey();
            }
            //// If cathc block with parameter class Exception is written first, then the following error message come at compile time
            //// A previous catch clause already catches all exceptions of this or of a super type ('Exception')

            catch (DivideByZeroException ex)  // Here DivideByZeroException is written first because it is derived from ArithmeticException, if not it shows the compile time error as same as above
            {
                Console.WriteLine(ex.Message.ToString() + " DivideByZero Exception");
                Console.ReadKey();
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message.ToString() + " Arithmetic Exception");
                Console.ReadKey();
            }
           // This catch block should be last, because this is the super class for all exceptions
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " Base Exception");
                Console.ReadKey();
            }
        }
    }
}
