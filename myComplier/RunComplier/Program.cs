using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunComplier
{
    class Program
    {
        static void Main(string[] args)
        {            
            Functionality func = new Functionality();
            GlobalStore.FunctionType = 0;

            string testString = "th!@b2ne ;";

            for (int i = 0; i < testString.Length; i++)
            {
                func.readChar(i, testString);
                func.PrintResponse(GlobalStore.FunctionType.ToString());
            }
            //Console.WriteLine("Write Something");
            //string stuff = func.ReadInput();
            //func.PrintResponse(stuff);
            Console.ReadKey();           
            Console.ReadKey();           
        }
    }
}
