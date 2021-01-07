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
    public partial class ConsultAdminForm : Form
    {
        Admin admin;
        private IAlbumRepository _albumRepository;
        Form connexion;


        public ConsultAdminForm(Admin a, IAlbumRepository albumRepository, Form connect)
        {
            InitializeComponent();
            admin = a;
            _albumRepository = albumRepository;
            connexion = connect;
            adminLabel.Text = admin.Login;
            RefreshAlbumListView();
        }
        private void catalogueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (catalogueListBox.SelectedItem != null)
            {
                Album selectedAlbum = (Album)catalogueListBox.SelectedItem;
                nomAlbumCatalogue.Text = selectedAlbum.Nom;
                imageAlbumCatalogue.ImageLocation = selectedAlbum.Img;
                serieCatalogue.Text = selectedAlbum.Serie;
                auteurCatalogue.Text = selectedAlbum.Auteur;
                catCatalogue.Text = selectedAlbum.Categorie;
                genreCatalogue.Text = selectedAlbum.Genre;
                editCatalogue.Text = selectedAlbum.Editeur;
            }
        }
        private void RefreshAlbumListView()
        {
            catalogueListBox.DataSource = null;
            List<Album> albums = _albumRepository.GetAll();
            catalogueListBox.DataSource = albums;
            if (albums.Count > 0)
                catalogueListBox.SelectedIndex = 0; // Sélectionne le 1er album
        }
        private void deconnectionButton_Click(object sender, EventArgs e)
        {
            connexion.Show();
            this.Close();
        }

        private void rechercheCatalogueButton_Click(object sender, EventArgs e)
        {

        }
        private void AddAlbumToMarket_Click(object sender, EventArgs e)
        {
            AddAlbumForm addAlbumForm = new AddAlbumForm();
            if (addAlbumForm.ShowDialog() == DialogResult.OK)
            {
                string image = addAlbumForm.Img;
                string nom = addAlbumForm.Nom;
                string serie = addAlbumForm.Serie;
                string auteur = addAlbumForm.Auteur;
                string genre = addAlbumForm.Genre;
                string categorie = addAlbumForm.Categorie;
                string editeur = addAlbumForm.Editeur;
                Album album = new Album(image, nom, serie, auteur, categorie, genre, editeur);
                SaveAndUpdateAlbumView(album);
            }
            
        }
        private void SaveAndUpdateAlbumView(Album album)
        {
            _albumRepository.Save(album);
            RefreshAlbumListView();
        }
        private void DelAlbumToMarket_Click(object sender, EventArgs e)
        {
            
            RefreshAlbumListView();
        }
    }
}
