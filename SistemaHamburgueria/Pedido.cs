using MySql.Data.MySqlClient;
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
            cmbLanches.Items.Insert(0, "Selecione um lanche...");
            cmbLanches.SelectedIndex = 0;

            cmbAcompanhamentos.Items.Insert(0, "Selecione um acompanhamento...");
            cmbAcompanhamentos.SelectedIndex = 0;

            cmbBebidas.Items.Insert(0, "Selecione uma bebida...");
            cmbBebidas.SelectedIndex = 0;



            cmbLanches.Items.Add("X-Salada - R$ 30,00");
            cmbLanches.Items.Add("X-Bacon - R$ 48,00");
            cmbLanches.Items.Add("Duplo Salada - R$ 60,00");
            cmbLanches.Items.Add("Frango Junior - R$ 20,00");
            cmbLanches.Items.Add("Duplo Frango  - R$ 23,00");
            cmbLanches.Items.Add("Duplo Cheddar - R$ 45,00");
            cmbLanches.Items.Add("TexMex Burguer - R$ 40,00");
            cmbLanches.Items.Add("BBQ Bacon- R$ 45,00");


            // --- Acompanhamentos ---
            cmbAcompanhamentos.Items.Add("Batata Frita P - R$ 20,00");
            cmbAcompanhamentos.Items.Add("Batata Frita M - R$ 30,00");
            cmbAcompanhamentos.Items.Add("Batata Frita G - R$ 40,00");
            cmbAcompanhamentos.Items.Add("Nuggets P (4 unidades) - R$ 8,00");
            cmbAcompanhamentos.Items.Add("Nuggets M (6 unidades) - R$ 10,00");
            cmbAcompanhamentos.Items.Add("Nuggets G (10 unidades) - R$ 15,00");
            cmbAcompanhamentos.Items.Add("Onion Rings M - R$ 15,00");
            cmbAcompanhamentos.Items.Add("Onion Rings G - R$ 20,00");

            // --- Bebidas ---
            cmbBebidas.Items.Add("Coca-cola M - R$ 8,00");
            cmbBebidas.Items.Add("Coca-cola G - R$ 15,00");
            cmbBebidas.Items.Add("Pepsi M - R$ 6,00");
            cmbBebidas.Items.Add("Pepsi G - R$ 10,00");
            cmbBebidas.Items.Add("Guaraná M - R$ 8,00");
            cmbBebidas.Items.Add("Guaraná G - R$ 12,00");
            cmbBebidas.Items.Add("Milkshake de Nutella M - R$ 15,00");
            cmbBebidas.Items.Add("Milkshake de Nutella G - R$ 20,00");

            if (cmbLanches.Items.Count > 0) cmbLanches.SelectedIndex = 0;
            if (cmbAcompanhamentos.Items.Count > 0) cmbAcompanhamentos.SelectedIndex = 0;
            if (cmbBebidas.Items.Count > 0) cmbBebidas.SelectedIndex = 0;
            cmbLanches.SelectedIndex = 0;
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


        

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            Menu telamenu = new Menu();
            telamenu.Show();
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //vefificar os campos
            if (lblValorLanche.Text == "")
            {
                MessageBox.Show("Campo obrigátorio");
                lblValorLanche.Focus();
            }
            else if (lblValorOpcionais.Text == "")
            {
                MessageBox.Show("Campo obrigátorio");
                lblValorOpcionais.Focus();
            }
            else if (lblValorAcompanhamentos.Text == "")
            {
                MessageBox.Show("Campo obrigátorio");
                lblValorAcompanhamentos.Focus();
            }
            else if (lblValorBebida.Text == "")
            {
                MessageBox.Show("Campo obrigátorio");
                lblValorBebida.Focus();
            }
            else if (lblValorPagar.Text == "")
            {
                MessageBox.Show("Campo obrigátorio");
                lblValorPagar.Focus();
            }
            else
            {
                //tratamento de erros
                try
                {
                    //inserindo dados no banco
                    string sql = "insert into tbPedido(valorLanche,valorOpcao,valorTotal,valorBebida,valorAcompanhamento,valorNome) values(@vlanche,@vopcao, @total,@vbebida, @vacompanhamentos,@vNome)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@vlanche", MySqlDbType.Text).Value = cmbLanches.Text;
                    cmd.Parameters.Add("@vopcao", MySqlDbType.Text).Value = lblValorOpcionais.Text;
                    cmd.Parameters.Add("@total", MySqlDbType.Text).Value = lblValorTotal.Text;
                    cmd.Parameters.Add("@vbebida", MySqlDbType.Text).Value = cmbBebidas.Text;
                    cmd.Parameters.Add("@vacompanhamentos", MySqlDbType.Text).Value = cmbAcompanhamentos.Text;
                    cmd.Parameters.Add("@vNome", MySqlDbType.Text).Value = txtNome.Text;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dados cadastrados com Sucesso !!!");
                    cmbLanches.Text = "";
                    cmbBebidas.Text = "";
                    cmbAcompanhamentos.Text = "";
                    lblValorLanche.Text = "";
                    lblValorOpcionais.Text = "";
                    lblValorPagar.Text = "";
                    cmbLanches.Focus();
                    con.DesConnectarBD();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            double valorLanche = 0, valorAcompanhamento = 0, valorBebida = 0, valorOpcao = 0, valorTotal = 0;

            //  Lanches 
            if (cmbLanches.SelectedIndex == 1)
            {
                valorLanche = 30; // X-SALADA
            }
            else if (cmbLanches.SelectedIndex == 2)
            {
                valorLanche = 48; // X-BACON
            }
            else if (cmbLanches.SelectedIndex == 3)
            {
                valorLanche = 60; // COMBO DUPLO SALADA (corrigido: antes 20)
            }
            else if (cmbLanches.SelectedIndex == 4)
            {
                valorLanche = 20; // X-FRANGO JUNIOR (corrigido: antes 23)
            }
            else if (cmbLanches.SelectedIndex == 5)
            {
                valorLanche = 23; // X-FRANGO MEDIO (corrigido: antes 50)
            }
            else if (cmbLanches.SelectedIndex == 6)
            {
                valorLanche = 45; // CHEDDAR DUPLO (corrigido: antes 50)
            }
            else if (cmbLanches.SelectedIndex == 7)
            {
                valorLanche = 40; // CHEDDAR DUPLO (corrigido: antes 50)
            }
            else if (cmbLanches.SelectedIndex == 8)
            {
                valorLanche = 45; // CHEDDAR DUPLO (corrigido: antes 50)
            }

            // --- Acompanhamentos ---
            if (cmbAcompanhamentos.SelectedIndex == 1)
            {
                valorAcompanhamento = 20;
            }
            else if (cmbAcompanhamentos.SelectedIndex == 2)
            {
                valorAcompanhamento = 30;
            }
            else if (cmbAcompanhamentos.SelectedIndex == 3)
            {
                valorAcompanhamento = 40;
            }
            else if (cmbAcompanhamentos.SelectedIndex == 4)
            {
                valorAcompanhamento = 8;
            }
            else if (cmbAcompanhamentos.SelectedIndex == 5)
            {
                valorAcompanhamento = 10;
            }
            else if (cmbAcompanhamentos.SelectedIndex == 6)
            {
                valorAcompanhamento = 15;
            }
            else if (cmbAcompanhamentos.SelectedIndex == 7)
            {
                valorAcompanhamento = 15;
            }
            else if (cmbAcompanhamentos.SelectedIndex == 8)
            {
                valorAcompanhamento = 20;
            }

            // --- Bebidas ---
            if (cmbBebidas.SelectedIndex == 1)
            {
                valorBebida = 8;
            }
            else if (cmbBebidas.SelectedIndex == 2)
            {
                valorBebida = 15;
            }
            else if (cmbBebidas.SelectedIndex == 3)
            {
                valorBebida = 6;
            }
            else if (cmbBebidas.SelectedIndex == 4)
            {
                valorBebida = 10;
            }
            else if (cmbBebidas.SelectedIndex == 5)
            {
                valorBebida = 8;
            }
            else if (cmbBebidas.SelectedIndex == 6)
            {
                valorBebida = 12;
            }
            else if (cmbBebidas.SelectedIndex == 7)
            {
                valorBebida = 15;
            }
            else if (cmbBebidas.SelectedIndex == 8)
            {
                valorBebida = 20;
            }

            // --- Opcionais ---
            if (chkCheddar.Checked == true)
            {
                valorOpcao = valorOpcao + 6;
            }
            if (chkHabmburguer.Checked == true)
            {
                valorOpcao = valorOpcao + 12;
            }
            if (chkCatupiryA.Checked == true)
            {
                valorOpcao = valorOpcao + 8;
            }
            if (chkMolhoEspecial.Checked == true)
            {
                valorOpcao = valorOpcao + 3;
            }
            if (chkBacon.Checked == true)
            {
                valorOpcao = valorOpcao + 5;
            }
            if (chkMaionese.Checked == true)
            {
                valorOpcao += 3;
            }

            // --- Total ---
            valorTotal = valorLanche + valorAcompanhamento + valorBebida + valorOpcao;

            // Exibe os resultados 
            lblValorLanche.Text = "R$ " + Convert.ToString(valorLanche) + ",00";
            lblValorAcompanhamentos.Text = "R$ " + Convert.ToString(valorAcompanhamento) + ",00";
            lblValorOpcionais.Text = "R$ " + Convert.ToString(valorOpcao) + ",00";
            lblValorBebida.Text = "R$ " + Convert.ToString(valorBebida) + ",00";
            lblValorTotal.Text = "R$ " + Convert.ToString(valorTotal) + ",00";

        }

        private void cmbLanches_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSair_Click_1(object sender, EventArgs e)
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
            Menu lanches = new Menu();
            lanches.Show();
            this.Hide();
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
    }
}
