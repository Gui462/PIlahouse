namespace PITEST
{
    partial class Criar_Planos
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
            this.BoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxMes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BoxDia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxPeriodo = new System.Windows.Forms.TextBox();
            this.p = new System.Windows.Forms.Label();
            this.BoxDesconto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxOBS = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BoxDescricao = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BoxNome
            // 
            this.BoxNome.Location = new System.Drawing.Point(163, 24);
            this.BoxNome.Name = "BoxNome";
            this.BoxNome.Size = new System.Drawing.Size(244, 20);
            this.BoxNome.TabIndex = 3;
            this.BoxNome.TextChanged += new System.EventHandler(this.BoxNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Plano:  ";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // BoxValor
            // 
            this.BoxValor.Location = new System.Drawing.Point(163, 180);
            this.BoxValor.Name = "BoxValor";
            this.BoxValor.Size = new System.Drawing.Size(38, 20);
            this.BoxValor.TabIndex = 5;
            this.BoxValor.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor Hora: ";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // BoxMes
            // 
            this.BoxMes.Location = new System.Drawing.Point(163, 151);
            this.BoxMes.Name = "BoxMes";
            this.BoxMes.Size = new System.Drawing.Size(38, 20);
            this.BoxMes.TabIndex = 7;
            this.BoxMes.TextChanged += new System.EventHandler(this.BoxMes_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Horas/Mês: ";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 55);
            this.button2.TabIndex = 9;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // BoxDia
            // 
            this.BoxDia.Location = new System.Drawing.Point(369, 150);
            this.BoxDia.Name = "BoxDia";
            this.BoxDia.Size = new System.Drawing.Size(38, 20);
            this.BoxDia.TabIndex = 11;
            this.BoxDia.TextChanged += new System.EventHandler(this.BoxDia_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Horas/Dia:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // BoxPeriodo
            // 
            this.BoxPeriodo.Location = new System.Drawing.Point(163, 211);
            this.BoxPeriodo.Name = "BoxPeriodo";
            this.BoxPeriodo.Size = new System.Drawing.Size(114, 20);
            this.BoxPeriodo.TabIndex = 13;
            this.BoxPeriodo.TextChanged += new System.EventHandler(this.BoxPeriodo_TextChanged);
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.p.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p.Location = new System.Drawing.Point(34, 212);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(69, 19);
            this.p.TabIndex = 12;
            this.p.Text = "Período: ";
            this.p.Click += new System.EventHandler(this.P_Click);
            // 
            // BoxDesconto
            // 
            this.BoxDesconto.Location = new System.Drawing.Point(369, 176);
            this.BoxDesconto.Name = "BoxDesconto";
            this.BoxDesconto.Size = new System.Drawing.Size(38, 20);
            this.BoxDesconto.TabIndex = 15;
            this.BoxDesconto.TextChanged += new System.EventHandler(this.BoxDesconto_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Desconto ";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // BoxOBS
            // 
            this.BoxOBS.Location = new System.Drawing.Point(163, 249);
            this.BoxOBS.Name = "BoxOBS";
            this.BoxOBS.Size = new System.Drawing.Size(244, 96);
            this.BoxOBS.TabIndex = 16;
            this.BoxOBS.Text = "";
            this.BoxOBS.TextChanged += new System.EventHandler(this.BoxOBS_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Observações:  ";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Descrição:";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // BoxDescricao
            // 
            this.BoxDescricao.Location = new System.Drawing.Point(163, 63);
            this.BoxDescricao.Name = "BoxDescricao";
            this.BoxDescricao.Size = new System.Drawing.Size(244, 59);
            this.BoxDescricao.TabIndex = 18;
            this.BoxDescricao.Text = "";
            this.BoxDescricao.TextChanged += new System.EventHandler(this.BoxDescricao_TextChanged);
            // 
            // Criar_Planos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BoxDescricao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BoxOBS);
            this.Controls.Add(this.BoxDesconto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BoxPeriodo);
            this.Controls.Add(this.p);
            this.Controls.Add(this.BoxDia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BoxMes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BoxValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxNome);
            this.Controls.Add(this.label1);
            this.Name = "Criar_Planos";
            this.Text = "Criar_Planos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox BoxDia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BoxPeriodo;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.TextBox BoxDesconto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox BoxOBS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox BoxDescricao;
    }
}