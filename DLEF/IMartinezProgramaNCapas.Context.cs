﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLEF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class IMartinezProgramacionNCapasEntities1 : DbContext
    {
        public IMartinezProgramacionNCapasEntities1()
            : base("name=IMartinezProgramacionNCapasEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Colonia> Colonias { get; set; }
        public virtual DbSet<Direccion> Direccions { get; set; }
        public virtual DbSet<Estado> Estadoes { get; set; }
        public virtual DbSet<Municipio> Municipios { get; set; }
        public virtual DbSet<Pai> Pais { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Departamento> Departamentoes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Producto> Productoes { get; set; }
        public virtual DbSet<Proveedor> Proveedors { get; set; }
    
        public virtual int RolAdd(string nombre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RolAdd", nombreParameter);
        }
    
        public virtual int RolDelete(Nullable<int> idRol)
        {
            var idRolParameter = idRol.HasValue ?
                new ObjectParameter("IdRol", idRol) :
                new ObjectParameter("IdRol", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RolDelete", idRolParameter);
        }
    
        public virtual ObjectResult<RolGetAll_Result> RolGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RolGetAll_Result>("RolGetAll");
        }
    
        public virtual ObjectResult<RolGetById_Result> RolGetById(Nullable<int> idRol)
        {
            var idRolParameter = idRol.HasValue ?
                new ObjectParameter("IdRol", idRol) :
                new ObjectParameter("IdRol", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RolGetById_Result>("RolGetById", idRolParameter);
        }
    
        public virtual int RolUpdate(Nullable<int> idRol, string nombre)
        {
            var idRolParameter = idRol.HasValue ?
                new ObjectParameter("IdRol", idRol) :
                new ObjectParameter("IdRol", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RolUpdate", idRolParameter, nombreParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<ColoniaGetById_Result> ColoniaGetById(Nullable<int> idMunicipio)
        {
            var idMunicipioParameter = idMunicipio.HasValue ?
                new ObjectParameter("IdMunicipio", idMunicipio) :
                new ObjectParameter("IdMunicipio", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ColoniaGetById_Result>("ColoniaGetById", idMunicipioParameter);
        }
    
        public virtual ObjectResult<EstadoGetById_Result> EstadoGetById(Nullable<int> idPais)
        {
            var idPaisParameter = idPais.HasValue ?
                new ObjectParameter("IdPais", idPais) :
                new ObjectParameter("IdPais", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EstadoGetById_Result>("EstadoGetById", idPaisParameter);
        }
    
        public virtual ObjectResult<MunicipioGetById_Result> MunicipioGetById(Nullable<int> idEstado)
        {
            var idEstadoParameter = idEstado.HasValue ?
                new ObjectParameter("IdEstado", idEstado) :
                new ObjectParameter("IdEstado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MunicipioGetById_Result>("MunicipioGetById", idEstadoParameter);
        }
    
        public virtual ObjectResult<PaisGetAll_Result> PaisGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PaisGetAll_Result>("PaisGetAll");
        }
    
        public virtual ObjectResult<PaisGetById_Result> PaisGetById(Nullable<int> idPais)
        {
            var idPaisParameter = idPais.HasValue ?
                new ObjectParameter("IdPais", idPais) :
                new ObjectParameter("IdPais", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PaisGetById_Result>("PaisGetById", idPaisParameter);
        }
    
        public virtual int UsiarioAdd(string nombre, string apellidoPaterno, string apellidoMaterno, Nullable<System.DateTime> fechaNacimiento, Nullable<int> idRol, string username, string email, string sexo, string telefono, string password, string celular, string curp, string calle, string numeroInterior, string numeroExterior, Nullable<int> idColonia, string imagen, ObjectParameter filasAfectadas)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var idRolParameter = idRol.HasValue ?
                new ObjectParameter("IdRol", idRol) :
                new ObjectParameter("IdRol", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var celularParameter = celular != null ?
                new ObjectParameter("Celular", celular) :
                new ObjectParameter("Celular", typeof(string));
    
            var curpParameter = curp != null ?
                new ObjectParameter("Curp", curp) :
                new ObjectParameter("Curp", typeof(string));
    
            var calleParameter = calle != null ?
                new ObjectParameter("Calle", calle) :
                new ObjectParameter("Calle", typeof(string));
    
            var numeroInteriorParameter = numeroInterior != null ?
                new ObjectParameter("NumeroInterior", numeroInterior) :
                new ObjectParameter("NumeroInterior", typeof(string));
    
            var numeroExteriorParameter = numeroExterior != null ?
                new ObjectParameter("NumeroExterior", numeroExterior) :
                new ObjectParameter("NumeroExterior", typeof(string));
    
            var idColoniaParameter = idColonia.HasValue ?
                new ObjectParameter("IdColonia", idColonia) :
                new ObjectParameter("IdColonia", typeof(int));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsiarioAdd", nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, fechaNacimientoParameter, idRolParameter, usernameParameter, emailParameter, sexoParameter, telefonoParameter, passwordParameter, celularParameter, curpParameter, calleParameter, numeroInteriorParameter, numeroExteriorParameter, idColoniaParameter, imagenParameter, filasAfectadas);
        }
    
        public virtual int UsuarioDelete(Nullable<int> idUsuario, ObjectParameter filasAfectadas)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsuarioDelete", idUsuarioParameter, filasAfectadas);
        }
    
        public virtual ObjectResult<UsuarioGetById_Result> UsuarioGetById(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuarioGetById_Result>("UsuarioGetById", idUsuarioParameter);
        }
    
        public virtual int AreaAdd(string nombre, ObjectParameter filasAfectadas)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AreaAdd", nombreParameter, filasAfectadas);
        }
    
        public virtual int AreaDelete(Nullable<int> idArea, ObjectParameter filasAfectadas)
        {
            var idAreaParameter = idArea.HasValue ?
                new ObjectParameter("IdArea", idArea) :
                new ObjectParameter("IdArea", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AreaDelete", idAreaParameter, filasAfectadas);
        }
    
        public virtual ObjectResult<AreaGetById_Result> AreaGetById(Nullable<int> idArea)
        {
            var idAreaParameter = idArea.HasValue ?
                new ObjectParameter("IdArea", idArea) :
                new ObjectParameter("IdArea", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AreaGetById_Result>("AreaGetById", idAreaParameter);
        }
    
        public virtual int AreaUpdate(Nullable<int> idArea, string nombre, ObjectParameter filasAfectadas)
        {
            var idAreaParameter = idArea.HasValue ?
                new ObjectParameter("IdArea", idArea) :
                new ObjectParameter("IdArea", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AreaUpdate", idAreaParameter, nombreParameter, filasAfectadas);
        }
    
        public virtual int DeapartamentoAdd(string nombre, Nullable<int> idArea, ObjectParameter filasAfectadas)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var idAreaParameter = idArea.HasValue ?
                new ObjectParameter("IdArea", idArea) :
                new ObjectParameter("IdArea", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeapartamentoAdd", nombreParameter, idAreaParameter, filasAfectadas);
        }
    
        public virtual int DeapartamentoDelete(Nullable<int> idDepartamento, ObjectParameter filasAfectadas)
        {
            var idDepartamentoParameter = idDepartamento.HasValue ?
                new ObjectParameter("IdDepartamento", idDepartamento) :
                new ObjectParameter("IdDepartamento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeapartamentoDelete", idDepartamentoParameter, filasAfectadas);
        }
    
        public virtual int DeapartamentoUpdate(Nullable<int> idDepartamento, string nombre, Nullable<int> idArea, ObjectParameter filasAfectadas)
        {
            var idDepartamentoParameter = idDepartamento.HasValue ?
                new ObjectParameter("IdDepartamento", idDepartamento) :
                new ObjectParameter("IdDepartamento", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var idAreaParameter = idArea.HasValue ?
                new ObjectParameter("IdArea", idArea) :
                new ObjectParameter("IdArea", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeapartamentoUpdate", idDepartamentoParameter, nombreParameter, idAreaParameter, filasAfectadas);
        }
    
        public virtual ObjectResult<DepartamentoGetById_Result> DepartamentoGetById(Nullable<int> idDepartamento)
        {
            var idDepartamentoParameter = idDepartamento.HasValue ?
                new ObjectParameter("IdDepartamento", idDepartamento) :
                new ObjectParameter("IdDepartamento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DepartamentoGetById_Result>("DepartamentoGetById", idDepartamentoParameter);
        }
    
        public virtual int ChangeStatus(Nullable<int> idUsuario, Nullable<bool> status, ObjectParameter filasAfectadas)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ChangeStatus", idUsuarioParameter, statusParameter, filasAfectadas);
        }
    
        public virtual ObjectResult<UsuarioGetEmail_Result> UsuarioGetEmail(string email)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuarioGetEmail_Result>("UsuarioGetEmail", emailParameter);
        }
    
        public virtual ObjectResult<DeapartamentoGetByIdArea_Result> DeapartamentoGetByIdArea(Nullable<int> idArea)
        {
            var idAreaParameter = idArea.HasValue ?
                new ObjectParameter("IdArea", idArea) :
                new ObjectParameter("IdArea", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DeapartamentoGetByIdArea_Result>("DeapartamentoGetByIdArea", idAreaParameter);
        }
    
        public virtual int ProductoAdd(string nombre, Nullable<decimal> precioUnitario, Nullable<int> stock, Nullable<int> idProveedor, Nullable<int> idDepartamento, string descripcion, string imagen, ObjectParameter filasAfectadas)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var precioUnitarioParameter = precioUnitario.HasValue ?
                new ObjectParameter("PrecioUnitario", precioUnitario) :
                new ObjectParameter("PrecioUnitario", typeof(decimal));
    
            var stockParameter = stock.HasValue ?
                new ObjectParameter("Stock", stock) :
                new ObjectParameter("Stock", typeof(int));
    
            var idProveedorParameter = idProveedor.HasValue ?
                new ObjectParameter("IdProveedor", idProveedor) :
                new ObjectParameter("IdProveedor", typeof(int));
    
            var idDepartamentoParameter = idDepartamento.HasValue ?
                new ObjectParameter("IdDepartamento", idDepartamento) :
                new ObjectParameter("IdDepartamento", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProductoAdd", nombreParameter, precioUnitarioParameter, stockParameter, idProveedorParameter, idDepartamentoParameter, descripcionParameter, imagenParameter, filasAfectadas);
        }
    
        public virtual int ProductoDelete(Nullable<int> idProducto, ObjectParameter filasAfectadas)
        {
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("IdProducto", idProducto) :
                new ObjectParameter("IdProducto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProductoDelete", idProductoParameter, filasAfectadas);
        }
    
        public virtual ObjectResult<ProductoGeById_Result> ProductoGeById(Nullable<int> idProducto)
        {
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("IdProducto", idProducto) :
                new ObjectParameter("IdProducto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProductoGeById_Result>("ProductoGeById", idProductoParameter);
        }
    
        public virtual int ProductoGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProductoGetAll");
        }
    
        public virtual int ProveedorAdd(string nombre, string telefono, ObjectParameter filasAfectadas)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProveedorAdd", nombreParameter, telefonoParameter, filasAfectadas);
        }
    
        public virtual int ProveedorDelete(Nullable<int> idProveedor, ObjectParameter filasAfectadas)
        {
            var idProveedorParameter = idProveedor.HasValue ?
                new ObjectParameter("IdProveedor", idProveedor) :
                new ObjectParameter("IdProveedor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProveedorDelete", idProveedorParameter, filasAfectadas);
        }
    
        public virtual ObjectResult<ProveedorGetAll_Result> ProveedorGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProveedorGetAll_Result>("ProveedorGetAll");
        }
    
        public virtual ObjectResult<ProveedorGetById_Result> ProveedorGetById(Nullable<int> idProveedor)
        {
            var idProveedorParameter = idProveedor.HasValue ?
                new ObjectParameter("IdProveedor", idProveedor) :
                new ObjectParameter("IdProveedor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProveedorGetById_Result>("ProveedorGetById", idProveedorParameter);
        }
    
        public virtual int ProveedorUpdate(Nullable<int> idProveedor, string nombre, string telefono, ObjectParameter filasAfectadas)
        {
            var idProveedorParameter = idProveedor.HasValue ?
                new ObjectParameter("IdProveedor", idProveedor) :
                new ObjectParameter("IdProveedor", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProveedorUpdate", idProveedorParameter, nombreParameter, telefonoParameter, filasAfectadas);
        }
    
        public virtual int ProductoUpdate(Nullable<int> idProducto, string nombre, Nullable<decimal> precioUnitario, Nullable<int> stock, Nullable<int> idProveedor, Nullable<int> idDepartamento, string descripcion, string imagen, ObjectParameter filasAfectadas)
        {
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("IdProducto", idProducto) :
                new ObjectParameter("IdProducto", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var precioUnitarioParameter = precioUnitario.HasValue ?
                new ObjectParameter("PrecioUnitario", precioUnitario) :
                new ObjectParameter("PrecioUnitario", typeof(decimal));
    
            var stockParameter = stock.HasValue ?
                new ObjectParameter("Stock", stock) :
                new ObjectParameter("Stock", typeof(int));
    
            var idProveedorParameter = idProveedor.HasValue ?
                new ObjectParameter("IdProveedor", idProveedor) :
                new ObjectParameter("IdProveedor", typeof(int));
    
            var idDepartamentoParameter = idDepartamento.HasValue ?
                new ObjectParameter("IdDepartamento", idDepartamento) :
                new ObjectParameter("IdDepartamento", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProductoUpdate", idProductoParameter, nombreParameter, precioUnitarioParameter, stockParameter, idProveedorParameter, idDepartamentoParameter, descripcionParameter, imagenParameter, filasAfectadas);
        }
    
        public virtual int UsuarioUpdate(Nullable<int> idUsuario, string nombre, string apellidoPaterno, string apellidoMaterno, Nullable<System.DateTime> fechaNacimiento, Nullable<int> idRol, string username, string email, string sexo, string telefono, string password, string celular, string curp, string calle, string numeroInterior, string numeroExterior, Nullable<int> idColonia, string imagen, ObjectParameter filasAfectadas)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var idRolParameter = idRol.HasValue ?
                new ObjectParameter("IdRol", idRol) :
                new ObjectParameter("IdRol", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var celularParameter = celular != null ?
                new ObjectParameter("Celular", celular) :
                new ObjectParameter("Celular", typeof(string));
    
            var curpParameter = curp != null ?
                new ObjectParameter("Curp", curp) :
                new ObjectParameter("Curp", typeof(string));
    
            var calleParameter = calle != null ?
                new ObjectParameter("Calle", calle) :
                new ObjectParameter("Calle", typeof(string));
    
            var numeroInteriorParameter = numeroInterior != null ?
                new ObjectParameter("NumeroInterior", numeroInterior) :
                new ObjectParameter("NumeroInterior", typeof(string));
    
            var numeroExteriorParameter = numeroExterior != null ?
                new ObjectParameter("NumeroExterior", numeroExterior) :
                new ObjectParameter("NumeroExterior", typeof(string));
    
            var idColoniaParameter = idColonia.HasValue ?
                new ObjectParameter("IdColonia", idColonia) :
                new ObjectParameter("IdColonia", typeof(int));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsuarioUpdate", idUsuarioParameter, nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, fechaNacimientoParameter, idRolParameter, usernameParameter, emailParameter, sexoParameter, telefonoParameter, passwordParameter, celularParameter, curpParameter, calleParameter, numeroInteriorParameter, numeroExteriorParameter, idColoniaParameter, imagenParameter, filasAfectadas);
        }
    
        public virtual ObjectResult<DepartamentoGetAll1_Result> DepartamentoGetAll1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DepartamentoGetAll1_Result>("DepartamentoGetAll1");
        }
    
        public virtual ObjectResult<UsuariaGetAll_Result> UsuariaGetAll(string nombre, string apellidoPaterno)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuariaGetAll_Result>("UsuariaGetAll", nombreParameter, apellidoPaternoParameter);
        }
    
        public virtual ObjectResult<AreaGetAll_Result> AreaGetAll(string nombre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AreaGetAll_Result>("AreaGetAll", nombreParameter);
        }
    
        public virtual ObjectResult<ProductoGetByIdArea_Result> ProductoGetByIdArea(Nullable<int> idArea)
        {
            var idAreaParameter = idArea.HasValue ?
                new ObjectParameter("IdArea", idArea) :
                new ObjectParameter("IdArea", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProductoGetByIdArea_Result>("ProductoGetByIdArea", idAreaParameter);
        }
    
        public virtual ObjectResult<ProductoGetByIdDepartamento_Result> ProductoGetByIdDepartamento(Nullable<int> idDepartamento)
        {
            var idDepartamentoParameter = idDepartamento.HasValue ?
                new ObjectParameter("IdDepartamento", idDepartamento) :
                new ObjectParameter("IdDepartamento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProductoGetByIdDepartamento_Result>("ProductoGetByIdDepartamento", idDepartamentoParameter);
        }
    
        public virtual ObjectResult<ProductoGetAll1_Result> ProductoGetAll1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProductoGetAll1_Result>("ProductoGetAll1");
        }
    
        public virtual ObjectResult<DepartamentoGetAll_Result> DepartamentoGetAll(string nombre, Nullable<int> idArea)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var idAreaParameter = idArea.HasValue ?
                new ObjectParameter("IdArea", idArea) :
                new ObjectParameter("IdArea", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DepartamentoGetAll_Result>("DepartamentoGetAll", nombreParameter, idAreaParameter);
        }
    }
}