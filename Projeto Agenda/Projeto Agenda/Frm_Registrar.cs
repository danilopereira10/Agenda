using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Projeto_Agenda
{
    public partial class Frm_Registrar : Form
    {
        public Frm_Registrar()
        {
            InitializeComponent();
        }
        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Form x = Application.OpenForms["Frm_Agenda"];
            x.Show();
            this.Dispose();
        }
        private void Letras(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
        private void Números(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text == "" || txt_Sobrenome.Text == "" || txt_Idade.Text == "" || msk_Telefone.Text == "" || txt_Cidade.Text == "" || txt_Nacionalidade.Text == "")
                MessageBox.Show("ERRO!", "Favor preencher os campos em branco corretamente!");
            else
            {
                if (!Directory.Exists("C:\\Users\\aluno\\Desktop\\AGENDA"))
                    Directory.CreateDirectory("C:\\Users\\aluno\\Desktop\\AGENDA");
                String NomeArquivo = "C:\\Users\\aluno\\Desktop\\AGENDA\\" + txt_Nome.Text + "_" + txt_Sobrenome.Text + ".txt";
                File.WriteAllText(NomeArquivo, "Nome completo: " + txt_Nome.Text + txt_Sobrenome.Text + "\r\n");
                File.AppendAllText(NomeArquivo, "\r\n");
                File.AppendAllText(NomeArquivo, "Idade: " + txt_Idade.Text + "\r\n");
                File.AppendAllText(NomeArquivo, "\r\n");
                File.AppendAllText(NomeArquivo, "Telefone: " + msk_Telefone.Text + "\r\n");
                File.AppendAllText(NomeArquivo, "\r\n");
                File.AppendAllText(NomeArquivo, "Cidade: " + txt_Cidade.Text + "\r\n");
                File.AppendAllText(NomeArquivo, "\r\n");
                File.AppendAllText(NomeArquivo, "Nacionalidade: " + txt_Nacionalidade.Text + "\r\n");
                txt_Nome.Text = "";
                txt_Sobrenome.Text = "";
                txt_Idade.Text = "";
                msk_Telefone.Text = "";
                txt_Cidade.Text = "";
                txt_Nacionalidade.Text = "";
                txt_Nome.Focus();
            }
        }
    }
}