using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FRoG_Creator.Client
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
            panelLogin.Enabled = true;
            panelLogin.Visible = true;
        }

        private void SwitchPanel(Panel currentPanel, Panel nextPanel)
        {
            currentPanel.Enabled = false;
            currentPanel.Visible = false;

            nextPanel.Enabled = true;
            nextPanel.Visible = true;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            SwitchPanel(panelLogin, panelRegister);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {

        }

        private void buttonReturnMain_Click(object sender, EventArgs e)
        {
            SwitchPanel(panelRegister, panelLogin);
        }

        private void buttonRegisterDone_Click(object sender, EventArgs e)
        {

        }
    }
}
