using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Vista.Seguridad;


namespace POO
{
    internal static class Program
    { 
       
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var filtro = new ActivityMessageFilter();

            filtro.OnUserActivity += () =>
            {
                ControladoraSesiones.Instancia.RegistrarActividad();    
                Console.WriteLine("Actividad detectada");
            };
            Application.AddMessageFilter(filtro);
            Application.Run(new FormIniciarSesion());         
        }
    }
}
