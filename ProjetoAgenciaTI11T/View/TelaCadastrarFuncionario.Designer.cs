
namespace ProjetoAgenciaTI11T.View
{
    partial class TelaCadastrarFuncionario
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
            this.tbxNomeFun = new System.Windows.Forms.TextBox();
            this.tbxSenhaFun = new System.Windows.Forms.TextBox();
            this.tbxEmailFun = new System.Windows.Forms.TextBox();
            this.btnSalvarFun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(145, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(154, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(150, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(150, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha";
            // 
            // tbxNomeFun
            // 
            this.tbxNomeFun.Location = new System.Drawing.Point(216, 165);
            this.tbxNomeFun.Name = "tbxNomeFun";
            this.tbxNomeFun.Size = new System.Drawing.Size(310, 23);
            this.tbxNomeFun.TabIndex = 4;
            // 
            // tbxSenhaFun
            // 
            this.tbxSenhaFun.Location = new System.Drawing.Point(216, 261);
            this.tbxSenhaFun.Name = "tbxSenhaFun";
            this.tbxSenhaFun.Size = new System.Drawing.Size(310, 23);
            this.tbxSenhaFun.TabIndex = 5;
            // 
            // tbxEmailFun
            // 
            this.tbxEmailFun.Location = new System.Drawing.Point(216, 211);
            this.tbxEmailFun.Name = "tbxEmailFun";
            this.tbxEmailFun.Size = new System.Drawing.Size(310, 23);
            this.tbxEmailFun.TabIndex = 6;
            // 
            // btnSalvarFun
            // 
            this.btnSalvarFun.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvarFun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvarFun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarFun.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSalvarFun.Location = new System.Drawing.Point(321, 290);
            this.btnSalvarFun.Name = "btnSalvarFun";
            this.btnSalvarFun.Size = new System.Drawing.Size(81, 36);
            this.btnSalvarFun.TabIndex = 7;
            this.btnSalvarFun.Text = "Salvar";
            this.btnSalvarFun.UseVisualStyleBackColor = false;
            this.btnSalvarFun.Click += new System.EventHandler(this.btnSalvarFun_Click);
            // 
            // TelaCadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.btnSalvarFun);
            this.Controls.Add(this.tbxEmailFun);
            this.Controls.Add(this.tbxSenhaFun);
            this.Controls.Add(this.tbxNomeFun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastrarFuncionario";
            this.Text = "telaCadastrarFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNomeFun;
        private System.Windows.Forms.TextBox tbxSenhaFun;
        private System.Windows.Forms.TextBox tbxEmailFun;
        private System.Windows.Forms.Button btnSalvarFun;
    }
}