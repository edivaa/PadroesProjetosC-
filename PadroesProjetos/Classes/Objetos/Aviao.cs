using System;
namespace PadroesProjetos.Classes.Objetos
{
    public class Aviao : MeioTransporte
    {
      

        public override void Mover()
        {

            Console.WriteLine(Modelo +" "+ Marca + " Voando ...");
        }
    }
}
