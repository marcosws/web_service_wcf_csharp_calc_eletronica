namespace Wcf_CalculoEletronica_Cliente_Win
{
    partial class frmCalculo
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
            this.ValorResistencia = new System.Windows.Forms.TextBox();
            this.ValorCorrente = new System.Windows.Forms.TextBox();
            this.ValorTensao = new System.Windows.Forms.TextBox();
            this.cbResistencia = new System.Windows.Forms.ComboBox();
            this.cbCorrente = new System.Windows.Forms.ComboBox();
            this.cbTensao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultadoTexto = new System.Windows.Forms.TextBox();
            this.gbResistencia = new System.Windows.Forms.GroupBox();
            this.gbCorrente = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbTensao = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbTensao = new System.Windows.Forms.RadioButton();
            this.rbCorrente = new System.Windows.Forms.RadioButton();
            this.rbResistencia = new System.Windows.Forms.RadioButton();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.gbResistencia.SuspendLayout();
            this.gbCorrente.SuspendLayout();
            this.gbTensao.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ValorResistencia
            // 
            this.ValorResistencia.Location = new System.Drawing.Point(9, 32);
            this.ValorResistencia.Name = "ValorResistencia";
            this.ValorResistencia.Size = new System.Drawing.Size(121, 20);
            this.ValorResistencia.TabIndex = 0;
            // 
            // ValorCorrente
            // 
            this.ValorCorrente.Location = new System.Drawing.Point(9, 32);
            this.ValorCorrente.Name = "ValorCorrente";
            this.ValorCorrente.Size = new System.Drawing.Size(121, 20);
            this.ValorCorrente.TabIndex = 1;
            // 
            // ValorTensao
            // 
            this.ValorTensao.Location = new System.Drawing.Point(6, 32);
            this.ValorTensao.Name = "ValorTensao";
            this.ValorTensao.Size = new System.Drawing.Size(121, 20);
            this.ValorTensao.TabIndex = 2;
            // 
            // cbResistencia
            // 
            this.cbResistencia.FormattingEnabled = true;
            this.cbResistencia.Items.AddRange(new object[] {
            "(µΩ) Micro-Ohm",
            "(mΩ) Mili-Ohm",
            "(Ω) Ohm",
            "(kΩ) Kilo-Ohm",
            "(MΩ) Mega-Ohm"});
            this.cbResistencia.Location = new System.Drawing.Point(9, 77);
            this.cbResistencia.Name = "cbResistencia";
            this.cbResistencia.Size = new System.Drawing.Size(121, 21);
            this.cbResistencia.TabIndex = 3;
            this.cbResistencia.Tag = "";
            // 
            // cbCorrente
            // 
            this.cbCorrente.FormattingEnabled = true;
            this.cbCorrente.Items.AddRange(new object[] {
            "(µA) Micro-Ampere",
            "(mA) Mili-Ampere",
            "(A) Ampere"});
            this.cbCorrente.Location = new System.Drawing.Point(9, 77);
            this.cbCorrente.Name = "cbCorrente";
            this.cbCorrente.Size = new System.Drawing.Size(121, 21);
            this.cbCorrente.TabIndex = 4;
            // 
            // cbTensao
            // 
            this.cbTensao.FormattingEnabled = true;
            this.cbTensao.Items.AddRange(new object[] {
            "(µV) Micro-Volt",
            "(mV) Mili-Volt",
            "(V) Volt"});
            this.cbTensao.Location = new System.Drawing.Point(6, 77);
            this.cbTensao.Name = "cbTensao";
            this.cbTensao.Size = new System.Drawing.Size(121, 21);
            this.cbTensao.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Unidade:";
            // 
            // ResultadoTexto
            // 
            this.ResultadoTexto.BackColor = System.Drawing.SystemColors.WindowText;
            this.ResultadoTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoTexto.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ResultadoTexto.Location = new System.Drawing.Point(12, 128);
            this.ResultadoTexto.Multiline = true;
            this.ResultadoTexto.Name = "ResultadoTexto";
            this.ResultadoTexto.ReadOnly = true;
            this.ResultadoTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultadoTexto.Size = new System.Drawing.Size(595, 324);
            this.ResultadoTexto.TabIndex = 8;
            // 
            // gbResistencia
            // 
            this.gbResistencia.Controls.Add(this.label1);
            this.gbResistencia.Controls.Add(this.ValorResistencia);
            this.gbResistencia.Controls.Add(this.label2);
            this.gbResistencia.Controls.Add(this.cbResistencia);
            this.gbResistencia.Enabled = false;
            this.gbResistencia.Location = new System.Drawing.Point(163, 12);
            this.gbResistencia.Name = "gbResistencia";
            this.gbResistencia.Size = new System.Drawing.Size(144, 110);
            this.gbResistencia.TabIndex = 9;
            this.gbResistencia.TabStop = false;
            this.gbResistencia.Text = "Resistência Ohm (Ω).";
            // 
            // gbCorrente
            // 
            this.gbCorrente.Controls.Add(this.label4);
            this.gbCorrente.Controls.Add(this.label3);
            this.gbCorrente.Controls.Add(this.ValorCorrente);
            this.gbCorrente.Controls.Add(this.cbCorrente);
            this.gbCorrente.Location = new System.Drawing.Point(313, 12);
            this.gbCorrente.Name = "gbCorrente";
            this.gbCorrente.Size = new System.Drawing.Size(144, 110);
            this.gbCorrente.TabIndex = 10;
            this.gbCorrente.TabStop = false;
            this.gbCorrente.Text = "Corrente Ampere (A)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor:";
            // 
            // gbTensao
            // 
            this.gbTensao.Controls.Add(this.label6);
            this.gbTensao.Controls.Add(this.label5);
            this.gbTensao.Controls.Add(this.ValorTensao);
            this.gbTensao.Controls.Add(this.cbTensao);
            this.gbTensao.Location = new System.Drawing.Point(463, 12);
            this.gbTensao.Name = "gbTensao";
            this.gbTensao.Size = new System.Drawing.Size(144, 110);
            this.gbTensao.TabIndex = 11;
            this.gbTensao.TabStop = false;
            this.gbTensao.Text = "Tensão Volt (V)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Unidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Valor:";
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(12, 458);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(144, 23);
            this.btCalcular.TabIndex = 12;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbTensao);
            this.groupBox4.Controls.Add(this.rbCorrente);
            this.groupBox4.Controls.Add(this.rbResistencia);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(144, 110);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Calcular";
            // 
            // rbTensao
            // 
            this.rbTensao.AutoSize = true;
            this.rbTensao.Location = new System.Drawing.Point(18, 77);
            this.rbTensao.Name = "rbTensao";
            this.rbTensao.Size = new System.Drawing.Size(61, 17);
            this.rbTensao.TabIndex = 16;
            this.rbTensao.Text = "Tensão";
            this.rbTensao.UseVisualStyleBackColor = true;
            this.rbTensao.CheckedChanged += new System.EventHandler(this.rbTensao_CheckedChanged);
            // 
            // rbCorrente
            // 
            this.rbCorrente.AutoSize = true;
            this.rbCorrente.Location = new System.Drawing.Point(18, 54);
            this.rbCorrente.Name = "rbCorrente";
            this.rbCorrente.Size = new System.Drawing.Size(65, 17);
            this.rbCorrente.TabIndex = 15;
            this.rbCorrente.Text = "Corrente";
            this.rbCorrente.UseVisualStyleBackColor = true;
            this.rbCorrente.CheckedChanged += new System.EventHandler(this.rbCorrente_CheckedChanged);
            // 
            // rbResistencia
            // 
            this.rbResistencia.AutoSize = true;
            this.rbResistencia.Checked = true;
            this.rbResistencia.Location = new System.Drawing.Point(18, 31);
            this.rbResistencia.Name = "rbResistencia";
            this.rbResistencia.Size = new System.Drawing.Size(80, 17);
            this.rbResistencia.TabIndex = 14;
            this.rbResistencia.TabStop = true;
            this.rbResistencia.Text = "Resistência";
            this.rbResistencia.UseVisualStyleBackColor = true;
            this.rbResistencia.CheckedChanged += new System.EventHandler(this.rbResistencia_CheckedChanged);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(163, 458);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(144, 23);
            this.btLimpar.TabIndex = 14;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(463, 458);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(144, 23);
            this.btFechar.TabIndex = 15;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // frmCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 493);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.gbTensao);
            this.Controls.Add(this.gbCorrente);
            this.Controls.Add(this.gbResistencia);
            this.Controls.Add(this.ResultadoTexto);
            this.Name = "frmCalculo";
            this.Text = "Calculo Eletronica";
            this.Load += new System.EventHandler(this.frmCalculo_Load);
            this.gbResistencia.ResumeLayout(false);
            this.gbResistencia.PerformLayout();
            this.gbCorrente.ResumeLayout(false);
            this.gbCorrente.PerformLayout();
            this.gbTensao.ResumeLayout(false);
            this.gbTensao.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ValorResistencia;
        private System.Windows.Forms.TextBox ValorCorrente;
        private System.Windows.Forms.TextBox ValorTensao;
        private System.Windows.Forms.ComboBox cbResistencia;
        private System.Windows.Forms.ComboBox cbCorrente;
        private System.Windows.Forms.ComboBox cbTensao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ResultadoTexto;
        private System.Windows.Forms.GroupBox gbResistencia;
        private System.Windows.Forms.GroupBox gbCorrente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbTensao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbTensao;
        private System.Windows.Forms.RadioButton rbCorrente;
        private System.Windows.Forms.RadioButton rbResistencia;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btFechar;
    }
}

