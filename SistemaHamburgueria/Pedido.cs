using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHamburgueria
{
    public partial class Pedido : Form
    {
        Conexao con = new Conexao();
        public Pedido()
        {
            InitializeComponent();
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            cmbLanches.Items.Add("X-SALADA- R$ 30,00");
            cmbLanches.Items.Add("X-BACON- R$ 48,00");
            cmbLanches.Items.Add("COMBO DUPLO SALADA- R$70,00");
            cmbLanches.Items.Add("X-FRANGO JUNIOR- R$20,00");
            cmbLanches.Items.Add("X-FRANGO MEDIO- R$23,00");
            cmbLanches.Items.Add("CHEDDAR DUPLO- R$45,00");
            cmbLanches.Items.Add("X-SALADA- R$ 30,00");
            cmbAcompanhamentos.Items.Add("Batata Frita P- R$ 20,00");
            cmbAcompanhamentos.Items.Add("Batata Frita M- R$30,00");
            cmbAcompanhamentos.Items.Add("Batata Frita G- R$40,00");
            cmbAcompanhamentos.Items.Add("Nuggets P (4 unidades)- R$8,00");
            cmbAcompanhamentos.Items.Add("Nuggets M (6 unidades)- R$10,00");
            cmbAcompanhamentos.Items.Add("Nuggets G (10 unidades)- R$15,00");
            cmbAcompanhamentos.Items.Add("Onion Rings M - R$15,00");
            cmbAcompanhamentos.Items.Add("Onion Rings G- R$20,00");
            cmbBebidas.Items.Add("Coca-cola M- R$ 20,00");
            cmbBebidas.Items.Add("Coca-cola G- R$30,00");
            cmbBebidas.Items.Add("Pepsi M- R$40,00");
            cmbBebidas.Items.Add("Pepsi G- R$8,00");
            cmbBebidas.Items.Add("Guaraná M- R$10,00");
            cmbBebidas.Items.Add("Guaraná G- R$15,00");
            cmbBebidas.Items.Add("Milkshake de Nutella M- R$15,00");
            cmbBebidas.Items.Add("Milkshake de Nutella G- R$20,00");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkCebola_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (sair == DialogResult.No)
            {
                Pedido ped = new Pedido();
                ped.Show();
                this.Hide();
            }
            else
            {
                Application.Exit();
            }

        }

        private void cmbLanches_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpRetirar_Enter(object sender, EventArgs e)
        {

        }

        private void chkSalada_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorLanche= 0, valorOpcao = 0, valorTotal = 0, valorAcompanhamento = 0;
            if (cmbLanches.SelectedIndex == 0)
            {
                valorPizza = 30 ;
            }
            else if (cmbLanches.SelectedIndex == 1)
            {
                valorPizza = 48;
            }
            else if (cmbLanches.SelectedIndex == 2)
            {
                valorPizza = 20;
            }
            else if (cmbLanches.SelectedIndex == 3)
            {
                valorPizza = 23;
            }
            else if (cmbLanches.SelectedIndex == 4)
            {
                valorPizza = 50;
            }
            else if (cmbLanches.SelectedIndex == 5)
            {
                valorPizza = 50;
            }
            if (chkBorda.Checked == true)
            {
                valorOpcao = valorOpcao + 5;
            }
            if (chkTempero.Checked == true)
            {
                valorOpcao = valorOpcao + 6;
            }
            if (chkCebola.Checked == true)
            {
                valorOpcao = valorOpcao + 3;
            }
            if (chkCatupiry.Checked == true)
            {
                valorOpcao = valorOpcao + 4;
            }
            else
            {

            }
            valorTotal = valorPizza + valorOpcao;
            txtValorPizza.Text = Convert.ToString(valorPizza);
            txtValorOpcionais.Text = Convert.ToString(valorOpcao);
            txtValorPagar.Text = Convert.ToString(valorTotal);
        }
    }
}
