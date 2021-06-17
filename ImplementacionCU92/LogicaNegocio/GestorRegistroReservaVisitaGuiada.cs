using ImplementacionCU92.Entidades;
using ImplementacionCU92.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementacionCU92.LogicaNegocio
{
    class GestorRegistroReservaVisitaGuiada
    {

      private  PantallaEscuela pantalla;
        private string escuelaSeleccionada;
        private int cantidadVisitantes;
        private string sedeSeleccionada;


        public void tomarOpcionRegReservaVisita(Form pantalla)
        { 
            
            this.pantalla = (PantallaEscuela)pantalla;
            buscarEscuelas();
            
        }

        public void tomarEscuela(string nombreEscuela)

        {
            escuelaSeleccionada = nombreEscuela;
            pantalla.solicitarCantidadVisitantes();

        }

        public void tomarCantidadVisitantes(int numeroVisitante)
        {
            cantidadVisitantes = numeroVisitante;
            buscarSedes();
        }


        public void buscarSedes()
        {
            Sede oSede = new Sede();
            string[] nombresSede = oSede.mostrarNombres();
            pantalla.mostrarSedes(nombresSede);
                    

        }
        public void tomarSede(string nombreSede)
        {
            sedeSeleccionada = nombreSede;
            buscarTipoVisita();
        }
        public void buscarTipoVisita()
        {
            TipoVisita oTipoVisita = new TipoVisita();
            string[] nombreTipoVisita = oTipoVisita.mostrarNombres();
            pantalla.mostrarTiposVisita(nombreTipoVisita);
        }
        public void buscarEscuelas()
        {
            
          Escuela oescuela = new Escuela();
          string[] nombres= oescuela.mostrarNombres();
          pantalla.mostrarEscuelas(nombres);

        }
        public void  tomarTipoVisita(string nombreTipoVisita)
        {

        }
    }
}
