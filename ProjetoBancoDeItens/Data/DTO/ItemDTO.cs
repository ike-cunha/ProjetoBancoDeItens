using ProjetoBancoDeItens.Data.Enum;    

namespace ProjetoBancoDeItens.Data.DTO
{
    public class ItemDTO
    {
        public string UsuarioId { get; set; }
        public int UnidadeCurricularId { get; set; }
        public Constantes.Nivel Nivel { get; set; }
        public Constantes.Alternativa Gabarito { get; set; }
        public bool Aprovado { get; set; }
        public bool Ativo { get; set; }
    }
}
