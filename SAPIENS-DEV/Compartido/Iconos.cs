using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace SAPIENS_DEV.Compartido
{
    /// <summary>
    /// Ayudante para usar iconos PNG guardados en la carpeta "imagenes"
    /// (que viaja junto al programa).
    ///
    /// Los iconos se guardan como SILUETA BLANCA con fondo transparente.
    /// Así, con un solo archivo, podemos pintarlo del color que necesite
    /// cada pantalla gris, índigo, rojo, blanco
    /// </summary>
    public static class Iconos
    {
        /// <summary>
        /// Carga un icono de la carpeta "imagenes", lo pinta del color pedido
        /// y lo deja en el tamaño indicado.
        ///
        /// Tamaños : 16, 24, 32 o 48 píxeles.
        /// Ejemplo: Iconos.Cargar("guardar", Color.White, 24)
        /// </summary>
        public static Image Cargar(string nombre, Color color, int tamano = 24)
        {
            // La carpeta "imagenes" está al lado del .exe.
            string ruta = Path.Combine(Application.StartupPath, "imagenes", nombre + ".png");

            // Si por alguna razón no existe el archivo, no truena la app.
            if (!File.Exists(ruta)) return null;

            // Solo aceptamos los tamaños estándar; cualquier otro se ajusta a 24.
            if (tamano != 16 && tamano != 24 && tamano != 32 && tamano != 48)
                tamano = 24;

            using (Bitmap original = new Bitmap(ruta))
            using (Bitmap pintada = Tenir(original, color))
            {
                return Redimensionar(pintada, tamano);
            }
        }

        /// <summary>
        /// Pone un icono al lado izquierdo del texto de un botón (estilo menú).
        /// Sirve para los botones de menú que tienen el texto alineado a la izquierda.
        /// </summary>
        public static void EnBoton(Button boton, string nombre, Color color, int tamano = 24)
        {
            boton.Image = Cargar(nombre, color, tamano);
            boton.ImageAlign = ContentAlignment.MiddleLeft;
            boton.TextImageRelation = TextImageRelation.ImageBeforeText;
            boton.Padding = new Padding(14, 0, 0, 0);
        }

        /// <summary>
        /// Pone un icono a la izquierda del texto de un botón, centrado
        /// (para botones de acción como "Guardar", "Cancelar", etc.).
        /// </summary>
        public static void EnBotonTexto(Button boton, string nombre, Color color, int tamano = 16)
        {
            boton.Image = Cargar(nombre, color, tamano);
            boton.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        /// <summary>
        /// Pone un icono dentro de un Label (que antes mostraba un emoji).
        /// Quita el texto y deja solo la imagen, centrada.
        /// </summary>
        public static void EnLabel(Label label, string nombre, Color color, int tamano = 32)
        {
            label.Image = Cargar(nombre, color, tamano);
            label.Text = "";
            label.ImageAlign = ContentAlignment.MiddleCenter;
        }

        /// <summary>
        /// Pone un icono a la izquierda del texto de un Label (deja el texto).
        /// Útil para "badges" (etiquetas con icono + texto).
        /// </summary>
        public static void EnLabelConTexto(Label label, string nombre, Color color, int tamano = 16, bool arriba = false)
        {
            // El Label no tiene TextImageRelation (eso es solo de los botones).
            // El Padding no sirve para separarlos porque el icono y el texto lo
            // respetan por igual y se encimarían. La forma que sí funciona es
            // poner el icono a la izquierda y empujar el texto con espacios.
            label.Image = Cargar(nombre, color, tamano);
            label.ImageAlign = arriba ? ContentAlignment.TopLeft : ContentAlignment.MiddleLeft;
            label.TextAlign = arriba ? ContentAlignment.TopLeft : ContentAlignment.MiddleLeft;
            label.Padding = new Padding(0);

            // Espacios suficientes para dejar libre el ancho del icono.
            string sangria = new string(' ', tamano / 3 + 2);
            if (!label.Text.StartsWith(sangria))
                label.Text = sangria + label.Text.TrimStart();
        }

        // Devuelve una copia de la imagen en el tamaño (cuadrado) indicado.
        private static Bitmap Redimensionar(Bitmap imagen, int tamano)
        {
            Bitmap chica = new Bitmap(tamano, tamano);
            using (Graphics g = Graphics.FromImage(chica))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(imagen, 0, 0, tamano, tamano);
            }
            return chica;
        }

        // Devuelve una copia de la imagen pintada del color indicado,
        // respetando la parte transparente .
        private static Bitmap Tenir(Bitmap original, Color color)
        {
            Bitmap pintada = new Bitmap(original.Width, original.Height);

            // Esta receta de colores cambia el rojo/verde/azul de cada pixel
            // al color que queremos, pero deja igual la transparencia .
            float r = color.R / 255f;
            float g = color.G / 255f;
            float b = color.B / 255f;

            ColorMatrix receta = new ColorMatrix(new float[][]
            {
                new float[] { 0, 0, 0, 0, 0 },
                new float[] { 0, 0, 0, 0, 0 },
                new float[] { 0, 0, 0, 0, 0 },
                new float[] { 0, 0, 0, 1, 0 }, // conserva la transparencia
                new float[] { r, g, b, 0, 1 }  // pone el color elegido
            });

            using (Graphics g2 = Graphics.FromImage(pintada))
            using (ImageAttributes atributos = new ImageAttributes())
            {
                atributos.SetColorMatrix(receta);
                g2.DrawImage(original,
                    new Rectangle(0, 0, original.Width, original.Height),
                    0, 0, original.Width, original.Height,
                    GraphicsUnit.Pixel, atributos);
            }

            return pintada;
        }
    }
}
