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
        private string ImagenBBDD;
        private void Form1_Load(object sender, EventArgs e)
        {
            llenarGrid();
            btnCamActIm.Visible = false;
            txtDesLugAct.Enabled = false;
            txtDescLugEli.Enabled = false;
            txtDescrImEli.Enabled = false;
            txtLugEl.Enabled = false;
            dataTimeEli.Enabled = false;
            txtDesImDir.Enabled = false;
            txtLugarDir.Enabled = false;
            txtDesLugarDir.Enabled = false;
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
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ImagenSCR = openFileDialog1.FileName;
                    picImaAct.Image = Image.FromFile(ImagenSCR);
                }

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
                even.descripcionImagen = txtDescIm.Text;
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
                ImagenSCR = null;
            }
        }

        private void btnBuscarAct_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscarAct.Text == "")
                {
                    MessageBox.Show("Por favor Ingrese la descripcion del evento para editar", "!Alerta¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Eventos eve = new Eventos();
                    eve = new Fachada().BuscarEventos(txtBuscarAct.Text.Trim());

                    if (eve.lugarEvento == null)
                    {
                        MessageBox.Show("El Evento que buscas no existe", "!Alerta¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        lblFechaAct.Text = eve.fechaEvento;
                        picImaAct.Image=Image.FromFile(eve.dirImagen);
                        txtDescImgAct.Text = eve.descripcionImagen;
                        txtDesLugAct.Text = eve.descricpionLugarEvento;
                        btnCamActIm.Visible = true;
                        cmbLugarAct.SelectedText = eve.lugarEvento;
                        ImagenBBDD = eve.dirImagen;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "!Alerta¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (datatimeAct.Value < DateTime.Now)
            {
                MessageBox.Show("La fecha a actualizar no puede ser menor al dia de hoy", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (txtDescImgAct.Text == "")
            {
                MessageBox.Show("La descripcion de la Imagen es obligatoria", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (txtDesLugAct.Text == "")
            {
                MessageBox.Show("La descripcion del lugar es obligatoria", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (txtDescImgAct.Text.Length > 200)
            {
                MessageBox.Show("La descripcion de la Imagen no puede exceder los 200 caracteres", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (txtDesLugAct.Text.Length > 200)
            {
                MessageBox.Show("La descripcion del lugar no puede exceder los 200 caracteres", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (cmbLugarAct.Text==null)
            {
                MessageBox.Show("El lugar debe tener un valor válido", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Eventos even = new Eventos();
                string Fecha = datatimeAct.Value.ToString();
                string[] fechasDiv = Fecha.Split('/');
                string[] año = fechasDiv[2].Split(' ');
                even.fechaEvento = año[0] + "-" + fechasDiv[1] + "-" + fechasDiv[0];

                even.lugarEvento = cmbLugarAct.Text.ToString();
                even.descricpionLugarEvento = txtDesLugAct.Text;
                even.descripcionImagen = txtDescImgAct.Text;

                if (ImagenSCR == null)
                {
                    even.dirImagen = ImagenBBDD.Replace("\\", "\\\\"); ;
                }
                else
                {
                    string editImRut = ImagenSCR.Replace("\\", "\\\\");
                    even.dirImagen = editImRut;
                }
                string respuesta = new Fachada().EditarEventos(even);

                if (respuesta == "")
                {
                    MessageBox.Show(respuesta, "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(respuesta, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                lblFechaAct.Text = string.Empty;
                picImaAct.Image = null;
                txtDescImgAct.Text = string.Empty;
                txtDesLugAct.Text = string.Empty;
                btnCamActIm.Visible = false;
                cmbLugarAct.Text = "";
                datatimeAct.Value = DateTime.Now;
                txtBuscarAct.Text = "";
                llenarGrid();
                ImagenBBDD = null;
                ImagenSCR = null;
            }
        }

        private void btnBusEli_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBusEli.Text == "")
                {
                    MessageBox.Show("Por favor Ingrese la descripcion del evento para editar", "!Alerta¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Eventos eve = new Eventos();
                    eve = new Fachada().BuscarEventos(txtBuscarAct.Text.Trim());

                    if (eve.lugarEvento == null)
                    {
                        MessageBox.Show("El Evento que buscas no existe", "!Alerta¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dataTimeEli.Value = Convert.ToDateTime(eve.fechaEvento);
                        picEli.Image = Image.FromFile(eve.dirImagen);
                        txtDescrImEli.Text = eve.descripcionImagen;
                        txtDescLugEli.Text = eve.descricpionLugarEvento;
                        txtLugEl.Text = eve.lugarEvento;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "!Alerta¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = new Fachada().EliminarEventos(txtDescLugEli.Text);
                if (respuesta == "")
                {
                    MessageBox.Show(respuesta, "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(respuesta, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dataTimeEli.Value = DateTime.Now;
                picEli.Image = null;
                txtDescrImEli.Text = string.Empty;
                txtDescLugEli.Text = string.Empty;
                txtLugEl.Text = string.Empty;
                llenarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "!Alerta¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarDir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBusDir.Text == "")
                {
                    
                }
                else
                {
                    Eventos eve = new Eventos();

                    eve = new Fachada().BuscarEventos(txtBusDir.Text.Trim());

                    if (eve.lugarEvento == null)
                    {
                        MessageBox.Show("El evento que buscas no existe.", "!Alerta¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    { 
                        EventoBuscar formBuscar = new EventoBuscar();

                        formBuscar.txtFechEvn.Text = eve.fechaEvento;
                        formBuscar.txtResDesEve.Text = eve.descricpionLugarEvento;

                        DialogResult resul = new DialogResult();
                        resul = formBuscar.ShowDialog();

                        if (resul == DialogResult.OK)
                        {
                            txtDesImDir.Text = eve.descripcionImagen;
                            picDir.Image = Image.FromFile(eve.dirImagen);
                            txtDesLugarDir.Text = eve.descricpionLugarEvento;
                            txtLugarDir.Text = eve.lugarEvento;
                            txtEvenDir.Text = eve.lugarEvento;
                        }
                        
                    }
                    
                    
                }

                
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
