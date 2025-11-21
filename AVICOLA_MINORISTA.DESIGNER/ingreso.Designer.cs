namespace AVICOLA_MINORISTA.DESIGNER
{
    partial class ingreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ingreso));
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            pictureBox1 = new PictureBox();
            imgCandado = new PictureBox();
            btnSalir = new Button();
            btnIngresar = new Button();
            pictureBox2 = new PictureBox();
            lblMuestraClave = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCandado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(235, 465);
            label1.Name = "label1";
            label1.Size = new Size(177, 36);
            label1.TabIndex = 0;
            label1.Text = "USUARIO :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(181, 506);
            label2.Name = "label2";
            label2.Size = new Size(231, 36);
            label2.TabIndex = 1;
            label2.Text = "CONTRASEÑA :";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.InactiveCaption;
            txtUsuario.ForeColor = SystemColors.WindowText;
            txtUsuario.Location = new Point(461, 472);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(213, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = SystemColors.InactiveCaption;
            txtContraseña.Location = new Point(461, 513);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(213, 23);
            txtContraseña.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(328, 200);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // imgCandado
            // 
            imgCandado.Image = (Image)resources.GetObject("imgCandado.Image");
            imgCandado.Location = new Point(798, 16);
            imgCandado.Margin = new Padding(3, 2, 3, 2);
            imgCandado.Name = "imgCandado";
            imgCandado.Size = new Size(47, 50);
            imgCandado.SizeMode = PictureBoxSizeMode.StretchImage;
            imgCandado.TabIndex = 6;
            imgCandado.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkOliveGreen;
            btnSalir.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Gold;
            btnSalir.Location = new Point(505, 612);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(169, 46);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.DarkOliveGreen;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.Gold;
            btnIngresar.Location = new Point(235, 612);
            btnIngresar.Margin = new Padding(3, 2, 3, 2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(172, 46);
            btnIngresar.TabIndex = 10;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(181, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(535, 148);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // lblMuestraClave
            // 
            lblMuestraClave.AutoSize = true;
            lblMuestraClave.Font = new Font("Unispace", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMuestraClave.ForeColor = Color.LightGreen;
            lblMuestraClave.Location = new Point(680, 519);
            lblMuestraClave.Name = "lblMuestraClave";
            lblMuestraClave.Size = new Size(31, 15);
            lblMuestraClave.TabIndex = 12;
            lblMuestraClave.Text = "VER";
            lblMuestraClave.Click += lblMuestraClave_Click;
            // 
            // ingreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(871, 707);
            Controls.Add(lblMuestraClave);
            Controls.Add(pictureBox2);
            Controls.Add(btnIngresar);
            Controls.Add(btnSalir);
            Controls.Add(imgCandado);
            Controls.Add(pictureBox1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ingreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INICIO DE SESIÓN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCandado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private PictureBox pictureBox1;
        private PictureBox imgCandado;
     
        private Button btnIngresar;
        private Button btnSalir;
        private PictureBox pictureBox2;
        private Label lblMuestraClave;
    }
}
