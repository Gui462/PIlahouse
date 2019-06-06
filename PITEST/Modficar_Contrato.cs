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
    public partial class Modficar_Contrato : Form
    {
        public Modficar_Contrato()
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
                MySqlCommand _inserir = new MySqlCommand("update contrato set codCliente =?, codFuncionario =?, codEspaco =?, codPlano =?, dataCadastro =?, dataInicio =?, datafim =?, valorTotal =?, formaPagamento =?, quantidadeParcelas =?, quantidadeImpessoes =?, observacoes =?, where codContrato = ?", _conexao);
                _inserir.Parameters.Add("@codCliente", MySqlDbType.Int16).Value = Convert.ToInt16(BoxCliente.Text);
                _inserir.Parameters.Add("@codFuncionario", MySqlDbType.Int16).Value = Convert.ToInt16(BoxFuncionario.Text);
                _inserir.Parameters.Add("@codEspaco", MySqlDbType.Int16).Value = Convert.ToInt16(BoxEspaco.Text);
                _inserir.Parameters.Add("@codPlano", MySqlDbType.Int16).Value = Convert.ToInt16(BoxPlano.Text);
                _inserir.Parameters.Add("@dataCadastro", MySqlDbType.Date).Value = dateTimePicker3.Text;
                _inserir.Parameters.Add("@datainicio", MySqlDbType.Date).Value = dateTimePicker1.Text;
                _inserir.Parameters.Add("@datafim", MySqlDbType.Date).Value = dateTimePicker2.Text;
                _inserir.Parameters.Add("@valorTotal", MySqlDbType.Double).Value = Convert.ToDouble(LabelValor.Text);
                _inserir.Parameters.Add("@formaPagamento", MySqlDbType.Text).Value = comboBox1.Text;
                _inserir.Parameters.Add("@quantidadeParcelas", MySqlDbType.Int32).Value = Convert.ToInt32(BoxParcelas.Text);
                _inserir.Parameters.Add("@quantidadeImpressoes", MySqlDbType.Int32).Value = Convert.ToInt32(BoxImpressao.Text);
                _inserir.Parameters.Add("@observacoes", MySqlDbType.Text).Value = BoxObs.Text.ToUpper();
                _inserir.Parameters.Add("@codContrato", MySqlDbType.Int16).Value = BoxCodigo.Text;

                _inserir.CommandType = CommandType.Text;
                _inserir.ExecuteNonQuery();





                MessageBox.Show("Atualização concluida com sucesso");
                //fecha a conexão
                _conexao.Close();

                BoxFuncionario.Text = "";
                BoxCliente.Text = "";
                BoxEspaco.Text = "";
                BoxImpressao.Text = "";
                BoxParcelas.Text = "";
                BoxPlano.Text = "";
                LabelValor.Text = "--";
                Lperiodo.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox7.Text = "";

            }
            catch (Exception erro)
            {
                MessageBox.Show("Atualização inválido" + erro);

            }

        }

        private void Modficar_Contrato_Load(object sender, EventArgs e)
        {

        }

        private void BoxFuncionario_TextChanged(object sender, EventArgs e)
        {

            if (BoxFuncionario.Text != "")
            {
                try
                {
                    MySqlConnection _conexao = new MySqlConnection("server=localhost;port=3306;User Id=root; database=cadastro;password=banana48;");

                    _conexao.Open();
                    MySqlCommand _busca = new MySqlCommand("select nome,sobrenome from funcionarios where codFuncionario = ?", _conexao);
                    _busca.Parameters.Clear();
                    _busca.Parameters.Add("@codFuncionario", MySqlDbType.Int16).Value = BoxFuncionario.Text;


                    _busca.CommandType = CommandType.Text;

                    MySqlDataReader dr;
                    dr = _busca.ExecuteReader();
                    dr.Read();

                    textBox3.Text = dr.GetString(0) + " " + dr.GetString(1);


                }
                catch (Exception erro)
                {
                    MessageBox.Show("funcionario não encontrado");
                }
            }
        }

        private void BoxEspaco_TextChanged(object sender, EventArgs e)
        {
            if (BoxEspaco.Text != "")
            {
                try
                {
                    MySqlConnection _conexao = new MySqlConnection("server=localhost;port=3306;User Id=root; database=cadastro;password=banana48;");

                    _conexao.Open();
                    MySqlCommand _busca = new MySqlCommand("select nomeEspaco from espaco where codEspaco = ?", _conexao);
                    _busca.Parameters.Clear();
                    _busca.Parameters.Add("@codEspaco", MySqlDbType.Int16).Value = BoxEspaco.Text;


                    _busca.CommandType = CommandType.Text;

                    MySqlDataReader dr;
                    dr = _busca.ExecuteReader();
                    dr.Read();

                    textBox7.Text = dr.GetString(0);


                }
                catch (Exception erro)
                {
                    MessageBox.Show("Espaço não encontrado");
                }
            }
        }

        private void BoxPlano_TextChanged(object sender, EventArgs e)
        {
            string valor;
            string horasMes;
            int Nimpressao = 0;
            if (BoxImpressao.Text != "")
            {
                Nimpressao = Convert.ToInt32(BoxImpressao.Text);

            }
            else
            {
                Nimpressao = 0;
            }

            if (BoxPlano.Text != "")
            {
                try
                {
                    MySqlConnection _conexao = new MySqlConnection("server=localhost;port=3306;User Id=root; database=cadastro;password=banana48;");

                    _conexao.Open();
                    MySqlCommand _busca = new MySqlCommand("select nomePlano,periodo,horasTotais,valorHora from Plano where codPlano = ?", _conexao);
                    _busca.Parameters.Clear();
                    _busca.Parameters.Add("@codPlano", MySqlDbType.Int16).Value = BoxPlano.Text;


                    _busca.CommandType = CommandType.Text;

                    MySqlDataReader dr;
                    dr = _busca.ExecuteReader();
                    dr.Read();
                    textBox2.Text = dr.GetString(0);
                    Lperiodo.Text = dr.GetString(1);
                    horasMes = dr.GetString(2);
                    valor = dr.GetString(3);
                    LabelValor.Text = (Convert.ToDouble(horasMes) * Convert.ToDouble(valor)).ToString();


                }
                catch (Exception erro)
                {
                    MessageBox.Show("Plano não encontrado");
                    //throw erro;
                }
            }
        }

        private void BoxCliente_TextChanged(object sender, EventArgs e)
        {
            if (BoxCliente.Text != "")
            {
                try
                {
                    MySqlConnection _conexao = new MySqlConnection("server=localhost;port=3306;User Id=root; database=cadastro;password=banana48;");

                    _conexao.Open();
                    MySqlCommand _busca = new MySqlCommand("select nome,sobrenome from clientes where codCliente = ?", _conexao);
                    _busca.Parameters.Clear();
                    _busca.Parameters.Add("@codCliente", MySqlDbType.Int16).Value = BoxCliente.Text;


                    _busca.CommandType = CommandType.Text;

                    MySqlDataReader dr;
                    dr = _busca.ExecuteReader();
                    dr.Read();

                    textBox1.Text = dr.GetString(0) + " " + dr.GetString(1);


                }
                catch (Exception erro)
                {
                    MessageBox.Show("Cliente não encontrado");
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection _conexao = new MySqlConnection("server=localhost;port=3306;User Id=root; database=cadastro;password=banana48;");

                _conexao.Open();
                MySqlCommand _deletar = new MySqlCommand("delete from contrato where codContrato = ? ", _conexao);
                _deletar.Parameters.Clear();
                _deletar.Parameters.Add("@codContrato", MySqlDbType.Int16).Value = BoxCodigo.Text;

                _deletar.CommandType = CommandType.Text;

                _deletar.ExecuteNonQuery();

                _conexao.Close();


                MessageBox.Show("contrato removido com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar a exclusão" + erro);

            }
        }

        private void BoxCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
