using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public abstract class Liquidacion
    {

        public abstract decimal CalcularLiquidacion(decimal IBL, decimal semanasDeTrabajo); 
    
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Cedula { get; set; }
        public string Sexo { get; set; }
        public decimal NumeroLiquidacion { get; set; }
        public string TipoDeUsuario { get; set; }
        public decimal SemanasDeTrabajo { get; set; }
        public decimal Ibl { get; set; }
        public decimal R { get; set; }
        public decimal S { get; set; }
        public decimal Incremento { get; set; }

 

    }
}
