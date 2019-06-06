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
    public partial class ModificarPlano : Form
    {
        public ModificarPlano()
        {
            InitializeComponent();
        }

        private void BoxCodgo_TextChanged(object sender, EventArgs e)
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
                MySqlCommand _inserir = new MySqlCommand("update clientes set nomePlano, descicao, horasTotais,horasPorDia,desonto,periodo,observacao=?,valorHora where codPlano = ?", _conexao);
                _inserir.Parameters.Add("@nomePlano", MySqlDbType.VarChar, 15).Value = BoxNome.Text.ToUpper();
                _inserir.Parameters.Add("@descricao", MySqlDbType.TinyText).Value = BoxDescricao.Text.ToUpper();
                _inserir.Parameters.Add("@horasTotais", MySqlDbType.Int32).Value = Convert.ToInt32(BoxMes.Text);
                _inserir.Parameters.Add("@horasPordia", MySqlDbType.Double).Value = Convert.ToInt16(BoxDia.Text);
                _inserir.Parameters.Add("@desonto", MySqlDbType.Double).Value = Convert.ToDouble(BoxDesconto.Text);
                _inserir.Parameters.Add("@periodo", MySqlDbType.VarChar, 10).Value = BoxPeriodo.Text;
                _inserir.Parameters.Add("@Observacoes", MySqlDbType.TinyText).Value = BoxOBS.Text;
                _inserir.Parameters.Add("@valorHora", MySqlDbType.Double).Value = Convert.ToDouble(BoxValor.Text);
                _inserir.Parameters.Add("@codPlano", MySqlDbType.Int16).Value = BoxCodigo.Text;

                _inserir.CommandType = CommandType.Text;
                _inserir.ExecuteNonQuery();

              


                MessageBox.Show("Atualização concluida com sucesso");
                //fecha a conexão
                _conexao.Close();


            }
            catch (Exception erro)
            {
                MessageBox.Show("Atualização inválido" + erro);

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection _conexao = new MySqlConnection("server=localhost;port=3306;User Id=root; database=cadastro;password=banana48;");

                _conexao.Open();
                MySqlCommand _deletar = new MySqlCommand("delete from plano where codPlano = ? ", _conexao);
                _deletar.Parameters.Clear();
                _deletar.Parameters.Add("@codPlano", MySqlDbType.Int16).Value = BoxCodigo.Text;

                _deletar.CommandType = CommandType.Text;

                _deletar.ExecuteNonQuery();

                _conexao.Close();


                MessageBox.Show("Plano removido com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar a exclusão" + erro);

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
