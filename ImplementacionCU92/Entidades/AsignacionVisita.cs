//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImplementacionCU92.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class AsignacionVisita
    {
        public Nullable<System.DateTime> fechaHoraFin { get; set; }
        public Nullable<System.DateTime> fechaHoraInicio { get; set; }
        public int id_asignacionVisita { get; set; }
        public Nullable<int> numeroReserva { get; set; }
        public Nullable<int> id_empleado { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual ReservaVisita ReservaVisita { get; set; }
    }
}
