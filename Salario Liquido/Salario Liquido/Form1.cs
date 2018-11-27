using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salario_Liquido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtPlanSaude.Clear();
            txtSalario.Clear();
            txtResultado.Clear();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float bruto = float.Parse(txtSalario.Text);
            float planoSaude = float.Parse(txtPlanSaude.Text);
            float salario, salario2, salarioFinal;

            if (bruto <= 1693.72)
            {

                salario = (bruto * 8 / 100);
                if (rbContruibuSocialSim.Checked)​
                {​
                    salario2 = (bruto * 2 / 100);​
                    salarioFinal = bruto - salario - salario2 - planoSaude;​
                }​
                else​
                {​
                    ​
                    salarioFinal = bruto - salario - planoSaude;​
                }​

            }
            else if (bruto < 2822.91)
            {

                salario = (bruto * 9 / 100);
                if (rbContruibuSocialSim.Checked)​
                {​
                    salario2 = (bruto * 2 / 100);​
                    salarioFinal = bruto - salario - salario2 - planoSaude;​
                }​
                else​
                {​
                    ​
                    salarioFinal = bruto - salario - planoSaude;​
                }​
            }
            else if (bruto < 5645.80)
            {
                salario = (bruto * 11 / 100);
                if (rbContruibuSocialSim.Checked)​
                {​
                    salario2 = (bruto * 2 / 100);​
                    salarioFinal = bruto - salario - salario2 - planoSaude;​
                }​
                else​
                {​
                    ​
                    salarioFinal = bruto - salario - planoSaude;​
                }​
            }
            else
            {
                bruto = (float)5645.80;

                salario = (bruto * 11 / 100);
                if (rbContruibuSocialSim.Checked)​
                {​
                    salario2 = (bruto * 2 / 100);​
                    salarioFinal = bruto - salario - salario2 - planoSaude;​
                }​
                else​
                {​
                    ​
                    salarioFinal = bruto - salario - planoSaude;​
                }​

            }



            txtResultado.Text = txtNome.Text + " Seu salario final é de : " + Convert.ToString(salarioFinal);




        }
    }
}
