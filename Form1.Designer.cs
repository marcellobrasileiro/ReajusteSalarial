
namespace ReajusteSalarial
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSalarioMin = new System.Windows.Forms.Label();
            this.lblHorasTrabalhadas = new System.Windows.Forms.Label();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.rbnVeterano = new System.Windows.Forms.RadioButton();
            this.rbnCalouro = new System.Windows.Forms.RadioButton();
            this.gbTurno = new System.Windows.Forms.GroupBox();
            this.rbnNoturno = new System.Windows.Forms.RadioButton();
            this.rbnVespertino = new System.Windows.Forms.RadioButton();
            this.rbnMatutino = new System.Windows.Forms.RadioButton();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.txtSituacaoEstagiario = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbxResumo = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbCategoria.SuspendLayout();
            this.gbTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalarioMin
            // 
            this.lblSalarioMin.AutoSize = true;
            this.lblSalarioMin.Location = new System.Drawing.Point(33, 47);
            this.lblSalarioMin.Name = "lblSalarioMin";
            this.lblSalarioMin.Size = new System.Drawing.Size(104, 17);
            this.lblSalarioMin.TabIndex = 0;
            this.lblSalarioMin.Text = "Salário Mínimo:";
            // 
            // lblHorasTrabalhadas
            // 
            this.lblHorasTrabalhadas.AutoSize = true;
            this.lblHorasTrabalhadas.Location = new System.Drawing.Point(33, 85);
            this.lblHorasTrabalhadas.Name = "lblHorasTrabalhadas";
            this.lblHorasTrabalhadas.Size = new System.Drawing.Size(134, 17);
            this.lblHorasTrabalhadas.TabIndex = 1;
            this.lblHorasTrabalhadas.Text = "Horas Trabalhadas:";
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.rbnVeterano);
            this.gbCategoria.Controls.Add(this.rbnCalouro);
            this.gbCategoria.Location = new System.Drawing.Point(36, 120);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(290, 65);
            this.gbCategoria.TabIndex = 2;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Categoria";
            // 
            // rbnVeterano
            // 
            this.rbnVeterano.AutoSize = true;
            this.rbnVeterano.Location = new System.Drawing.Point(164, 36);
            this.rbnVeterano.Name = "rbnVeterano";
            this.rbnVeterano.Size = new System.Drawing.Size(87, 21);
            this.rbnVeterano.TabIndex = 1;
            this.rbnVeterano.TabStop = true;
            this.rbnVeterano.Text = "Veterano";
            this.rbnVeterano.UseVisualStyleBackColor = true;
            // 
            // rbnCalouro
            // 
            this.rbnCalouro.AutoSize = true;
            this.rbnCalouro.Location = new System.Drawing.Point(18, 36);
            this.rbnCalouro.Name = "rbnCalouro";
            this.rbnCalouro.Size = new System.Drawing.Size(78, 21);
            this.rbnCalouro.TabIndex = 0;
            this.rbnCalouro.TabStop = true;
            this.rbnCalouro.Text = "Calouro";
            this.rbnCalouro.UseVisualStyleBackColor = true;
            // 
            // gbTurno
            // 
            this.gbTurno.Controls.Add(this.rbnNoturno);
            this.gbTurno.Controls.Add(this.rbnVespertino);
            this.gbTurno.Controls.Add(this.rbnMatutino);
            this.gbTurno.Location = new System.Drawing.Point(339, 47);
            this.gbTurno.Name = "gbTurno";
            this.gbTurno.Size = new System.Drawing.Size(150, 138);
            this.gbTurno.TabIndex = 3;
            this.gbTurno.TabStop = false;
            this.gbTurno.Text = "Turno";
            // 
            // rbnNoturno
            // 
            this.rbnNoturno.AutoSize = true;
            this.rbnNoturno.Location = new System.Drawing.Point(20, 109);
            this.rbnNoturno.Name = "rbnNoturno";
            this.rbnNoturno.Size = new System.Drawing.Size(80, 21);
            this.rbnNoturno.TabIndex = 2;
            this.rbnNoturno.TabStop = true;
            this.rbnNoturno.Text = "Noturno";
            this.rbnNoturno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbnNoturno.UseVisualStyleBackColor = true;
            // 
            // rbnVespertino
            // 
            this.rbnVespertino.AutoSize = true;
            this.rbnVespertino.Location = new System.Drawing.Point(20, 73);
            this.rbnVespertino.Name = "rbnVespertino";
            this.rbnVespertino.Size = new System.Drawing.Size(97, 21);
            this.rbnVespertino.TabIndex = 1;
            this.rbnVespertino.TabStop = true;
            this.rbnVespertino.Text = "Vespertino";
            this.rbnVespertino.UseVisualStyleBackColor = true;
            // 
            // rbnMatutino
            // 
            this.rbnMatutino.AutoSize = true;
            this.rbnMatutino.Location = new System.Drawing.Point(20, 33);
            this.rbnMatutino.Name = "rbnMatutino";
            this.rbnMatutino.Size = new System.Drawing.Size(83, 21);
            this.rbnMatutino.TabIndex = 0;
            this.rbnMatutino.TabStop = true;
            this.rbnMatutino.Text = "Matutino";
            this.rbnMatutino.UseVisualStyleBackColor = true;
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Location = new System.Drawing.Point(190, 47);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(136, 22);
            this.txtSalarioMinimo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtSalarioMinimo, "Informe o valor atual para o salário mínimo");
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(190, 85);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(135, 22);
            this.txtHorasTrabalhadas.TabIndex = 5;
            // 
            // txtSituacaoEstagiario
            // 
            this.txtSituacaoEstagiario.BackColor = System.Drawing.Color.Yellow;
            this.txtSituacaoEstagiario.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacaoEstagiario.ForeColor = System.Drawing.Color.Blue;
            this.txtSituacaoEstagiario.Location = new System.Drawing.Point(36, 366);
            this.txtSituacaoEstagiario.Name = "txtSituacaoEstagiario";
            this.txtSituacaoEstagiario.Size = new System.Drawing.Size(314, 28);
            this.txtSituacaoEstagiario.TabIndex = 7;
            this.txtSituacaoEstagiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(373, 361);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(116, 36);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbxResumo
            // 
            this.lbxResumo.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxResumo.FormattingEnabled = true;
            this.lbxResumo.ItemHeight = 16;
            this.lbxResumo.Location = new System.Drawing.Point(36, 196);
            this.lbxResumo.Name = "lbxResumo";
            this.lbxResumo.Size = new System.Drawing.Size(453, 148);
            this.lbxResumo.TabIndex = 9;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ajuda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 406);
            this.Controls.Add(this.lbxResumo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSituacaoEstagiario);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.gbTurno);
            this.Controls.Add(this.gbCategoria);
            this.Controls.Add(this.lblHorasTrabalhadas);
            this.Controls.Add(this.lblSalarioMin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCategoria.ResumeLayout(false);
            this.gbCategoria.PerformLayout();
            this.gbTurno.ResumeLayout(false);
            this.gbTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalarioMin;
        private System.Windows.Forms.Label lblHorasTrabalhadas;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.RadioButton rbnVeterano;
        private System.Windows.Forms.RadioButton rbnCalouro;
        private System.Windows.Forms.GroupBox gbTurno;
        private System.Windows.Forms.RadioButton rbnNoturno;
        private System.Windows.Forms.RadioButton rbnVespertino;
        private System.Windows.Forms.RadioButton rbnMatutino;
        private System.Windows.Forms.TextBox txtSalarioMinimo;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.TextBox txtSituacaoEstagiario;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox lbxResumo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

