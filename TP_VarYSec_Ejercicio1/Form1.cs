using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_VarYSec_Ejercicio1
{
    public partial class fCirculo : Form
    {
        public fCirculo()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bPerimetro_Click(object sender, EventArgs e)
        {
            string radio = tRadio.Text;
            double radioNum = Convert.ToDouble(tRadio.Text);
            double perimetro;

            perimetro = 2 * (System.Math.PI) * radioNum;
            MessageBox.Show("Con el radio: " + radio + "\nEl perimetro es: " + perimetro + " cm/s, m/s, km/s");
        }

        private void bArea_Click(object sender, EventArgs e)
        {
            string radio = tRadio.Text;
            double radioNum = Convert.ToDouble(tRadio.Text);
            double area;

            area = (System.Math.PI) * (Math.Pow(radioNum, 2));
            MessageBox.Show("Con el radio: " + radio + "\nEl área es: " + area + " cm/s, m/s, km/s");
        }
    }
}
