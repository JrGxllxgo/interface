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
    class Nomina
    {
        private Empleado miEmpleado;
        #region valores
        private Empleado empleadoNomina;
        private DateTime fechaNomina;
        private int numHorasExtras, porcIRPF;
        private double liquido, retIRPF;
        #endregion

        public Nomina(Empleado miEmpleado)
        {
            this.miEmpleado = miEmpleado;
            ImporteAntiguedad(miEmpleado);
            ImporteHorasExtras(miEmpleado);
        }

        public int NumHorasExtrasProp
        {
            get { return numHorasExtras; }
            set
            {
                numHorasExtras = value;
            }
        }

        public DateTime FechaNominaProp
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


        public double ImporteAntiguedad(Empleado miEmpleado)
        {
            return miEmpleado.NumTrieniosProp * miEmpleado.SalarioBaseProp * 4 / 100;
        }

        public double ImporteHorasExtras(Empleado miEmpleado)
        {
            return NumHorasExtrasProp * miEmpleado.SalarioBaseProp * 1 / 100;
        }

        public double DevengosPagaExtra(Empleado miEmpleado)
        {
            return miEmpleado.SalarioBaseProp + ImporteAntiguedad(miEmpleado);
        }

        public double TotalDescuentos(Empleado miEmpleado)
        {
            return CotASegSocial(miEmpleado) + CotSegSocial(miEmpleado) + RetIrpf(miEmpleado);
        }

        public double CotSegSocial(Empleado miEmpleado)
        {
            return DevengosPagaExtra(miEmpleado) * 1.97 / 100;
        }

        public double CotASegSocial(Empleado miEmpleado)
        {
            return BasCot(miEmpleado) * 4.51 / 100;
        }

        public double BasCot(Empleado miEmpledao)
        {
            return DevengosPagaExtra(miEmpleado) * 2 / 6;
        }

        public double TotalDevengado(Empleado miEmpledao)
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

        public double RetIrpf(Empleado miEmpleado)
        {
            if (FechaNominaProp.Month == 12 || FechaNominaProp.Month == 6)
            {
                retIRPF = (TotalDevengado(miEmpleado) + DevengosPagaExtra(miEmpleado) * porcIRPF / 100);
            }
            else
            {
                retIRPF = TotalDevengado(miEmpleado) * porcIRPF / 100;
            }
            return retIRPF;
        }


        public void showNomina()
        {
            Console.WriteLine("LIQUIDACION DE HABERES AL " + FechaNominaProp);
            Console.WriteLine("DEVENGOS" +
                "\n----------" +
                "\nSalariobase\t\t\t" + miEmpleado.SalarioBaseProp + 
                "\nAntigüedad\t\t\t" + ImporteAntiguedad(miEmpleado) +
                "\nImporte Hor.Extr.\t\t\t" + ImporteHorasExtras(miEmpleado) +
                "\nPaga Extra\t\t\t" + DevengosPagaExtra(miEmpleado) + 
                "\n\nTotal Deevengos\t\t\t" + TotalDevengado(miEmpleado));
        }
    }
}
