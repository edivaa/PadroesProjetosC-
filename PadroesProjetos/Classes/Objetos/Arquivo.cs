using System;
namespace PadroesProjetos.Classes.Objetos
{


    public interface IEditavel
    {
        void Editar();

    }

    public interface IImprimir
    {
        void Imprimir();
    }

    public abstract class Arquivo{


        private int _tamanho;
        public int TamArquivo
        {
            get { return _tamanho; }
            set { _tamanho = value; }
        }
        protected string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }

        }




        public virtual void abrir(){

            Console.WriteLine("Abrindo arquivo "+ _descricao+" ...");
        }

    }

    public class MP3: Arquivo{


        public override void abrir()
		{
            base.abrir();
            Console.WriteLine("Tocando arquivo MP3"+_descricao +"...");


		}

	}

    public class Foto : Arquivo, IImprimir, IEditavel
    {


        public override void abrir()
        {
            base.abrir();
            Console.WriteLine("Mostrando arquivo MP3" + _descricao + "...");


        }

        public void Editar()
        {
            //
        }

        public void Imprimir()
        {
            //
        }
    }

    public class Documento : Arquivo, IImprimir, IEditavel
    {
        public override void abrir()
        {
            base.abrir();
            Console.WriteLine("Exibindo arquivo MP3" + _descricao + "...");


        }

        public void Editar()
        {
            throw new NotImplementedException();
        }

        public void Imprimir()
        {
            throw new NotImplementedException();
        }
    }
}
