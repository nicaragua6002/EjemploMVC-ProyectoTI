//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EjemploMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Valoracion
    {
        public int Id { get; set; }
        public int Puntuacion { get; set; }
        public int TareaId { get; set; }
        public int UsuarioId { get; set; }
    
        public virtual Tarea Tarea { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
