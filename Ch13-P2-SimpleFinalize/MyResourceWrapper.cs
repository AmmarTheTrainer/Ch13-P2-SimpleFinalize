using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13_P2_SimpleFinalize
{
    // Override System.Object.Finalize() via finalizer syntax.
    class MyResourceWrapper
    {
        //// Compile-time error!
        //protected override void Finalize() { }
        
        ~MyResourceWrapper()
        {
            Console.Beep();
            Console.WriteLine(" C# Finalizer method invoked ");
        }
    }
}
