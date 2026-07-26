using System;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace SAPIENS_DEV.Compartido
{
    
    public static class Accesibilidad
    {
       
        public static bool Activada = false;
        private static readonly SpeechSynthesizer voz = new SpeechSynthesizer();

        
        public static void Iniciar()
        {
            Timer revisor = new Timer();
            revisor.Interval = 1000; 
            revisor.Tick += (s, e) =>
            {
                foreach (Form pantalla in Application.OpenForms)
                    PrepararBotones(pantalla);
            };
            revisor.Start();
        }

        
        private static void PrepararBotones(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                if (control is Button boton)
                {
                    boton.MouseEnter -= DecirBoton;
                    boton.MouseEnter += DecirBoton;
                }

                if (control.HasChildren)
                    PrepararBotones(control);
            }
        }

        private static void DecirBoton(object sender, EventArgs e)
        {
            if (!Activada) return; // si la accesibilidad esta apgasa no hace nada 

            Button boton = (Button)sender;

            string texto = boton.Text;
            if (string.IsNullOrWhiteSpace(texto))
                texto = boton.Name;

            Decir("Botón " + texto);
        }

        
        public static void Decir(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return;
            voz.SpeakAsyncCancelAll(); 
            voz.SpeakAsync(texto);
        }
    }
}
