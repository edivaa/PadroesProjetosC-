using System;
using PadroesProjetos.Classes.Objetos;
using System.ComponentModel.DataAnnotations.Schema;


namespace PadroesProjetos.Classes.Outros
{
    [Table("Loja")]
    public class Loja
    {

		private Produto produto;

        public Loja()
        {
			//produto = new List<Produto>();
        }



        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }


		//public virtual Loja Loja { get; set; }

        //public virtual List<Produto> Produtos { get; set; }
       
    }
    
}
