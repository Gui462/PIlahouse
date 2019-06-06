using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PITEST
{
    class dal
    {
        public MySqlConnection conexao;
        public void cadastrocliente(TabelaCliente cliente)
        {
            string caminho = "SERVER = localhost;DATABASE=cadastro;UID=root;PASSWORD=banana48;";
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();
                string inserir = "INSERT INTO clientes(nome,sobrenome,CPF,dataNascimento,telefone,email,dataCadastro)values('" + cliente._nomecliente + "','" + cliente._sobrenomecliente + "','" + cliente._CPFcliente + "','"+cliente._datanasc+"'+'"+cliente._telefone1+"'+'"+cliente._Email+"'+'"+cliente._Datacadastro+"')";

                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                comandos.ExecuteNonQuery();
                conexao.Close();
            }
            catch(Exception ex)
            {
                
                throw new Exception("Erro de comando:" + ex.Message);
            }

            }
        }
    }
