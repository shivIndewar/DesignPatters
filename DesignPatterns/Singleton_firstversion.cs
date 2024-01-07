using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    sealed class Singleton_firstversion
    {
        private static int counter = 0;

        private static Singleton_firstversion instance = null;
        private static Object obj = new object();
        public static Singleton_firstversion GetInstance {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new Singleton_firstversion();
                    }
                }
                return instance;
            }
        }
        private Singleton_firstversion()
        {
            counter++;
            Console.WriteLine("Counter value " +counter.ToString());

        }
        public void  PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
