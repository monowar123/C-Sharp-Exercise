using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceptions_11
{
    class Program
    {
        static void Main(string[] args)
        {
            DoesNotThrowException();
            Console.WriteLine();

            ThrowExceptionWtihCatch();
            Console.WriteLine();

            try
            {
                ThrowExceptionWithoutCatch();
            }
            catch
            {
                Console.WriteLine("Caught exception from ThrowExceptionWithoutCatch() in main()");
            }
            Console.WriteLine();

            try
            {
                ThrowExceptionCatchRethrow();
            }
            catch
            {
                Console.WriteLine("Caught exception from ThrowExceptionCatchRethrow() in main()");
            }

            Console.ReadKey();
        }

        static void DoesNotThrowException()
        {
            try
            {
                Console.WriteLine("DoesNotThrwoException() try block");
            }
            catch
            {
                Console.WriteLine("This catch never executes.");
            }
            finally
            {
                Console.WriteLine("DoesNotThrowException finally block.");
            }
        }

        static void ThrowExceptionWtihCatch()
        {
            try
            {
                Console.WriteLine("ThrowExceptionWtihCatch() try block");
                throw new Exception("Exception in ThrowExceptionWtihCatch()");
            }
            catch (Exception exParameter)
            {
                Console.WriteLine("Message: " + exParameter.Message);
            }
            finally
            {
                Console.WriteLine("ThrowExceptionWtihCatch() finally block.");
            }
        }

        static void ThrowExceptionWithoutCatch()
        {
            try
            {
                Console.WriteLine("ThrowExceptionWithoutCatch() try block.");
                throw new Exception("Exception in ThrowExceptionWithoutCatch()");
            }
            finally
            {
                Console.WriteLine("ThrowExceptionWithoutCatch() finally block");
            }
            Console.WriteLine("End of the ThrowExceptionWithoutCatch()");   // unreachable code
        }

        static void ThrowExceptionCatchRethrow()
        {
            try
            {
                Console.WriteLine("ThrowExceptionCatchRethrow() try block.");
                throw new Exception("Exception in ThrowExceptionCatchRethrow()");
            }
            catch (Exception exParameter)
            {
                Console.WriteLine("Message: " + exParameter.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("ThrowExceptionCatchRethrow() finally block");
            }
            Console.WriteLine("End of the ThrowExceptionCatchRethrow()"); // unreachable code
        }
    }
}
