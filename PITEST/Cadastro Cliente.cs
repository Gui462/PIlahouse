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
    public partial class Cadastro_Cliente : Form
    {
        public Cadastro_Cliente()
        {
            InitializeComponent();
        }

        private void Cadastro_Cliente_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("SIM");
            comboBox1.Items.Add("NÂO");

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //faz conexao com o banco
                MySqlConnection _conexao = new MySqlConnection("server=localhost;port=3306;User Id=root; database=cadastro;password=banana48;");
                //abre a conexão
                _conexao.Open();
                //faz o que tem que fazer
                MySqlCommand _inserir = new MySqlCommand("insert into clientes(codCliente,nome,sobrenome,CPF,dataNascimento,telefone,email,dataCadastro,notificacao,nomeEmpresa,CNPJ,area,servico,observacao)values(null,?,?,?,?,?,?,?,?,?,?,?,?,?)", _conexao);
                _inserir.Parameters.Add("@nome", MySqlDbType.VarChar,30).Value =BoxNome.Text.ToUpper();
                _inserir.Parameters.Add("@sobrenome", MySqlDbType.VarChar,30).Value = BoxSobrenome.Text.ToUpper();
                _inserir.Parameters.Add("@CPF", MySqlDbType.VarChar,13).Value = BoxCPF.Text.ToUpper();
                _inserir.Parameters.Add("@dataNascimento", MySqlDbType.Date).Value = dateTimePicker1.Text;
                _inserir.Parameters.Add("@telefone", MySqlDbType.Double).Value = Convert.ToDouble(BoxTelefone.Text);
                _inserir.Parameters.Add("@email", MySqlDbType.Text).Value = BoxEmail.Text.ToUpper();
                _inserir.Parameters.Add("@dataCadastro", MySqlDbType.Date).Value = dateTimePicker2.Text;
                _inserir.Parameters.Add("@notificacao", MySqlDbType.VarChar,4).Value = comboBox1.SelectedItem.ToString();
                _inserir.Parameters.Add("@nomeEmpresa", MySqlDbType.VarChar,30).Value = BoxEmpresa.Text.ToUpper();
                _inserir.Parameters.Add("@area", MySqlDbType.Text).Value = BoxArea.Text.ToUpper();
                _inserir.Parameters.Add("@servico", MySqlDbType.Text).Value = BoxServico.Text.ToUpper();
                _inserir.Parameters.Add("@observacao", MySqlDbType.Text).Value = BoxOBS.Text.ToUpper();
                _inserir.Parameters.Add("@CNPJ", MySqlDbType.VarChar,15).Value = BoxCNPJ.Text.ToUpper();

                _inserir.ExecuteNonQuery();
                BoxNome.Text = "";
                BoxSobrenome.Text = "";
                BoxCPF.Text = "";
                dateTimePicker1.Text = default;
                BoxTelefone.Text = "";
                BoxEmail.Text = "";
                BoxNome.Text = "";
                dateTimePicker2.Text = default;
                BoxNome.Text = "";
                BoxEmpresa.Text = "";
                BoxArea.Text = "";
                BoxServico.Text = "";
                BoxOBS.Text = "";
                BoxCNPJ.Text = "";



                MessageBox.Show("Cadastro concluido com sucesso");
                //fecha a conexão
                _conexao.Close();
                

            }
            catch(Exception erro)
            {
                MessageBox.Show("Cadastro inválido");
                
            }

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
