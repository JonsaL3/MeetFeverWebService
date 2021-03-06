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
    
    public partial class Experiencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Experiencia()
        {
            this.Entrada_Persona = new HashSet<Entrada_Persona>();
            this.Opinions = new HashSet<Opinion>();
        }
    
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime Fecha_Celebracion { get; set; }
        public decimal Precio { get; set; }
        public int Aforo { get; set; }
        public string Foto { get; set; }
        public int Id_Empresa { get; set; }
        public bool Eliminado { get; set; }
        public bool Borrado_Solicitado { get; set; }
    
        public virtual Empresa Empresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrada_Persona> Entrada_Persona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Opinion> Opinions { get; set; }
    }
}
