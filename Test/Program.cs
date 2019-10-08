using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            UserFeatures U = new UserFeatures();
            for (int i = 1; i < 2; i++)
            {
                U.Greeting();
                Console.WriteLine(i);
            }
            U.userInput();
        }
    }

    class UserFeatures
    {
        public void Greeting()
        {
            Console.WriteLine("Hello World");
        }

        public void userInput()
        {
            Console.ReadKey();
        }
    }
}
