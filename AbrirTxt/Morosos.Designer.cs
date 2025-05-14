namespace LectorTxt
{
    partial class Morosos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label1 = new Label();
            txtArchivo = new TextBox();
            dataGridView1 = new DataGridView();
            ColumnNombre = new DataGridViewTextBoxColumn();
            ColumnLocalidad = new DataGridViewTextBoxColumn();
            ColumnDeuda = new DataGridViewTextBoxColumn();
            ColumnIntereses = new DataGridViewTextBoxColumn();
            ColumnActualizacion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Archivo Moroso";
            // 
            // txtArchivo
            // 
            txtArchivo.Location = new Point(141, 27);
            txtArchivo.Name = "txtArchivo";
            txtArchivo.ReadOnly = true;
            txtArchivo.Size = new Size(647, 27);
            txtArchivo.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnNombre, ColumnLocalidad, ColumnDeuda, ColumnIntereses, ColumnActualizacion });
            dataGridView1.Location = new Point(21, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(767, 296);
            dataGridView1.TabIndex = 2;
            // 
            // ColumnNombre
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnNombre.DefaultCellStyle = dataGridViewCellStyle1;
            ColumnNombre.HeaderText = "Nombre";
            ColumnNombre.MinimumWidth = 6;
            ColumnNombre.Name = "ColumnNombre";
            ColumnNombre.ReadOnly = true;
            ColumnNombre.Width = 125;
            // 
            // ColumnLocalidad
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnLocalidad.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnLocalidad.HeaderText = "Localidad";
            ColumnLocalidad.MinimumWidth = 6;
            ColumnLocalidad.Name = "ColumnLocalidad";
            ColumnLocalidad.ReadOnly = true;
            ColumnLocalidad.Width = 125;
            // 
            // ColumnDeuda
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            ColumnDeuda.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnDeuda.HeaderText = "Deuda";
            ColumnDeuda.MinimumWidth = 6;
            ColumnDeuda.Name = "ColumnDeuda";
            ColumnDeuda.ReadOnly = true;
            ColumnDeuda.Width = 125;
            // 
            // ColumnIntereses
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            ColumnIntereses.DefaultCellStyle = dataGridViewCellStyle4;
            ColumnIntereses.HeaderText = "Interes";
            ColumnIntereses.MinimumWidth = 6;
            ColumnIntereses.Name = "ColumnIntereses";
            ColumnIntereses.ReadOnly = true;
            ColumnIntereses.Width = 125;
            // 
            // ColumnActualizacion
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            ColumnActualizacion.DefaultCellStyle = dataGridViewCellStyle5;
            ColumnActualizacion.HeaderText = "Actualizacion";
            ColumnActualizacion.MinimumWidth = 6;
            ColumnActualizacion.Name = "ColumnActualizacion";
            ColumnActualizacion.ReadOnly = true;
            ColumnActualizacion.Width = 125;
            // 
            // Morosos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 381);
            Controls.Add(dataGridView1);
            Controls.Add(txtArchivo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Morosos";
            Text = "Morosos";
            Load += Morosos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtArchivo;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnLocalidad;
        private DataGridViewTextBoxColumn ColumnDeuda;
        private DataGridViewTextBoxColumn ColumnIntereses;
        private DataGridViewTextBoxColumn ColumnActualizacion;
    }
}