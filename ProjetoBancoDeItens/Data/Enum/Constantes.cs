using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.Enum
{
    public class Constantes
    {

        public enum Alternativa
        {
            [Description("A")]
            A = 1,
            [Description("B")]
            B = 2,
            [Description("C")]
            C = 3,
            [Description("D")]
            D = 4,
            [Description("E")]
            E = 5,
        }

        public enum Nivel
        {
            [Description("Muito Fácil")]
            MuitoFacil = 1,
            [Description("Fácil")]
            Facil =2,
            [Description("Médio")]
            Medio = 3,
            [Description("Difícil")]
            Dificil = 4,
            [Description("Muito Difícil")]
            MuitoDificil = 5,
        }

        public enum Posicao
        {
            Suporte = 1,
            Comando = 2,
        }

        public enum Competencias
        {
            C1 = 1,
            C2 = 2,
            C3 = 3,
            C4 = 4,
            C5 = 5,
            C6 = 6,
            C7 = 7,
            C8 = 8,
            C9 = 9,
            C10 = 10,
            C11 = 11,
            C12 = 12,
            C13 = 13,
            C14 = 14,
        }
    }
}
