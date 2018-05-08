using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjetos.Classes.Padroes.Abstract_factory
{
    //Fabrica abstrata

    public abstract  class DBFactory
    {
        public abstract DBConnection createConnection();
        public abstract DBCommand createCommand();
    }
}
