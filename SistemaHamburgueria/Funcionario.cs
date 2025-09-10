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
        public partial class Funcionario : Form

        {

            Conexao con = new Conexao();
            public Funcionario()
            {
                InitializeComponent();
            }

            private void btnVoltar_Click(object sender, EventArgs e)
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

            private void Funcionario_Load(object sender, EventArgs e)
            {

           
            }

            private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void dgvPedido_MouseDown(object sender, MouseEventArgs e)
            {

            }

            private void dgvPedido_MouseDoubleClick(object sender, MouseEventArgs e)
            {
                if (dgvPedido.SelectedRows.Count > 0)
                {
                    MessageBox.Show(
                        "Lanche: " + dgvPedido.SelectedRows[0].Cells[1].Value.ToString() +
                        "\nAcompanhamento: " + dgvPedido.SelectedRows[0].Cells[3].Value.ToString() +
                        "\nBebida: " + dgvPedido.SelectedRows[0].Cells[4].Value.ToString() +
                        "\nTotal: " + dgvPedido.SelectedRows[0].Cells[5].Value.ToString()
                    );
                }
            }
        

            private void txtPesquisar_TextChanged(object sender, EventArgs e)
            {
                
            }

            private void txtPesquisar_DoubleClick(object sender, EventArgs e)
            {
              
            }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectarBD();
                string sql = "SELECT * FROM tbPedido WHERE valorLanche LIKE @pesquisa OR valorAcompanhamento LIKE @pesquisa OR valorBebida LIKE @pesquisa";
                MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                cmd.Parameters.AddWithValue("@pesquisa", "%" + txtPesquisar.Text + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPedido.DataSource = dt;

                con.DesConnectarBD();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao pesquisar: " + error.Message);
            }
            try
            {
                con.ConnectarBD();
                string sql = "SELECT * FROM tbPedido";
                MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPedido.DataSource = dt;
                con.DesConnectarBD();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao carregar pedidos: " + error.Message);
            }
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }
    }    }

