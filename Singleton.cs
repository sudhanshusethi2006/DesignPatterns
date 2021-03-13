using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testName;

namespace testName
{
    class test
    {
        private protected int x;
    }
}
namespace ConsoleApp2.SingletonPattern
{


    sealed class Singleton : test
    {
       
        private static int counter = 0;
        private static Singleton instance = null;
        //
        private static readonly object obj = new object();
        public static Singleton getInstance
        {

       
             get
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }

                return instance;

            }
        }
        private Singleton()
        {
            x++;
            counter++;
            Console.WriteLine($"Counter value is {counter}");
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
        // nested class if the class is not sealed this will violate the principle 
        //public class Derived : Singleton
        // {

      

        // }
    }


}
