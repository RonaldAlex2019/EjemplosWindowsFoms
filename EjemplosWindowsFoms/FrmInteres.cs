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
    public partial class FrmInteres : Form
    {
        public FrmInteres()
        {
            InitializeComponent();
        }

        private void txtTotalinteres_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                FrmTotalinteres frmInteres = new FrmTotalinteres();
                frmInteres.interesCompuesto += new FrmTotalinteres.pasarInteres(Ejecutar);
                frmInteres.ShowDialog();
            }
        }

        private void Ejecutar(string interes)
        {
            txtTotalinteres.Text = interes;
        }
    }
}
