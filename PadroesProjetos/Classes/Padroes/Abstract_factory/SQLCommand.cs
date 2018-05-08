using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjetos.Classes.Padroes.Abstract_factory
{
    public class SQLCommand:DBCommand
    {

        public override void Execute()
        {
            Console.WriteLine("Metodo  Execute SQLCommand foi chamdo");
        }
    }
}
