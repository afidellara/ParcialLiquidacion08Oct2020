using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Empleado : Liquidacion
    {

        public Empleado(string nombre, int edad, string cedula, string sexo, decimal numeroLiquidacion,
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
            decimal liquidacion = ibl * PorcentajeDeCotizacion(ibl) +CalcularIncremento(semanasDeTrabajo, ibl); 
            return liquidacion; 
        }

        public decimal PorcentajeDeCotizacion(decimal ibl)
        {
            decimal R = 65 - ((5 / 10) * CalcularSalariosVigentes(ibl));
            return R; 
        } 

        public decimal CalcularIncremento(decimal semanasDeTrabajo, decimal ibl)
        {
            decimal incremento = 0;
            if (semanasDeTrabajo > 1300)
            {
                incremento = Math.Floor((semanasDeTrabajo - 1300) / 50) * (15/10);
            }
            return incremento;
        }

        public decimal CalcularSalariosVigentes(decimal ibl)
        {
            decimal S= ibl / 980657;
            return S; 
        }

        public string verDatosEmpleado()
        {
            return $"Cedula:{Cedula} - Nombre: {Nombre} - numero de liquidacion: {NumeroLiquidacion}";
        }
    }
}
