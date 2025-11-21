namespace AVICOLA_MINORISTA.DESIGNER
{
    partial class frmAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrador));
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            TabControlPrincipal = new TabControl();
            tabPage3 = new TabPage();
            dgvUsuarios = new DataGridView();
            imgUsuario = new PictureBox();
            btnBuscar = new Button();
            gruBDatosUsuario = new GroupBox();
            pictureBox6 = new PictureBox();
            txtClave = new TextBox();
            lblIdUsuario = new Label();
            rdbInactivo = new RadioButton();
            rdbActivo = new RadioButton();
            label10 = new Label();
            cmbRol = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtUsuario = new TextBox();
            txtApellidoMaterno = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtNombre = new TextBox();
            btnSalir = new Button();
            btnNuevoUsuario = new Button();
            btnCancelarUsuario = new Button();
            btnGuardarUsuario = new Button();
            btnEliminarUsuario = new Button();
            tabPage1 = new TabPage();
            pictureBox4 = new PictureBox();
            button2 = new Button();
            btnCancelarProducto = new Button();
            btnEliminarProducto = new Button();
            btnGuardarProducto = new Button();
            btnNuevoProducto = new Button();
            groupBox2 = new GroupBox();
            lblIdProducto = new Label();
            rdbProductoActivo = new RadioButton();
            rdbProductoInactivo = new RadioButton();
            label14 = new Label();
            nudPrecio = new NumericUpDown();
            lblprecio = new Label();
            cmbUnidadMedida = new ComboBox();
            label13 = new Label();
            cmbCategoria = new ComboBox();
            label12 = new Label();
            txtNombreProducto = new TextBox();
            label11 = new Label();
            dgvProductos = new DataGridView();
            tabPage2 = new TabPage();
            pictureBox5 = new PictureBox();
            dataGridView1 = new DataGridView();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            TabControlPrincipal.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgUsuario).BeginInit();
            gruBDatosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowFrame;
            label3.Font = new Font("Unispace", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(369, 7);
            label3.Name = "label3";
            label3.Size = new Size(438, 42);
            label3.TabIndex = 12;
            label3.Text = "MENÚ - ADMINISTRADOR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(762, 132);
            label1.Name = "label1";
            label1.Size = new Size(88, 16);
            label1.TabIndex = 10;
            label1.Text = "USUARIO :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(856, 128);
            label2.Name = "label2";
            label2.Size = new Size(43, 16);
            label2.TabIndex = 18;
            label2.Text = "____";
            // 
            // TabControlPrincipal
            // 
            TabControlPrincipal.AllowDrop = true;
            TabControlPrincipal.Controls.Add(tabPage3);
            TabControlPrincipal.Controls.Add(tabPage1);
            TabControlPrincipal.Controls.Add(tabPage2);
            TabControlPrincipal.Controls.Add(tabPage4);
            TabControlPrincipal.Controls.Add(tabPage5);
            TabControlPrincipal.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TabControlPrincipal.Location = new Point(10, 91);
            TabControlPrincipal.Margin = new Padding(3, 2, 3, 2);
            TabControlPrincipal.Name = "TabControlPrincipal";
            TabControlPrincipal.SelectedIndex = 0;
            TabControlPrincipal.Size = new Size(1133, 742);
            TabControlPrincipal.TabIndex = 19;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.WindowFrame;
            tabPage3.Controls.Add(dgvUsuarios);
            tabPage3.Controls.Add(imgUsuario);
            tabPage3.Controls.Add(btnBuscar);
            tabPage3.Controls.Add(gruBDatosUsuario);
            tabPage3.Controls.Add(btnSalir);
            tabPage3.Controls.Add(btnNuevoUsuario);
            tabPage3.Controls.Add(btnCancelarUsuario);
            tabPage3.Controls.Add(btnGuardarUsuario);
            tabPage3.Controls.Add(btnEliminarUsuario);
            tabPage3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(1125, 706);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Usuarios";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = SystemColors.WindowFrame;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(184, 2);
            dgvUsuarios.Margin = new Padding(3, 2, 3, 2);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(915, 311);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // imgUsuario
            // 
            imgUsuario.Image = (Image)resources.GetObject("imgUsuario.Image");
            imgUsuario.Location = new Point(4, 38);
            imgUsuario.Name = "imgUsuario";
            imgUsuario.Size = new Size(181, 231);
            imgUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            imgUsuario.TabIndex = 23;
            imgUsuario.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(358, 604);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(116, 33);
            btnBuscar.TabIndex = 26;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // gruBDatosUsuario
            // 
            gruBDatosUsuario.Controls.Add(pictureBox6);
            gruBDatosUsuario.Controls.Add(txtClave);
            gruBDatosUsuario.Controls.Add(lblIdUsuario);
            gruBDatosUsuario.Controls.Add(rdbInactivo);
            gruBDatosUsuario.Controls.Add(rdbActivo);
            gruBDatosUsuario.Controls.Add(label10);
            gruBDatosUsuario.Controls.Add(cmbRol);
            gruBDatosUsuario.Controls.Add(label9);
            gruBDatosUsuario.Controls.Add(label8);
            gruBDatosUsuario.Controls.Add(label7);
            gruBDatosUsuario.Controls.Add(label6);
            gruBDatosUsuario.Controls.Add(label5);
            gruBDatosUsuario.Controls.Add(label4);
            gruBDatosUsuario.Controls.Add(txtUsuario);
            gruBDatosUsuario.Controls.Add(txtApellidoMaterno);
            gruBDatosUsuario.Controls.Add(txtApellidoPaterno);
            gruBDatosUsuario.Controls.Add(txtNombre);
            gruBDatosUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gruBDatosUsuario.ForeColor = Color.Black;
            gruBDatosUsuario.Location = new Point(42, 327);
            gruBDatosUsuario.Margin = new Padding(3, 2, 3, 2);
            gruBDatosUsuario.Name = "gruBDatosUsuario";
            gruBDatosUsuario.Padding = new Padding(3, 2, 3, 2);
            gruBDatosUsuario.Size = new Size(1017, 249);
            gruBDatosUsuario.TabIndex = 1;
            gruBDatosUsuario.TabStop = false;
            gruBDatosUsuario.Text = "Datos del Usuario";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(508, 203);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 31);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 25;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(276, 203);
            txtClave.Margin = new Padding(3, 2, 3, 2);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(218, 32);
            txtClave.TabIndex = 24;
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIdUsuario.Location = new Point(900, 20);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(88, 19);
            lblIdUsuario.TabIndex = 16;
            lblIdUsuario.Text = "ID_USUARIO";
            lblIdUsuario.Visible = false;
            // 
            // rdbInactivo
            // 
            rdbInactivo.AutoSize = true;
            rdbInactivo.Font = new Font("Segoe UI", 10.2F);
            rdbInactivo.ForeColor = Color.Black;
            rdbInactivo.Location = new Point(671, 164);
            rdbInactivo.Margin = new Padding(3, 2, 3, 2);
            rdbInactivo.Name = "rdbInactivo";
            rdbInactivo.Size = new Size(90, 23);
            rdbInactivo.TabIndex = 15;
            rdbInactivo.TabStop = true;
            rdbInactivo.Text = "INACTIVO";
            rdbInactivo.UseVisualStyleBackColor = true;
            // 
            // rdbActivo
            // 
            rdbActivo.AutoSize = true;
            rdbActivo.Font = new Font("Segoe UI", 10.2F);
            rdbActivo.ForeColor = Color.Black;
            rdbActivo.Location = new Point(671, 139);
            rdbActivo.Margin = new Padding(3, 2, 3, 2);
            rdbActivo.Name = "rdbActivo";
            rdbActivo.Size = new Size(76, 23);
            rdbActivo.TabIndex = 14;
            rdbActivo.TabStop = true;
            rdbActivo.Text = "ACTIVO";
            rdbActivo.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(568, 142);
            label10.Name = "label10";
            label10.Size = new Size(79, 21);
            label10.TabIndex = 13;
            label10.Text = "ESTADO :";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(671, 62);
            cmbRol.Margin = new Padding(3, 2, 3, 2);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(134, 33);
            cmbRol.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(568, 65);
            label9.Name = "label9";
            label9.Size = new Size(48, 21);
            label9.TabIndex = 11;
            label9.Text = "ROL :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(67, 209);
            label8.Name = "label8";
            label8.Size = new Size(125, 21);
            label8.TabIndex = 9;
            label8.Text = "CONTRASEÑA :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(103, 175);
            label7.Name = "label7";
            label7.Size = new Size(89, 21);
            label7.TabIndex = 8;
            label7.Text = "USUARIO :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(27, 126);
            label6.Name = "label6";
            label6.Size = new Size(175, 21);
            label6.TabIndex = 7;
            label6.Text = "APELLIDO MATERNO :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(27, 83);
            label5.Name = "label5";
            label5.Size = new Size(165, 21);
            label5.TabIndex = 6;
            label5.Text = "APELLIDO PATERNO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(96, 38);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 5;
            label4.Text = "NOMBRES :";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(276, 164);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(218, 32);
            txtUsuario.TabIndex = 3;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(276, 122);
            txtApellidoMaterno.Margin = new Padding(3, 2, 3, 2);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(218, 32);
            txtApellidoMaterno.TabIndex = 2;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(276, 80);
            txtApellidoPaterno.Margin = new Padding(3, 2, 3, 2);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(218, 32);
            txtApellidoPaterno.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(276, 38);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(218, 32);
            txtNombre.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(901, 604);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(119, 33);
            btnSalir.TabIndex = 25;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_click;
            // 
            // btnNuevoUsuario
            // 
            btnNuevoUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoUsuario.Location = new Point(85, 604);
            btnNuevoUsuario.Margin = new Padding(3, 2, 3, 2);
            btnNuevoUsuario.Name = "btnNuevoUsuario";
            btnNuevoUsuario.Size = new Size(116, 33);
            btnNuevoUsuario.TabIndex = 23;
            btnNuevoUsuario.Text = "NUEVO";
            btnNuevoUsuario.UseVisualStyleBackColor = true;
            btnNuevoUsuario.Click += btnNuevoUsuario_Click;
            // 
            // btnCancelarUsuario
            // 
            btnCancelarUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarUsuario.Location = new Point(763, 604);
            btnCancelarUsuario.Margin = new Padding(3, 2, 3, 2);
            btnCancelarUsuario.Name = "btnCancelarUsuario";
            btnCancelarUsuario.Size = new Size(119, 33);
            btnCancelarUsuario.TabIndex = 20;
            btnCancelarUsuario.Text = "CANCELAR";
            btnCancelarUsuario.UseVisualStyleBackColor = true;
            btnCancelarUsuario.Click += btnCancelarUsuario_Click;
            // 
            // btnGuardarUsuario
            // 
            btnGuardarUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarUsuario.Location = new Point(220, 604);
            btnGuardarUsuario.Margin = new Padding(3, 2, 3, 2);
            btnGuardarUsuario.Name = "btnGuardarUsuario";
            btnGuardarUsuario.Size = new Size(116, 33);
            btnGuardarUsuario.TabIndex = 22;
            btnGuardarUsuario.Text = "GUARDAR";
            btnGuardarUsuario.UseVisualStyleBackColor = true;
            btnGuardarUsuario.Enter += btnGuardarUsuario_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarUsuario.Location = new Point(625, 604);
            btnEliminarUsuario.Margin = new Padding(3, 2, 3, 2);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(119, 33);
            btnEliminarUsuario.TabIndex = 21;
            btnEliminarUsuario.Text = "ELIMINAR";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.WindowFrame;
            tabPage1.Controls.Add(pictureBox4);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(btnCancelarProducto);
            tabPage1.Controls.Add(btnEliminarProducto);
            tabPage1.Controls.Add(btnGuardarProducto);
            tabPage1.Controls.Add(btnNuevoProducto);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(dgvProductos);
            tabPage1.Font = new Font("Segoe UI", 11.25F);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(1125, 706);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Productos";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(940, 64);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(179, 241);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(954, 629);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(129, 36);
            button2.TabIndex = 6;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSalir_click;
            // 
            // btnCancelarProducto
            // 
            btnCancelarProducto.Location = new Point(803, 629);
            btnCancelarProducto.Margin = new Padding(3, 2, 3, 2);
            btnCancelarProducto.Name = "btnCancelarProducto";
            btnCancelarProducto.Size = new Size(129, 36);
            btnCancelarProducto.TabIndex = 5;
            btnCancelarProducto.Text = "Cancelar";
            btnCancelarProducto.UseVisualStyleBackColor = true;
            btnCancelarProducto.Click += btnCancelarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(353, 629);
            btnEliminarProducto.Margin = new Padding(3, 2, 3, 2);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(116, 36);
            btnEliminarProducto.TabIndex = 4;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.Location = new Point(219, 629);
            btnGuardarProducto.Margin = new Padding(3, 2, 3, 2);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(116, 36);
            btnGuardarProducto.TabIndex = 3;
            btnGuardarProducto.Text = "Guardar";
            btnGuardarProducto.UseVisualStyleBackColor = true;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Location = new Point(91, 629);
            btnNuevoProducto.Margin = new Padding(3, 2, 3, 2);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(116, 36);
            btnNuevoProducto.TabIndex = 2;
            btnNuevoProducto.Text = "Nuevo";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblIdProducto);
            groupBox2.Controls.Add(rdbProductoActivo);
            groupBox2.Controls.Add(rdbProductoInactivo);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(nudPrecio);
            groupBox2.Controls.Add(lblprecio);
            groupBox2.Controls.Add(cmbUnidadMedida);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(cmbCategoria);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtNombreProducto);
            groupBox2.Controls.Add(label11);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(66, 363);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(997, 243);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del Producto";
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.Font = new Font("Unispace", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdProducto.Location = new Point(972, 29);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(16, 16);
            lblIdProducto.TabIndex = 12;
            lblIdProducto.Text = "0";
            lblIdProducto.Visible = false;
            // 
            // rdbProductoActivo
            // 
            rdbProductoActivo.AutoSize = true;
            rdbProductoActivo.Font = new Font("Unispace", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdbProductoActivo.ForeColor = SystemColors.ActiveCaptionText;
            rdbProductoActivo.Location = new Point(802, 143);
            rdbProductoActivo.Margin = new Padding(3, 2, 3, 2);
            rdbProductoActivo.Name = "rdbProductoActivo";
            rdbProductoActivo.Size = new Size(80, 22);
            rdbProductoActivo.TabIndex = 11;
            rdbProductoActivo.TabStop = true;
            rdbProductoActivo.Text = "Activo";
            rdbProductoActivo.UseVisualStyleBackColor = true;
            // 
            // rdbProductoInactivo
            // 
            rdbProductoInactivo.AutoSize = true;
            rdbProductoInactivo.Font = new Font("Unispace", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdbProductoInactivo.ForeColor = SystemColors.ActiveCaptionText;
            rdbProductoInactivo.Location = new Point(802, 179);
            rdbProductoInactivo.Margin = new Padding(3, 2, 3, 2);
            rdbProductoInactivo.Name = "rdbProductoInactivo";
            rdbProductoInactivo.Size = new Size(98, 22);
            rdbProductoInactivo.TabIndex = 10;
            rdbProductoInactivo.TabStop = true;
            rdbProductoInactivo.Text = "Inactivo";
            rdbProductoInactivo.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(665, 145);
            label14.Name = "label14";
            label14.Size = new Size(106, 23);
            label14.TabIndex = 9;
            label14.Text = "Estado :";
            // 
            // nudPrecio
            // 
            nudPrecio.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudPrecio.Location = new Point(809, 65);
            nudPrecio.Margin = new Padding(3, 2, 3, 2);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(116, 30);
            nudPrecio.TabIndex = 8;
            // 
            // lblprecio
            // 
            lblprecio.AutoSize = true;
            lblprecio.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblprecio.Location = new Point(586, 65);
            lblprecio.Name = "lblprecio";
            lblprecio.Size = new Size(202, 23);
            lblprecio.TabIndex = 7;
            lblprecio.Text = "Precio Unitario:";
            // 
            // cmbUnidadMedida
            // 
            cmbUnidadMedida.FormattingEnabled = true;
            cmbUnidadMedida.Location = new Point(332, 177);
            cmbUnidadMedida.Margin = new Padding(3, 2, 3, 2);
            cmbUnidadMedida.Name = "cmbUnidadMedida";
            cmbUnidadMedida.Size = new Size(186, 28);
            cmbUnidadMedida.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(80, 177);
            label13.Name = "label13";
            label13.Size = new Size(214, 23);
            label13.TabIndex = 4;
            label13.Text = "Unidad de Medida:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(332, 124);
            cmbCategoria.Margin = new Padding(3, 2, 3, 2);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(186, 28);
            cmbCategoria.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(153, 124);
            label12.Name = "label12";
            label12.Size = new Size(142, 23);
            label12.TabIndex = 2;
            label12.Text = "Categoría :";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(332, 54);
            txtNombreProducto.Margin = new Padding(3, 2, 3, 2);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(186, 27);
            txtNombreProducto.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(31, 62);
            label11.Name = "label11";
            label11.Size = new Size(262, 23);
            label11.TabIndex = 0;
            label11.Text = "Nombre del Producto :";
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(6, 9);
            dgvProductos.Margin = new Padding(3, 2, 3, 2);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(928, 322);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellContentClick += dgvProductos_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.WindowFrame;
            tabPage2.Controls.Add(pictureBox5);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(1125, 706);
            tabPage2.TabIndex = 4;
            tabPage2.Text = "Clientes";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(4, 74);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(190, 229);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 25;
            pictureBox5.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(197, 23);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(922, 322);
            dataGridView1.TabIndex = 1;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = SystemColors.WindowFrame;
            tabPage4.Location = new Point(4, 32);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 2, 3, 2);
            tabPage4.Size = new Size(1125, 706);
            tabPage4.TabIndex = 5;
            tabPage4.Text = "Compras";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = SystemColors.WindowFrame;
            tabPage5.ForeColor = SystemColors.ActiveCaptionText;
            tabPage5.Location = new Point(4, 32);
            tabPage5.Margin = new Padding(3, 2, 3, 2);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3, 2, 3, 2);
            tabPage5.Size = new Size(1125, 706);
            tabPage5.TabIndex = 6;
            tabPage5.Text = "Ventas";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(814, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(15, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(248, 66);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // frmAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1154, 845);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(TabControlPrincipal);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            ForeColor = Color.DimGray;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAdministrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU ADMINISTRADOR";
            Load += frmAdministrador_Load;
            TabControlPrincipal.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgUsuario).EndInit();
            gruBDatosUsuario.ResumeLayout(false);
            gruBDatosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label1;
        private Label label2;
        private TabControl TabControlPrincipal;
        private TabPage tabPage3;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button btnCancelarUsuario;
        private GroupBox gruBDatosUsuario;
        private DataGridView dgvUsuarios;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtUsuario;
        private TextBox txtApellidoMaterno;
        private TextBox txtApellidoPaterno;
        private TextBox txtNombre;
        private Label lblIdUsuario;
        private RadioButton rdbInactivo;
        private RadioButton rdbActivo;
        private Label label10;
        private ComboBox cmbRol;
        private Label label9;
        private Button btnNuevoUsuario;
        private Button btnGuardarUsuario;
        private Button btnEliminarUsuario;
        private DataGridView dgvProductos;
        private GroupBox groupBox2;
        private ComboBox cmbCategoria;
        private Label label12;
        private TextBox txtNombreProducto;
        private Label label11;
        private Label lblprecio;
        private ComboBox cmbUnidadMedida;
        private Label label13;
        private NumericUpDown nudPrecio;
        private Label lblIdProducto;
        private RadioButton rdbProductoActivo;
        private RadioButton rdbProductoInactivo;
        private Label label14;
        private Button btnCancelarProducto;
        private Button btnEliminarProducto;
        private Button btnGuardarProducto;
        private Button btnNuevoProducto;
        private TextBox txtClave;
        private Button btnSalir;
        private Button btnBuscar;
        private DataGridView dataGridView1;
        private PictureBox imgUsuario;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}