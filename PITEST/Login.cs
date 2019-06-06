using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PITEST
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string Login = "ADMIN";
            if (textBox1.Text == Login|| textBox2.Text== Login)
            {
                Inicio Tinicio = new Inicio();
                Tinicio.ShowDialog();
                this.Close();
            }
            else
            {
                label3.Text = "Login Inválido!!";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}