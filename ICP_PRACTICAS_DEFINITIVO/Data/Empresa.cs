//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empresa()
        {
            this.Empleadoes = new HashSet<Empleado>();
            this.Experiencias = new HashSet<Experiencia>();
            this.Opinions = new HashSet<Opinion>();
        }
    
        public int Id { get; set; }
        public string Nombre_Empresa { get; set; }
        public string Cif { get; set; }
        public string Direccion_Facturacion { get; set; }
        public string Direccion_Fiscal { get; set; }
        public string Nombre_Persona { get; set; }
        public string Apellido1_Persona { get; set; }
        public string Apellido2_Persona { get; set; }
        public string Dni_Persona { get; set; }
        public Nullable<bool> Eliminado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleado> Empleadoes { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Experiencia> Experiencias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Opinion> Opinions { get; set; }
    }
}
