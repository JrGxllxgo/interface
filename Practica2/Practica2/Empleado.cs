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
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Empleado
    {
        #region values
        private int categoria, numHijos, numTrienios, salarioBase;
        private string nif, nombre;
        #endregion

        public int SalarioBaseProp
        {
            get { return salarioBase; }
            set 
            {
                salarioBase = value;
            }
        }
        public int CategoriaProp
        {
            get { return categoria; }
            set 
            { 
                categoria = value; 

                if (categoria == 1)
                {
                    SalarioBaseProp = 2500;
                }
                else if (categoria == 2)
                {
                    SalarioBaseProp = 2000;
                }
                else if (categoria == 3)
                {
                    SalarioBaseProp = 1500;
                }
            }
        }

        public int NumHijosProp
        {
            get { return numHijos; }
            set { numHijos = value; }
        }

        public int NumTrieniosProp
        {
            get { return numTrienios; }
            set { numTrienios = value; }
        }

        public string NifProp
        {
            get { return nif; }
            set { nif = value; }
        }

        public string NombreProp
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Empleado()
        {
            CategoriaProp = 1;
            NifProp = "12345678A";
            NombreProp = "Default";
            NumHijosProp = 1;
            NumTrieniosProp = 1;
        }

        public Empleado(int categoria, string nif, string nombre, int numHijos, int numTrienios)
        {
            CategoriaProp = categoria;
            NifProp = nif;
            NombreProp = nombre;
            NumHijosProp = numHijos;
            NumTrieniosProp = numTrienios;
        }

        public void showData()
        {
            Console.WriteLine("Nombre.....: " + NombreProp 
                +"\nN.I.F......: " + NifProp
                + "\nCategoría......: " + CategoriaProp
                + "\nNº Hijos......: " + NumHijosProp
                + "\nNº Trienios......: " + NumTrieniosProp);
        }
    }
}
