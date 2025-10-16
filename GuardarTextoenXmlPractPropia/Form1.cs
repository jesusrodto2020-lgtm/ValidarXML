
using System.Xml.Linq; // Para manejar XML fácilmente
namespace GuardarTextoenXmlPractPropia
{
    public partial class Form1 : Form
    {

        string rutaArchivo = @"C:\Users\jadri\OneDrive\Desktop\S3ED 24100666\Parcial2\GuardarTextoenXmlPractPropia\ArchivoGuardarTexto.xml"; // Nombre del archivo XML

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardarTexto_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear o sobrescribir el archivo XML con el texto del TextBox
                XDocument xml = new XDocument(
                    new XElement("Archivo",
                        new XElement("Contenido", txtTextoEscrito.Text)
                    )
                );

                xml.Save(rutaArchivo);
                MessageBox.Show("Texto guardado correctamente en el archivo XML.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnMostrarTextoGuardado_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(rutaArchivo))
                {
                    XDocument xml = XDocument.Load(rutaArchivo);
                    XElement contenido = xml.Element("Archivo")?.Element("Contenido");

                    if (contenido != null)
                        lblTextoGuardado.Text = contenido.Value;
                    else
                        MessageBox.Show("El archivo XML no contiene texto.");
                }
                else
                {
                    MessageBox.Show("El archivo no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer: " + ex.Message);
            }

        }
    }
}
