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
        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }

        }




        public virtual void abrir(){

            Console.WriteLine("Abrindo arquivo");
        }

    }

    public class MP3: Arquivo{
        
    }

    public class Foto : Arquivo, IImprimir, IEditavel
    {
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
        public Documento()
        {
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
