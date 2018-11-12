using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13_P2_SimpleFinalize
{
    class Program
    {
        
        //~Program()
        //{
        //    object
        //    Console.WriteLine(" prOGRAM CLASS Finalizer ");
        //}
        static void Main(string[] args)
        {
            MyResourceWrapper rw = new MyResourceWrapper();

            //Console.WriteLine("***** Fun with Finalizers *****\n");
            //Console.WriteLine("Hit the return key to shut down this app");
            //Console.WriteLine("and force the GC to invoke Finalize()");
            //Console.WriteLine("for finalizable objects created in this AppDomain.");

            ////MyResourceWrapper rw2 = new MyResourceWrapper();

            ////Program program = new Program();
            ///

                using (Student stu = new Student())
                {
                    // logic , data 
                }

            Student stu2 = new Student();

            //stu.Dispose();

            Console.ReadLine();

        }
    }
}
