using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjetos.Classes.Padroes.Abstract_factory
{
    class OracleFactory:DBFactory
    {
        public override DBConnection createConnection()
        {
            return new OracleConnection();
        }

        public override DBCommand createCommand()
        {
            return new OracleCommand();
        }
    }
}
