
namespace ProjetoAgenciaTI11T.View
{
    partial class TelaPesquisarPacote
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewPaco = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarNomePacote = new System.Windows.Forms.Button();
            this.tbxOrigem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxDataVolta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxDataIda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxPacote = new System.Windows.Forms.PictureBox();
            this.tbxDestinoPacote = new System.Windows.Forms.TextBox();
            this.tbxOrigemPacote = new System.Windows.Forms.TextBox();
            this.tbxValorPacote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscarPacote = new System.Windows.Forms.Button();
            this.btnAlterarPacote = new System.Windows.Forms.Button();
            this.btnDeletarPacote = new System.Windows.Forms.Button();
            this.btnBuscarImagemPacote = new System.Windows.Forms.Button();
            this.tbxCodigoPacote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialogPacote = new System.Windows.Forms.OpenFileDialog();
            this.tbxDescrição = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaco)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPacote)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar Pacotes";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 105);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 333);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewPaco);
            this.tabPage1.Controls.Add(this.btnBuscarNomePacote);
            this.tabPage1.Controls.Add(this.tbxOrigem);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar por Nome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPaco
            // 
            this.dataGridViewPaco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPaco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Origem,
            this.Destino});
            this.dataGridViewPaco.Location = new System.Drawing.Point(6, 79);
            this.dataGridViewPaco.Name = "dataGridViewPaco";
            this.dataGridViewPaco.RowTemplate.Height = 25;
            this.dataGridViewPaco.Size = new System.Drawing.Size(756, 223);
            this.dataGridViewPaco.TabIndex = 8;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 71;
            // 
            // Origem
            // 
            this.Origem.HeaderText = "Origem";
            this.Origem.Name = "Origem";
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            // 
            // btnBuscarNomePacote
            // 
            this.btnBuscarNomePacote.Location = new System.Drawing.Point(618, 50);
            this.btnBuscarNomePacote.Name = "btnBuscarNomePacote";
            this.btnBuscarNomePacote.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarNomePacote.TabIndex = 7;
            this.btnBuscarNomePacote.Text = "Buscar";
            this.btnBuscarNomePacote.UseVisualStyleBackColor = true;
            // 
            // tbxOrigem
            // 
            this.tbxOrigem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxOrigem.Location = new System.Drawing.Point(203, 44);
            this.tbxOrigem.Name = "tbxOrigem";
            this.tbxOrigem.Size = new System.Drawing.Size(409, 29);
            this.tbxOrigem.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "Digite o nome do Pacote...";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbxDescrição);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbxDataVolta);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbxDataIda);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.pictureBoxPacote);
            this.tabPage2.Controls.Add(this.tbxDestinoPacote);
            this.tabPage2.Controls.Add(this.tbxOrigemPacote);
            this.tabPage2.Controls.Add(this.tbxValorPacote);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btnBuscarPacote);
            this.tabPage2.Controls.Add(this.btnAlterarPacote);
            this.tabPage2.Controls.Add(this.btnDeletarPacote);
            this.tabPage2.Controls.Add(this.btnBuscarImagemPacote);
            this.tabPage2.Controls.Add(this.tbxCodigoPacote);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisar por Codigo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(393, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "Descrição";
            // 
            // tbxDataVolta
            // 
            this.tbxDataVolta.Location = new System.Drawing.Point(88, 208);
            this.tbxDataVolta.Name = "tbxDataVolta";
            this.tbxDataVolta.PasswordChar = '*';
            this.tbxDataVolta.Size = new System.Drawing.Size(266, 23);
            this.tbxDataVolta.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "Data de Volta";
            // 
            // tbxDataIda
            // 
            this.tbxDataIda.Location = new System.Drawing.Point(78, 179);
            this.tbxDataIda.Name = "tbxDataIda";
            this.tbxDataIda.PasswordChar = '*';
            this.tbxDataIda.Size = new System.Drawing.Size(276, 23);
            this.tbxDataIda.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Data de Ida";
            // 
            // pictureBoxPacote
            // 
            this.pictureBoxPacote.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxPacote.Location = new System.Drawing.Point(535, 136);
            this.pictureBoxPacote.Name = "pictureBoxPacote";
            this.pictureBoxPacote.Size = new System.Drawing.Size(154, 114);
            this.pictureBoxPacote.TabIndex = 34;
            this.pictureBoxPacote.TabStop = false;
            // 
            // tbxDestinoPacote
            // 
            this.tbxDestinoPacote.Location = new System.Drawing.Point(54, 151);
            this.tbxDestinoPacote.Name = "tbxDestinoPacote";
            this.tbxDestinoPacote.PasswordChar = '*';
            this.tbxDestinoPacote.Size = new System.Drawing.Size(300, 23);
            this.tbxDestinoPacote.TabIndex = 33;
            // 
            // tbxOrigemPacote
            // 
            this.tbxOrigemPacote.Location = new System.Drawing.Point(62, 122);
            this.tbxOrigemPacote.Name = "tbxOrigemPacote";
            this.tbxOrigemPacote.Size = new System.Drawing.Size(292, 23);
            this.tbxOrigemPacote.TabIndex = 32;
            // 
            // tbxValorPacote
            // 
            this.tbxValorPacote.Location = new System.Drawing.Point(55, 93);
            this.tbxValorPacote.Name = "tbxValorPacote";
            this.tbxValorPacote.Size = new System.Drawing.Size(299, 23);
            this.tbxValorPacote.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(6, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "Destino";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(6, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Origem";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(9, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Valor";
            // 
            // btnBuscarPacote
            // 
            this.btnBuscarPacote.Location = new System.Drawing.Point(667, 50);
            this.btnBuscarPacote.Name = "btnBuscarPacote";
            this.btnBuscarPacote.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPacote.TabIndex = 27;
            this.btnBuscarPacote.Text = "Buscar";
            this.btnBuscarPacote.UseVisualStyleBackColor = true;
            this.btnBuscarPacote.Click += new System.EventHandler(this.btnBuscarPacote_Click);
            // 
            // btnAlterarPacote
            // 
            this.btnAlterarPacote.Location = new System.Drawing.Point(295, 276);
            this.btnAlterarPacote.Name = "btnAlterarPacote";
            this.btnAlterarPacote.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarPacote.TabIndex = 26;
            this.btnAlterarPacote.Text = "Alterar";
            this.btnAlterarPacote.UseVisualStyleBackColor = true;
            // 
            // btnDeletarPacote
            // 
            this.btnDeletarPacote.Location = new System.Drawing.Point(376, 276);
            this.btnDeletarPacote.Name = "btnDeletarPacote";
            this.btnDeletarPacote.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarPacote.TabIndex = 25;
            this.btnDeletarPacote.Text = "Deletar";
            this.btnDeletarPacote.UseVisualStyleBackColor = true;
            // 
            // btnBuscarImagemPacote
            // 
            this.btnBuscarImagemPacote.Location = new System.Drawing.Point(562, 256);
            this.btnBuscarImagemPacote.Name = "btnBuscarImagemPacote";
            this.btnBuscarImagemPacote.Size = new System.Drawing.Size(112, 23);
            this.btnBuscarImagemPacote.TabIndex = 24;
            this.btnBuscarImagemPacote.Text = "Buscar Imagem";
            this.btnBuscarImagemPacote.UseVisualStyleBackColor = true;
            // 
            // tbxCodigoPacote
            // 
            this.tbxCodigoPacote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxCodigoPacote.Location = new System.Drawing.Point(210, 46);
            this.tbxCodigoPacote.Name = "tbxCodigoPacote";
            this.tbxCodigoPacote.Size = new System.Drawing.Size(435, 29);
            this.tbxCodigoPacote.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Digite o Codigo do Pacote...";
            // 
            // openFileDialogPacote
            // 
            this.openFileDialogPacote.FileName = "openFileDialogPacote";
            // 
            // tbxDescrição
            // 
            this.tbxDescrição.Location = new System.Drawing.Point(457, 93);
            this.tbxDescrição.Name = "tbxDescrição";
            this.tbxDescrição.Size = new System.Drawing.Size(285, 23);
            this.tbxDescrição.TabIndex = 42;
            // 
            // TelaPesquisarPacote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "TelaPesquisarPacote";
            this.Text = "TelaPesquisarPacote";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaco)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPacote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCodigoPacote;
        private System.Windows.Forms.Button btnBuscarPacote;
        private System.Windows.Forms.Button btnAlterarPacote;
        private System.Windows.Forms.Button btnDeletarPacote;
        private System.Windows.Forms.Button btnBuscarImagemPacote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxDestinoPacote;
        private System.Windows.Forms.TextBox tbxOrigemPacote;
        private System.Windows.Forms.TextBox tbxValorPacote;
        private System.Windows.Forms.PictureBox pictureBoxPacote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxDataVolta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxDataIda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewPaco;
        private System.Windows.Forms.Button btnBuscarNomePacote;
        private System.Windows.Forms.TextBox tbxOrigem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.OpenFileDialog openFileDialogPacote;
        private System.Windows.Forms.TextBox tbxDescrição;
    }
}