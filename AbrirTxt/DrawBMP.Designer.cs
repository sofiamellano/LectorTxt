namespace LectorTxt
{
    partial class DrawBMP
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
            txtCarNegro = new TextBox();
            label1 = new Label();
            btnDraw = new Button();
            txtBMP = new TextBox();
            SuspendLayout();
            // 
            // txtCarNegro
            // 
            txtCarNegro.Location = new Point(125, 21);
            txtCarNegro.MaxLength = 1;
            txtCarNegro.Name = "txtCarNegro";
            txtCarNegro.Size = new Size(112, 27);
            txtCarNegro.TabIndex = 0;
            txtCarNegro.Text = "X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 1;
            label1.Text = "Caracter negro";
            // 
            // btnDraw
            // 
            btnDraw.Location = new Point(257, 24);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(94, 29);
            btnDraw.TabIndex = 2;
            btnDraw.Text = "Draw";
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnDraw_Click;
            // 
            // txtBMP
            // 
            txtBMP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBMP.BackColor = Color.White;
            txtBMP.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBMP.Location = new Point(3, 76);
            txtBMP.MaxLength = 1;
            txtBMP.Multiline = true;
            txtBMP.Name = "txtBMP";
            txtBMP.ReadOnly = true;
            txtBMP.ScrollBars = ScrollBars.Both;
            txtBMP.Size = new Size(1261, 748);
            txtBMP.TabIndex = 3;
            // 
            // DrawBMP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 836);
            Controls.Add(txtBMP);
            Controls.Add(btnDraw);
            Controls.Add(label1);
            Controls.Add(txtCarNegro);
            Name = "DrawBMP";
            Text = "BMP";
            Load += DrawBMP_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCarNegro;
        private Label label1;
        private Button btnDraw;
        private TextBox txtBMP;
    }
}