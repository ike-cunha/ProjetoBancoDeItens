using ProjetoBancoDeItens.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoBancoDeItens.Data.Model
{
    public class Competencia
    {
       [Key]
        public int Id { get; set; }

        [Required]
        public Constantes.Competencias Sigla { get; set; }

        [Column(TypeName = "VARCHAR(80)")]
        public string Descricao { get; set; }
    }
}
