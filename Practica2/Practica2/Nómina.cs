/*
* PRÁCTICA.............: Práctica 2.
* NOMBRE y APELLIDOS...: José Ramón Gallego Vélez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Definición de Clases. Uso de Métodos.
* FECHA de ENTREGA.....: 27 de octubre de 2022
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Nómina
    {
        private static Empleado miEmpleado;
        #region valores
        private static Empleado empleadoNomina;
        private static DateTime fechaNomina;
        private static int numHorasExtras, porcIRPF;
        private double liquido;
        #endregion

        Nómina()
        {
            ImporteAntiguedad(miEmpleado);
            ImporteHorasExtras(miEmpleado);
        }

        public static int NumHorasExtrasProp
        {
            get { return numHorasExtras; }
            set 
            { 
                numHorasExtras = value; 
            }
        }

        public static DateTime FechaNominaProp
        {
            get { return fechaNomina; }
            set 
            {
                fechaNomina = value; 
            }

        }

        public int PorcIRPFProp
        {
            get { return porcIRPF; }
            set
            {
                if (miEmpleado.CategoriaProp == 1)
                {
                    porcIRPF = 18 - miEmpleado.NumHijosProp;
                }
                else if (miEmpleado.CategoriaProp == 2)
                {
                    porcIRPF = 15 - miEmpleado.NumHijosProp;
                }
                else if (miEmpleado.CategoriaProp == 3)
                {
                    porcIRPF = 12 - miEmpleado.NumHijosProp;
                }
            }
        }

        public Empleado EmpleadoNominaProp
        {
            get { return empleadoNomina; }
            set
            {
                empleadoNomina = value;
            }
        }


        public static double ImporteAntiguedad(Empleado miEmpleado)
        {
            return miEmpleado.NumTrieniosProp * miEmpleado.SalarioBaseProp * 4 / 100;
        }

        public static double ImporteHorasExtras(Empleado miEmpleado)
        {
            return NumHorasExtrasProp * miEmpleado.SalarioBaseProp * 1 / 100;
        }

        public static double DevengosPagaExtra(Empleado miEmpleado)
        {
            return miEmpleado.SalarioBaseProp + ImporteAntiguedad(miEmpleado);
        }

        public static double TotalDescuentos(Empleado miEmpleado)
        {
            return CotASegSocial(miEmpleado) + CotSegSocial(miEmpleado) + Re
        }

        public static double CotSegSocial(Empleado miEmpleado)
        {
            return DevengosPagaExtra(miEmpleado) * 1.97 / 100;
        }

        public static double CotASegSocial(Empleado miEmpleado)
        {
            return BasCot(miEmpleado) * 4.51 / 100;
        }

        public static double BasCot(Empleado miEmpledao)
        {
            return DevengosPagaExtra(miEmpleado) * 2 / 6;
        }

        public static double TotalDevengado(Empleado miEmpledao)
        {
            return miEmpleado.SalarioBaseProp + ImporteAntiguedad(miEmpleado) + ImporteHorasExtras(miEmpleado);
        }

        public double LiquidoAPercibir(Empleado miEmpleado)
        {
            if (FechaNominaProp.Month == 12 || FechaNominaProp.Month == 6)
            {
                liquido = TotalDevengado(miEmpleado) + DevengosPagaExtra(miEmpleado) - TotalDescuentos(miEmpleado);
            }
            else
            {
                liquido = TotalDevengado(miEmpleado) - TotalDescuentos(miEmpleado);
            }
            return liquido;
        }
    }
}
