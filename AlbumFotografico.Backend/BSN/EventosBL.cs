using AlbumFotografico.Backend.DAO.Maestros;
using AlbumFotografico.Backend.DAO.Procesos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumFotografico.Backend.BSN
{
    internal class EventosBL
    {
        internal string CrearEventos(Eventos even)
        {
            return new EventosDAO().CrearEvento(even);
        }
        internal List<Eventos> ListaEventos()
        {
            return new EventosDAO().ListaEventos();
        }
        internal Eventos BuscarEventos(string Descripcion)
        {
            return new EventosDAO().BuscarEvento(Descripcion);
        }
        internal string EditarrEventos(Eventos even)
        {
            return new EventosDAO().EditarEvento(even);
        }
    }
}
