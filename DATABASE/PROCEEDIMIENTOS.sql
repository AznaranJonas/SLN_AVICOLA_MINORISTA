-- Registrar usuario
CREATE PROCEDURE PROC_REGISTRAR_USUARIO
    @Nombre VARCHAR(40),
    @ApellidoPaterno VARCHAR(40),
    @ApellidoMaterno VARCHAR(40),
    @Usuario VARCHAR(40),
    @Clave VARCHAR(200),
    @Rol VARCHAR(20)
AS
BEGIN
    INSERT INTO Usuarios (Nombre, ApellidoPaterno, ApellidoMaterno, Usuario, Clave, Rol, Estado)
    VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Usuario, @Clave, @Rol, 'A');
END;
GO










-- Editar usuario
CREATE PROCEDURE PROC_EDITAR_USUARIO
    @IdUsuario INT,
    @Nombre VARCHAR(40),
    @ApellidoPaterno VARCHAR(40),
    @ApellidoMaterno VARCHAR(40),
    @Usuario VARCHAR(40),
    @Clave VARCHAR(200),
    @Rol VARCHAR(20),
    @Estado CHAR(1)
AS
BEGIN
    UPDATE Usuarios
    SET Nombre = @Nombre,
        ApellidoPaterno = @ApellidoPaterno,
        ApellidoMaterno = @ApellidoMaterno,
        Usuario = @Usuario,
        Clave = @Clave,
        Rol = @Rol,
        Estado = @Estado
    WHERE IdUsuario = @IdUsuario;
END;
GO








-- Eliminar usuario (lógica)
CREATE PROCEDURE PROC_ELIMINAR_USUARIO
    @IdUsuario INT
AS
BEGIN
    UPDATE Usuarios
    SET Estado = 'I'
    WHERE IdUsuario = @IdUsuario;
END;
GO






-- Listar usuarios
CREATE PROCEDURE PROC_LISTAR_USUARIOS
AS
BEGIN
    SELECT IdUsuario, Nombre, ApellidoPaterno, ApellidoMaterno, Usuario, Rol, Estado,Clave 
    FROM Usuarios
    ORDER BY IdUsuario asc ,ApellidoPaterno, ApellidoMaterno, Nombre;
END;
GO



-- Login usuario
CREATE PROCEDURE PROC_LOGIN_USUARIO
    @Usuario VARCHAR(40),
    @Clave VARCHAR(200)
AS
BEGIN
    SELECT IdUsuario, Nombre, ApellidoPaterno, ApellidoMaterno, Usuario, Rol, Estado
    FROM Usuarios
    WHERE Usuario = @Usuario
      AND Clave = @Clave
      AND Estado = 'A';
END;
GO







-- BUSCAR USUARIOS APELLIDO

CREATE PROCEDURE PROC_BUSCAR_USUARIOS_APELLIDO
    @ApellidoPaterno VARCHAR(40)
AS
BEGIN
    SELECT IdUsuario, Nombre, ApellidoPaterno, ApellidoMaterno, Usuario, Rol, Estado, Clave
    FROM Usuarios
    WHERE ApellidoPaterno LIKE '%' + @ApellidoPaterno + '%'
    ORDER BY ApellidoPaterno, ApellidoMaterno, Nombre;
END
GO


-- BUSCAR USUARIOS x ESTADO

CREATE PROCEDURE PROC_BUSCAR_USUARIOS_X_ESTADO
    @Estado CHAR(1)
AS
BEGIN
        SELECT
        IdUsuario,
        Nombre,
        ApellidoPaterno,
        ApellidoMaterno,
        Usuario,
        Rol,
        Estado,
        Clave
    FROM Usuarios
    WHERE Estado = @Estado
    ORDER BY IdUsuario;
End;
GO

EXEC PROC_BUSCAR_USUARIOS_X_ESTADO 'A';   -- usuarios activos
EXEC PROC_BUSCAR_USUARIOS_X_ESTADO 'I';   -- usuarios inactivos











-- CLIENTES
-- ================================================

-- Registrar cliente
CREATE PROCEDURE PROC_REGISTRAR_CLIENTE
    @NombreCliente VARCHAR(80),
    @TipoCliente VARCHAR(30),
    @Celular VARCHAR(9),
    @RUC VARCHAR(11) = NULL
AS
BEGIN
    INSERT INTO Clientes (NombreCliente, TipoCliente, Celular, RUC, Estado)
    VALUES (@NombreCliente, @TipoCliente, @Celular, @RUC, 'A');
END;
GO

-- Editar cliente
CREATE PROCEDURE PROC_EDITAR_CLIENTE
    @IdCliente INT,
    @NombreCliente VARCHAR(80),
    @TipoCliente VARCHAR(30),
    @Celular VARCHAR(9),
    @RUC VARCHAR(11) = NULL
