using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
            cmbBoxTipoUser.Items.Add("Administrador");
            cmbBoxTipoUser.Items.Add("Cliente");
        }

        public void OnLoad()
        {
            
        }

        private void cmbBoxTipoUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxTipoUser.SelectedItem.Equals("Administrador"))
            {
                tlpDadosAdm.Visible = true;
                tlpDadosCliente.Visible = false;
            }
            else if (cmbBoxTipoUser.SelectedItem.Equals("Cliente"))
            {
                tlpDadosAdm.Visible = false;
                tlpDadosCliente.Visible = true;
            }
        }
    }
}
