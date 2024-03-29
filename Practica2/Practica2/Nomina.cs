﻿/*
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
        #region atributos
        private Empleado miEmpleado;
        private Empleado empleadoNomina;
        private DateTime fechaNomina;
        private int numHorasExtras, porcIRPF;
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
            return CotASegSocial(miEmpleado) + CotSegDes(miEmpleado) + RetIrpf(miEmpleado);
        }

        public double CotSegDes(Empleado miEmpleado)
        {
            return DevengosPagaExtra(miEmpleado) * 1.97 / 100;
        }

        public double CotASegSocial(Empleado miEmpleado)
        {
            return Math.Round((BasCot(miEmpleado) * 4.51 / 100),2);
        }

        public double BasCot(Empleado miEmpledao)
        {
            return DevengosPagaExtra(miEmpleado) * 2 / 6;
        }

        public double TotalDevengado(Empleado miEmpledao)
        {
            return miEmpleado.SalarioBaseProp + ImporteAntiguedad(miEmpleado) + ImporteHorasExtras(miEmpleado) + DevengosPagaExtra(miEmpleado);
        }

        public double LiquidoAPercibir(Empleado miEmpleado)
        {
            double liquido;
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
            double retIrpf;
            if (FechaNominaProp.Month == 12 || FechaNominaProp.Month == 6)
            {
                retIrpf = (TotalDevengado(miEmpleado) + DevengosPagaExtra(miEmpleado) * porcIRPF / 100);
            }
            else
            {
                retIrpf = TotalDevengado(miEmpleado) * porcIRPF / 100;
            }
            return retIrpf;
        }

        public void showNomina()
        {
            Console.WriteLine("\nLIQUIDACION DE HABERES AL " + FechaNominaProp.Day + "-" + FechaNominaProp.Month + "-" + FechaNominaProp.Year);
            Console.WriteLine("\nDEVENGOS\t\t\t\tDESCUENTOS" +
                "\n----------\t\t\t\t----------" +
                "\nSalario Base\t\t" + miEmpleado.SalarioBaseProp + "\t\tCotizacion Seg.Soc.\t" + Math.Round(CotASegSocial(miEmpleado), 2) +
                "\nAntigüedad\t\t" + Math.Round(ImporteAntiguedad(miEmpleado), 2) + "\t\tCotizacion Seg.Des.\t" + Math.Round(CotSegDes(miEmpleado), 2) +
                "\nImporte Hor.Extr.\t" + Math.Round(ImporteHorasExtras(miEmpleado), 2) + "\t\tRetención I.R.P.F\t" + Math.Round(RetIrpf(miEmpleado), 2) +
                "\nPaga Extra\t\t" + Math.Round(DevengosPagaExtra(miEmpleado), 2) + 
                "\n\nTotal Devengos\t\t" + Math.Round(TotalDevengado(miEmpleado), 2) + "\t\tTotal Descuentos\t" + Math.Round(TotalDescuentos(miEmpleado), 2));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n************************************" +
                "\nLIQUIDO A PERCIBIR\t" + Math.Round(LiquidoAPercibir(miEmpleado), 2) +
                "\n************************************");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
