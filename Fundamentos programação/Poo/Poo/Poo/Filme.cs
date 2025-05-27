using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    internal class Filme
    {
        public string nome;
        public string tipo;
        public string data;
        public string estudio;


        public void Executar() 
        {

            Console.WriteLine("Rodando Filme: {0}", nome);
            Console.WriteLine("Data do Filme: {0}", data);
            Console.WriteLine("Estúdio do Filme: {0}", estudio);
        
        }
    
        public void Pausar() 
        {
        
        
        }
    }
}
