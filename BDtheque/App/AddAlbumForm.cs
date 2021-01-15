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

namespace App
{
    public partial class AddAlbumForm : Form
    {
        public AddAlbumForm()
        {
            InitializeComponent();
        }
        public string Img 
        {
            get { return "img/" + Path.GetFileName(imgTextBox.Text); }
            set { imgTextBox.Text=value; } 
        }
        public string Nom 
        {
            get { return nomTextBox.Text ; }
            set { nomTextBox.Text = value ; } 
        }
        public string Serie 
        { 
            get { return serieTextBox.Text ; } 
            set { serieTextBox.Text = value ;  } 
        }
        public string Auteur 
        {
            get { return auteurTextBox.Text ; }
            set { auteurTextBox.Text = value ; }
        }
        public string Categorie 
        { 
            get { return categorieTextBox.Text ; }
            set { categorieTextBox.Text = value ; }
        }
        public string Genre
        {
            get { return genreTextBox.Text ; }
            set { genreTextBox.Text = value ; }
        }
        public string Editeur 
        {
            get { return editeurTextBox.Text ; }
            set { editeurTextBox.Text = value ; } 
        }

        private void imgImportButton_Click(object sender, EventArgs e)
        {
            imgOpenFileDialog.Title = "Importer une image";
            //imgOpenFileDialog.ShowDialog();
            if (imgOpenFileDialog.ShowDialog()==DialogResult.OK)
            {
                imgTextBox.Text = imgOpenFileDialog.FileName;
                File.Copy(imgTextBox.Text, "../img/" + Path.GetFileName(imgTextBox.Text));
            }
        }
        
    }
}
