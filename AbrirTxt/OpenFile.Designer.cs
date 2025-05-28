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
            toolStripSeparator1 = new ToolStripSeparator();
            gifsToolStripMenuItem = new ToolStripMenuItem();
            datosBMPToolStripMenuItem = new ToolStripMenuItem();
            label = new Label();
            txtNombreArchivo = new TextBox();
            label1 = new Label();
            txtNombreArchivoBackup = new TextBox();
            label2 = new Label();
            btnChoose = new Button();
            groupBox1 = new GroupBox();
            txtArchivoGif = new TextBox();
            label6 = new Label();
            txtAltoGif = new TextBox();
            label5 = new Label();
            txtAnchoGif = new TextBox();
            label4 = new Label();
            txtVersionGif = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            txtArchivoBPM = new TextBox();
            label7 = new Label();
            txtAltoBPM = new TextBox();
            label8 = new Label();
            txtAnchoBMP = new TextBox();
            label9 = new Label();
            txtSizeBPM = new TextBox();
            label10 = new Label();
            drawBMPToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            btnArchivo.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, backupToolStripMenuItem, backUpNoComentToolStripMenuItem, morososToolStripMenuItem, jsonUsuariosToolStripMenuItem, toolStripSeparator1, gifsToolStripMenuItem, datosBMPToolStripMenuItem, drawBMPToolStripMenuItem });
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
            // datosBMPToolStripMenuItem
            // 
            datosBMPToolStripMenuItem.Name = "datosBMPToolStripMenuItem";
            datosBMPToolStripMenuItem.Size = new Size(231, 26);
            datosBMPToolStripMenuItem.Text = "Datos BMP";
            datosBMPToolStripMenuItem.Click += datosBMPToolStripMenuItem_Click;
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
            groupBox1.Size = new Size(491, 458);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Gif's";
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
            // txtVersionGif
            // 
            txtVersionGif.Location = new Point(190, 180);
            txtVersionGif.Name = "txtVersionGif";
            txtVersionGif.ReadOnly = true;
            txtVersionGif.Size = new Size(188, 27);
            txtVersionGif.TabIndex = 1;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(txtArchivoBPM);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtAltoBPM);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtAnchoBMP);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtSizeBPM);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(1069, 525);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(491, 279);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos BMP";
            // 
            // txtArchivoBPM
            // 
            txtArchivoBPM.Location = new Point(73, 71);
            txtArchivoBPM.Name = "txtArchivoBPM";
            txtArchivoBPM.ReadOnly = true;
            txtArchivoBPM.Size = new Size(397, 27);
            txtArchivoBPM.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 71);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 6;
            label7.Text = "Archivo:";
            // 
            // txtAltoBPM
            // 
            txtAltoBPM.Location = new Point(124, 180);
            txtAltoBPM.Name = "txtAltoBPM";
            txtAltoBPM.ReadOnly = true;
            txtAltoBPM.Size = new Size(188, 27);
            txtAltoBPM.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(73, 183);
            label8.Name = "label8";
            label8.Size = new Size(40, 20);
            label8.TabIndex = 4;
            label8.Text = "Alto:";
            // 
            // txtAnchoBMP
            // 
            txtAnchoBMP.Location = new Point(124, 234);
            txtAnchoBMP.Name = "txtAnchoBMP";
            txtAnchoBMP.ReadOnly = true;
            txtAnchoBMP.Size = new Size(188, 27);
            txtAnchoBMP.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(59, 237);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 2;
            label9.Text = "Ancho:";
            // 
            // txtSizeBPM
            // 
            txtSizeBPM.Location = new Point(124, 127);
            txtSizeBPM.Name = "txtSizeBPM";
            txtSizeBPM.ReadOnly = true;
            txtSizeBPM.Size = new Size(254, 27);
            txtSizeBPM.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 130);
            label10.Name = "label10";
            label10.Size = new Size(113, 20);
            label10.TabIndex = 0;
            label10.Text = "Tamaño (Bytes):";
            // 
            // drawBMPToolStripMenuItem
            // 
            drawBMPToolStripMenuItem.Name = "drawBMPToolStripMenuItem";
            drawBMPToolStripMenuItem.Size = new Size(231, 26);
            drawBMPToolStripMenuItem.Text = "Draw BMP";
            drawBMPToolStripMenuItem.Click += drawBMPToolStripMenuItem_Click;
            // 
            // OpenFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1564, 811);
            Controls.Add(groupBox2);
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private ToolStripMenuItem datosBMPToolStripMenuItem;
        private GroupBox groupBox2;
        private TextBox txtArchivoBPM;
        private Label label7;
        private TextBox txtAltoBPM;
        private Label label8;
        private TextBox txtAnchoBMP;
        private Label label9;
        private TextBox txtSizeBPM;
        private Label label10;
        private ToolStripMenuItem drawBMPToolStripMenuItem;
    }
}
