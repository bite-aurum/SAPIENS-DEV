using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAPIENS_DEV.Logins;
using SAPIENS_DEV.Compartido;
namespace SAPIENS_DEV
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
			Accesibilidad.Iniciar(); // enciende la accesibilidad para todas las pantallas
			Application.Run(new FrmLogin());
		}
	}
}
