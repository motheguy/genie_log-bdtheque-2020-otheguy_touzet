using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;

namespace App
{
    public partial class ConnectionForm : Form
    {
        private IIndividualRepository _individualRepository;

        public string Login
        {
            get { return loginTextBox.Text; }
            set { loginTextBox.Text = value; }
        }

        public string Mdp
        {
            get { return mdpTextBox.Text; }
            set { mdpTextBox.Text = value; }
        }

        public bool Admin
        {
            get { return adminCheckBox.Checked; }
            set { adminCheckBox.Checked = value; }
        }

        public ConnectionForm(IndividualRepository individualRepository)
        {
            InitializeComponent();

            _individualRepository = individualRepository;
        }

        private void adminCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (adminCheckBox.Checked)
            {
                notAdminCheckBox.Checked = false;
            }
            else
            {
                notAdminCheckBox.Checked = true;
            }
        }

        private void notAdminCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (notAdminCheckBox.Checked)
            {
                adminCheckBox.Checked = false;
            }
            else
            {
                adminCheckBox.Checked = true;
            }
        }

        private void connexionButton_Click(object sender, EventArgs e)
        {
            bool exist = false;
            Individual individual;
            if (Admin) //L'individu se connecte en tant qu'administrateur
            {
                foreach (Individual i in _individualRepository.GetAll())
                {
                    if (i is Admin)
                    {
                        if (i.Login == loginTextBox.Text && i.Password == mdpTextBox.Text)
                        {
                            exist = true;
                            individual = i;
                            ConsultAdminForm adminForm = new ConsultAdminForm(individual);
                            adminForm.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else //L'individu se connecte en tant que simple utilisateur
            {
                foreach (Individual i in _individualRepository.GetAll())
                {
                    if (i is User)
                    {
                        if (i.Login == loginTextBox.Text && i.Password == mdpTextBox.Text)
                        {
                            exist = true;
                            individual = i;
                            ConsultUserForm userForm = new ConsultUserForm(individual);
                            userForm.Show();
                            this.Hide();
                        }
                    }
                }
            }
            if (exist==false)
            {
                errorLabel.Text = "Identifiant ou mot de passe incorrect";
            }
        }
    }
}
