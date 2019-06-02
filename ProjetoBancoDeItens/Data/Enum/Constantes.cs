using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.Enum
{
    public class Constantes
    {

        public enum Gabarito
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
    }
}
