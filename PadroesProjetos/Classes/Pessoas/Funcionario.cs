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



    public class Estagiario: Pessoa
    {

        public void trabalhar()
        {
            Console.WriteLine(Nome + "estagiario Trabalhanado ...");
        }
    }



    public class ArquitetoSoftware :Funcionario
    {

       
    }
}
