using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PITEST
{
    class TabelaCliente
    {
        //cliente
        private int CodigoCliente;
        private string Nomecliente;
        private string SobrenomeCliente;
        private int CPFClient;
        private string Datanac;
        private string Telefone1;
        private string Email;
        private string Datacadastro;
        private string Observacao;


        public int _codigocliente
        {
            get { return CodigoCliente; }
            set { CodigoCliente = value; }
        }
        public string _nomecliente
        {
            get { return Nomecliente; }
            set { Nomecliente = value; }
        }
        public string _sobrenomecliente
        {
            get { return SobrenomeCliente; }
            set { SobrenomeCliente = value; }
        }
        public int _CPFcliente
        {
            get { return CPFClient; }
            set { CPFClient = value; }
        }
        public  string _datanasc
        {
            get { return Datanac; }
            set { Datanac = value; }
        }
        public  string _telefone1
        {
            get { return Telefone1; }
            set { Telefone1 = value; }
        }

        public string _Email
        {
            get { return Email; }
            set { Email = value; }
        }
        public string _Datacadastro
        {
            get { return Datacadastro; }
            set { Datacadastro = value; }
        }

        public string _Observacao
        {
            get { return Observacao; }
            set { Observacao = value; }
        }







    }
}
