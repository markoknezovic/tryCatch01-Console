using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch01_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            Console.Write("unesi broj: ");
            try
            {
                broj = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(broj);
            }
            catch (Exception greska)
            {
                Console.WriteLine(greska.Message);
            }
            
            Console.ReadKey();
        }
    }
}
