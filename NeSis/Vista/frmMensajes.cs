using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmMensajes : Form 
    {
        Timer reloj = new Timer();

        public frmMensajes()
        {
            InitializeComponent();

            reloj.Interval = 1000;
            reloj.Enabled = true;
            reloj.Tick += reloj_Tick;
            reloj.Start();
        }
        private void reloj_Tick(object sender, EventArgs e)
        {
            reloj.Stop();
            this.Close();
            this.Dispose();

            reloj.Dispose();
        }

        private void FrmMensajes_Load(object sender, EventArgs e)
        {
            
        }

        private void PctClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptarMensaje_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
