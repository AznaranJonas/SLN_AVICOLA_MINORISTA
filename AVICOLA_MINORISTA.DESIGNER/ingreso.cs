using AVICOLA.DAL;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Reflection.Metadata;
using AVICOLA.BOL;

namespace AVICOLA_MINORISTA.DESIGNER
{
    public partial class ingreso : Form
    {
        public ingreso()
        {
            InitializeComponent();
        }

        private void btnIngresar_click(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.OrangeRed; //al hacer click cambia de color
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Verificar que no estén vacíos los campos
            if (usuario == "" || contraseña == "")
            {
                MessageBox.Show("Debe introducir un usuario y contraseña por favor");
                btnIngresar.BackColor = Color.DarkOliveGreen ;   //al hacer click cambia de color que
                                                                 //puse en mis propiedades
                return;
            }

            // Encerramos en un try catch por si hay error de conexión
            try
            {
                // NUEVO Usar la capa BOL
                DataTable resultados = UsuarioBOL.LoginUsuario(usuario, contraseña);

                // Verificamos si encontró el usuario
                if (resultados.Rows.Count > 0)
                {
                    DataRow usuarioEncontrado = resultados.Rows[0];

                    // Obtener tipo de usuario en el sistema xc
                    string rol = usuarioEncontrado["Rol"].ToString();
                    string nombre = usuarioEncontrado["Nombre"].ToString();

                    // Mensaje de bienvenida personalizado
                    MessageBox.Show("Bienvenido de Nuevo: " + nombre + "\n" + "Rol: " + rol);

                    // Mandar formularios diferentes según el rol
                    if (rol == "Administrador")
                    {
                        frmAdministrador formularioAdmin = new frmAdministrador();
                        formularioAdmin.Show();
                    }
                    else if (rol == "Vendedor")
                    {
                        frmVendedor formularioVendedor = new frmVendedor();
                        formularioVendedor.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    // Limpiar mis txt
                    txtContraseña.Text = "";
                    txtUsuario.Focus();
                }
            }
            // Bloque catch para capturar los errores
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


















        //metodos de decoraciones
        private void lblMuestraClave_Click(object sender, EventArgs e)
        {
            if (txtContraseña.PasswordChar == '*')
            {
                txtContraseña.PasswordChar = '\0';
                lblMuestraClave.ForeColor = Color.Red;

            }
            else
            {
                txtContraseña.PasswordChar = '*';
                lblMuestraClave.ForeColor = Color.Green;

            }
            
        }
    }
}