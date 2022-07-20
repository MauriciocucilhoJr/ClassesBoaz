using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_dos_insetos
{
    internal class Insetos
    {

        public string Nome { get; set; }

        public int Patas { get; set; }

        private int Antenas { get; set; }

        private string Cor { get; set; }  

        public Insetos()    
        {

        }

        public Insetos( string nome, int patas, int antenas, string cor)
        {
            Nome = nome;
            Patas = patas;
            Antenas = antenas;
            Cor = cor;
        }   
         
        public override string ToString()
        {
            return $"Inseto na sua casa agora mesmo: {Nome} com {Patas} patas {Antenas} antenas e de cor {Cor}";

        }
    }
}
