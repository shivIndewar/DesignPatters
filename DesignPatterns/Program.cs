using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintEmployeeDetails(),
                () => PrintStudentDetails()
                );
            //PrintEmployeeDetails();
            //PrintStudentDetails();

            //SingletonSecondVersion singletonSecondVersion = SingletonSecondVersion.GetInstance;
            //singletonSecondVersion.PrintDetails("this is from second version");

            //SingletonSecondVersion singletonSecondVersion1 = SingletonSecondVersion.GetInstance;
            //singletonSecondVersion1.PrintDetails("this is from second1 version");

            //SingletonSecondVersion.DerivedSinglTon derivedSinglTon = new SingletonSecondVersion.DerivedSinglTon();
            //derivedSinglTon.PrintDetails("This is from derived singleton");

            Console.ReadKey();
        }

        private static void PrintStudentDetails()
        {
            Singleton_firstversion student = Singleton_firstversion.GetInstance;
            student.PrintDetails("this is from student");
        }

        private static void PrintEmployeeDetails()
        {
            Singleton_firstversion fromEmaployee = Singleton_firstversion.GetInstance;
            fromEmaployee.PrintDetails("this is from employee");
        }
    }
}
