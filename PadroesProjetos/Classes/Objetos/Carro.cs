using System;
namespace PadroesProjetos.Classes.Objetos
{
    public class Carro : MeioTransporte
    {
        
        public Carro(string nome){

            Console.WriteLine("Criando objeto Carro");

            _motor = new Motor();
            _bateria = new Bateria();

             Modelo = nome;
        }


        private void Ignicao(){

            Console.WriteLine("Foi dada ignição no "+Modelo);
        }

        public override  void Mover(){

             Console.WriteLine(Modelo+ " " + Marca + " andando ...");
        }

		
        public override void Ligar()
        {
            Console.WriteLine("Ligando " + Modelo + "...");
            Ignicao();
        }


        public override void Desligar()
		{
            Console.WriteLine("Desligando "+Modelo +"...");
		}

        public override void Abastecer()
        {
            Console.WriteLine("Abastecendo " + Modelo + "...");
        }



	}
}
