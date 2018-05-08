using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjetos.Classes.Padroes.Abstract_factory
{
    class OracleConnection: DBConnection
    {
        public override void Open()
        {
            Console.WriteLine("Conexao com Oracle inciado com sucesso!");
        }

    }
}