AS
BEGIN
    UPDATE Clientes
    SET NombreCliente = @NombreCliente,
        TipoCliente = @TipoCliente,
        Celular = @Celular,
        RUC = @RUC
    WHERE IdCliente = @IdCliente;
END;
GO

-- Eliminar cliente
CREATE PROCEDURE PROC_ELIMINAR_CLIENTE
    @IdCliente INT
AS
BEGIN
    UPDATE Clientes
    SET Estado = 'I'
    WHERE IdCliente = @IdCliente;
END;
GO

-- Listar clientes
CREATE PROCEDURE PROC_LISTAR_CLIENTES
AS
BEGIN
    SELECT IdCliente, NombreCliente, TipoCliente, Celular, RUC, Estado
    FROM Clientes
    ORDER BY TipoCliente, NombreCliente;
END;
GO






-- PRODUCTOS
-- ================================================


-- Registrar producto CORREGIDO
CREATE PROCEDURE PROC_REGISTRAR_PRODUCTO
    @NombreProducto VARCHAR(80),
    @Categoria VARCHAR(40),
    @UnidadMedida VARCHAR(20),
    @PrecioUnitario DECIMAL(7,2),
    @Estado CHAR(1)  
AS   
BEGIN
    INSERT INTO Productos (NombreProducto, Categoria, UnidadMedida, PrecioUnitario, Estado)
    VALUES (@NombreProducto, @Categoria, @UnidadMedida, @PrecioUnitario, @Estado);
END;
GO

-- Editar producto CORREGIDO
CREATE PROCEDURE PROC_EDITAR_PRODUCTO
    @IdProducto INT,
    @NombreProducto VARCHAR(80),
    @Categoria VARCHAR(40),
    @UnidadMedida VARCHAR(20),
    @PrecioUnitario DECIMAL(7,2),
    @Estado CHAR(1)  
AS  -- ← AGREGA 'AS' AQUÍ
BEGIN
    UPDATE Productos
    SET NombreProducto = @NombreProducto,
        Categoria = @Categoria,
        UnidadMedida = @UnidadMedida,
        PrecioUnitario = @PrecioUnitario,
        Estado = @Estado 
    WHERE IdProducto = @IdProducto;
END;
GO

-- Eliminar producto (lógica)
CREATE PROCEDURE PROC_ELIMINAR_PRODUCTO
    @IdProducto INT
AS
BEGIN
    UPDATE Productos
    SET Estado = 'I'
    WHERE IdProducto = @IdProducto;
END;
GO
--LISTASSS

-- Listar productos
CREATE PROCEDURE PROC_LISTAR_PRODUCTOS
AS
BEGIN
    SELECT IdProducto, NombreProducto, Categoria, UnidadMedida, PrecioUnitario, Estado
    FROM Productos
    ORDER BY IdProducto ,Categoria, NombreProducto;
END;
GO

-- Listar productos activos para combos
CREATE PROCEDURE PROC_LISTAR_PRODUCTOS_COMBO
AS
BEGIN
    SELECT IdProducto, NombreProducto
    FROM Productos
    WHERE Estado = 'A'
    ORDER BY NombreProducto;
END;
GO

-- BUSCAR_PRODUCTOS_NOMBRE


CREATE PROCEDURE PROC_BUSCAR_PRODUCTOS_NOMBRE
    @NombreProducto VARCHAR(80)
AS
BEGIN
    SELECT IdProducto, NombreProducto, Categoria, UnidadMedida, PrecioUnitario, Estado
    FROM Productos
    WHERE NombreProducto LIKE '%' + @NombreProducto + '%'
    ORDER BY NombreProducto;
END
GO



-- PROCEDURES PARA COMBOBOX DE PRODUCTOS

CREATE PROCEDURE PROC_LISTAR_CATEGORIAS
AS
BEGIN
    SELECT DISTINCT Categoria 
    FROM Productos 
    WHERE Estado = 'A'
    ORDER BY Categoria;
END;
GO
--2 

CREATE PROCEDURE PROC_LISTAR_UNIDADES_MEDIDA
AS
BEGIN
    SELECT DISTINCT UnidadMedida 
    FROM Productos 
    WHERE Estado = 'A'
    ORDER BY UnidadMedida;
END;
GO
















-- COMPRAS DE POLLOS
-- ================================================

-- Registrar compra
CREATE PROCEDURE PROC_REGISTRAR_COMPRA
    @FechaCompra DATE,
    @CantidadPollos INT,
    @PesoTotal DECIMAL(7,2),
    @CostoTotal DECIMAL(8,2),
    @Proveedor VARCHAR(80),
    @IdUsuario INT
