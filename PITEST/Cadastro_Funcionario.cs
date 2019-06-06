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
    public partial class Cadastro_Funcionario : Form
    {
        public Cadastro_Funcionario()
        {
            InitializeComponent();
        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                MySqlCommand _inserir = new MySqlCommand("insert into funcionarios(codFuncionario,nome,sobrenome,CPF,RG,dataNasc,CTPS,serieCTPS,PIS,endereço,numero,bairro,cidade,CEP,estado,telefone1,email,permissao,cargo,salarioBase,horas,gerente,nomeUsuario,senha,dataRegistro,observacao)values(null,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)", _conexao);
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
                _inserir.Parameters.Add("@estado", MySqlDbType.Text ).Value = BoxEstado.Text.ToUpper();
                _inserir.Parameters.Add("@CEP", MySqlDbType.VarChar,60).Value =  BoxCEP.Text;
                _inserir.Parameters.Add("@telefone1", MySqlDbType.Double).Value = Convert.ToDouble(BoxTelefone.Text);
                _inserir.Parameters.Add("@email", MySqlDbType.VarChar,40).Value = BoxEmail.Text.ToUpper();
                _inserir.Parameters.Add("@permissao", MySqlDbType.VarChar, 10).Value = BoxPermissao.Text.ToUpper();
                _inserir.Parameters.Add("@cargo", MySqlDbType.VarChar,30).Value = BoxCargo.Text.ToUpper();
                _inserir.Parameters.Add("@salarioBase", MySqlDbType.Double).Value = Convert.ToDouble(BoxSalariobase.Text);
                _inserir.Parameters.Add("@horas", MySqlDbType.Int16).Value = Convert.ToInt16(BoxHorario.Text);
                _inserir.Parameters.Add("@gerente", MySqlDbType.VarChar,30).Value = BoxGerente.Text.ToUpper();
                _inserir.Parameters.Add("@nomeUsuario", MySqlDbType.VarChar,15).Value = BoxUsuario.Text.ToUpper();
                _inserir.Parameters.Add("@senha", MySqlDbType.VarChar,12).Value = BoxSenha.Text.ToUpper();
                _inserir.Parameters.Add("@dataRegistro", MySqlDbType.Date).Value = dateTimePicker2.Text;
                _inserir.Parameters.Add("@observacao", MySqlDbType.TinyText).Value = BoxOBS.Text.ToUpper();



                _inserir.ExecuteNonQuery();
               
                



                MessageBox.Show("Cadastro concluido com sucesso");
                //fecha a conexão
                _conexao.Close();


            }
            catch (Exception erro)
            {
                MessageBox.Show("Cadastro inválido");
                throw (erro);
                
                
            }
        }

        private void Cadastro_Funcionario_Load(object sender, EventArgs e)
        {
           // comboBox1.Items.Add("sp");
          //  comboBox1.Items.Add("rj");
          // comboBox1.Items.Add("mg");
          //  comboBox1.Items.Add("se");
           // comboBox1.Items.Add("pa");
          //  comboBox1.Items.Add("am");
        }
    }
}
