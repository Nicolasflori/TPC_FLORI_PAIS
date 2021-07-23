CREATE DATABASE PAIS_FLORI_DB
GO
USE PAIS_FLORI_DB
GO
CREATE TABLE Colores(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
Descripcion VARCHAR(100) NOT NULL,
Baja bit not null default(0)
)
GO
CREATE TABLE Talles(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
Descripcion VARCHAR(100) NOT NULL,
Baja bit not null default(0)
)
GO
CREATE TABLE Categorias(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
Descripcion VARCHAR(100) NOT NULL,
Precio money not null
)
GO
CREATE TABLE Estampados(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
Descripcion VARCHAR(100) NOT NULL,
Imagen varchar (100),
Precio money not null,
Baja bit not null default(0)
)
GO
CREATE TABLE ProductoPreCargado(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
IDEstampado INT null foreign key  references Estampados(ID),
IDColor INT  not null foreign key  references Colores(ID),
IDCategoria INT not null foreign key  references Categorias(ID),
FechaCarga datetime not null default(GETDATE()),
Baja bit not null default(0)
)
GO
Create Table CostosDeEnvio(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
Zona INT NOT NULL,
Precio money not null,
Baja bit not null default(0)
)
GO
Create Table Provincias(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
IDCostoEnvio INT  not null foreign key  references CostosDeEnvio(ID),
Descripcion VARCHAR(100) NOT NULL,
Baja bit not null default(0)
)
GO
Create Table Ciudades(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
IDProvincia INT not  null foreign key  references Provincias(ID),
Descripcion VARCHAR(100) NOT NULL,
Baja bit not null default(0)
)
GO
Create Table Direcciones(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
IDCiudad INT not null foreign key  references Ciudades(ID),
IDProvincia INT not  null foreign key  references Provincias(ID),
Calle varchar(100) not null,
Numeracion int not null,
Depto varchar(10) null,
Piso varchar(10) null,
CP varchar(4) null,
Baja bit not null default(0)
)
GO
Create Table Permisos(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
Descripcion varchar(100) 
)
GO
Create Table Usuarios(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
Usuario varchar(12) not null unique,
Contraseña varchar(10) not null,
Nombre varchar(50) not null,
Apellido varchar(100) not null,
DNI INT NULL,
Email varchar(50) null,
Telefono varchar(50) null,
IDDireccion int foreign key references Direcciones(ID),
IDPermiso int foreign key references Permisos(ID) DEFAULT 2,
Baja bit not null default(0)
)
GO
Create Table Carrito(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
IDUsuario int  not null foreign key references Usuarios(ID),
SubTotalProductos money not null,
CostoDeEnvio money not null,
Total money not null,
Estado varchar(50)not null check(Estado='En Proceso' or Estado='Pagado' or Estado= 'Entregado' or Estado= 'Cancelado'),
FormaPago varchar(50) not null,
Fecha date not null default(GETDATE()),
FechaEntrega date check(FechaEntrega>=GETDATE())
)
GO
Create Table CarritoDet(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
IDEstampado INT null foreign key  references Estampados(ID),
IDColor INT  not null foreign key  references Colores(ID),
IDCategoria INT not null foreign key  references Categorias(ID),
IDTalle INT not null foreign key  references Talles(ID),
Precio money not null,
Cantidad int not null,
PrecioxProducto money not null,
IDCarrito int not null foreign key references Carrito(ID)
)