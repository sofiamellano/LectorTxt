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
            label = new Label();
            txtNombreArchivo = new TextBox();
            label1 = new Label();
            txtNombreArchivoBackup = new TextBox();
            label2 = new Label();
            btnChoose = new Button();
            morososToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtContenido
            // 
            txtContenido.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtContenido.Location = new Point(3, 128);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.ReadOnly = true;
            txtContenido.ScrollBars = ScrollBars.Both;
            txtContenido.Size = new Size(1033, 204);
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
            btnArchivo.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, backupToolStripMenuItem, backUpNoComentToolStripMenuItem, morososToolStripMenuItem });
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
            txtNombreArchivoBackup.Location = new Point(12, 394);
            txtNombreArchivoBackup.Name = "txtNombreArchivoBackup";
            txtNombreArchivoBackup.Size = new Size(1024, 27);
            txtNombreArchivoBackup.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 371);
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
            // morososToolStripMenuItem
            // 
            morososToolStripMenuItem.Name = "morososToolStripMenuItem";
            morososToolStripMenuItem.Size = new Size(231, 26);
            morososToolStripMenuItem.Text = "Morosos";
            morososToolStripMenuItem.Click += morososToolStripMenuItem_Click;
            // 
            // OpenFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 433);
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
    }
}
