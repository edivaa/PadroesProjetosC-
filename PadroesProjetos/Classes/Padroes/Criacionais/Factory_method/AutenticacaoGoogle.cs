using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjetos.Classes.Padroes.Factory_method
{
   public  class AutenticacaoGoogle: Autenticacao 
    {
         
        public override void Autenticar()
        {
            Console.WriteLine("Autenticando via google");
        }
    }
}
