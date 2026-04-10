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
















        }
    }
}
