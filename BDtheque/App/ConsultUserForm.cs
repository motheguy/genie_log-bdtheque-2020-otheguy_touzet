using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using DAL;

namespace App
{
    public partial class ConsultUserForm : Form
    {
        Individual indiv;

        public ConsultUserForm(Individual i)
        {
            indiv = i;
            InitializeComponent();
            userLabel.Text = i.Login;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void deconnectionButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
