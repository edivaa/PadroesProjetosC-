using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjetos.Classes.Padroes
{
    class SQLConnection : DBConnection 
    {
        public override void Open()
        {
            Console.WriteLine("SQLConnection foi implementado"); 
        }
    }
}
