using AlbumFotografico.Backend.DAO.Maestros;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumFotografico.Backend.DAO.Procesos
{
    internal class EventosDAO
    {
        private string MYSQLCon = "datasource=127.0.0.1;port=3306;username=root;password=root;database=directoriotelefonico_albumfotografico";

        internal string CrearEvento(Eventos even)
        {
            try
            {
                string respuesta = null;
                MySqlConnection con = new MySqlConnection(MYSQLCon);
                MySqlCommand command = new MySqlCommand("call DirectorioTelefonico_Eventos_CRUD (1, '" + even.fechaEvento + "','" + even.lugarEvento + "','" + even.descricpionLugarEvento + "','" + even.descripcionImagen + "','" + even.dirImagen + "')", con);
                con.Open();

                MySqlDataReader myRd = command.ExecuteReader();

                while (myRd.Read())
                {
                    respuesta = myRd.GetString(0);
                }
                return respuesta;
            }
            catch (Exception e)
            {

                return e.Message;
            }
            
        }

        internal List<Eventos> ListaEventos()
        {
            try
            {
                List<Eventos> lisEve = new List<Eventos>();
                MySqlConnection con = new MySqlConnection(MYSQLCon);
                MySqlCommand command = new MySqlCommand("call DirectorioTelefonico_Eventos_CRUD (2, NOW(),'','','','');", con);
                con.Open();
                MySqlDataReader myRd = command.ExecuteReader();
                while (myRd.Read())
                {
                    Eventos eve = new Eventos();
                    eve.fechaEvento = myRd.GetString(0);
                    eve.lugarEvento = myRd.GetString(1);
                    eve.descricpionLugarEvento = myRd.GetString(2);
                    eve.descripcionImagen = myRd.GetString(3);
                    eve.dirImagen = myRd.GetString(4);
                    lisEve.Add(eve);
                }
                return lisEve;

            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
