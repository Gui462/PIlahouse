namespace PITEST
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.BTSair = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTCriaContrato = new System.Windows.Forms.Button();
            this.BTContratos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTCadastraPlano = new System.Windows.Forms.Button();
            this.BTCadastroFuncionario = new System.Windows.Forms.Button();
            this.BTcadastCliente = new System.Windows.Forms.Button();
            this.BTCadatros = new System.Windows.Forms.Button();
            this.BTCadastraEspaço = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTModContrato = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 15;
            this.timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // BTSair
            // 
            this.BTSair.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTSair.Location = new System.Drawing.Point(371, 3);
            this.BTSair.Name = "BTSair";
            this.BTSair.Size = new System.Drawing.Size(175, 52);
            this.BTSair.TabIndex = 4;
            this.BTSair.Text = "SAIR";
            this.BTSair.UseVisualStyleBackColor = true;
            this.BTSair.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BTModContrato);
            this.panel2.Controls.Add(this.BTCriaContrato);
            this.panel2.Controls.Add(this.BTContratos);
            this.panel2.Location = new System.Drawing.Point(187, 3);
            this.panel2.MaximumSize = new System.Drawing.Size(178, 168);
            this.panel2.MinimumSize = new System.Drawing.Size(178, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 59);
            this.panel2.TabIndex = 5;
            // 
            // BTCriaContrato
            // 
            this.BTCriaContrato.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTCriaContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTCriaContrato.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCriaContrato.Location = new System.Drawing.Point(0, 61);
            this.BTCriaContrato.Name = "BTCriaContrato";
            this.BTCriaContrato.Size = new System.Drawing.Size(176, 52);
            this.BTCriaContrato.TabIndex = 2;
            this.BTCriaContrato.Text = "CONTRATO";
            this.BTCriaContrato.UseVisualStyleBackColor = false;
            this.BTCriaContrato.Click += new System.EventHandler(this.Button1_Click_4);
            // 
            // BTContratos
            // 
            this.BTContratos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTContratos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTContratos.Location = new System.Drawing.Point(0, 0);
            this.BTContratos.Name = "BTContratos";
            this.BTContratos.Size = new System.Drawing.Size(178, 52);
            this.BTContratos.TabIndex = 1;
            this.BTContratos.Text = "CONTRATOS";
            this.BTContratos.UseVisualStyleBackColor = true;
            this.BTContratos.Click += new System.EventHandler(this.BTContratos_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTCadastraPlano);
            this.panel1.Controls.Add(this.BTCadastroFuncionario);
            this.panel1.Controls.Add(this.BTcadastCliente);
            this.panel1.Controls.Add(this.BTCadatros);
            this.panel1.Controls.Add(this.BTCadastraEspaço);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.MaximumSize = new System.Drawing.Size(178, 343);
            this.panel1.MinimumSize = new System.Drawing.Size(178, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 59);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // BTCadastraPlano
            // 
            this.BTCadastraPlano.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTCadastraPlano.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTCadastraPlano.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCadastraPlano.Location = new System.Drawing.Point(0, 174);
            this.BTCadastraPlano.Name = "BTCadastraPlano";
            this.BTCadastraPlano.Size = new System.Drawing.Size(176, 52);
            this.BTCadastraPlano.TabIndex = 5;
            this.BTCadastraPlano.Text = "PLANO";
            this.BTCadastraPlano.UseVisualStyleBackColor = false;
            this.BTCadastraPlano.Click += new System.EventHandler(this.BTCadastraPlano_Click);
            // 
            // BTCadastroFuncionario
            // 
            this.BTCadastroFuncionario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTCadastroFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTCadastroFuncionario.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCadastroFuncionario.Location = new System.Drawing.Point(0, 116);
            this.BTCadastroFuncionario.Name = "BTCadastroFuncionario";
            this.BTCadastroFuncionario.Size = new System.Drawing.Size(176, 52);
            this.BTCadastroFuncionario.TabIndex = 2;
            this.BTCadastroFuncionario.Text = "FUNCIONÁRIO";
            this.BTCadastroFuncionario.UseVisualStyleBackColor = false;
            this.BTCadastroFuncionario.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // BTcadastCliente
            // 
            this.BTcadastCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTcadastCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTcadastCliente.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTcadastCliente.Location = new System.Drawing.Point(3, 58);
            this.BTcadastCliente.Name = "BTcadastCliente";
            this.BTcadastCliente.Size = new System.Drawing.Size(172, 52);
            this.BTcadastCliente.TabIndex = 1;
            this.BTcadastCliente.Text = "CLIENTES";
            this.BTcadastCliente.UseVisualStyleBackColor = false;
            this.BTcadastCliente.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // BTCadatros
            // 
            this.BTCadatros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTCadatros.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCadatros.Location = new System.Drawing.Point(0, 0);
            this.BTCadatros.Name = "BTCadatros";
            this.BTCadatros.Size = new System.Drawing.Size(178, 52);
            this.BTCadatros.TabIndex = 0;
            this.BTCadatros.Text = "CADASTROS";
            this.BTCadatros.UseVisualStyleBackColor = true;
            this.BTCadatros.Click += new System.EventHandler(this.BTCadatros_Click);
            // 
            // BTCadastraEspaço
            // 
            this.BTCadastraEspaço.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTCadastraEspaço.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTCadastraEspaço.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCadastraEspaço.Location = new System.Drawing.Point(0, 232);
            this.BTCadastraEspaço.Name = "BTCadastraEspaço";
            this.BTCadastraEspaço.Size = new System.Drawing.Size(176, 52);
            this.BTCadastraEspaço.TabIndex = 3;
            this.BTCadastraEspaço.Text = "ESPAÇO";
            this.BTCadastraEspaço.UseVisualStyleBackColor = false;
            this.BTCadastraEspaço.Click += new System.EventHandler(this.BTCadastraEspaço_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.BTSair);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(928, 622);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutPanel1_Paint_1);
            // 
            // BTModContrato
            // 
            this.BTModContrato.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTModContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTModContrato.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTModContrato.Location = new System.Drawing.Point(-1, 116);
            this.BTModContrato.Name = "BTModContrato";
            this.BTModContrato.Size = new System.Drawing.Size(176, 52);
            this.BTModContrato.TabIndex = 3;
            this.BTModContrato.Text = "MODIFICAR CONTRATO";
            this.BTModContrato.UseVisualStyleBackColor = false;
            this.BTModContrato.Click += new System.EventHandler(this.BTModContrato_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1109, 622);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button BTSair;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTCriaContrato;
        private System.Windows.Forms.Button BTContratos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTCadastraPlano;
        private System.Windows.Forms.Button BTCadastroFuncionario;
        private System.Windows.Forms.Button BTCadatros;
        private System.Windows.Forms.Button BTCadastraEspaço;
        private System.Windows.Forms.Button BTcadastCliente;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BTModContrato;
    }
}