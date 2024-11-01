using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username;
            Console.WriteLine("Please enter your name : ");
            Console.Write("");
            username = Console.ReadLine();
            Console.WriteLine("Greetings, " + username); 
            Console.ReadLine();
        }
    }
}
