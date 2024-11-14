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
    public partial class Frm_Consultar : Form
    {
        public Frm_Consultar()
        {
            InitializeComponent();
        }
        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Form x = Application.OpenForms["Frm_Agenda"];
            x.Show();
            this.Dispose();
        }
    }
}