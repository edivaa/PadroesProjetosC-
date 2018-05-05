using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PadroesProjetos.Classes.Objetos
{
    [Table("Produto")]
    public class Produto
    {

       
        [Key]//DataAnnotations
        public int Id { get; set; }

        [Required]
        [MaxLength(200)] //Defini tamanho maximo do campo no banco
        public string Nome { get; set; }
        [MaxLength(2000)] 
        public string Descricao { get; set; }

        [Range(999999999999.999, 999999999999.999)]
        [Required]
        public decimal Valor { get; set; }
        [ForeignKey("Loja")]
        public int LojaId { get; set; }


}
