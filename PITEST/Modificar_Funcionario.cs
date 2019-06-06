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
    public partial class Modificar_Funcionario : Form
    {
        public Modificar_Funcionario()
        {
            InitializeComponent();
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
                MySqlCommand _inserir = new MySqlCommand("update funcionarios set nome =?, sobrenome =?, CPF =?,RG=?, dataNasc =?,CTPS=?,serieCTPS=?,PIS =?,endereço = ?, numero = ?,bairro = ?,cidade = ?, estado = ?, CEP = ?, telefone1 =?, email =?,permissao=?, cargo = ?, salarioBase = ?,horas = ?,gerente = ?, nomeUsuario = ?, senha = ?, dataRegistro =?,  observacao =? where codFuncionario = ? ", _conexao);
                _inserir.Parameters.Add("@nome", MySqlDbType.VarChar, 30).Value = BoxNome.Text.ToUpper();
                _inserir.Parameters.Add("@sobrenome", MySqlDbType.VarChar, 30).Value = BoxSobrenome.Text.ToUpper();
                _inserir.Parameters.Add("@CPF", MySqlDbType.VarChar, 13).Value = BoxCPF.Text;
                _inserir.Parameters.Add("@RG", MySqlDbType.VarChar, 13).Value = BoxRG.Text;
                _inserir.Parameters.Add("@dataNasc", MySqlDbType.Date).Value = dateTimePicker1.Text;
                _inserir.Parameters.Add("@CTPS", MySqlDbType.VarChar, 15).Value = BoxCTPS.Text;
                _inserir.Parameters.Add("@serieCTPS", MySqlDbType.VarChar, 15).Value = BoxSerie.Text;
                _inserir.Parameters.Add("@PIS", MySqlDbType.VarChar, 15).Value = BoxPIS.Text;
                _inserir.Parameters.Add("@endereço", MySqlDbType.VarChar, 60).Value = BoxEndereco.Text.ToUpper();
                _inserir.Parameters.Add("@numero", MySqlDbType.VarChar, 5).Value = BoxNumero.Text.ToUpper();
                _inserir.Parameters.Add("@bairro", MySqlDbType.VarChar, 40).Value = BoxBairro.Text.ToUpper();
                _inserir.Parameters.Add("@cidade", MySqlDbType.VarChar, 40).Value = BoxCidade.Text.ToUpper();
                _inserir.Parameters.Add("@estado", MySqlDbType.Text).Value = BoxEstado.Text.ToUpper();
                _inserir.Parameters.Add("@CEP", MySqlDbType.VarChar, 60).Value = BoxCEP.Text;
                _inserir.Parameters.Add("@telefone1", MySqlDbType.Double).Value = Convert.ToDouble(BoxTelefone.Text);
                _inserir.Parameters.Add("@email", MySqlDbType.VarChar, 40).Value = BoxEmail.Text.ToUpper();
                _inserir.Parameters.Add("@permissao", MySqlDbType.VarChar, 10).Value = BoxPermissao.Text.ToUpper();
                _inserir.Parameters.Add("@cargo", MySqlDbType.VarChar, 30).Value = BoxCargo.Text.ToUpper();
                _inserir.Parameters.Add("@salarioBase", MySqlDbType.Double).Value = Convert.ToDouble(BoxSalariobase.Text);
                _inserir.Parameters.Add("@horas", MySqlDbType.Int16).Value = Convert.ToInt16(BoxHorario.Text);
                _inserir.Parameters.Add("@gerente", MySqlDbType.VarChar, 30).Value = BoxGerente.Text.ToUpper();
                _inserir.Parameters.Add("@nomeUsuario", MySqlDbType.VarChar, 15).Value = BoxUsuario.Text.ToUpper();
                _inserir.Parameters.Add("@senha", MySqlDbType.VarChar, 12).Value = BoxSenha.Text.ToUpper();
                _inserir.Parameters.Add("@dataRegistro", MySqlDbType.Date).Value = dateTimePicker2.Text;
                _inserir.Parameters.Add("@observacao", MySqlDbType.TinyText).Value = BoxOBS.Text.ToUpper();
                _inserir.Parameters.Add("@codFuncionario", MySqlDbType.Int16).Value = BoxCodigo.Text;



                _inserir.CommandType = CommandType.Text;
                _inserir.ExecuteNonQuery();




                MessageBox.Show("Cadastro alterado com sucesso");
                //fecha a conexão
                _conexao.Close();

               


            }
            catch (Exception erro)
            {
                MessageBox.Show("Alterações inválidas");
                throw (erro);


            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection _conexao = new MySqlConnection("server=localhost;port=3306;User Id=root; database=cadastro;password=banana48;");

                _conexao.Open();
                MySqlCommand _deletar = new MySqlCommand("delete from funcionarios where codFuncionario = ? ", _conexao);
                _deletar.Parameters.Clear();
                _deletar.Parameters.Add("@codFunionario", MySqlDbType.Int16).Value = BoxCodigo.Text;

                _deletar.CommandType = CommandType.Text;

                _deletar.ExecuteNonQuery();

                _conexao.Close();


                MessageBox.Show("Funcionario removido com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar a exclusão" + erro);

            }
        }

        private void BoxCodigo_TextChanged(object sender, EventArgs e)
        {
            if (BoxCodigo.Text != "")
            {
                try
                {
                    MySqlConnection _conexao = new MySqlConnection("server=localhost;port=3306;User Id=root; database=cadastro;password=banana48;");

                    _conexao.Open();
                    MySqlCommand _busca = new MySqlCommand("select nome, sobrenome, CPF, RG, dataNasc, CTPS, serieCTPS, PIS, endereço , numero,bairro,cidade, estado, CEP, telefone1, email, permissao, cargo, salarioBase, horas, gerente, nomeUsuario, senha, dataRegistro,  observacao  from funcionarios where codFuncionario = ? ", _conexao);
                    _busca.Parameters.Clear();
                    _busca.Parameters.Add("@codFuncionario", MySqlDbType.Int16).Value = BoxCodigo.Text;


                    _busca.CommandType = CommandType.Text;

                    MySqlDataReader dr;
                    dr = _busca.ExecuteReader();
                    dr.Read();

                    BoxNome.Text = dr.GetString(0);
                    BoxSobrenome.Text = dr.GetString(1);
                    BoxCPF.Text = dr.GetString(2);
                    BoxRG.Text = dr.GetString(3);
                    dateTimePicker1.Text = dr.GetString(4);
                    BoxCTPS.Text = dr.GetString(5);
                    BoxSerie.Text = dr.GetString(6);
                    BoxPIS.Text = dr.GetString(7);
                    BoxEndereco.Text = dr.GetString(8);
                    BoxNumero.Text = dr.GetString(9);
                    BoxBairro.Text = dr.GetString(10);
                    BoxCidade.Text = dr.GetString(11);
                    BoxEstado.Text = dr.GetString(12);
                    BoxCEP.Text = dr.GetString(13);
                    BoxTelefone.Text = dr.GetString(14);
                    BoxEmail.Text = dr.GetString(15);
                    BoxPermissao.Text = dr.GetString(16);
                    BoxCargo.Text = dr.GetString(17);
                    BoxSalariobase.Text = dr.GetString(18);
                    BoxHorario.Text = dr.GetString(19);
                    BoxGerente.Text = dr.GetString(20);
                    BoxUsuario.Text = dr.GetString(21);
                    BoxSenha.Text = dr.GetString(22);
                    dateTimePicker2.Text = dr.GetString(23);
                    BoxOBS.Text = dr.GetString(24);

                    




                   // MessageBox.Show("Atualização concluida com sucesso");
                    //fecha a conexão
                    _conexao.Close();


                }
                catch (Exception erro)
                {
                    MessageBox.Show("Funcionario não encontrado"+erro);
                    
                }
            }
        }
    }
}
