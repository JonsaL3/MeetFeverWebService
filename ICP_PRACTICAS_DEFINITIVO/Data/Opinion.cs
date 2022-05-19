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
    
    public partial class Opinion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Opinion()
        {
            this.MeGustas = new HashSet<MeGusta>();
        }
    
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime Fecha { get; set; }
        public Nullable<int> Emoticono { get; set; }
        public int Id_Autor { get; set; }
        public Nullable<int> Id_Empresa { get; set; }
        public Nullable<int> Id_Experiencia { get; set; }
        public bool Eliminado { get; set; }
    
        public virtual Emoticono Emoticono1 { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual Experiencia Experiencia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MeGusta> MeGustas { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
