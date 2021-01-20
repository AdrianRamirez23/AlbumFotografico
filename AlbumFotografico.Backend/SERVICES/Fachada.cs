using AlbumFotografico.Backend.BSN;
using AlbumFotografico.Backend.DAO.Maestros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumFotografico.Backend.SERVICES
{
    public class Fachada
    {
        public string CrearEventos(Eventos even)
        {
            return new EventosBL().CrearEventos(even);
        }
    }
}
