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
    
    public partial class Emoticono
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Emoticono()
        {
            this.Opinions = new HashSet<Opinion>();
        }
    
        public int Id { get; set; }
        public string Emoji { get; set; }
        public bool Eliminado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Opinion> Opinions { get; set; }
    }
}
