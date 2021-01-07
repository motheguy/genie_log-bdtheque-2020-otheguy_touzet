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
        User user;
        private IAlbumRepository _albumRepository;
        Form connexion;

        public ConsultUserForm(User u, IAlbumRepository albumRepository, Form connect)
        {
            InitializeComponent();
            user = u;
            _albumRepository = albumRepository;
            RefreshAlbumListView();
            userLabel.Text = user.Login;
            connexion = connect;
        }

        private void RefreshAlbumListView()
        {
            catalogueListBox.DataSource = null;
            List<Album> albums = _albumRepository.GetAll();
            catalogueListBox.DataSource = albums;
            if (albums.Count > 0)
                catalogueListBox.SelectedIndex = 0; // Sélectionne le 1er album

            possessionListBox.DataSource = null;
            List<Album> possess = _albumRepository.GetPossess(user);
            possessionListBox.DataSource = possess;
            if (possess.Count > 0)
                possessionListBox.SelectedIndex = 0; // Sélectionne le 1er album

            souhaitsListBox.DataSource = null;
            List<Album> souhaits = _albumRepository.GetSouhait(user);
            souhaitsListBox.DataSource = souhaits;
            if (souhaits.Count > 0)
                souhaitsListBox.SelectedIndex = 0; // Sélectionne le 1er album
        }

        private void deconnectionButton_Click(object sender, EventArgs e)
        {
            connexion.Show();
            this.Close();
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

        private void possessionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (possessionListBox.SelectedItem != null)
            {
                Album selectedAlbum = (Album)possessionListBox.SelectedItem;
                nomAlbumPossess.Text = selectedAlbum.Nom;
                imageAlbumPossess.ImageLocation = selectedAlbum.Img;
                seriePossess.Text = selectedAlbum.Serie;
                auteurPossess.Text = selectedAlbum.Auteur;
                catPossess.Text = selectedAlbum.Categorie;
                genrePossess.Text = selectedAlbum.Genre;
                editPossess.Text = selectedAlbum.Editeur;
            }
        }

        private void souhaitsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (souhaitsListBox.SelectedItem != null)
            {
                Album selectedAlbum = (Album)souhaitsListBox.SelectedItem;
                nomAlbumSouhait.Text = selectedAlbum.Nom;
                imageAlbumSouhait.ImageLocation = selectedAlbum.Img;
                serieSouhait.Text = selectedAlbum.Serie;
                auteurSouhait.Text = selectedAlbum.Auteur;
                catSouhait.Text = selectedAlbum.Categorie;
                genreSouhait.Text = selectedAlbum.Genre;
                editSouhait.Text = selectedAlbum.Editeur;
            }
        }

        private void cataloguePage_Click(object sender, EventArgs e)
        {
            rechercheCatalogueTextBox.Text = "";
            RefreshAlbumListView();
        }

        private void possessionPage_Click(object sender, EventArgs e)
        {
            recherchePossessTextBox.Text = "";
            RefreshAlbumListView();
        }

        private void souhaitsPage_Click(object sender, EventArgs e)
        {
            rechercheSouhaitTextBox.Text = "";
            RefreshAlbumListView();
        }

        private void achatSouhaitButton_Click(object sender, EventArgs e)
        {
            Album selectedAlbum = (Album)souhaitsListBox.SelectedItem;
            user.AddComicOwned(selectedAlbum);
            user.RemoveComicWanted(selectedAlbum);
            RefreshAlbumListView();
            IndividualRepository indivRepo = new IndividualRepository();
            indivRepo.Save(user);
        }

        private void achatCatalogueButton_Click(object sender, EventArgs e)
        {
            Album selectedAlbum = (Album)catalogueListBox.SelectedItem;
            user.AddComicOwned(selectedAlbum);
            if (user.ComicsWanted.Contains(selectedAlbum))
            {
                user.RemoveComicWanted(selectedAlbum);
            }
            RefreshAlbumListView();
            IndividualRepository indivRepo = new IndividualRepository();
            indivRepo.Save(user);
        }

        private void ajoutSouhaitButton_Click(object sender, EventArgs e)
        {
            Album selectedAlbum = (Album)catalogueListBox.SelectedItem;
            user.AddComicWanted(selectedAlbum);
            RefreshAlbumListView();
            IndividualRepository indivRepo = new IndividualRepository();
            indivRepo.Save(user);
        }

        private void deleteSouhaitButton_Click(object sender, EventArgs e)
        {
            Album selectedAlbum = (Album)souhaitsListBox.SelectedItem;
            user.RemoveComicWanted(selectedAlbum);
            RefreshAlbumListView();
            IndividualRepository indivRepo = new IndividualRepository();
            indivRepo.Save(user);
        }

        private void rechercheCatalogueButton_Click(object sender, EventArgs e)
        {
            string recherche = rechercheCatalogueTextBox.Text;
            catalogueListBox.DataSource = null;
            List<Album> albums = _albumRepository.Search(recherche);
            catalogueListBox.DataSource = albums;
            if (albums.Count > 0)
                catalogueListBox.SelectedIndex = 0; // Sélectionne le 1er album

        }

        private void rechercheSouhaitButton_Click(object sender, EventArgs e)
        {
            string recherche = rechercheSouhaitTextBox.Text;
            souhaitsListBox.DataSource = null;
            List<Album> albums = _albumRepository.SearchWanted(user, recherche);
            souhaitsListBox.DataSource = albums;
            if (albums.Count > 0)
                souhaitsListBox.SelectedIndex = 0; // Sélectionne le 1er album
        }

        private void recherchePossessButton_Click(object sender, EventArgs e)
        {
            string recherche = recherchePossessTextBox.Text;
            possessionListBox.DataSource = null;
            List<Album> albums = _albumRepository.SearchOwned(user, recherche);
            possessionListBox.DataSource = albums;
            if (albums.Count > 0)
                possessionListBox.SelectedIndex = 0; // Sélectionne le 1er album
        }
    }
}
