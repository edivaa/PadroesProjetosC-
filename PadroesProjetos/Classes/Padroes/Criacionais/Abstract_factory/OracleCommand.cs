using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjetos.Classes.Padroes.Abstract_factory
{
    class OracleCommand: DBCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Comnando do oracle executado com sucesso!");
        }
    }
}
