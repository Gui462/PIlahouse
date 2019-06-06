namespace PITEST
{
    partial class Funcionario
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
            this.BTCADASTRAR = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BoxCodigo = new System.Windows.Forms.TextBox();
            this.Lnome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LRG = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LCargo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lgerente = new System.Windows.Forms.Label();
            this.Ltelefone = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTCADASTRAR
            // 
            this.BTCADASTRAR.Location = new System.Drawing.Point(137, 297);
            this.BTCADASTRAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTCADASTRAR.Name = "BTCADASTRAR";
            this.BTCADASTRAR.Size = new System.Drawing.Size(117, 97);
            this.BTCADASTRAR.TabIndex = 0;
            this.BTCADASTRAR.Text = "Cadastrar";
            this.BTCADASTRAR.UseVisualStyleBackColor = true;
            this.BTCADASTRAR.Click += new System.EventHandler(this.BoxCodigo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 297);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 97);
            this.button2.TabIndex = 1;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // BoxCodigo
            // 
            this.BoxCodigo.Location = new System.Drawing.Point(195, 75);
            this.BoxCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.BoxCodigo.Name = "BoxCodigo";
            this.BoxCodigo.Size = new System.Drawing.Size(37, 22);
            this.BoxCodigo.TabIndex = 2;
            this.BoxCodigo.TextChanged += new System.EventHandler(this.BoxCodigo_TextChanged);
            // 
            // Lnome
            // 
            this.Lnome.AutoSize = true;
            this.Lnome.BackColor = System.Drawing.SystemColors.Control;
            this.Lnome.Location = new System.Drawing.Point(357, 78);
            this.Lnome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lnome.Name = "Lnome";
            this.Lnome.Size = new System.Drawing.Size(16, 16);
            this.Lnome.TabIndex = 3;
            this.Lnome.Text = "--";
            this.Lnome.Click += new System.EventHandler(this.Lnome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(46, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo Funcionario:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(267, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome: ";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // LRG
            // 
            this.LRG.AutoSize = true;
            this.LRG.BackColor = System.Drawing.SystemColors.Control;
            this.LRG.Location = new System.Drawing.Point(357, 167);
            this.LRG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LRG.Name = "LRG";
            this.LRG.Size = new System.Drawing.Size(16, 16);
            this.LRG.TabIndex = 6;
            this.LRG.Text = "--";
            this.LRG.Click += new System.EventHandler(this.LRG_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(267, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "RG: ";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(267, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telefone:";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(267, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cargo:";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // LCargo
            // 
            this.LCargo.AutoSize = true;
            this.LCargo.BackColor = System.Drawing.SystemColors.Control;
            this.LCargo.Location = new System.Drawing.Point(357, 108);
            this.LCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCargo.Name = "LCargo";
            this.LCargo.Size = new System.Drawing.Size(16, 16);
            this.LCargo.TabIndex = 10;
            this.LCargo.Text = "--";
            this.LCargo.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(267, 138);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Gerente:";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // Lgerente
            // 
            this.Lgerente.AutoSize = true;
            this.Lgerente.BackColor = System.Drawing.SystemColors.Control;
            this.Lgerente.Location = new System.Drawing.Point(357, 138);
            this.Lgerente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lgerente.Name = "Lgerente";
            this.Lgerente.Size = new System.Drawing.Size(16, 16);
            this.Lgerente.TabIndex = 12;
            this.Lgerente.Text = "--";
            this.Lgerente.Click += new System.EventHandler(this.Lgerente_Click);
            // 
            // Ltelefone
            // 
            this.Ltelefone.AutoSize = true;
            this.Ltelefone.BackColor = System.Drawing.SystemColors.Control;
            this.Ltelefone.Location = new System.Drawing.Point(357, 199);
            this.Ltelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ltelefone.Name = "Ltelefone";
            this.Ltelefone.Size = new System.Drawing.Size(16, 16);
            this.Ltelefone.TabIndex = 13;
            this.Ltelefone.Text = "--";
            this.Ltelefone.Click += new System.EventHandler(this.Ltelefone_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 97);
            this.button1.TabIndex = 14;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(706, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ltelefone);
            this.Controls.Add(this.Lgerente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LCargo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LRG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lnome);
            this.Controls.Add(this.BoxCodigo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTCADASTRAR);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Funcionario";
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTCADASTRAR;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox BoxCodigo;
        private System.Windows.Forms.Label Lnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LRG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LCargo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lgerente;
        private System.Windows.Forms.Label Ltelefone;
        private System.Windows.Forms.Button button1;
    }
}