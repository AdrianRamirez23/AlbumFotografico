using AlbumFotografico.Backend.DAO.Maestros;
using AlbumFotografico.Backend.SERVICES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumFotografico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        private string ImagenSCR;
        private void Form1_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void llenarGrid()
        {
            try
            {
                dataGriLeer.DataSource = new Fachada().ListarEventos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSubir_Click(object sender, EventArgs e)
        {
            try
            {
               if(openFileDialog1.ShowDialog()== DialogResult.OK)
                {
                    ImagenSCR = openFileDialog1.FileName;
                    pcGuard.Image = Image.FromFile(ImagenSCR);
                }
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCamActIm_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGuardarEve_Click(object sender, EventArgs e)
        {
            if (txtDescLugGar.Text == "")
            {
                MessageBox.Show("Por favor ingresar descripción del lugar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (cmbLugares.SelectedText == "Seleccione el lugar")
            {
                MessageBox.Show("Por favor seleccione el lugar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtDescIm.Text == "") {
                MessageBox.Show("Por favor ingresar descripción de la imagen", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (pcGuard.ImageLocation == "")
            {
                MessageBox.Show("Por favor inserte una imágen", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtDescLugGar.Text.Length > 200)
            {
                MessageBox.Show("El tamaño máximo de la descripción del lugar es de 200 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDescIm.Text.Length > 200)
            {
                MessageBox.Show("El tamaño máximo de la descripción de la imagen es de 200 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Eventos even = new Eventos();
                string Fecha = datEvenGuar.Value.ToString();
                string[] fechasDiv = Fecha.Split('/');
                string[] año = fechasDiv[2].Split(' ');
                even.fechaEvento = año[0] + "-" + fechasDiv[1] + "-" + fechasDiv[0];
                
                even.lugarEvento = cmbLugares.SelectedItem.ToString();
                even.descricpionLugarEvento = txtDescLugGar.Text;
                even.descripcionImagen = txtDescLugGar.Text;
                string editImRut = ImagenSCR.Replace("\\","\\\\");
                even.dirImagen = editImRut;

                string respuesta = new Fachada().CrearEventos(even);

                if (respuesta == "")
                {
                    MessageBox.Show(respuesta, "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(respuesta, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtDescIm.Text = string.Empty;
                txtDescLugGar.Text = string.Empty;
                cmbLugares.Text = "Seleccione Lugar";
                pcGuard.Image = null;
                datEvenGuar.Value = DateTime.Now;
                llenarGrid();

            }
        }

      
    }
}
