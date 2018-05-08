using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjetos.Classes.Padroes.Factory_method
{
    //Dedifne metedo Factory Method abstrato 
    public abstract class Creator
    {

        public abstract Autenticacao CreateInstance();
    }
}
