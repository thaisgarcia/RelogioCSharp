using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relógio
{
    public partial class FrmRelógio : Form
    {
        public FrmRelógio()
        {
            InitializeComponent();
        }

        private void FrmRelógio_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblRelogio.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToLongTimeString();
        }

        private void lblRelogio_Click(object sender, EventArgs e)
        {

        }
    }
}
