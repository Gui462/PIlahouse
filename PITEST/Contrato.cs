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
    public partial class Contrato : Form
    {
        public Contrato()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Criar_Contratos TCriarcon = new Criar_Contratos();
            TCriarcon.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Modficar_Contrato modificar_Contrato = new Modficar_Contrato();
            modificar_Contrato.ShowDialog();
        }
    }
}
