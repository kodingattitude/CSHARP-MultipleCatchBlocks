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
                Console.Write("Enter numerator value : ");
                int? numerator = int.Parse(Console.ReadLine());
                Console.Write("Enter denominator value : ");
                int? denominator = int.Parse(Console.ReadLine());
                int? result = numerator / denominator;
                Console.WriteLine("Division Of numerator/denominator : {0}", result);
                Console.ReadKey();
            }
            //// If catch block with parameter class Exception is written first, then the following error message come at compile time
            //// A previous catch clause already catches all exceptions of this or of a super type ('Exception')

            //// If given value is more than the datatype size then ArithmeticException Occurs
            catch (DivideByZeroException ex)  // Here DivideByZeroException is written first because it is derived from ArithmeticException, if not it shows the compile time error as same as above
            {
                Console.WriteLine(ex.Message.ToString() + " DivideByZero Exception");
                Console.ReadKey();
            }
            //// If given value is more than the datatype size then ArithmeticException Occurs
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message.ToString() + " Arithmetic Exception");
                Console.ReadKey();
            }
           
            //// If given value datatype is not supports by existing declared datatype then FormatException Occurs
            catch (FormatException ex)
            {
                Console.Write(ex.Message.ToString() + " Format Exception");
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
