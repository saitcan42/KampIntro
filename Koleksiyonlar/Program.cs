using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Sait", "Ahmet", "Selim", "Neslihan" };


            List<string> isimler2 = new List<string> { "Sait", "Ahmet", "Selim", "Neslihan" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Emine");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
