using System;
using System.Collections.Generic;
using System.Drawing;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace SAPIENS_DEV.Compartido
{

    public static class Accesibilidad
    {

        public static bool Activada = false;

        // aggrandaletras
        public static bool TextoGrande = false;

        private static readonly SpeechSynthesizer voz = new SpeechSynthesizer();
        private static readonly Dictionary<Control, float> tamanosOriginales
            = new Dictionary<Control, float>();


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
                {
                    // Es un panel solo entramos a sus hijos. NO le cambiamos sufuente, porque con AutoScaleMode.Font eso descoloca todo.
                    PrepararBotones(control);
                }
                else
                {
                    AjustarTexto(control);
                }
            }
        }

        // Agranda o regresa el tamaño de la letra de un control.
        private static void AjustarTexto(Control control)
        {
            // La primera vez que vemos el control, guardamos su tamaño original.
            if (!tamanosOriginales.ContainsKey(control))
                tamanosOriginales[control] = control.Font.Size;

            float original = tamanosOriginales[control];
            float nuevo = TextoGrande ? original * 1.4f : original;

            // Solo lo cambiamos si de verdad es diferente 
            if (control.Font.Size != nuevo)
                control.Font = new Font(control.Font.FontFamily, nuevo, control.Font.Style);
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
