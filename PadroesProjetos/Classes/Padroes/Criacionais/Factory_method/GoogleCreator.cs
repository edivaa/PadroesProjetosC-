using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjetos.Classes.Padroes.Factory_method
{
    class GoogleCreator:Creator
    {    //Concreto create 
        public override Autenticacao CreateInstance()
        {
            return new AutenticacaoGoogle();
        }

    }
}
