using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            string cedula;
            string sexo;
            decimal numeroLiquidacion;
            decimal semanasDeTrabajo;
            decimal ibl;
            int opcion;
            string tipo; 
            Console.WriteLine("M E N U");
            Console.WriteLine("1. REGISTRAR");
            Console.WriteLine("2. MODIFICAR");
            Console.WriteLine("3. ELIMINAR");
            Console.WriteLine("4. LEER");
            Console.WriteLine("5. SALIR");
            opcion = int.Parse(Console.ReadLine());

            
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("REGISTRAR");
                    Console.WriteLine("Cedula: ");
                    cedula = Console.ReadLine();

                    Console.WriteLine("Nombre: ");
                    nombre = Console.ReadLine();
                    
                    Console.WriteLine("Sexo: ");
                    sexo = Console.ReadLine();

                    Console.WriteLine("Numero liquidacion: ");
                    numeroLiquidacion = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Semanas cotizadas: ");
                    semanasDeTrabajo = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Ibl: ");
                    ibl = decimal.Parse(Console.ReadLine()); 

                    Console.WriteLine("Edad: ");
                    edad = int.Parse(Console.ReadLine());


                    Console.WriteLine("TIPO DE PERSONA [PUBLICO-EMPLEADO]: ");
                    tipo = Console.ReadLine();
                    if (tipo.Equals("PUBLICO"))
                    {
                        Publico publico = new Publico(nombre, edad, cedula, sexo, numeroLiquidacion, tipo, semanasDeTrabajo, ibl);
                        publico.CalcularIncremento(semanasDeTrabajo,ibl);
                        publico.CalcularLiquidacion(ibl, semanasDeTrabajo);
                        Console.WriteLine(publico.verDatosPublico()); 
                    }
                    else
                    {
                        if (tipo.Equals("EMPLEADO"))
                        {
                            Empleado empleado = new Empleado(nombre, edad, cedula, sexo, numeroLiquidacion, tipo, semanasDeTrabajo, ibl);
                            empleado.CalcularSalariosVigentes(ibl);
                            empleado.CalcularIncremento(semanasDeTrabajo, ibl);
                            empleado.CalcularLiquidacion(ibl, semanasDeTrabajo);
                            Console.WriteLine(empleado.verDatosEmpleado()); 
                        }
                    }
                    break;
                case 2:
                     
                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
            }
            Console.ReadKey(); 
        }
    }
}
