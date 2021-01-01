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
        private IAlbumRepository _albumRepository;

        public ConsultUserForm(Individual i, IAlbumRepository albumRepository)
        {
            InitializeComponent();
            indiv = i;
            _albumRepository = albumRepository;
            RefreshAlbumListView();
            userLabel.Text = i.Login;
        }

        private void RefreshAlbumListView()
        {
            catalogueListBox.DataSource = null;
            List<Album> albums = _albumRepository.GetAll();
            catalogueListBox.DataSource = albums;
            if (albums.Count > 0)
                catalogueListBox.SelectedIndex = 0; // Sélectionne le 1er album
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

        private void catalogueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
