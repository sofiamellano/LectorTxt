namespace AbrirTxt
{
    partial class OpenFile
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtContenido = new TextBox();
            menuStrip1 = new MenuStrip();
            btnArchivo = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            backupToolStripMenuItem = new ToolStripMenuItem();
            backUpNoComentToolStripMenuItem = new ToolStripMenuItem();
            morososToolStripMenuItem = new ToolStripMenuItem();
            jsonUsuariosToolStripMenuItem = new ToolStripMenuItem();
            label = new Label();
            txtNombreArchivo = new TextBox();
            label1 = new Label();
            txtNombreArchivoBackup = new TextBox();
            label2 = new Label();
            btnChoose = new Button();
            toolStripSeparator1 = new ToolStripSeparator();
            gifsToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtVersionGif = new TextBox();
            txtAnchoGif = new TextBox();
            label4 = new Label();
            txtAltoGif = new TextBox();
            label5 = new Label();
            txtArchivoGif = new TextBox();
            label6 = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(3, 100);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.ReadOnly = true;
            txtContenido.ScrollBars = ScrollBars.Both;
            txtContenido.Size = new Size(1022, 378);
            txtContenido.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { btnArchivo });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(81, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnArchivo
            // 
            btnArchivo.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, backupToolStripMenuItem, backUpNoComentToolStripMenuItem, morososToolStripMenuItem, jsonUsuariosToolStripMenuItem, toolStripSeparator1, gifsToolStripMenuItem });
            btnArchivo.Name = "btnArchivo";
            btnArchivo.Size = new Size(73, 24);
            btnArchivo.Text = "Archivo";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(231, 26);
            openFileToolStripMenuItem.Text = "Open File...";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // backupToolStripMenuItem
            // 
            backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            backupToolStripMenuItem.Size = new Size(231, 26);
            backupToolStripMenuItem.Text = "BackUp";
            backupToolStripMenuItem.Click += backupToolStripMenuItem_Click;
            // 
            // backUpNoComentToolStripMenuItem
            // 
            backUpNoComentToolStripMenuItem.Name = "backUpNoComentToolStripMenuItem";
            backUpNoComentToolStripMenuItem.Size = new Size(231, 26);
            backUpNoComentToolStripMenuItem.Text = "BackUp No Coment...";
            backUpNoComentToolStripMenuItem.Click += backUpNoComentToolStripMenuItem_Click;
            // 
            // morososToolStripMenuItem
            // 
            morososToolStripMenuItem.Name = "morososToolStripMenuItem";
            morososToolStripMenuItem.Size = new Size(231, 26);
            morososToolStripMenuItem.Text = "Morosos";
            morososToolStripMenuItem.Click += morososToolStripMenuItem_Click;
            // 
            // jsonUsuariosToolStripMenuItem
            // 
            jsonUsuariosToolStripMenuItem.Name = "jsonUsuariosToolStripMenuItem";
            jsonUsuariosToolStripMenuItem.Size = new Size(231, 26);
            jsonUsuariosToolStripMenuItem.Text = "Json Usuarios";
            jsonUsuariosToolStripMenuItem.Click += jsonUsuariosToolStripMenuItem_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(12, 38);
            label.Name = "label";
            label.Size = new Size(65, 20);
            label.TabIndex = 3;
            label.Text = "Archivos";
            // 
            // txtNombreArchivo
            // 
            txtNombreArchivo.Location = new Point(12, 61);
            txtNombreArchivo.Name = "txtNombreArchivo";
            txtNombreArchivo.Size = new Size(893, 27);
            txtNombreArchivo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 105);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 5;
            label1.Text = "Contenido";
            // 
            // txtNombreArchivoBackup
            // 
            txtNombreArchivoBackup.Location = new Point(12, 534);
            txtNombreArchivoBackup.Name = "txtNombreArchivoBackup";
            txtNombreArchivoBackup.Size = new Size(1024, 27);
            txtNombreArchivoBackup.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 499);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 6;
            label2.Text = "Archivos de Respaldo";
            // 
            // btnChoose
            // 
            btnChoose.Location = new Point(911, 60);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(118, 29);
            btnChoose.TabIndex = 8;
            btnChoose.Text = "CHOOSE FILE";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += btnChoose_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(228, 6);
            // 
            // gifsToolStripMenuItem
            // 
            gifsToolStripMenuItem.Name = "gifsToolStripMenuItem";
            gifsToolStripMenuItem.Size = new Size(231, 26);
            gifsToolStripMenuItem.Text = "Gif's";
            gifsToolStripMenuItem.Click += gifsToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtArchivoGif);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtAltoGif);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtAnchoGif);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtVersionGif);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(1069, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(491, 500);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Gif's";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 180);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 0;
            label3.Text = "Version:";
            // 
            // txtVersionGif
            // 
            txtVersionGif.Location = new Point(190, 180);
            txtVersionGif.Name = "txtVersionGif";
            txtVersionGif.ReadOnly = true;
            txtVersionGif.Size = new Size(188, 27);
            txtVersionGif.TabIndex = 1;
            // 
            // txtAnchoGif
            // 
            txtAnchoGif.Location = new Point(190, 411);
            txtAnchoGif.Name = "txtAnchoGif";
            txtAnchoGif.ReadOnly = true;
            txtAnchoGif.Size = new Size(188, 27);
            txtAnchoGif.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 414);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 2;
            label4.Text = "Ancho:";
            // 
            // txtAltoGif
            // 
            txtAltoGif.Location = new Point(190, 296);
            txtAltoGif.Name = "txtAltoGif";
            txtAltoGif.ReadOnly = true;
            txtAltoGif.Size = new Size(188, 27);
            txtAltoGif.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(124, 296);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 4;
            label5.Text = "Alto:";
            // 
            // txtArchivoGif
            // 
            txtArchivoGif.Location = new Point(73, 71);
            txtArchivoGif.Name = "txtArchivoGif";
            txtArchivoGif.ReadOnly = true;
            txtArchivoGif.Size = new Size(397, 27);
            txtArchivoGif.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 71);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 6;
            label6.Text = "Archivo:";
            // 
            // OpenFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1564, 599);
            Controls.Add(groupBox1);
            Controls.Add(btnChoose);
            Controls.Add(txtNombreArchivoBackup);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombreArchivo);
            Controls.Add(label);
            Controls.Add(txtContenido);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "OpenFile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OpenFile";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtContenido;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem btnArchivo;
        private Label label;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private TextBox txtNombreArchivo;
        private Label label1;
        private TextBox txtNombreArchivoBackup;
        private Label label2;
        private Button btnChoose;
        private ToolStripMenuItem backupToolStripMenuItem;
        private ToolStripMenuItem backUpNoComentToolStripMenuItem;
        private ToolStripMenuItem morososToolStripMenuItem;
        private ToolStripMenuItem jsonUsuariosToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem gifsToolStripMenuItem;
        private GroupBox groupBox1;
        private TextBox txtArchivoGif;
        private Label label6;
        private TextBox txtAltoGif;
        private Label label5;
        private TextBox txtAnchoGif;
        private Label label4;
        private TextBox txtVersionGif;
        private Label label3;
    }
}
