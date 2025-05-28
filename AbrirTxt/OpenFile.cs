using LectorTxt;
using Microsoft.VisualBasic.Logging;
using System;
using System.IO;
using System.Web;
using System.Windows.Forms;

namespace AbrirTxt
{
    public partial class OpenFile : Form
    {
        public OpenFile()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                this.txtNombreArchivo.Text = rutaArchivo;
                string contenido = File.ReadAllText(rutaArchivo);
                txtContenido.Text = contenido;
            }
            else
            {
                txtNombreArchivo.Text = "";
                txtContenido.Text = "";
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                this.txtNombreArchivo.Text = rutaArchivo;
                string contenido = File.ReadAllText(rutaArchivo);
                txtContenido.Text = contenido;
            }
            else
            {
                txtNombreArchivo.Text = "";
                txtContenido.Text = "";
            }
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreArchBackup;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(openFileDialog.FileName))
                {
                    MessageBox.Show("El archivo no existe!", "Redes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string rutaArchivo = openFileDialog.FileName;
                this.txtNombreArchivo.Text = rutaArchivo;
                nombreArchBackup = rutaArchivo;
                nombreArchBackup = nombreArchBackup.Substring(0, nombreArchBackup.Length - 3);
                nombreArchBackup += "bak";
                txtNombreArchivoBackup.Text = nombreArchBackup;
                //
                copiarArchivo();
            }
            else
            {
                this.txtNombreArchivo.Clear();
            }
        }

        private void copiarArchivo(bool copyNoComent = false)
        {
            StreamReader lector = new StreamReader(txtNombreArchivo.Text);
            StreamWriter escritor = new StreamWriter(txtNombreArchivoBackup.Text);
            string? linea;
            string? lineaAux;
            char caracter;
            while ((linea = lector.ReadLine()) != null)
            {
                lineaAux = linea.Trim();
                caracter = 'X';
                if (lineaAux.Length != 0)
                {
                    caracter = lineaAux[0];
                }
                if (caracter != '#' || copyNoComent == false)
                {
                    escritor.WriteLine(linea);
                }

            }
            lector.Close();
            escritor.Close();
        }

        private void backUpNoComentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreArchBackup;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(openFileDialog.FileName))
                {
                    MessageBox.Show("El archivo no existe!", "Redes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string rutaArchivo = openFileDialog.FileName;
                this.txtNombreArchivo.Text = rutaArchivo;
                nombreArchBackup = rutaArchivo;
                nombreArchBackup = nombreArchBackup.Substring(0, nombreArchBackup.Length - 3);
                nombreArchBackup += "bak";
                txtNombreArchivoBackup.Text = nombreArchBackup;
                //
                copiarArchivo(true);
            }
            else
            {
                this.txtNombreArchivo.Clear();
            }
        }

        private void morososToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.csv)|*.csv|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(openFileDialog.FileName))
                {
                    MessageBox.Show("El archivo no existe!", "Redes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string rutaArchivo = openFileDialog.FileName;
                Morosos morosos = new Morosos();
                morosos.Archivo = rutaArchivo;
                morosos.ShowDialog();
            }
            else
            {
                this.txtNombreArchivo.Clear();
            }
        }

        private void jsonUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.json)|*.json";
            //| Todos los archivos(*.*)| *.*

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(openFileDialog.FileName))
                {
                    MessageBox.Show("El archivo no existe!", "Redes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string rutaArchivo = openFileDialog.FileName;
                JSONUser jsonUser = new JSONUser();
                jsonUser.JSONFile = rutaArchivo;
                jsonUser.ShowDialog();
            }
        }

        private void gifsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string version;
            int alto = 0;
            int ancho = 0;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.gif)|*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                this.txtArchivoGif.Text = rutaArchivo;
                byte[] contenido = File.ReadAllBytes(rutaArchivo);

                version = "" + Convert.ToChar(contenido[0]) + Convert.ToChar(contenido[1]) + Convert.ToChar(contenido[2]) + Convert.ToChar(contenido[3]) + Convert.ToChar(contenido[4]) + Convert.ToChar(contenido[5]);
                txtVersionGif.Text = version;

                ancho = contenido[7];
                ancho = ancho << 8;
                ancho = ancho | contenido[6];

                alto = contenido[9];
                alto = alto << 8;
                alto = alto | contenido[8];

                txtAltoGif.Text = alto.ToString();
                txtAnchoGif.Text = ancho.ToString();
            }
            else
            {
                this.txtArchivoGif.Text = "";
                this.txtVersionGif.Text = "";
                this.txtAltoGif.Text = "";
                this.txtAnchoGif.Text = "";
            }
        }

        private void datosBMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string version;
            int alto = 0;
            int ancho = 0;
            int size = 0;


            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.bmp)|*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                this.txtArchivoBPM.Text = rutaArchivo;
                byte[] contenido = File.ReadAllBytes(rutaArchivo);


                // calcular tamaño
                size = contenido[5];
                size = size << 8;
                size = size | contenido[4];
                size = size << 8;
                size = size | contenido[3];
                size = size << 8;
                size = size | contenido[2];

                // calcular ancho
                ancho = contenido[19];
                ancho = ancho << 8;
                ancho = ancho | contenido[18];

                // calcular alto
                alto = contenido[23];
                alto = alto << 8;
                alto = alto | contenido[22];


                txtAltoBPM.Text = alto.ToString();
                txtAnchoBMP.Text = ancho.ToString();
                txtSizeBPM.Text = size.ToString();
            }
            else
            {
                this.txtArchivoBPM.Text = "";
                this.txtSizeBPM.Text = "";
                this.txtAltoBPM.Text = "";
                this.txtAnchoBMP.Text = "";
            }
        }

        private void drawBMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.bmp)|*.bmp";
            //| Todos los archivos(*.*)| *.*

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(openFileDialog.FileName))
                {
                    MessageBox.Show("El archivo no existe!", "Redes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string rutaArchivo = openFileDialog.FileName;
                DrawBMP drawBMP = new DrawBMP();
                drawBMP.FileBMP= rutaArchivo;
                drawBMP.ShowDialog();
            }
        }
    }
}

