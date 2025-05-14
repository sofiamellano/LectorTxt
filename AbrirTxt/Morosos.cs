using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LectorTxt
{
    public partial class Morosos : Form
    {
        public string Archivo { get; set; } = string.Empty;
        public Morosos()
        {
            InitializeComponent();
        }

        private void Morosos_Load(object sender, EventArgs e)
        {
            txtArchivo.Text = Archivo;
            StreamReader sr = new StreamReader(txtArchivo.Text);
            string? linea;
            //string[] campos = new string[3];
            decimal actualizacion = 0; 

            linea = sr.ReadLine(); // Leer la primera línea (encabezados)

            while ((linea = sr.ReadLine()) != null)
            {
                string[] campos = linea.Split(";");
                actualizacion = Convert.ToDecimal(campos[2] + campos[3]);
                this.dataGridView1.Rows.Add(new object[] { campos[0], campos[1], campos[2], campos[3], actualizacion });
            }
            sr.Close();
        }

    }
}
