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
    
    public partial class SIDA_USUARIO_PRUEBA_GONZALO
    {
        public int id { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }
        public string nickname { get; set; }
    
        public virtual SIDA_EMPRESA_PRUEBA_GONZALO SIDA_EMPRESA_PRUEBA_GONZALO { get; set; }
        public virtual SIDA_PERSONA_PRUEBA_GONZALO SIDA_PERSONA_PRUEBA_GONZALO { get; set; }
    }
}