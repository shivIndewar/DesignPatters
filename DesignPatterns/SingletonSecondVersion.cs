using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public sealed class SingletonSecondVersion
    {

        private static int counter = 0;
        private SingletonSecondVersion()
        {
            counter++;
            Console.WriteLine("Counter value " + counter.ToString());
        }
        private static SingletonSecondVersion instance = null;

        public static SingletonSecondVersion GetInstance { 
            get { 

                if (instance == null)
                    instance = new SingletonSecondVersion();
                return instance; 
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }


        //public class DerivedSinglTon : SingletonSecondVersion
        //{
            
        //}

    }
}
