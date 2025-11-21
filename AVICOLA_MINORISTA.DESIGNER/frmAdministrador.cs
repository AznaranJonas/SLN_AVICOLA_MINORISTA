using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVICOLA.DAL;
using AVICOLA.BOL;

namespace AVICOLA_MINORISTA.DESIGNER
{
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void frmAdministrador_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarRoles();
            LimpiarFormularioUsuario();

            //AQUIN CARGA LOS PRODUCTOS 
            CargarProductos();
            CargarCategorias();
            CargarUnidadesMedida();
        }

        //  MÉTODOS PARA USUARIOS 

        private void CargarUsuarios()
        {
            try
            {
                DataTable dt = UsuarioBOL.ListarUsuarios();
                dgvUsuarios.DataSource = dt;

                //HACER TODO EL DATAGRIDVIEW DE SOLO LECTURA
                dgvUsuarios.ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        private void CargarRoles()
        {
            cmbRol.Items.Clear();
            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Vendedor");
        }

        private void LimpiarFormularioUsuario()
        {
            lblIdUsuario.Text = "0";
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtUsuario.Text = "";
            txtClave.Text = "";
            cmbRol.Text = "";
            rdbActivo.Checked = true;
        }

        private bool ValidarUsuario()
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre del usuario");
                txtNombre.Focus();
                return false;
            }
            if (txtApellidoPaterno.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el apellido paterno");
                txtApellidoPaterno.Focus();
                return false;
            }
            if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre de usuario");
                txtUsuario.Focus();
                return false;
            }
            if (txtClave.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la contraseña");
                txtClave.Focus();
                return false;
            }
            if (cmbRol.Text == "")
            {
                MessageBox.Show("Seleccione el rol del usuario");
                cmbRol.Focus();
                return false;
            }
            return true;
        }

        //  EVENTOS DE BOTONES - USUARIOS 

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            LimpiarFormularioUsuario();
            gruBDatosUsuario.Enabled = true;
            txtNombre.Focus();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (ValidarUsuario())
            {
                try
                {
                    int idUsuario = Convert.ToInt32(lblIdUsuario.Text);
                    string estado = rdbActivo.Checked ? "A" : "I";

                    int resultado = UsuarioBOL.GuardarUsuario(
                        idUsuario,
                        txtNombre.Text.Trim(),
                        txtApellidoPaterno.Text.Trim(),
                        txtApellidoMaterno.Text.Trim(),
                        txtUsuario.Text.Trim(),
                        txtClave.Text.Trim(),
                        cmbRol.Text,
                        estado
                    );

                    if (resultado > 0)
                    {
                        MessageBox.Show("Usuario guardado correctamente");
                        LimpiarFormularioUsuario();
                        CargarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar el usuario");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar usuario: " + ex.Message);
                }
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (lblIdUsuario.Text != "0")
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este usuario?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        int idUsuario = Convert.ToInt32(lblIdUsuario.Text);
                        int resultado = UsuarioBOL.EliminarUsuario(idUsuario);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Usuario eliminado correctamente");
                            LimpiarFormularioUsuario();
                            CargarUsuarios();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar usuario: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminar");
            }
        }

        private void btnCancelarUsuario_Click(object sender, EventArgs e)
        {
            LimpiarFormularioUsuario();
            //refeSCA MIS USUARIOS 
            CargarUsuarios();

        }


        // EVENTO DEL DATAGRIDVIEW 

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                lblIdUsuario.Text = fila.Cells["IdUsuario"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtApellidoPaterno.Text = fila.Cells["ApellidoPaterno"].Value.ToString();
                txtApellidoMaterno.Text = fila.Cells["ApellidoMaterno"].Value.ToString();
                txtUsuario.Text = fila.Cells["Usuario"].Value.ToString();
                txtClave.Text = fila.Cells["Clave"].Value.ToString();
                cmbRol.Text = fila.Cells["Rol"].Value.ToString();

                string estado = fila.Cells["Estado"].Value.ToString();
                if (estado == "A")
                {
                    rdbActivo.Checked = true;
                    rdbInactivo.Checked = false;
                }
                else
                {
                    rdbActivo.Checked = false;
                    rdbInactivo.Checked = true;
                }

                gruBDatosUsuario.Enabled = true;
            }
        }




        private void btnSalir_click(object sender, EventArgs e)
        {
            this.Close();
        }








        // metodos de busqueda de usuarios--------------------------------------

        private void BuscarUsuariosPorApellido()
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtApellidoPaterno.Text))
                {
                    MessageBox.Show("Ingrese una apellido paterno ");
                    txtApellidoPaterno.Focus();
                    return;
                }
                //

                DataTable dt = UsuarioBOL.BuscarUsuariosPorApellido(txtApellidoPaterno.Text.Trim());
                dgvUsuarios.DataSource = dt;
                dgvUsuarios.ReadOnly = true;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron usuarios con ese apellido");
                }
                else
                {
                    MessageBox.Show($"Se encontraron {dt.Rows.Count} usuarios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }






        // buscar por estado reutilizando metodo anterior 
        private void BuscarPorEstado()
        {

            string estado = ""; //decaramos para faciliarnos la vida

            if (rdbActivo.Checked)
            {
                estado = "A";

            }
            else
            {
                estado = "I";

            }


            //no necesito hacer conversion al ser almacenado en mi variakle stringg
            DataTable dt = UsuarioBOL.BuscarPorEstado(estado);
            dgvUsuarios.DataSource = dt;
            dgvUsuarios.ReadOnly = true;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron usuarios con ese estado");
            }
            else
            {
                MessageBox.Show($"Se encontraron {dt.Rows.Count} usuarios");
            }

        }

        //metodo generalidad del boton buscar 
        //adaptar para quie no dependa uno de otro
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //este if separa mis dos tipos de busqueda para que no se crucen las mesagebox
            if (txtApellidoPaterno.Text != "")
            {
                BuscarUsuariosPorApellido();
            }
            else
            {
                BuscarPorEstado();
            }
        }

















        //************************************************************************************

        //*****************************MÉTODOS PARA PRODUCTOS ***********************---------------------------------

        private void CargarProductos()
        {
            try
            {
                DataTable dt = ProductoBOL.ListarProductos();
                dgvProductos.DataSource = dt;
                dgvProductos.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void CargarCategorias()
        {
            try
            {
                DataTable dt = ProductoBOL.ListarCategorias();
                cmbCategoria.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    cmbCategoria.Items.Add(row["Categoria"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }

        private void CargarUnidadesMedida()
        {
            try
            {
                DataTable dt = ProductoBOL.ListarUnidadesMedida();
                cmbUnidadMedida.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    cmbUnidadMedida.Items.Add(row["UnidadMedida"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar unidades de medida: " + ex.Message);
            }
        }

        private void LimpiarFormularioProducto()
        {
            lblIdProducto.Text = "0";
            txtNombreProducto.Text = "";
            cmbCategoria.Text = "";
            cmbCategoria.SelectedIndex = -1;
            cmbUnidadMedida.Text = "";
            cmbUnidadMedida.SelectedIndex = -1;
            nudPrecio.Value = 0;
            rdbProductoActivo.Checked = true;
        }

        private bool ValidarProducto()
        {
            if (txtNombreProducto.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre del producto");
                txtNombreProducto.Focus();
                return false;
            }
            if (cmbCategoria.Text == "")
            {
                MessageBox.Show("Seleccione la categoría");
                cmbCategoria.Focus();
                return false;
            }
            if (cmbUnidadMedida.Text == "")
            {
                MessageBox.Show("Seleccione la unidad de medida");
                cmbUnidadMedida.Focus();
                return false;
            }
            if (nudPrecio.Value <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a 0");
                nudPrecio.Focus();
                return false;
            }
            return true;
        }
























        //-- crud productos eventos de botones -- 

        // ==================== EVENTOS DE BOTONES - PRODUCTOS ====================

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            LimpiarFormularioProducto();
            groupBox2.Enabled = true;
            txtNombreProducto.Focus();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (ValidarProducto())
            {
                try
                {
                    int idProducto = Convert.ToInt32(lblIdProducto.Text);
                    string estado = rdbProductoActivo.Checked ? "A" : "I";

                    int resultado = ProductoBOL.GuardarProducto(
                        idProducto,
                        txtNombreProducto.Text.Trim(),
                        cmbCategoria.Text,
                        cmbUnidadMedida.Text,
                        nudPrecio.Value,
                        estado
                    );

                    if (resultado > 0)
                    {
                        MessageBox.Show("Producto guardado correctamente");
                        LimpiarFormularioProducto();
                        CargarProductos();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar el producto");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar producto: " + ex.Message);
                }
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (lblIdProducto.Text != "0")
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este producto?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        int idProducto = Convert.ToInt32(lblIdProducto.Text);
                        int resultado = ProductoBOL.EliminarProducto(idProducto);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Producto eliminado correctamente");
                            LimpiarFormularioProducto();
                            CargarProductos();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar producto: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar");
            }
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            LimpiarFormularioProducto();
            CargarProductos();



        }

        // ==================== EVENTO DEL DATAGRIDVIEW - PRODUCTOS ====================

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

                lblIdProducto.Text = fila.Cells["IdProducto"].Value.ToString();
                txtNombreProducto.Text = fila.Cells["NombreProducto"].Value.ToString();
                cmbCategoria.Text = fila.Cells["Categoria"].Value.ToString();
                cmbUnidadMedida.Text = fila.Cells["UnidadMedida"].Value.ToString();
                nudPrecio.Value = Convert.ToDecimal(fila.Cells["PrecioUnitario"].Value);

                string estado = fila.Cells["Estado"].Value.ToString();
                if (estado == "A")
                {
                    rdbProductoActivo.Checked = true;
                    rdbProductoInactivo.Checked = false;
                }
                else
                {
                    rdbProductoActivo.Checked = false;
                    rdbProductoInactivo.Checked = true;
                }

                groupBox2.Enabled = true;
            }
        }


































        //metodos de decoraciones
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (txtClave.PasswordChar == '*')
            {
                txtClave.PasswordChar = '\0'; //para mostrar la clave seleccionadaa
            }
            else
            {
                txtClave.PasswordChar = '*'; //si clickeo x segunda vess oulta
            }

        }


    }
}