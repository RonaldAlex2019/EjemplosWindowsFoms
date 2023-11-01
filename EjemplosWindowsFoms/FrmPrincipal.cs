using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemplosWindowsFoms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void tabControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contenedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTabControl frmTabControl = new FrmTabControl();
            frmTabControl.ShowDialog();
        }

        private void calculosInteresCompuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInteres frmInteres = new FrmInteres();
            frmInteres.ShowDialog();
        }
    }
}
