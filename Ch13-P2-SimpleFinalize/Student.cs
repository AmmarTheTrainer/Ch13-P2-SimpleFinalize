using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ch13_P2_SimpleFinalize
{
    class Student 
    {
        public Student()
        {
            Console.WriteLine(" ctor invoked ");
        }

        ~Student()
        {
            CleanUpLogic(); // call 
            Console.WriteLine(" finalize() method invoked ");
            Thread.Sleep(5000);
            Console.ReadLine();
        }
        private bool IsDisposed;
        private void CleanUpLogic()
        {
            // clean up logic for unmanaged resources
        }

        //public void Dispose()
        //{
        //    if (!IsDisposed)
        //    {
        //        CleanUpLogic();
        //    }
        //    // clean up logic for managed resources

        //    Console.WriteLine(" Dispose() method invoked ");
        //    GC.SuppressFinalize(this);
        //    IsDisposed = true;
        //}
    }
}
