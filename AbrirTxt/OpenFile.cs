using LectorTxt;
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
    }
}

