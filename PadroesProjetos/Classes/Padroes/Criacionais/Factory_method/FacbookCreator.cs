using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjetos.Classes.Padroes.Factory_method
{
    class FacbookCreator : Creator
    {
        public override Autenticacao CreateInstance()
        {
            return new AutenticacaoFacebook();
        }
    }
}
