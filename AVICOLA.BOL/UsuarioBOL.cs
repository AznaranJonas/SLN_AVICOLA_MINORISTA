using AVICOLA.DAL;
using System.Data;

namespace AVICOLA.BOL
{
    public class UsuarioBOL
    {
        //no olvidar ja,as las comillas dobles  
        // M.  de ingreessoo
        public static DataTable LoginUsuario(string usuario, string clave)
        {
            AccesoBD db = new AccesoBD();
            DataSet ds = new DataSet();
            db.AddParameter("@Usuario", usuario);
            db.AddParameter("@Clave", clave);
            ds = db.ExecuteDataSet("PROC_LOGIN_USUARIO");
            return ds.Tables[0];
        }

        // M.  de crud 
        public static DataTable ListarUsuarios()
        {
            AccesoBD db = new AccesoBD();
            DataSet ds = new DataSet();
            ds = db.ExecuteDataSet("PROC_LISTAR_USUARIOS");
            return ds.Tables[0];
        }



        //M. De Guardar (Registrar y Editar)
        public static int RegistrarUsuario(string nombre, string apellidoPaterno,
                                         string apellidoMaterno, string usuario,
                                         string clave, string rol)
        {
            AccesoBD db = new AccesoBD();
            DataSet ds = new DataSet();
            db.AddParameter("@Nombre", nombre);
            db.AddParameter("@ApellidoPaterno", apellidoPaterno);
            db.AddParameter("@ApellidoMaterno", apellidoMaterno);
            db.AddParameter("@Usuario", usuario);
            db.AddParameter("@Clave", clave);
            db.AddParameter("@Rol", rol);
            ds = db.ExecuteDataSet("PROC_REGISTRAR_USUARIO");
            return 1; // Retorna 1 si se insertó correctamente
        }




        // M . DE Editar
        public static int EditarUsuario(int idUsuario, string nombre, string apellidoPaterno,
                                      string apellidoMaterno, string usuario, string clave,
                                      string rol, string estado)
        {
            AccesoBD db = new AccesoBD();
            DataSet ds = new DataSet();
            db.AddParameter("@IdUsuario", idUsuario);
            db.AddParameter("@Nombre", nombre);
            db.AddParameter("@ApellidoPaterno", apellidoPaterno);
            db.AddParameter("@ApellidoMaterno", apellidoMaterno);
            db.AddParameter("@Usuario", usuario);
            db.AddParameter("@Clave", clave);
            db.AddParameter("@Rol", rol);
            db.AddParameter("@Estado", estado);
            ds = db.ExecuteDataSet("PROC_EDITAR_USUARIO");
            return 1; // Retorna 1 si se actualizó correctamente
        }




        // M . de Eliminacion Logica
        public static int EliminarUsuario(int idUsuario)
        {
            AccesoBD db = new AccesoBD();
            DataSet ds = new DataSet();
            db.AddParameter("@IdUsuario", idUsuario);
            ds = db.ExecuteDataSet("PROC_ELIMINAR_USUARIO");
            return 1; // Retorna 1 si se eliminó correctamente
        }



        // M unificado p guardar
        public static int GuardarUsuario(int idUsuario, string nombre, string apellidoPaterno,
                                       string apellidoMaterno, string usuario, string clave,
                                       string rol, string estado)
        {
            if (idUsuario == 0) // Nuevo usuario
            {
                return RegistrarUsuario(nombre, apellidoPaterno, apellidoMaterno, usuario, clave, rol);
            }
            else // Editar usuario existente
            {
                return EditarUsuario(idUsuario, nombre, apellidoPaterno, apellidoMaterno, usuario, clave, rol, estado);
            }
        }



        // M : busuqueda por apellidoPAterno
        public static DataTable BuscarUsuariosPorApellido(string apellidoPaterno)
        {
            AccesoBD db = new AccesoBD();
            DataSet ds = new DataSet();
            db.AddParameter("@ApellidoPaterno", apellidoPaterno);
            ds = db.ExecuteDataSet("PROC_BUSCAR_USUARIOS_APELLIDO");
            return ds.Tables[0];
        }







        //ultima prueba 
        //por estado

        public static DataTable BuscarPorEstado(string Estado)
        {
            AccesoBD db = new AccesoBD();
            DataSet ds = new DataSet();
            db.AddParameter("@Estado", Estado);
            ds = db.ExecuteDataSet("PROC_BUSCAR_USUARIOS_X_ESTADO"); // crear proceedure faltante
            return ds.Tables[0];
        }
    }
}

