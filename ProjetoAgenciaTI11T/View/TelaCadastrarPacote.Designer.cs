
namespace ProjetoAgenciaTI11T.View
{
    partial class TelaCadastrarPacote
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSalvarPacote = new System.Windows.Forms.Button();
            this.btnBuscarPacote = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.tbxDataVolta = new System.Windows.Forms.TextBox();
            this.tbxDataIda = new System.Windows.Forms.TextBox();
            this.tbxDestino = new System.Windows.Forms.TextBox();
            this.tbxOrigemPacote = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(82, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Pacote";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(82, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origem do Pacote";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(82, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destino do Pacote";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(82, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de Ida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(82, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Volta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(82, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descrição";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(412, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 178);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnSalvarPacote
            // 
            this.btnSalvarPacote.Location = new System.Drawing.Point(210, 338);
            this.btnSalvarPacote.Name = "btnSalvarPacote";
            this.btnSalvarPacote.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarPacote.TabIndex = 7;
            this.btnSalvarPacote.Text = "Salvar";
            this.btnSalvarPacote.UseVisualStyleBackColor = true;
            this.btnSalvarPacote.Click += new System.EventHandler(this.btnSalvarPacote_Click);
            // 
            // btnBuscarPacote
            // 
            this.btnBuscarPacote.Location = new System.Drawing.Point(480, 338);
            this.btnBuscarPacote.Name = "btnBuscarPacote";
            this.btnBuscarPacote.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPacote.TabIndex = 8;
            this.btnBuscarPacote.Text = "Buscar";
            this.btnBuscarPacote.UseVisualStyleBackColor = true;
            this.btnBuscarPacote.Click += new System.EventHandler(this.btnBuscarPacote_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(210, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(323, 38);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cadastrar Pacote";
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(160, 137);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(218, 23);
            this.tbxValor.TabIndex = 10;
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Location = new System.Drawing.Point(146, 292);
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(232, 23);
            this.tbxDescricao.TabIndex = 11;
            // 
            // tbxDataVolta
            // 
            this.tbxDataVolta.Location = new System.Drawing.Point(164, 261);
            this.tbxDataVolta.Name = "tbxDataVolta";
            this.tbxDataVolta.Size = new System.Drawing.Size(214, 23);
            this.tbxDataVolta.TabIndex = 12;
            // 
            // tbxDataIda
            // 
            this.tbxDataIda.Location = new System.Drawing.Point(154, 230);
            this.tbxDataIda.Name = "tbxDataIda";
            this.tbxDataIda.Size = new System.Drawing.Size(224, 23);
            this.tbxDataIda.TabIndex = 13;
            // 
            // tbxDestino
            // 
            this.tbxDestino.Location = new System.Drawing.Point(191, 199);
            this.tbxDestino.Name = "tbxDestino";
            this.tbxDestino.Size = new System.Drawing.Size(187, 23);
            this.tbxDestino.TabIndex = 14;
            // 
            // tbxOrigemPacote
            // 
            this.tbxOrigemPacote.Location = new System.Drawing.Point(191, 168);
            this.tbxOrigemPacote.Name = "tbxOrigemPacote";
            this.tbxOrigemPacote.Size = new System.Drawing.Size(187, 23);
            this.tbxOrigemPacote.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TelaCadastrarPacote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.tbxOrigemPacote);
            this.Controls.Add(this.tbxDestino);
            this.Controls.Add(this.tbxDataIda);
            this.Controls.Add(this.tbxDataVolta);
            this.Controls.Add(this.tbxDescricao);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscarPacote);
            this.Controls.Add(this.btnSalvarPacote);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastrarPacote";
            this.Text = "telaCadastrarPacote";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSalvarPacote;
        private System.Windows.Forms.Button btnBuscarPacote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.TextBox tbxDataVolta;
        private System.Windows.Forms.TextBox tbxDataIda;
        private System.Windows.Forms.TextBox tbxDestino;
        private System.Windows.Forms.TextBox tbxOrigemPacote;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}