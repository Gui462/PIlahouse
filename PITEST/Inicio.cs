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
    public partial class Inicio : Form
    {
        public bool IsCollapsed;
        public Inicio()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            cliente TCadClient = new cliente();
            TCadClient.ShowDialog();

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (IsCollapsed)
            {
                panel1.Height += 168;
                if (panel1.Size == panel1.MaximumSize)
                {
                    timer1.Stop();
                    IsCollapsed = false;
                }
            }
            else
            {
                panel1.Height -= 168;
                if (panel1.Size == panel1.MinimumSize)
                {
                    timer1.Stop();
                    IsCollapsed = true;
                }
            }
        }

        private void BTCadatros_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (IsCollapsed)
            {
                panel2.Height += 10;
                if (panel2.Size == panel2.MaximumSize)
                {
                    timer2.Stop();
                    IsCollapsed = false;
                }
            }
            else
            {
                panel2.Height -= 10;
                if (panel2.Size == panel2.MinimumSize)
                {
                    timer2.Stop();
                    IsCollapsed = true;
                }
            }
        }

        private void BTContratos_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void Button1_Click_3(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {Funcionario TCadFunc = new Funcionario();
            TCadFunc.ShowDialog();
        }

        private void Button1_Click_4(object sender, EventArgs e)
        {
            Contrato TCriarcon = new Contrato();
            TCriarcon.ShowDialog();
        }

        private void BTCadastraEspaço_Click(object sender, EventArgs e)
        {
            Cadastrar_Espaço TCadEsp = new Cadastrar_Espaço();
            TCadEsp.ShowDialog();
        }

        private void BTCadastraPlano_Click(object sender, EventArgs e)
        {

            Plano TCriaPlan = new Plano();
            TCriaPlan.ShowDialog();
        }

        private void BTModContrato_Click(object sender, EventArgs e)
        {
            Modficar_Contrato TModContrato = new Modficar_Contrato();
            TModContrato.ShowDialog();
        }

        private void BTRelatorios_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
           // if (IsCollapsed)
            //{
              //  panel3.Height += 10;
               // if (panel3.Size == panel3.MaximumSize)
               // {
                //    timer3.Stop();
                //    IsCollapsed = false;
             //   }
           // }
           // else
          //  {
             //   panel3.Height -= 10;
             //   if (panel3.Size == panel3.MinimumSize)
            //    {
                //    timer3.Stop();
                //    IsCollapsed = true;
             //   }
          //  }
        }

        private void FlowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void BTPagamentos_Click(object sender, EventArgs e)
        {

        }
    }
}


