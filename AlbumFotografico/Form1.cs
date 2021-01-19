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

    
        private void btnSubir_Click(object sender, EventArgs e)
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

       
    }
}
