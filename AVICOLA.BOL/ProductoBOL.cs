using AVICOLA.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVICOLA.BOL
{
    public class ProductoBOL
    {
        // ==================== CRUD PRODUCTOS ====================
        public static DataTable ListarProductos()
        {
            AccesoBD db = new AccesoBD();
            DataSet ds = new DataSet();
            ds = db.ExecuteDataSet("PROC_LISTAR_PRODUCTOS");
            return ds.Tables[0];
        }

        // ==================== MÉTODOS DE REGISTRO, EDICIÓN Y ELIMINACIÓN ====================
        public static int RegistrarProducto(string nombreProducto, string categoria,
                                          string unidadMedida, decimal precioUnitario, string estado)
        {
            AccesoBD db = new AccesoBD();
            db.AddParameter("@NombreProducto", nombreProducto);
            db.AddParameter("@Categoria", categoria);
            db.AddParameter("@UnidadMedida", unidadMedida);
            db.AddParameter("@PrecioUnitario", precioUnitario);
            db.AddParameter("@Estado", estado);
            return db.ExecuteNonQuery("PROC_REGISTRAR_PRODUCTO");
        }

        // ==================== MÉTODO DE EDICIÓN ====================
        public static int EditarProducto(int idProducto, string nombreProducto, string categoria,
                                       string unidadMedida, decimal precioUnitario, string estado)
        {
            AccesoBD db = new AccesoBD();
            db.AddParameter("@IdProducto", idProducto);
            db.AddParameter("@NombreProducto", nombreProducto);
            db.AddParameter("@Categoria", categoria);
            db.AddParameter("@UnidadMedida", unidadMedida);
            db.AddParameter("@PrecioUnitario", precioUnitario);
            db.AddParameter("@Estado", estado);
            return db.ExecuteNonQuery("PROC_EDITAR_PRODUCTO");
        }

        // ==================== ELIMINAR PRODUCTO ====================
        public static int EliminarProducto(int idProducto)
        {
            AccesoBD db = new AccesoBD();
            db.AddParameter("@IdProducto", idProducto);
            return db.ExecuteNonQuery("PROC_ELIMINAR_PRODUCTO");
        }

        // ==================== GUARDAR PRODUCTO ====================
        public static int GuardarProducto(int idProducto, string nombreProducto, string categoria,
                                    string unidadMedida, decimal precioUnitario, string estado)
        {
            if (idProducto == 0) // Nuevo producto
            {
                return RegistrarProducto(nombreProducto, categoria, unidadMedida, precioUnitario, estado);
            }
            else // Editar producto existente
            {
                return EditarProducto(idProducto, nombreProducto, categoria, unidadMedida, precioUnitario, estado);
            }
        }




        // ==================== MÉTODOS PARA COMBOBOX ====================
        public static DataTable ListarCategorias()
        {
            AccesoBD db = new AccesoBD();
            DataSet ds = new DataSet();
            ds = db.ExecuteDataSet("PROC_LISTAR_CATEGORIAS");
            return ds.Tables[0];
        }

        public static DataTable ListarUnidadesMedida()
        {
            AccesoBD db = new AccesoBD();
            DataSet ds = new DataSet();
            ds = db.ExecuteDataSet("PROC_LISTAR_UNIDADES_MEDIDA");
            return ds.Tables[0];
        }

        // ==================== BÚSQUEDA DE PRODUCTOS ====================
        public static DataTable BuscarProductosPorNombre(string nombreProducto)
        {
            AccesoBD db = new AccesoBD();
            DataSet ds = new DataSet();
            db.AddParameter("@NombreProducto", nombreProducto);
            ds = db.ExecuteDataSet("PROC_BUSCAR_PRODUCTOS_NOMBRE");
            return ds.Tables[0];
        }
    }
}