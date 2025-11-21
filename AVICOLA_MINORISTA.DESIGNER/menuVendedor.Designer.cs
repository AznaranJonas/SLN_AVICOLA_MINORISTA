namespace AVICOLA_MINORISTA.DESIGNER
{
    partial class menuVendedor
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
            label2 = new Label();
            btnSalir = new Button();
            btnIngresar = new Button();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(954, 21);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 23;
            label2.Text = "____";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkOliveGreen;
            btnSalir.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Gold;
            btnSalir.Location = new Point(569, 670);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(173, 61);
            btnSalir.TabIndex = 22;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.DarkOliveGreen;
            btnIngresar.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.Gold;
            btnIngresar.Location = new Point(294, 670);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(185, 61);
            btnIngresar.TabIndex = 21;
            btnIngresar.Text = "ENTRAR";
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowFrame;
            label3.Font = new Font("Unispace", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(256, 46);
            label3.Name = "label3";
            label3.Size = new Size(563, 53);
            label3.TabIndex = 20;
            label3.Text = "MENÚ - ADMINISTRADOR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(850, 21);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 19;
            label1.Text = "USUARIO :";
            // 
            // menuVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1034, 787);
            Controls.Add(label2);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "menuVendedor";
            Text = "menuVendedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnSalir;
        private Button btnIngresar;
        private Label label3;
        private Label label1;
    }
}