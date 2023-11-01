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
    public partial class FrmTotalinteres : Form
    {
        public delegate void pasarInteres(string interes);
        public event pasarInteres interesCompuesto;
        public FrmTotalinteres()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            interesCompuesto(CalcularIntereses());
            Close();
        }

        private string CalcularIntereses()
        {
            // Declaracion de variables
            double capital, razon, plazo;
            double interes, monto;

            capital = double.Parse(this.txtCapital.Text);
            razon = double.Parse(txtRazon.Text);
            plazo = double.Parse(txtPlazo.Text);

            monto = Math.Pow((1 + razon), plazo) * capital;
            interes = monto - capital;

            return Convert.ToString(interes);
        }
    }
}
