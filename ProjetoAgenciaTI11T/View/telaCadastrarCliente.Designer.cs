
namespace ProjetoAgenciaTI11T.View
{
    partial class telaCadastrarCliente
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
            this.tbxNomeCliente = new System.Windows.Forms.TextBox();
            this.tbxEmailCliente = new System.Windows.Forms.TextBox();
            this.tbxSenhaCliente = new System.Windows.Forms.TextBox();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialogImagem = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(122, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(122, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(122, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            // 
            // tbxNomeCliente
            // 
            this.tbxNomeCliente.Location = new System.Drawing.Point(176, 142);
            this.tbxNomeCliente.Name = "tbxNomeCliente";
            this.tbxNomeCliente.Size = new System.Drawing.Size(267, 23);
            this.tbxNomeCliente.TabIndex = 3;
            // 
            // tbxEmailCliente
            // 
            this.tbxEmailCliente.Location = new System.Drawing.Point(176, 182);
            this.tbxEmailCliente.Name = "tbxEmailCliente";
            this.tbxEmailCliente.Size = new System.Drawing.Size(267, 23);
            this.tbxEmailCliente.TabIndex = 4;
            // 
            // tbxSenhaCliente
            // 
            this.tbxSenhaCliente.Location = new System.Drawing.Point(176, 222);
            this.tbxSenhaCliente.Name = "tbxSenhaCliente";
            this.tbxSenhaCliente.PasswordChar = '*';
            this.tbxSenhaCliente.Size = new System.Drawing.Size(267, 23);
            this.tbxSenhaCliente.TabIndex = 5;
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(233, 265);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(75, 23);
            this.bntSalvar.TabIndex = 6;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(498, 265);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar Imagem";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(449, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 117);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(233, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cadastro de Cliente";
            // 
            // openFileDialogImagem
            // 
            this.openFileDialogImagem.FileName = "openFileDialogImagem";
            // 
            // telaCadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.tbxSenhaCliente);
            this.Controls.Add(this.tbxEmailCliente);
            this.Controls.Add(this.tbxNomeCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "telaCadastrarCliente";
            this.Text = "TelaCadastrarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNomeCliente;
        private System.Windows.Forms.TextBox tbxEmailCliente;
        private System.Windows.Forms.TextBox tbxSenhaCliente;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialogImagem;
    }
}