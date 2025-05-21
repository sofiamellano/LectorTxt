namespace LectorTxt
{
    partial class JSONUser
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
            dataGridJSON = new DataGridView();
            Column = new DataGridViewTextBoxColumn();
            ColumnLocalidad = new DataGridViewTextBoxColumn();
            ColumnDeuda = new DataGridViewTextBoxColumn();
            ColumnIntereses = new DataGridViewTextBoxColumn();
            ColumnActualizacion = new DataGridViewTextBoxColumn();
            Ciudad = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            txtJSON = new TextBox();
            label1 = new Label();
            btnExportar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridJSON).BeginInit();
            SuspendLayout();
            // 
            // dataGridJSON
            // 
            dataGridJSON.AllowUserToAddRows = false;
            dataGridJSON.AllowUserToDeleteRows = false;
            dataGridJSON.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridJSON.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridJSON.Columns.AddRange(new DataGridViewColumn[] { Column, ColumnLocalidad, ColumnDeuda, ColumnIntereses, ColumnActualizacion, Ciudad, Column1 });
            dataGridJSON.Location = new Point(17, 95);
            dataGridJSON.Name = "dataGridJSON";
            dataGridJSON.ReadOnly = true;
            dataGridJSON.RowHeadersWidth = 51;
            dataGridJSON.Size = new Size(934, 425);
            dataGridJSON.TabIndex = 5;
            // 
            // Column
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column.DefaultCellStyle = dataGridViewCellStyle1;
            Column.HeaderText = "ID";
            Column.MinimumWidth = 6;
            Column.Name = "Column";
            Column.ReadOnly = true;
            Column.Width = 70;
            // 
            // ColumnLocalidad
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnLocalidad.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnLocalidad.HeaderText = "Nombre";
            ColumnLocalidad.MinimumWidth = 6;
            ColumnLocalidad.Name = "ColumnLocalidad";
            ColumnLocalidad.ReadOnly = true;
            ColumnLocalidad.Width = 150;
            // 
            // ColumnDeuda
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            ColumnDeuda.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnDeuda.HeaderText = "Email";
            ColumnDeuda.MinimumWidth = 6;
            ColumnDeuda.Name = "ColumnDeuda";
            ColumnDeuda.ReadOnly = true;
            ColumnDeuda.Width = 120;
            // 
            // ColumnIntereses
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            ColumnIntereses.DefaultCellStyle = dataGridViewCellStyle4;
            ColumnIntereses.HeaderText = "Telefono";
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
            ColumnActualizacion.HeaderText = "Calle";
            ColumnActualizacion.MinimumWidth = 6;
            ColumnActualizacion.Name = "ColumnActualizacion";
            ColumnActualizacion.ReadOnly = true;
            ColumnActualizacion.Width = 125;
            // 
            // Ciudad
            // 
            Ciudad.HeaderText = "Ciudad";
            Ciudad.MinimumWidth = 6;
            Ciudad.Name = "Ciudad";
            Ciudad.ReadOnly = true;
            Ciudad.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Empresa";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // txtJSON
            // 
            txtJSON.Location = new Point(137, 29);
            txtJSON.Name = "txtJSON";
            txtJSON.ReadOnly = true;
            txtJSON.Size = new Size(647, 27);
            txtJSON.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 29);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 3;
            label1.Text = "Archivo JSON";
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(830, 537);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(113, 38);
            btnExportar.TabIndex = 6;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // JSONUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 587);
            Controls.Add(btnExportar);
            Controls.Add(dataGridJSON);
            Controls.Add(txtJSON);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "JSONUser";
            Text = "JSONUser";
            Load += JSONUser_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridJSON).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridJSON;
        private DataGridViewTextBoxColumn Column;
        private DataGridViewTextBoxColumn ColumnLocalidad;
        private DataGridViewTextBoxColumn ColumnDeuda;
        private DataGridViewTextBoxColumn ColumnIntereses;
        private DataGridViewTextBoxColumn ColumnActualizacion;
        private DataGridViewTextBoxColumn Ciudad;
        private DataGridViewTextBoxColumn Column1;
        private TextBox txtJSON;
        private Label label1;
        private Button btnExportar;
    }
}