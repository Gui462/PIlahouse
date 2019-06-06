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
    public partial class Plano : Form
    {
        public Plano()
        {
            InitializeComponent();
        }

        private void BTCADASTRAR_Click(object sender, EventArgs e)
        {
            Criar_Planos TCriaPlan = new Criar_Planos();
            TCriaPlan.ShowDialog();
        }

        private void BoxCodigo_TextChanged(object sender, EventArgs e)
        {
            if (BoxCodigo.Text != "")
            {
                try
                {
                   MySqlConnection _conexao = new MySqlConnection("server=localhost;port=3306;User Id=root; database=cadastro;password=banana48;");

                   _conexao.Open();
                    MySqlCommand _busca = new MySqlCommand("select nomePlano, periodo, valorHora from plano  where codPlano = ?", _conexao);
                    _busca.Parameters.Clear();
                    _busca.Parameters.Add("@codPlano", MySqlDbType.Int16).Value = BoxCodigo.Text;


                    _busca.CommandType = CommandType.Text;

                    MySqlDataReader dr;
                    dr = _busca.ExecuteReader(); 
                    dr.Read();

                    Lnome.Text = dr.GetString(0);
                    LPeriodo.Text = dr.GetString(1);
                    Lvalor.Text = dr.GetString(2);




                }
               catch (Exception erro)
                {
                  MessageBox.Show("Plano não encontrado"+erro);
               }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ModificarPlano TmodPlano = new ModificarPlano();
            TmodPlano.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
