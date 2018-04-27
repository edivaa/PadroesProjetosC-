using System;
namespace PadroesProjetos.Classes.Objetos
{


    public abstract class Arquivo{


        private int _tamanho;
        private string _descricao;


        public virtual void abrir(){

            Console.WriteLine("Abrindo arquivo");
        }

    }

    public class MP3: Arquivo{
        
    }

    public class Foto : Arquivo{
        
    }

    public class Documento : Arquivo
    {
        public Documento()
        {
        }
    }
}
