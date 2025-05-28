using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LectorTxt
{
    public partial class DrawBMP : Form
    {
        public string FileBMP  { get; set; }
        public DrawBMP()
        {
            InitializeComponent();
        }


        private void DrawBMP_Load(object sender, EventArgs e)
        {
            this.Text += " | " + this.FileBMP;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int ancho = 0;


            byte[] contenido = File.ReadAllBytes(FileBMP);
            // calcular ancho
            ancho = contenido[19];
            ancho = ancho << 8;
            ancho = ancho | contenido[18];
            int pos = ancho - 1;

            char[] linea = new char[ancho];

            for (int i = contenido.Length -1; i > 54; i-=3)
            {
                if (contenido[i] == 0)
                {
                    linea[pos] = txtCarNegro.Text[0];
                }
                else
                {
                    linea[pos] = ' ';
                }
                pos--;
                if (pos < 0)
                {
                    pos = ancho - 1;
                    this.txtBMP.Text += new string(linea) + Environment.NewLine;
                }
            }
        }
    }
}

