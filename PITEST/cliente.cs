using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PITEST
{
    public partial class cliente : Form
    {
        public cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.clientes'. Você pode movê-la ou removê-la conforme necessário.


        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastro_Cliente TCadClient = new Cadastro_Cliente();
            TCadClient.ShowDialog();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Modifica_Cliente TCadClient = new Modifica_Cliente();
            TCadClient.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {
            // dataGrid.Rows = MySqlDataAdapter.clientesTableAdapter1.Fill();
        }

        private void BoxCodigo_TextChanged(object sender, EventArgs e)
        {
            if (BoxCodigo.Text != "")
            {
                try
                {
                    MySqlConnection _conexao = new MySqlConnection("server=localhost;port=3306;User Id=root; database=cadastro;password=banana48;");

                    _conexao.Open();
                    MySqlCommand _busca = new MySqlCommand("select nome,sobrenome,CPF, telefone, email from clientes where codCliente = ?", _conexao);
                    _busca.Parameters.Clear();
                    _busca.Parameters.Add("@codCliente", MySqlDbType.Int16).Value = BoxCodigo.Text;


                    _busca.CommandType = CommandType.Text;

                    MySqlDataReader dr;
                    dr = _busca.ExecuteReader();
                    dr.Read();

                    LNome.Text = dr.GetString(0) + " " + dr.GetString(1);
                    LCPF.Text = dr.GetString(2);
                    Ltelefone.Text = dr.GetString(3);
                    LEmail.Text = dr.GetString(4);




                }
                catch (Exception erro)
                {
                    MessageBox.Show("Funcionario não encontrado");
                }
            }
        }

        private void LCPF_Click(object sender, EventArgs e)
        {

        }
    }
}
