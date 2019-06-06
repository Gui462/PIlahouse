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
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Cadastro_Funcionario TCadFunc = new Cadastro_Funcionario();
            TCadFunc.ShowDialog();
        }

        private void BoxCodigo_Click(object sender, EventArgs e)
        {
            Cadastro_Funcionario TCadfun = new Cadastro_Funcionario();
            TCadfun.ShowDialog();
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

        }

        private void BoxCodigo_TextChanged(object sender, EventArgs e)
        {
            if (BoxCodigo.Text != "")
            {
                try
                {
                    MySqlConnection _conexao = new MySqlConnection("server=localhost;port=3306;User Id=root; database=cadastro;password=banana48;");

                    _conexao.Open();
                    MySqlCommand _busca = new MySqlCommand("select nome,sobrenome, cargo, gerente, RG, telefone1 from funcionarios where codFuncionario = ?", _conexao);
                    _busca.Parameters.Clear();
                    _busca.Parameters.Add("@codFuncionario", MySqlDbType.Int16).Value = BoxCodigo.Text;


                    _busca.CommandType = CommandType.Text;

                    MySqlDataReader dr;
                    dr = _busca.ExecuteReader();
                    dr.Read();

                    Lnome.Text = dr.GetString(0) + " " + dr.GetString(1);
                    LCargo.Text = dr.GetString(2);
                    Lgerente.Text = dr.GetString(3);
                    LRG.Text = dr.GetString(4);
                    Ltelefone.Text = dr.GetString(5);
                    
                    

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Funcionario não encontrado");
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Modificar_Funcionario ModFun = new Modificar_Funcionario();
            ModFun.ShowDialog();
        }
        
        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Lnome_Click(object sender, EventArgs e)
        {

        }

        private void Ltelefone_Click(object sender, EventArgs e)
        {

        }

        private void Lgerente_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void LRG_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
    }

