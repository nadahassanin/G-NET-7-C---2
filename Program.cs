using static System.Reflection.Metadata.BlobBuilder;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using static System.Formats.Asn1.AsnWriter;
using System.Reflection.Emit;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {





            #region
            // Q: What is the purpose of #region and #endregion directives?
            /* A: They are used to organize code by allowing developers to collapse or expand
            specific blocks of code in the IDE This makes large files more readable*/


            #endregion


            #region QUESTION02
            // Q: Difference between explicit and implicit declaration?
            // EXPLICIT: Specify the type clearly.
            // int explicitNumber = 10;
            // IMPLICIT: Use 'var', compiler determines the type.
            // var implicitNumber = 10; 

            #endregion
            #region QUESTION03
            // Q: Syntax and why use them?
            // const int  ID = 3;
            /* A: Use constants for values that never change. They prevent accidental 
             modification and can improve performance. */

            #endregion
            #region QUESTION04


            // Q: Explain the difference with examples.

            /* A: classField (above) is class-level; it's accessible by any method in the class.

               Inside Main 'methodVar' is method-level; it only exists within Main. */

            // int methodVar = 50;

            #endregion
            #region QUESTION05
            //Q: What is block - level scope ?
            // A variable created inside { }
            // stays inside { }. It is born at the opening brace and 'dies' at the closing brace
            // You cannot use it outside
            #endregion
            #region QUESTION06

            //Variable Lifetime -Local vs Static?
            /* A: Local Variables: Live only while the method is executing.
               Static Variables: Live as long as the application is running. */
            #endregion
            #region QUESTION07
            // Garbage Collector?
            /* A: automatic memory manager. it tracks objects on the Heap and 
               deletes them when no references to them remain to free up memory. */
            #endregion
            #region QUESTION08


            // Variable Shadowing?
            /* A: Shadowing occurs when a variable in an inner scope has the same name as 
               one in an outer scope. C# allows shadowing class fields with local variables, 
               but not local variables within nested blocks in the same method. */
            #endregion
            #region QUESTION09 
            //C# Naming Rules?
            /* 1. Must start with a letter or underscore.
               2. No digits at the start. 
               3. No spaces.
               4. No reserved keywords (unless using @). 
               5. Case-sensitive. */
            #endregion
            #region QUESTION10
            //Naming Conventions?
            /* (a) Local Variables: camelCase
               (b) Class Names: PascalCase 
               (c) Constants: PascalCase  */
            #endregion

            #region QUESTION11
            //Error Types?
            /* 1. Syntax Error: Code grammar mistake 
               2. Runtime Error: Crashes during execution 
               3. Logical Error: Runs but gives wrong results  */
            #endregion





            #region QUESTION13
            //try-catch-finally
            /* A: The 'finally' block executes regardless of whether an exception occurred or not. */
            //try
            //{
            //    int x = 0;
            //    int y = 5 / x;
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Error caught.");
            //}
            //finally
            //{
            //    Console.WriteLine("Cleanup code here.");
            //}
            #endregion
            #region QUESTION17
            //Stack and Heap Memory
            /* A: Stack: Fast, small memory for Value Types (int, double) and reference pointers.
               Heap: Large memory for Reference Types (Objects, Strings). */

            #endregion
            #region QUESTION19
            //Object in C#
            /* A: 'System.Object' is the base class for everything. 
             * Inherited methods include:
               ToString()
               Equals()
               GetHashCode()
               GetType()
            */
            #endregion









        }
    }
}
