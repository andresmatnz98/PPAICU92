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
    
    public partial class ReservaVisita
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReservaVisita()
        {
            this.AsignacionVisita = new HashSet<AsignacionVisita>();
            this.CambioEstado = new HashSet<CambioEstado>();
            this.Exposicion = new HashSet<Exposicion>();
        }
    
        public int numeroReserva { get; set; }
        public int cantidadAlumnos { get; set; }
        public int cantidadAlumnosConfirmada { get; set; }
        public System.TimeSpan duracionEstimada { get; set; }
        public Nullable<System.DateTime> fechaHoraCreacion { get; set; }
        public Nullable<System.DateTime> fechaHoraReserva { get; set; }
        public Nullable<System.TimeSpan> horaFinReal { get; set; }
        public Nullable<System.TimeSpan> horaInicioReal { get; set; }
        public Nullable<int> id_escuela { get; set; }
        public Nullable<int> id_sede { get; set; }
        public Nullable<int> id_empleado { get; set; }
        public Nullable<int> id_asignacionGuia { get; set; }
        public Nullable<int> id_exposicion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AsignacionVisita> AsignacionVisita { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CambioEstado> CambioEstado { get; set; }
        public virtual Escuela Escuela { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exposicion> Exposicion { get; set; }
    }
}
