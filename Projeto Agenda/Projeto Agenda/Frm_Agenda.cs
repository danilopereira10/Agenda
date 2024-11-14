using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Projeto_Agenda
{
    public partial class Frm_Agenda : Form
    {
        public Frm_Agenda()
        {
            InitializeComponent();
        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Frm_Registrar a = new Frm_Registrar();
            a.Show();
            this.Hide();
        }
        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            Frm_Consultar b = new Frm_Consultar();
            b.Show();
            this.Hide();
        }
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Frm_Editar c = new Frm_Editar();
            c.Show();
            this.Hide();
        }
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Frm_Excluir d = new Frm_Excluir();
            d.Show();
            this.Hide();
        }
    }
}