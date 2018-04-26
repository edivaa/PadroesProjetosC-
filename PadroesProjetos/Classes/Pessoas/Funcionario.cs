using System;
namespace PadroesProjetos.Classes
{
    public class Funcionario: Pessoa
    {
        public string Departamento { get; set; }

        public void trabalhar()
        {
            Console.WriteLine(Nome + " Trabalhanado ...");
        }

    }
}
