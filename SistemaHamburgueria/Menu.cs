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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
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

        private void btnLanches_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Acompanhamentos ac = new Acompanhamentos();
            ac.Show();
            this.Hide();
        }

        private void bntBebidas_Click(object sender, EventArgs e)
        {
            Bebidas bd = new Bebidas();
            bd.Show();
            this.Hide();
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            btnAcompanhamentos.BackColor = ColorTranslator.FromHtml("#3E2723");
            btnAcompanhamentos.ForeColor = ColorTranslator.FromHtml("#F5E8C8");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            btnAcompanhamentos.BackColor = ColorTranslator.FromHtml("#F5E8C8");
            btnAcompanhamentos.ForeColor = Color.Black;
        }

        private void bntBebidas_MouseHover(object sender, EventArgs e)
        {
            bntBebidas.BackColor = ColorTranslator.FromHtml("#F5E8C8");
            bntBebidas.ForeColor = Color.Black;
        }

        private void bntBebidas_MouseLeave(object sender, EventArgs e)
        {
            bntBebidas.BackColor = ColorTranslator.FromHtml("#3E2723");
            bntBebidas.ForeColor = ColorTranslator.FromHtml("#F5E8C8");
        }

        private void btnLanches_MouseHover(object sender, EventArgs e)
        {
            btnLanches.BackColor = ColorTranslator.FromHtml("#F5E8C8");
            btnLanches.ForeColor = Color.Black;
        }

        private void btnLanches_MouseLeave(object sender, EventArgs e)
        {
            btnLanches.BackColor = ColorTranslator.FromHtml("#3E2723");
            btnLanches.ForeColor = ColorTranslator.FromHtml("#F5E8C8");
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            Pedido pd = new Pedido();
            pd.Show();
            this.Hide();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (sair == DialogResult.No)
            {
                Menu mn = new Menu();
                mn.Show();
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
