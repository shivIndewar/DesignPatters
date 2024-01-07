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

        private static readonly Lazy<Singleton_firstversion> instance = new Lazy<Singleton_firstversion>(() => new Singleton_firstversion());
        public static Singleton_firstversion GetInstance {
            get
            {
                return instance.Value;
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
