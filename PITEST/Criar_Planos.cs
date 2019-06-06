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
    public partial class Criar_Planos : Form
    {
        public Criar_Planos()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
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
                MySqlConnection _conexao = new MySqlConnection("server=localhost;port=3306;User Id=root; database=cadastro;password=banana48;");

                _conexao.Open();
                MySqlCommand _inserir = new MySqlCommand("insert into plano(codPlano,nomePlano,descricao,horasTotais,horasPorDia,desonto,periodo,Observacoes,valorHora)values(null,?,?,?,?,?,?,?,?)", _conexao);

                _inserir.Parameters.Add("@nomePlano", MySqlDbType.VarChar, 15).Value = BoxNome.Text.ToUpper();
                _inserir.Parameters.Add("@descricao", MySqlDbType.TinyText).Value = BoxDescricao.Text.ToUpper();
                _inserir.Parameters.Add("@horasTotais", MySqlDbType.Int32).Value = Convert.ToInt32(BoxMes.Text);
                _inserir.Parameters.Add("@horasPordia", MySqlDbType.Double).Value = Convert.ToInt16(BoxDia.Text);
                _inserir.Parameters.Add("@desonto", MySqlDbType.Double).Value = Convert.ToDouble(BoxDesconto.Text);
                _inserir.Parameters.Add("@periodo", MySqlDbType.VarChar,10).Value = BoxPeriodo.Text;
                _inserir.Parameters.Add("@Observacoes", MySqlDbType.TinyText).Value = BoxOBS.Text;
                _inserir.Parameters.Add("@valorHora", MySqlDbType.Double).Value = Convert.ToDouble(BoxValor.Text);


                _inserir.ExecuteNonQuery();

                _conexao.Close();


                MessageBox.Show("Cadastro concluído");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Cadastro inválido");
                throw erro;
            }
        }

        private void BoxDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void BoxOBS_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxDesconto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void BoxPeriodo_TextChanged(object sender, EventArgs e)
        {

        }

        private void P_Click(object sender, EventArgs e)
        {

        }

        private void BoxDia_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void BoxMes_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
