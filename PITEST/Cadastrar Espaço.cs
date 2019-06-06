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
    public partial class Cadastrar_Espaço : Form
    {
        public Cadastrar_Espaço()
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
                MySqlConnection _conexao = new MySqlConnection("server=localhost;port=3306;User Id=root; database=cadastro;password=banana48;");

                _conexao.Open();
                MySqlCommand _inserir = new MySqlCommand("insert into espaco(codEspaco,nomeEspaco,descricao,tipo,largura,comprimento,ValorHora,quantidadeTotal)values(null,?,?,?,?,?,?,?)", _conexao);

                _inserir.Parameters.Add("@nomeEspaco", MySqlDbType.VarChar, 15).Value = BoxNome.Text.ToUpper();
                _inserir.Parameters.Add("@descricao", MySqlDbType.Text).Value = BoxDescricao.Text.ToUpper();
                _inserir.Parameters.Add("@tipo", MySqlDbType.VarChar, 15).Value = BoxTipo.Text.ToUpper();
                _inserir.Parameters.Add("@largura", MySqlDbType.Double).Value = Convert.ToDouble(BoxLargura.Text);
                _inserir.Parameters.Add("@comprimento", MySqlDbType.Double).Value = Convert.ToDouble(BoxComprimento.Text);
                _inserir.Parameters.Add("@valorHora", MySqlDbType.Double).Value = Convert.ToDouble(BoxValor.Text);
                _inserir.Parameters.Add("@quantidadeTotal", MySqlDbType.Int16).Value = Convert.ToInt16(BoxQuantidade.Text);
                

                _inserir.ExecuteNonQuery();

                _conexao.Close();


                MessageBox.Show("Cadastro concluído");

                BoxNome.Text = "";
                BoxDescricao.Text = "";
                BoxTipo.Text = "";
                BoxLargura.Text = "";
                BoxComprimento.Text = "";
                BoxValor.Text = "";
                BoxQuantidade.Text = "";


            }
            catch(Exception erro)
            {
                MessageBox.Show("Cadastro inválido");
                throw erro;
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
