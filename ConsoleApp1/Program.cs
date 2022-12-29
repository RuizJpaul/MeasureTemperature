using System;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int realNum;
            string ans;
            Console.Write("Enter a temperature to evaluate: ");
            bool num = int.TryParse(Console.ReadLine(), out realNum);
            // we use a reduced conditional structure (developed if)
            // answer = condition ? "(actions in case True)" : "(actions in case False)";
            ans = num == true ? True(realNum) : "that isn't a correct temperature";
            Console.WriteLine(ans);
        }
        public static string True(int temperature)
        {
            string clima;
            clima = temperature <= 15 ? "It's so cold" : temperature >= 16 && temperature <= 28 ?
                "It's a friendly weather" : "It's so hot"; 
            return clima;
        }
    }
}
