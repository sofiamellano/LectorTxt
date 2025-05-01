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
            btnAbrir = new Button();
            txtContenido = new TextBox();
            SuspendLayout();
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(664, 12);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(124, 29);
            btnAbrir.TabIndex = 0;
            btnAbrir.Text = "CHOOSE FILE";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(12, 47);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(776, 391);
            txtContenido.TabIndex = 1;
            // 
            // OpenFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContenido);
            Controls.Add(btnAbrir);
            Name = "OpenFile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OpenFile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbrir;
        private TextBox txtContenido;
    }
}
