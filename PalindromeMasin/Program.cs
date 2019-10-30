using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeMasin
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string nameReversed = "";
            Console.WriteLine("Sisesta oma nimi.");
            name = Console.ReadLine();

            for (int i = name.Length - 1; i >= 0; i--) 
            {
                nameReversed += name[i].ToString();
            }
            if (nameReversed == name) 
            {
                Console.WriteLine($"{name} on palindroom.");
            }
            else
            {
                Console.WriteLine($"{name} ei ole palindroom.");
            }
            Console.ReadLine();
        }
    }
}
