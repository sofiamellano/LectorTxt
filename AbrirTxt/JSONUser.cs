using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Microsoft.VisualBasic.ApplicationServices;

namespace LectorTxt
{
    public partial class JSONUser : Form
    {
        public string JSONFile { get; set; } = string.Empty;
        private List<User>? users;
        private class User
        {
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            public Adrees address { get; set; }
            public Company company { get; set; }

        }
        private class Adrees
        {
            public string street { get; set; }
            public string city { get; set; }
        }
        private class Company
        {
            public string name { get; set; }
        }

        public JSONUser()
        {
            InitializeComponent();
        }

        private void JSONUser_Load(object sender, EventArgs e)
        {
            string jsoncontent = File.ReadAllText(JSONFile);
            users = JsonSerializer.Deserialize<List<User>>(jsoncontent);
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            this.dataGridJSON.Rows.Clear();
            foreach (User user in users)
            {
                this.dataGridJSON.Rows.Add(new object[] { user.id, user.name, user.email, user.phone, user.address.street, user.address.city, user.company.name });
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string ArchSave;
            string ContenidoCsv = string.Empty;
            string linea;

            try {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos de texto (*.csv)|*.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    linea = "ID;NOMBRE;EMAIL;TELEFONO;CALLE;CIUDAD;EMPRESA";
                    ContenidoCsv += linea + Environment.NewLine;
                    ArchSave = saveFileDialog.FileName;
                    foreach (User user in users)
                    {
                        linea = $"{user.id};{user.name};{user.email};{user.phone};{user.address.street};{user.address.city};{user.company.name}";
                        ContenidoCsv += linea + Environment.NewLine;
                    }
                    //"\r\n"
                    File.WriteAllText(ArchSave, ContenidoCsv);
                    MessageBox.Show("Archivo exportado correctamente", "Exportar CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex){
                MessageBox.Show("Error al exportar el archivo", "Exportar CSV", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
