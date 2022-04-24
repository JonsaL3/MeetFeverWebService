﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ICP_PRACTICAS_DEFINITIVO.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MeetFeverDatos : DbContext
    {
        public MeetFeverDatos()
            : base("name=MeetFeverDatos")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Emoticono> Emoticonoes { get; set; }
        public virtual DbSet<Empleado> Empleadoes { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Entrada_Persona> Entrada_Persona { get; set; }
        public virtual DbSet<Experiencia> Experiencias { get; set; }
        public virtual DbSet<MeGusta> MeGustas { get; set; }
        public virtual DbSet<Opinion> Opinions { get; set; }
        public virtual DbSet<Perfil> Perfils { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Seguidor_Seguido> Seguidor_Seguido { get; set; }
        public virtual DbSet<Sexo> Sexoes { get; set; }
        public virtual DbSet<SIDA_EMPRESA_PRUEBA_GONZALO> SIDA_EMPRESA_PRUEBA_GONZALO { get; set; }
        public virtual DbSet<SIDA_PERSONA_PRUEBA_GONZALO> SIDA_PERSONA_PRUEBA_GONZALO { get; set; }
        public virtual DbSet<SIDA_USUARIO_PRUEBA_GONZALO> SIDA_USUARIO_PRUEBA_GONZALO { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Registro> Registroes { get; set; }
    
        public virtual int PA_Borrado_Logico_Emoticono_Por_ID(string jSON_IN, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var jSON_INParameter = jSON_IN != null ?
                new ObjectParameter("JSON_IN", jSON_IN) :
                new ObjectParameter("JSON_IN", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_Borrado_Logico_Emoticono_Por_ID", jSON_INParameter, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_Borrado_Logico_Empleado_Por_ID(string jSON_IN, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var jSON_INParameter = jSON_IN != null ?
                new ObjectParameter("JSON_IN", jSON_IN) :
                new ObjectParameter("JSON_IN", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_Borrado_Logico_Empleado_Por_ID", jSON_INParameter, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_Borrado_Logico_Empresa_Por_ID(string jSON_IN, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var jSON_INParameter = jSON_IN != null ?
                new ObjectParameter("JSON_IN", jSON_IN) :
                new ObjectParameter("JSON_IN", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_Borrado_Logico_Empresa_Por_ID", jSON_INParameter, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_Borrado_Logico_Experiencia_Por_ID(string jSON_IN, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var jSON_INParameter = jSON_IN != null ?
                new ObjectParameter("JSON_IN", jSON_IN) :
                new ObjectParameter("JSON_IN", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_Borrado_Logico_Experiencia_Por_ID", jSON_INParameter, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_Borrado_logico_MeGusta_Por_ID(string jSON_IN, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var jSON_INParameter = jSON_IN != null ?
                new ObjectParameter("JSON_IN", jSON_IN) :
                new ObjectParameter("JSON_IN", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_Borrado_logico_MeGusta_Por_ID", jSON_INParameter, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_Borrado_Logico_Opinion_Por_ID(string jSON_IN, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var jSON_INParameter = jSON_IN != null ?
                new ObjectParameter("JSON_IN", jSON_IN) :
                new ObjectParameter("JSON_IN", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_Borrado_Logico_Opinion_Por_ID", jSON_INParameter, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_Borrado_Logico_Perfil_Por_ID(string jSON_IN, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var jSON_INParameter = jSON_IN != null ?
                new ObjectParameter("JSON_IN", jSON_IN) :
                new ObjectParameter("JSON_IN", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_Borrado_Logico_Perfil_Por_ID", jSON_INParameter, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_Borrado_Logico_Persona_Por_ID(string jSON_IN, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var jSON_INParameter = jSON_IN != null ?
                new ObjectParameter("JSON_IN", jSON_IN) :
                new ObjectParameter("JSON_IN", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_Borrado_Logico_Persona_Por_ID", jSON_INParameter, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_Borrado_Logico_seguidor_Por_ID(string jSON_IN, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var jSON_INParameter = jSON_IN != null ?
                new ObjectParameter("JSON_IN", jSON_IN) :
                new ObjectParameter("JSON_IN", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_Borrado_Logico_seguidor_Por_ID", jSON_INParameter, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_Borrado_Logico_Sexo_Por_ID(string jSON_IN, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var jSON_INParameter = jSON_IN != null ?
                new ObjectParameter("JSON_IN", jSON_IN) :
                new ObjectParameter("JSON_IN", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_Borrado_Logico_Sexo_Por_ID", jSON_INParameter, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_Insertar_Registro_De_Error(string jSON_IN, ObjectParameter jSON_OUT, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var jSON_INParameter = jSON_IN != null ?
                new ObjectParameter("JSON_IN", jSON_IN) :
                new ObjectParameter("JSON_IN", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_Insertar_Registro_De_Error", jSON_INParameter, jSON_OUT, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_Obtener_Empresa_Por_ID(string jSON_IN, ObjectParameter jSON_OUT, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var jSON_INParameter = jSON_IN != null ?
                new ObjectParameter("JSON_IN", jSON_IN) :
                new ObjectParameter("JSON_IN", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_Obtener_Empresa_Por_ID", jSON_INParameter, jSON_OUT, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_Obtener_Persona_Por_ID(string jSON_IN, ObjectParameter jSON_OUT, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var jSON_INParameter = jSON_IN != null ?
                new ObjectParameter("JSON_IN", jSON_IN) :
                new ObjectParameter("JSON_IN", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_Obtener_Persona_Por_ID", jSON_INParameter, jSON_OUT, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_Obtener_Usuarios_Por_ID_Con_Fotos_Pruebas(string jSON_IN, ObjectParameter jSON_OUT, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var jSON_INParameter = jSON_IN != null ?
                new ObjectParameter("JSON_IN", jSON_IN) :
                new ObjectParameter("JSON_IN", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_Obtener_Usuarios_Por_ID_Con_Fotos_Pruebas", jSON_INParameter, jSON_OUT, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int PA_Obtener_Usuarios_Por_ID_Pruebas(string jSON_IN, ObjectParameter jSON_OUT, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var jSON_INParameter = jSON_IN != null ?
                new ObjectParameter("JSON_IN", jSON_IN) :
                new ObjectParameter("JSON_IN", typeof(string));
    
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_Obtener_Usuarios_Por_ID_Pruebas", jSON_INParameter, jSON_OUT, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int SIDA_PA_CHUNGO_GONZALO_EJEMPLO_ALBERTO(ObjectParameter jSON_OUT, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SIDA_PA_CHUNGO_GONZALO_EJEMPLO_ALBERTO", jSON_OUT, iNVOKERParameter, rETCODE, mENSAJE);
        }
    
        public virtual int SIDA_PA_OBTENER_TODAS_LAS_EMPRESAS(ObjectParameter jSON_OUT, Nullable<int> iNVOKER, ObjectParameter rETCODE, ObjectParameter mENSAJE)
        {
            var iNVOKERParameter = iNVOKER.HasValue ?
                new ObjectParameter("INVOKER", iNVOKER) :
                new ObjectParameter("INVOKER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SIDA_PA_OBTENER_TODAS_LAS_EMPRESAS", jSON_OUT, iNVOKERParameter, rETCODE, mENSAJE);
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
    }
}
