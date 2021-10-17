using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproductorMultimedia
{
    public partial class FomRproductor : Form
    {
        private string ruta;
        private string ruta1;

        public FomRproductor()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                ruta1 = ruta;
                Btnplay.Visible = true;
            }
            ruta = "";
        }

        private void Btnplay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ruta1;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            Btnplay.Visible=false;
        }
    }
}
