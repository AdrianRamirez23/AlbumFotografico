using AlbumFotografico.Backend.DAO.Maestros;
using AlbumFotografico.Backend.DAO.Procesos;
using System;
using System.Collections.Generic;
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
    }
}
