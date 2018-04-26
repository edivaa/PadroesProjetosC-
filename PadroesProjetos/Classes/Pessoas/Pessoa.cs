using System;

namespace PadroesProjetos.Classes
{
    public class Pessoa
    {

        public string Nome { get; set; }
        public int Idade { get; set; }
        public void Dormir()
        {
            Console.WriteLine(Nome +" tem "+Idade+ " está Dormindo");
        }
    }
}
