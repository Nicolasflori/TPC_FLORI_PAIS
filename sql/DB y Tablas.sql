CREATE DATABASE PAIS_FLORI_DB

CREATE TABLE Colores
(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
Descripcion VARCHAR(100) NOT NULL
)

CREATE TABLE Talles
(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
Descripcion VARCHAR(100) NOT NULL
)


CREATE TABLE Categorias(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
Descripcion VARCHAR(100) NOT NULL,
Precio money not null
)

CREATE TABLE Estampados (
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
Descripcion VARCHAR(100) NOT NULL,
Imagen varchar (100),
Precio money not null
)

CREATE TABLE ProductoPreCargado(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
IDEstampado INT null foreign key  references Estampados(ID),
IDColor INT  not null foreign key  references Colores(ID),
IDCategoria INT not null foreign key  references Categorias(ID),
FechaCarga datetime not null
)

Create Table CostosEnvio (
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
Zona INT NOT NULL,
Precio money not null)

Create Table Provincias(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
IDCostoEnvio INT  not null foreign key  references CostosEnvio(ID),
Descripcion VARCHAR(100) NOT NULL)

Create Table Ciudades(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
IDProvincia INT not  null foreign key  references Provincias(ID),
Descripcion VARCHAR(100) NOT NULL)

Create Table Direcciones(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
IDCiudad INT not null foreign key  references Ciudades(ID),
Calle varchar(100) not null,
Numeracion int not null,
Depto varchar(10) null,
Piso varchar(10) null,
CP varchar(50) null

)
Create Table Permisos (
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
Descripcion varchar(100) )


Create Table Usuarios (
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
Usuario varchar(10) not null unique,
Contraseña varchar(10) not null,
Nombre varchar(50) not null,
Apellido varchar(100) not null,
DNI INT NOT NULL unique,
Email varchar(50) not null,
Telefono varchar(50) not null,
IDDireccion int foreign key references Direcciones(ID),
IDPermiso int foreign key references Permisos(ID),
Baja bit not null default(0))

Create Table Pedidos(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
IDUsuario int  not null foreign key references Usuarios(ID),
Total money not null,
Fecha datetime not null,
Estados varchar(12) check (Estados in ('Borrador','Pagado','Entregado')),
FechaEntrega datetime not null,
FormaPago varchar(100) not null check (FormaPago in ('Tarjeta de Credito','Tarjeta de Debito','Trasferencia','Mercado Pago'))
)
Create Table PedidosDet(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
IDEstampado INT null foreign key  references Estampados(ID),
IDColor INT  not null foreign key  references Colores(ID),
IDCategoria INT not null foreign key  references Categorias(ID),
IDTalle INT not null foreign key  references Categorias(ID),
Precio money not null,
Cantidad int not null check(cantidad>0),
IDPedido INT not null foreign key  references Pedidos(ID)
)
