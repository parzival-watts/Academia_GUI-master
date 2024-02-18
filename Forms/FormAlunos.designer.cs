﻿namespace Academia_GUI.Forms
{
    partial class FormAlunos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblError = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmailAluno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefoneAluno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataNascimentoAluno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCpfAluno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStatusAluno = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 433);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tabPage1.Controls.Add(this.lblError);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(799, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista Alunos";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(142, 6);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(45, 17);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Error";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(669, 289);
            this.dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(20, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar Aluno:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(24, 29);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(578, 27);
            this.txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(608, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(697, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Deletar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(697, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtEmailAluno);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtTelefoneAluno);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtNomeAluno);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtDataNascimentoAluno);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtCpfAluno);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtStatusAluno);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(799, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhes Aluno";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(514, 275);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 51);
            this.button6.TabIndex = 18;
            this.button6.Text = "Cancelar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(649, 275);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 51);
            this.button5.TabIndex = 17;
            this.button5.Text = "Salvar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(52, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Cadastrar Aluno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(53, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Email Aluno:";
            // 
            // txtEmailAluno
            // 
            this.txtEmailAluno.Location = new System.Drawing.Point(57, 304);
            this.txtEmailAluno.Name = "txtEmailAluno";
            this.txtEmailAluno.Size = new System.Drawing.Size(424, 22);
            this.txtEmailAluno.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(299, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefone:";
            // 
            // txtTelefoneAluno
            // 
            this.txtTelefoneAluno.Location = new System.Drawing.Point(303, 79);
            this.txtTelefoneAluno.Name = "txtTelefoneAluno";
            this.txtTelefoneAluno.Size = new System.Drawing.Size(178, 22);
            this.txtTelefoneAluno.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(53, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nome Completo:";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(57, 235);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(424, 22);
            this.txtNomeAluno.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(299, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data Nacimento Aluno:";
            // 
            // txtDataNascimentoAluno
            // 
            this.txtDataNascimentoAluno.Location = new System.Drawing.Point(303, 156);
            this.txtDataNascimentoAluno.Name = "txtDataNascimentoAluno";
            this.txtDataNascimentoAluno.Size = new System.Drawing.Size(178, 22);
            this.txtDataNascimentoAluno.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(53, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "CPF:";
            // 
            // txtCpfAluno
            // 
            this.txtCpfAluno.Location = new System.Drawing.Point(57, 156);
            this.txtCpfAluno.Name = "txtCpfAluno";
            this.txtCpfAluno.Size = new System.Drawing.Size(156, 22);
            this.txtCpfAluno.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(53, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status:";
            // 
            // txtStatusAluno
            // 
            this.txtStatusAluno.Location = new System.Drawing.Point(57, 79);
            this.txtStatusAluno.Name = "txtStatusAluno";
            this.txtStatusAluno.Size = new System.Drawing.Size(156, 22);
            this.txtStatusAluno.TabIndex = 5;
            // 
            // FormAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 433);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAlunos";
            this.Text = "FormAlunos";
            this.Load += new System.EventHandler(this.FormAlunos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelAlunosList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDataNascimentoAluno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCpfAluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStatusAluno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefoneAluno;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmailAluno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblError;
    }
}