AS
BEGIN
    INSERT INTO ComprasPollos (FechaCompra, CantidadPollos, PesoTotal, CostoTotal, Proveedor, IdUsuario)
    VALUES (@FechaCompra, @CantidadPollos, @PesoTotal, @CostoTotal, @Proveedor, @IdUsuario);
END;
GO

-- Editar compra
CREATE PROCEDURE PROC_EDITAR_COMPRA
    @IdCompra INT,
    @FechaCompra DATE,
    @CantidadPollos INT,
    @PesoTotal DECIMAL(7,2),
    @CostoTotal DECIMAL(8,2),
    @Proveedor VARCHAR(80)
AS
BEGIN
    UPDATE ComprasPollos
    SET FechaCompra = @FechaCompra,
        CantidadPollos = @CantidadPollos,
        PesoTotal = @PesoTotal,
        CostoTotal = @CostoTotal,
        Proveedor = @Proveedor
    WHERE IdCompra = @IdCompra;
END;
GO

-- Eliminar compra (físico)
CREATE PROCEDURE PROC_ELIMINAR_COMPRA
    @IdCompra INT
AS
BEGIN
    DELETE FROM ComprasPollos
    WHERE IdCompra = @IdCompra;
END;
GO

-- Listar compras por fecha
CREATE PROCEDURE PROC_LISTAR_COMPRAS_POR_FECHA
    @FechaDesde DATE = NULL,
    @FechaHasta DATE = NULL
AS
BEGIN
    SELECT IdCompra, FechaCompra, CantidadPollos, PesoTotal, CostoTotal, Proveedor, IdUsuario
    FROM ComprasPollos
    WHERE (@FechaDesde IS NULL OR FechaCompra >= @FechaDesde)
      AND (@FechaHasta IS NULL OR FechaCompra <= @FechaHasta)
    ORDER BY FechaCompra DESC;
END;
GO















-- VENTAS
-- ================================================

-- Iniciar venta
CREATE PROCEDURE PROC_INICIAR_VENTA
    @IdCliente INT = NULL,
    @IdUsuario INT,
    @MontoTotal DECIMAL(8,2)
AS
BEGIN
    INSERT INTO Ventas (IdCliente, FechaVenta, MontoTotal, IdUsuario, Estado)
    VALUES (@IdCliente, GETDATE(), @MontoTotal, @IdUsuario, 'A');
END;
GO

-- Insertar detalle venta
CREATE PROCEDURE PROC_INSERTAR_DETALLE_VENTA
    @IdVenta INT,
    @IdProducto INT,
    @Cantidad DECIMAL(7,2),
    @PrecioUnitario DECIMAL(7,2),
    @SubTotal DECIMAL(8,2)
AS
BEGIN
    INSERT INTO DetalleVenta (IdVenta, IdProducto, Cantidad, PrecioUnitario, SubTotal)
    VALUES (@IdVenta, @IdProducto, @Cantidad, @PrecioUnitario, @SubTotal);
END;
GO

-- Listar detalle venta
CREATE PROCEDURE PROC_LISTAR_DETALLE_VENTA
    @IdVenta INT
AS
BEGIN
    SELECT dv.IdDetalle, dv.IdProducto, p.NombreProducto, dv.Cantidad, dv.PrecioUnitario, dv.SubTotal
    FROM DetalleVenta dv
    INNER JOIN Productos p ON dv.IdProducto = p.IdProducto
    WHERE dv.IdVenta = @IdVenta;
END;
GO

-- Anular venta (lógica)
CREATE PROCEDURE PROC_ANULAR_VENTA
    @IdVenta INT
AS
BEGIN
    UPDATE Ventas
    SET Estado = 'I'
    WHERE IdVenta = @IdVenta;
END;
GO

-- Listar ventas por fecha
CREATE PROCEDURE PROC_LISTAR_VENTAS_POR_FECHA
    @FechaDesde DATE = NULL,
    @FechaHasta DATE = NULL
AS
BEGIN
    SELECT v.IdVenta, v.FechaVenta, v.MontoTotal, v.Estado, 
           u.Nombre + ' ' + u.ApellidoPaterno + ' ' + u.ApellidoMaterno AS Vendedor,
           c.NombreCliente
    FROM Ventas v
    LEFT JOIN Usuarios u ON v.IdUsuario = u.IdUsuario
    LEFT JOIN Clientes c ON v.IdCliente = c.IdCliente
    WHERE (@FechaDesde IS NULL OR CAST(v.FechaVenta AS DATE) >= @FechaDesde)
      AND (@FechaHasta IS NULL OR CAST(v.FechaVenta AS DATE) <= @FechaHasta)
    ORDER BY v.FechaVenta DESC;
END;
GO

