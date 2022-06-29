using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1 = 0;
            double n2 = 0;
            double resultado = 0;

            if (txtBase.Text != "" && txtBase.Text != "")
            {
                n1 = double.Parse(txtBase.Text);
                n2 = double.Parse(txtBase.Text);


                resultado = n1 * n2 / 2;

                lblResultado.Text = resultado.ToString();


            } 

        }
    }
}
