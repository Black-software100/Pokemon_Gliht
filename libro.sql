create database DBSISTEMA_VENTA;
go
use DBSISTEMA_VENTA;
go
CREATE TABLE ROL (
IdRol int primary key identity,
Descripcion varchar(50),
FechaRegistro datetime default getdate()
);
go
CREATE TABLE PERMISO (
IdPermisos int primary key identity,
IdRol int references ROL(IdRol),
NombreMenu varchar(100),
FechaRegistro datetime default getdate(),
foreign key (IdRol) references Rol(IdRol)
);
go
CREATE TABLE PROVERDOR (
IdProveedor int primary key identity,
Documento varchar(50),
RazonSocial varchar(50),
Correo  varchar(50),
Telefono varchar(50),
Estado bit,
FechaRegistro datetime default getdate()
);
go
CREATE TABLE CLIENTE (
IdCliente int primary key identity,
Documento varchar(50),
NombreCompleto varchar(50),
Correo  varchar(50),
Telefono varchar(50),
Estado bit,
FechaRegistro datetime default getdate()
);
go
CREATE TABLE USUARIO (
IdUsuario int primary key identity,
Documento varchar(50),
NombreCompleto varchar(50),
Correo  varchar(50),
Clave  varchar(50),
IdRol int,
Estado bit,
FechaRegistro datetime default getdate(),
foreign key (IdRol) references Rol(IdRol)
);
go
CREATE TABLE CATEGORIA (
IdCategoria int primary key identity,
Descripcion varchar(100),
Estado bit,
FechaRegistro datetime default getdate()
);
go
CREATE TABLE PRODUCTO (
IdProducto int primary key identity,
Codigo varchar(50),
Nombre varchar(50),
Descripcion varchar(50),
IdCategoria int references CATEGORIA(IdCategoria) ,
Stock int not null default 0,
PrecioCompra decimal(10,2) default 0,
PrecioVenta decimal(10,2) default 0,
Estado bit,
FechaRegistro datetime default getdate(),
);
go
CREATE TABLE COMPRA (
IdCompra int primary key identity,
IdUsuario int references USUARIO(IdUsuario),
IdProveedor int references PROVERDOR(IdProveedor),
TipoDocumento varchar(50),
NumeroDocumento varchar(50),
MontoTotal decimal(10,2),
FechaRegistro datetime default getdate(),
);  
go
CREATE TABLE DETALLE_COMPRA (
IdDetalleCompra int primary key identity,
IdCompra int references COMPRA(IdCompra),
IdProducto int references PRODUCTO(IdProducto),
PrecioCompra decimal(10,2) default 0,
PrecioVenta decimal(10,2) default 0,
Cantidad int,
MontoTotal decimal(10,2),
FechaRegistro datetime default getdate(),

);
go
CREATE TABLE VENTA (
IdVenta int primary key identity,
IdUsuario int references USUARIO(IdUsuario),
TipoDocumento varchar(50),
NumeroDocumento varchar(50),
DocumentoCliente varchar(50),
NombreCliente varchar(100),
MontoPago decimal(10,2),
MotoCambio decimal(10,2),
MontoTotal decimal(10,2),
FechaRegistro datetime default getdate(),
);
go
CREATE TABLE DETALLE_VENTA (
IdDetalleVenta int primary key identity,
IdVenta int references VENTA(IdVenta),
IdProducto int references PRODUCTO(IdProducto),
PrecioVENTA decimal(10,2),
Cantidad int,
SubTotal decimal(10,2),
FechaRegistro datetime default getdate(), 
);

INSERT INTO ROL (Descripcion) VALUES ('ADMINISTRADOR');

INSERT INTO ROL (Descripcion) VALUES ('EMPLEADOS');

SELECT * FROM ROL

INSERT INTO USUARIO(Documento,NombreCompleto,Correo,Clave,IdRol,Estado) VALUES ('1001','juan Estado','juanto@gmail.com','123',1,1);

INSERT INTO USUARIO(Documento,NombreCompleto,Correo,Clave,IdRol,Estado) VALUES ('1002','juan Torres','juanes@gmail.com','123',2,1);

SELECT IdUsuario,Documento,NombreCompleto,Clave,Correo,Estado FROM USUARIO;

INSERT INTO PERMISO(IdRol,NombreMenu) VALUES 
(1,'MnuUsuarios'),
(1,'MnuMantenedor'),
(1,'MnuVentas'),
(1,'MnuCompras'),
(1,'MnuClientes'),
(1,'MnuProveedores'),
(1,'MnuClientes'),
(1,'MnuProveedores'),
(1,'MnuReportes'),
(1,'MnuAcercaDe');

INSERT INTO PERMISO(IdRol,NombreMenu) VALUES 
(2,'MnuVentas'),
(2,'MnuCompras'),
(2,'MnuClientes'),
(2,'MnuProveedores'),
(2,'MnuAcercaDe');

select u.IdUsuario,u.Documento,u.NombreCompleto,u.Correo,u.Clave,u.Estado,r.IdRol,r.Descripcion from USUARIO u inner join ROL r on r.IdRol = u.IdRol