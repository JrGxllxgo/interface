using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
* PRÁCTICA.............: Práctica 6.
* NOMBRE Y APELLIDOS...: José Ramón Gallego Vélez
* CURSO Y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Aplicaciones de Formulario. Controles Básicos.
* FECHA DE ENTREGA.....: 07 de diciembre de 2022
*/

namespace Practica6
{
    internal static class Prueba
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmHojaSalarial());
        }
    }
}
