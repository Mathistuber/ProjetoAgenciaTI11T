
namespace ProjetoAgenciaTI11T.View
{
    partial class TelaPesquisarFuncionario
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAlterarFuncionario = new System.Windows.Forms.Button();
            this.btnDeletarFuncionario = new System.Windows.Forms.Button();
            this.btnBuscarFuncionario = new System.Windows.Forms.Button();
            this.tbxSenhaFun = new System.Windows.Forms.TextBox();
            this.tbxEmailFun = new System.Windows.Forms.TextBox();
            this.tbxNomeFun = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxCodigoFun = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar Funcionario";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 106);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 332);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 304);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisar por Nome ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAlterarFuncionario);
            this.tabPage1.Controls.Add(this.btnDeletarFuncionario);
            this.tabPage1.Controls.Add(this.btnBuscarFuncionario);
            this.tabPage1.Controls.Add(this.tbxSenhaFun);
            this.tabPage1.Controls.Add(this.tbxEmailFun);
            this.tabPage1.Controls.Add(this.tbxNomeFun);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.tbxCodigoFun);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 304);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Pesquisar por Código";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAlterarFuncionario
            // 
            this.btnAlterarFuncionario.Location = new System.Drawing.Point(291, 265);
            this.btnAlterarFuncionario.Name = "btnAlterarFuncionario";
            this.btnAlterarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarFuncionario.TabIndex = 26;
            this.btnAlterarFuncionario.Text = "Alterar";
            this.btnAlterarFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnDeletarFuncionario
            // 
            this.btnDeletarFuncionario.Location = new System.Drawing.Point(372, 265);
            this.btnDeletarFuncionario.Name = "btnDeletarFuncionario";
            this.btnDeletarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarFuncionario.TabIndex = 25;
            this.btnDeletarFuncionario.Text = "Deletar";
            this.btnDeletarFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnBuscarFuncionario
            // 
            this.btnBuscarFuncionario.Location = new System.Drawing.Point(645, 44);
            this.btnBuscarFuncionario.Name = "btnBuscarFuncionario";
            this.btnBuscarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarFuncionario.TabIndex = 23;
            this.btnBuscarFuncionario.Text = "Buscar";
            this.btnBuscarFuncionario.UseVisualStyleBackColor = true;
            this.btnBuscarFuncionario.Click += new System.EventHandler(this.btnBuscarFuncionario_Click);
            // 
            // tbxSenhaFun
            // 
            this.tbxSenhaFun.Location = new System.Drawing.Point(60, 189);
            this.tbxSenhaFun.Name = "tbxSenhaFun";
            this.tbxSenhaFun.PasswordChar = '*';
            this.tbxSenhaFun.Size = new System.Drawing.Size(660, 23);
            this.tbxSenhaFun.TabIndex = 21;
            // 
            // tbxEmailFun
            // 
            this.tbxEmailFun.Location = new System.Drawing.Point(61, 149);
            this.tbxEmailFun.Name = "tbxEmailFun";
            this.tbxEmailFun.Size = new System.Drawing.Size(659, 23);
            this.tbxEmailFun.TabIndex = 20;
            // 
            // tbxNomeFun
            // 
            this.tbxNomeFun.Location = new System.Drawing.Point(61, 109);
            this.tbxNomeFun.Name = "tbxNomeFun";
            this.tbxNomeFun.Size = new System.Drawing.Size(659, 23);
            this.tbxNomeFun.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(15, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Senha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(15, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "E-mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(15, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nome";
            // 
            // tbxCodigoFun
            // 
            this.tbxCodigoFun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxCodigoFun.Location = new System.Drawing.Point(259, 40);
            this.tbxCodigoFun.Name = "tbxCodigoFun";
            this.tbxCodigoFun.Size = new System.Drawing.Size(353, 29);
            this.tbxCodigoFun.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite o Codigo do Funcionario...";
            // 
            // TelaPesquisarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "TelaPesquisarFuncionario";
            this.Text = "TelaPesquisarFuncionario";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCodigoFun;
        private System.Windows.Forms.TextBox tbxSenhaFun;
        private System.Windows.Forms.TextBox tbxEmailFun;
        private System.Windows.Forms.TextBox tbxNomeFun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAlterarFuncionario;
        private System.Windows.Forms.Button btnDeletarFuncionario;
        private System.Windows.Forms.Button btnBuscarFuncionario;
    }
}