using System;
namespace PadroesProjetos.Classes
{
    public class Aluno : Pessoa
    {
       
        public string Matricula { set; get; }

        public void Estuda()
        {
            Console.WriteLine(Nome + " Estudando ...")
;
        }

    }
}
