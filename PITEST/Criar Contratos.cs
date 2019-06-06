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
    public partial class Criar_Contratos : Form
    {
        public Criar_Contratos()
        {
            InitializeComponent();
        }



        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contratos_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
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

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection _conexao = new MySqlConnection("server=localhost;port=3306;User Id=root; database=cadastro;password=banana48;");

                _conexao.Open();
                MySqlCommand _inserir = new MySqlCommand("insert into contrato(codContrato,codCliente,codFuncionario,codEspaco,codPlano,dataCadastro,datainicio,datafim,valorTotal,formaPagamento,quantidadeParcelas,quantidadeImpressoes,observacoes)values(null,?,?,?,?,?,?,?,?,?,?,?,?)", _conexao);

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


                



                _inserir.ExecuteNonQuery();

                _conexao.Close();


                MessageBox.Show("Cadastro concluído");

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
                MessageBox.Show("Cadastro inválido");

                throw erro;
            }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
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
            if(BoxImpressao.Text !="")
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
                    horasMes =dr.GetString(2);
                    valor = dr.GetString(3);
                    LabelValor.Text = (Convert.ToDouble(horasMes)*Convert.ToDouble(valor)).ToString();


                }
                catch (Exception erro)
                { 
                    MessageBox.Show("Plano não encontrado");
                    //throw erro;
                }
            }
        }
    }
}
