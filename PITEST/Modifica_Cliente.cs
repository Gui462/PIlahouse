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
    public partial class Modifica_Cliente : Form
    {
        public Modifica_Cliente()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection _conexao = new MySqlConnection("server=localhost;port=3306;User Id=root; database=cadastro;password=banana48;");

                _conexao.Open();
                MySqlCommand _deletar = new MySqlCommand("delete from clientes where codCliente = ? ", _conexao);
                _deletar.Parameters.Clear();
                _deletar.Parameters.Add("@codcliente", MySqlDbType.Int16).Value = BoxCodigo.Text;

                _deletar.CommandType = CommandType.Text;

                _deletar.ExecuteNonQuery();

                _conexao.Close();


                MessageBox.Show("cliente removido com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar a exclusão" + erro);
                
            }
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
                MySqlCommand _inserir = new MySqlCommand("update clientes set nome=?,sobrenome=?,CPF=?,dataNascimento=?,telefone=?,email=?,dataCadastro=?,notificacao=?,nomeEmpresa=?,CNPJ=?,area=?,servico=?,observacao=? where codCliente = ?", _conexao);
                _inserir.Parameters.Add("@nome", MySqlDbType.VarChar, 30).Value = BoxNome.Text.ToUpper();
                _inserir.Parameters.Add("@sobrenome", MySqlDbType.VarChar, 30).Value = BoxSobrenome.Text.ToUpper();
                _inserir.Parameters.Add("@CPF", MySqlDbType.VarChar, 13).Value = BoxCPF.Text.ToUpper();
                _inserir.Parameters.Add("@dataNascimento", MySqlDbType.Date).Value = dateTimePicker1.Text;
                _inserir.Parameters.Add("@telefone", MySqlDbType.Double).Value = Convert.ToDouble(BoxTelefone.Text);
                _inserir.Parameters.Add("@email", MySqlDbType.Text).Value = BoxEmail.Text.ToUpper();
                _inserir.Parameters.Add("@dataCadastro", MySqlDbType.Date).Value = dateTimePicker2.Text;
                _inserir.Parameters.Add("@notificacao", MySqlDbType.VarChar, 4).Value = comboBox1.SelectedItem.ToString();
                _inserir.Parameters.Add("@nomeEmpresa", MySqlDbType.VarChar, 30).Value = BoxEmpresa.Text.ToUpper();
                _inserir.Parameters.Add("@area", MySqlDbType.Text).Value = BoxArea.Text.ToUpper();
                _inserir.Parameters.Add("@servico", MySqlDbType.Text).Value = BoxServico.Text.ToUpper();
                _inserir.Parameters.Add("@observacao", MySqlDbType.Text).Value = BoxOBS.Text.ToUpper();
                _inserir.Parameters.Add("@CNPJ", MySqlDbType.VarChar, 15).Value = BoxCNPJ.Text.ToUpper();
                _inserir.Parameters.Add("@codCliente", MySqlDbType.Int16).Value = BoxCodigo.Text;

                _inserir.CommandType = CommandType.Text;
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



                MessageBox.Show("Atualização concluida com sucesso");
                //fecha a conexão
                _conexao.Close();


            }
            catch (Exception erro)
            {
                MessageBox.Show("Atualização inválido"+erro);

            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BoxCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


