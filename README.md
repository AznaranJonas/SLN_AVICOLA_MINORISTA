# Sistema Minorista Avícola

## Descripción
Este proyecto es un **sistema de gestión minorista para una avícola**, desarrollado en SQL Server. Permite llevar el control de usuarios, productos, clientes, compras y ventas, incluyendo funcionalidades de **CRUD, eliminación lógica, búsquedas en cascada y manejo de inventario**.  
El sistema está diseñado para ser simple, funcional y escalable, ideal para la gestión de un negocio avícola pequeño o mediano.

## Características principales
- Registro, edición y eliminación lógica de **usuarios**, **productos** y **clientes**.  
- Control de compras de pollos con registro de cantidades, pesos y costos.  
- Gestión de ventas con cabecera y detalle, cálculo de subtotales y monto total.  
- Búsquedas en cascada (filtros por categoría, nombre, estado).  
- Listado de productos activos para **combos en interfaces gráficas**.  
- Eliminación lógica para preservar historial de registros.  
- Login de usuarios con control por roles (Administrador y Vendedor).  

## Requisitos
- **SQL Server 2019 o superior**  
- **SQL Server Management Studio (SSMS)**  
- Conocimientos básicos de SQL y procedimientos almacenados  

## Base de datos
**Nombre:** `AVICOLA_MINORISTA`  

### Tablas principales
1. **Usuarios**
   - `IdUsuario` (PK, INT, Identity)
   - `Nombre`, `ApellidoPaterno`, `ApellidoMaterno`, `Usuario`, `Clave`, `Rol`, `Estado`  

2. **Productos**
   - `IdProducto` (PK, INT, Identity)
   - `NombreProducto`, `Categoria`, `UnidadMedida`, `PrecioUnitario`, `Estado`  

3. **Clientes**
   - `IdCliente` (PK, INT, Identity)
   - `NombreCliente`, `TipoCliente`, `Celular`, `RUC`, `Estado`  

4. **Ventas**
   - `IdVenta` (PK, INT, Identity)
   - `IdCliente`, `FechaVenta`, `MontoTotal`, `IdUsuario`, `Estado`  

5. **ComprasPollos**
   - `IdCompra` (PK, INT, Identity)
   - `FechaCompra`, `CantidadPollos`, `PesoTotal`, `CostoTotal`, `Proveedor`, `IdUsuario`  

6. **DetalleVenta**
   - `IdDetalle` (PK, INT, Identity)
   - `IdVenta`, `IdProducto`, `Cantidad`, `PrecioUnitario`, `SubTotal`  

## Procedimientos almacenados (resumen)
- **Usuarios:** `PROC_REGISTRAR_USUARIO`, `PROC_EDITAR_USUARIO`, `PROC_ELIMINAR_USUARIO`, `PROC_LISTAR_USUARIOS`, `PROC_LOGIN_USUARIO`  
- **Productos:** `PROC_REGISTRAR_PRODUCTO`, `PROC_EDITAR_PRODUCTO`, `PROC_ELIMINAR_PRODUCTO`, `PROC_LISTAR_PRODUCTOS`, `PROC_LISTAR_PRODUCTOS_COMBO`, `PROC_BUSCAR_PRODUCTO_CASCADA`  
- **Clientes:** `PROC_REGISTRAR_CLIENTE`, `PROC_EDITAR_CLIENTE`, `PROC_ELIMINAR_CLIENTE`, `PROC_LISTAR_CLIENTES`, `PROC_BUSCAR_CLIENTE_CASCADA`  
- **Compras:** `PROC_REGISTRAR_COMPRA`, `PROC_EDITAR_COMPRA`, `PROC_ELIMINAR_COMPRA`, `PROC_LISTAR_COMPRAS_POR_FECHA`  
- **Ventas:** `PROC_INICIAR_VENTA`, `PROC_INSERTAR_DETALLE_VENTA`, `PROC_LISTAR_DETALLE_VENTA`, `PROC_ANULAR_VENTA`, `PROC_LISTAR_VENTAS_POR_FECHA`  

## Cómo usar
1. Crear la base de datos y tablas ejecutando los scripts en **SSMS**.  
2. Ejecutar los procedimientos almacenados para registrar usuarios, productos y clientes.  
3. Registrar compras de pollos y ventas según la operación del negocio.  
4. Realizar búsquedas y listados a través de los procedimientos correspondientes.  

## Notas
- La eliminación de registros de usuarios, productos y clientes es **lógica**, para mantener historial.  
- Se permite solo un usuario administrador con privilegios totales.  
- Los filtros en búsquedas en cascada son opcionales, si se dejan nulos muestran todos los registros.
