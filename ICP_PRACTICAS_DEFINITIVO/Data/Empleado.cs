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
    
    public partial class Empleado
    {
        public int Id { get; set; }
        public string Nick { get; set; }
        public string Constrasena { get; set; }
        public int Id_Empresa { get; set; }
        public int Id_Perfil { get; set; }
        public bool Eliminado { get; set; }
    
        public virtual Perfil Perfil { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
