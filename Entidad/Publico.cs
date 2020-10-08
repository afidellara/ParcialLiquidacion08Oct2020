using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Publico : Liquidacion
    {

        public decimal Liquidacion { get; set; }
        public Publico(string nombre, int edad, string cedula, string sexo, decimal numeroLiquidacion,
            string tipoDeUsuario, decimal semanasDeTrabajo, decimal ibl)
        {
            Nombre = nombre;
            Edad = edad;
            Cedula = cedula;
            Sexo = sexo;
            NumeroLiquidacion = numeroLiquidacion;
            TipoDeUsuario = tipoDeUsuario;
            SemanasDeTrabajo = semanasDeTrabajo;
            Ibl = ibl; 
        }

        public override decimal CalcularLiquidacion(decimal ibl, decimal semanasDeTrabajo)
        {
            Liquidacion= ibl * CalcularIncremento(semanasDeTrabajo, ibl); 
            return Liquidacion;
        }


        public decimal CalcularIncremento(decimal semanasDeTrabajo, decimal ibl)
        {
            decimal incremento = 0;
            if (semanasDeTrabajo > 1300)
            {
                incremento = (ibl * 79) / 100 + Math.Floor((semanasDeTrabajo - 1300) / 50) ;
            }
            return incremento;
        }


        public string verDatosPublico()
        {
            return $"Cedula:{Cedula} - Nombre: {Nombre} - numero de liquidacion: {NumeroLiquidacion} - Liquidacion: {Liquidacion}"; 
        }
    }
}
