namespace Projeto_Agenda
{
    partial class Frm_Registrar
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
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Sobrenome = new System.Windows.Forms.Label();
            this.lbl_Idade = new System.Windows.Forms.Label();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.lbl_Nacionalidade = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Sobrenome = new System.Windows.Forms.TextBox();
            this.txt_Idade = new System.Windows.Forms.TextBox();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.txt_Nacionalidade = new System.Windows.Forms.TextBox();
            this.msk_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_Nome.Location = new System.Drawing.Point(12, 9);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(67, 24);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Nome:";
            // 
            // lbl_Sobrenome
            // 
            this.lbl_Sobrenome.AutoSize = true;
            this.lbl_Sobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_Sobrenome.Location = new System.Drawing.Point(12, 48);
            this.lbl_Sobrenome.Name = "lbl_Sobrenome";
            this.lbl_Sobrenome.Size = new System.Drawing.Size(115, 24);
            this.lbl_Sobrenome.TabIndex = 1;
            this.lbl_Sobrenome.Text = "Sobrenome:";
            // 
            // lbl_Idade
            // 
            this.lbl_Idade.AutoSize = true;
            this.lbl_Idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_Idade.Location = new System.Drawing.Point(12, 87);
            this.lbl_Idade.Name = "lbl_Idade";
            this.lbl_Idade.Size = new System.Drawing.Size(62, 24);
            this.lbl_Idade.TabIndex = 2;
            this.lbl_Idade.Text = "Idade:";
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_Telefone.Location = new System.Drawing.Point(12, 126);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(90, 24);
            this.lbl_Telefone.TabIndex = 3;
            this.lbl_Telefone.Text = "Telefone:";
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_Cidade.Location = new System.Drawing.Point(12, 165);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.Size = new System.Drawing.Size(75, 24);
            this.lbl_Cidade.TabIndex = 4;
            this.lbl_Cidade.Text = "Cidade:";
            // 
            // lbl_Nacionalidade
            // 
            this.lbl_Nacionalidade.AutoSize = true;
            this.lbl_Nacionalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_Nacionalidade.Location = new System.Drawing.Point(12, 204);
            this.lbl_Nacionalidade.Name = "lbl_Nacionalidade";
            this.lbl_Nacionalidade.Size = new System.Drawing.Size(136, 24);
            this.lbl_Nacionalidade.TabIndex = 5;
            this.lbl_Nacionalidade.Text = "Nacionalidade:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(153, 14);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(100, 20);
            this.txt_Nome.TabIndex = 0;
            this.txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letras);
            // 
            // txt_Sobrenome
            // 
            this.txt_Sobrenome.Location = new System.Drawing.Point(153, 53);
            this.txt_Sobrenome.Name = "txt_Sobrenome";
            this.txt_Sobrenome.Size = new System.Drawing.Size(100, 20);
            this.txt_Sobrenome.TabIndex = 1;
            this.txt_Sobrenome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letras);
            // 
            // txt_Idade
            // 
            this.txt_Idade.Location = new System.Drawing.Point(153, 92);
            this.txt_Idade.Name = "txt_Idade";
            this.txt_Idade.Size = new System.Drawing.Size(100, 20);
            this.txt_Idade.TabIndex = 2;
            this.txt_Idade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Números);
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.Location = new System.Drawing.Point(153, 170);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(100, 20);
            this.txt_Cidade.TabIndex = 4;
            this.txt_Cidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letras);
            // 
            // txt_Nacionalidade
            // 
            this.txt_Nacionalidade.Location = new System.Drawing.Point(153, 209);
            this.txt_Nacionalidade.Name = "txt_Nacionalidade";
            this.txt_Nacionalidade.Size = new System.Drawing.Size(100, 20);
            this.txt_Nacionalidade.TabIndex = 5;
            this.txt_Nacionalidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letras);
            // 
            // msk_Telefone
            // 
            this.msk_Telefone.Location = new System.Drawing.Point(153, 131);
            this.msk_Telefone.Mask = "(99) 0000-0000";
            this.msk_Telefone.Name = "msk_Telefone";
            this.msk_Telefone.Size = new System.Drawing.Size(100, 20);
            this.msk_Telefone.TabIndex = 3;
            this.msk_Telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Números);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_Ok.Location = new System.Drawing.Point(16, 248);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(237, 42);
            this.btn_Ok.TabIndex = 6;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_Menu.Location = new System.Drawing.Point(16, 296);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(237, 42);
            this.btn_Menu.TabIndex = 7;
            this.btn_Menu.Text = "MENU";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // Frm_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(263, 345);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.msk_Telefone);
            this.Controls.Add(this.txt_Nacionalidade);
            this.Controls.Add(this.txt_Cidade);
            this.Controls.Add(this.txt_Idade);
            this.Controls.Add(this.txt_Sobrenome);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Nacionalidade);
            this.Controls.Add(this.lbl_Cidade);
            this.Controls.Add(this.lbl_Telefone);
            this.Controls.Add(this.lbl_Idade);
            this.Controls.Add(this.lbl_Sobrenome);
            this.Controls.Add(this.lbl_Nome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Frm_Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Sobrenome;
        private System.Windows.Forms.Label lbl_Idade;
        private System.Windows.Forms.Label lbl_Telefone;
        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.Label lbl_Nacionalidade;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Sobrenome;
        private System.Windows.Forms.TextBox txt_Idade;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.TextBox txt_Nacionalidade;
        private System.Windows.Forms.MaskedTextBox msk_Telefone;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Menu;
    }
}