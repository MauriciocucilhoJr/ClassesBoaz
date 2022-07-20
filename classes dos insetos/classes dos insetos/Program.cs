    using System;

namespace classes_dos_insetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insetos Insetos1 = new("Pulga",4,2,"cinza");
            Insetos Insetos2 = new("Aranha", 8, 0, "marrom");
            Insetos Insetos3 = new("Centopeia", 100, 2, "vermelho");
            Insetos Insetos4 = new("Grilo", 6, 2, "verde");

            Console.WriteLine(Insetos1.ToString());
            Console.WriteLine(Insetos2.ToString());
            Console.WriteLine(Insetos3.ToString());
            Console.WriteLine(Insetos4.ToString());
        }

        
    }
}
