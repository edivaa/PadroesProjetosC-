using System;
namespace PadroesProjetos.Classes.Objetos
{
    public class NoteBook
    {
        private string _nome;
        public USB Porta1;
        public USB Porta2;
        public USB Porta3;

        public NoteBook( string nome)
        {
            _nome = nome;
        }

        public string getNome(){
            return _nome;
        }


    }


    public abstract class USB
    {

        public abstract void plugar();
    }

    public class Mouse : USB{



        public override void plugar() {

            Console.WriteLine("Plugando Mouse");
        }
    }

    public class Teclado:USB{

		public override void plugar()
		{
            Console.WriteLine("Plugando Teclado");
		}
	}

    public class Iphone:USB{

		public override void plugar()
		{
            Console.WriteLine("Plugando Iphone");
		}
	}


    public class Tablet: USB{

		public override void plugar()
		{
            Console.WriteLine("Plugando um tablet");
		}
	}
}
