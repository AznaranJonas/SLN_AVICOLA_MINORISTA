-- bd minorista -- 

-- Elimina la base de datos si existe (forma rápida)
IF DB_ID('AVICOLA_MINORISTA') IS NOT NULL
BEGIN
    ALTER DATABASE AVICOLA_MINORISTA SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE AVICOLA_MINORISTA;
END
GO

-- Crear base de datos nueva
CREATE DATABASE AVICOLA_MINORISTA;
GO

USE AVICOLA_MINORISTA;
GO

CREATE TABLE Usuarios (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(40) NOT NULL,
    ApellidoPaterno VARCHAR(40) NOT NULL,
    ApellidoMaterno VARCHAR(40) NOT NULL,
    Usuario VARCHAR(40) NOT NULL UNIQUE,
    Clave VARCHAR(200) NOT NULL,
    Rol VARCHAR(20) NOT NULL CHECK (Rol IN ('Administrador', 'Vendedor')),
    Estado CHAR(1) NOT NULL DEFAULT 'A' CHECK (Estado IN ('A','I')),
    CONSTRAINT UQ_Usuarios_NombreCompleto UNIQUE (Nombre, ApellidoPaterno, ApellidoMaterno) 
);

-- productoisd vendidos 

CREATE TABLE Productos (
    IdProducto INT IDENTITY(1,1) PRIMARY KEY,
    NombreProducto VARCHAR(80) NOT NULL,
    Categoria VARCHAR(40) NOT NULL CHECK (Categoria IN (
        'Pollo entero',
        'Corte de pollo',
        'Gallina',
        'Huevos',
        'Codorniz'
    )),
    UnidadMedida VARCHAR(20) NOT NULL CHECK (UnidadMedida IN ('Kilo', 'Unidad', 'Java', 'Bolsa')),
    PrecioUnitario DECIMAL(7,2) NOT NULL CHECK (PrecioUnitario > 0),
    Estado CHAR(1) NOT NULL DEFAULT 'A' CHECK (Estado IN ('A','I')),
    CONSTRAINT UQ_NombreProducto UNIQUE (NombreProducto)
);
GO

-- clientes
-- Recrear la tabla con el índice filtrado
CREATE TABLE Clientes (
    IdCliente INT IDENTITY(1,1) PRIMARY KEY,
    NombreCliente VARCHAR(80) NOT NULL,
    TipoCliente VARCHAR(30) NOT NULL CHECK (TipoCliente IN (
        'Publico',
        'Restaurante',
        'Polleria',
        'Bodega',
        'Mercado'
    )),
    Celular VARCHAR(9) NULL CHECK (Celular LIKE '[9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
    RUC VARCHAR(11) NULL CHECK (LEN(RUC) = 11),
    Estado CHAR(1) NOT NULL DEFAULT 'A' CHECK (Estado IN ('A','I'))
);
GO

-- Crear el índice único filtrado
CREATE UNIQUE INDEX IX_Clientes_RUC_Unique 
ON Clientes(RUC) 
WHERE RUC IS NOT NULL;
GO










-- ventass
CREATE TABLE Ventas (
    IdVenta INT IDENTITY(1,1) PRIMARY KEY,
    IdCliente INT NULL REFERENCES Clientes(IdCliente),
    FechaVenta DATETIME NOT NULL DEFAULT GETDATE(),
    MontoTotal DECIMAL(8,2) NOT NULL CHECK (MontoTotal >= 0),
    IdUsuario INT NOT NULL REFERENCES Usuarios(IdUsuario),
    Estado CHAR(1) NOT NULL DEFAULT 'A' CHECK (Estado IN ('A','I'))
);
GO

-- detaLLE COMPAR DE POLLOS
CREATE TABLE ComprasPollos (
    IdCompra INT IDENTITY(1,1) PRIMARY KEY,
    FechaCompra DATE NOT NULL,
    CantidadPollos INT NOT NULL CHECK (CantidadPollos > 0),
    PesoTotal DECIMAL(7,2) NOT NULL CHECK (PesoTotal > 0),
    CostoTotal DECIMAL(8,2) NOT NULL CHECK (CostoTotal >= 0),
    Proveedor VARCHAR(80) NULL,
    IdUsuario INT NOT NULL REFERENCES Usuarios(IdUsuario)
);
GO

-- TABLA DETALLE VENTAS 
CREATE TABLE DetalleVenta (
    IdDetalle INT IDENTITY(1,1) PRIMARY KEY,
    IdVenta INT NOT NULL REFERENCES Ventas(IdVenta),
    IdProducto INT NOT NULL REFERENCES Productos(IdProducto),
    Cantidad DECIMAL(7,2) NOT NULL CHECK (Cantidad > 0),
    PrecioUnitario DECIMAL(7,2) NOT NULL CHECK (PrecioUnitario > 0),
    SubTotal DECIMAL(8,2) NOT NULL CHECK (SubTotal >= 0)
);
GO


