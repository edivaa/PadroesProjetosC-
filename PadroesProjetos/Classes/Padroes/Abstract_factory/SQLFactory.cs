using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjetos.Classes.Padroes.Abstract_factory
{
    //Fabrica concreta  
    public class SQLFactory : DBFactory 
    {

        public override DBConnection createConnection()
        {
            return new SQLConnection();
        }

        public override DBCommand createCommand()
        {
            return new SQLCommand();
        }
    }
}
