namespace App
{
    partial class ConsultAdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logOutButton = new System.Windows.Forms.Button();
            this.adminLabel = new System.Windows.Forms.Label();
            this.catalogueGroupBox = new System.Windows.Forms.GroupBox();
            this.rechercheCatalogueTextBox = new System.Windows.Forms.TextBox();
            this.rechercheCatalogueBouton = new System.Windows.Forms.Button();
            this.catalogueListBox = new System.Windows.Forms.ListBox();
            this.imageAlbumCatalogue = new System.Windows.Forms.PictureBox();
            this.editCatalogue = new System.Windows.Forms.Label();
            this.editCatalogueLabel = new System.Windows.Forms.Label();
            this.genreCatalogue = new System.Windows.Forms.Label();
            this.genreCatalogueLabel = new System.Windows.Forms.Label();
            this.catCatalogue = new System.Windows.Forms.Label();
            this.catCatalogueLabel = new System.Windows.Forms.Label();
            this.auteurCatalogue = new System.Windows.Forms.Label();
            this.auteurCatalogueLabel = new System.Windows.Forms.Label();
            this.serieCatalogue = new System.Windows.Forms.Label();
            this.serieCatalogueLabel = new System.Windows.Forms.Label();
            this.nomAlbumCatalogue = new System.Windows.Forms.Label();
            this.addAlbumButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.catalogueGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumCatalogue)).BeginInit();
            this.SuspendLayout();
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(251, 407);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(108, 28);
            this.logOutButton.TabIndex = 0;
            this.logOutButton.Text = "Déconnexion";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.deconnectionButton_Click);
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Location = new System.Drawing.Point(26, 19);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(0, 17);
            this.adminLabel.TabIndex = 1;
            // 
            // catalogueGroupBox
            // 
            this.catalogueGroupBox.Controls.Add(this.delButton);
            this.catalogueGroupBox.Controls.Add(this.addAlbumButton);
            this.catalogueGroupBox.Controls.Add(this.nomAlbumCatalogue);
            this.catalogueGroupBox.Controls.Add(this.editCatalogue);
            this.catalogueGroupBox.Controls.Add(this.editCatalogueLabel);
            this.catalogueGroupBox.Controls.Add(this.genreCatalogue);
            this.catalogueGroupBox.Controls.Add(this.genreCatalogueLabel);
            this.catalogueGroupBox.Controls.Add(this.catCatalogue);
            this.catalogueGroupBox.Controls.Add(this.catCatalogueLabel);
            this.catalogueGroupBox.Controls.Add(this.auteurCatalogue);
            this.catalogueGroupBox.Controls.Add(this.auteurCatalogueLabel);
            this.catalogueGroupBox.Controls.Add(this.serieCatalogue);
            this.catalogueGroupBox.Controls.Add(this.serieCatalogueLabel);
            this.catalogueGroupBox.Controls.Add(this.imageAlbumCatalogue);
            this.catalogueGroupBox.Controls.Add(this.catalogueListBox);
            this.catalogueGroupBox.Controls.Add(this.rechercheCatalogueBouton);
            this.catalogueGroupBox.Location = new System.Drawing.Point(29, 51);
            this.catalogueGroupBox.Name = "catalogueGroupBox";
            this.catalogueGroupBox.Size = new System.Drawing.Size(543, 338);
            this.catalogueGroupBox.TabIndex = 2;
            this.catalogueGroupBox.TabStop = false;
            this.catalogueGroupBox.Text = "Catalogue";
            // 
            // rechercheCatalogueTextBox
            // 
            this.rechercheCatalogueTextBox.Location = new System.Drawing.Point(55, 85);
            this.rechercheCatalogueTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rechercheCatalogueTextBox.Name = "rechercheCatalogueTextBox";
            this.rechercheCatalogueTextBox.Size = new System.Drawing.Size(198, 22);
            this.rechercheCatalogueTextBox.TabIndex = 4;
            // 
            // rechercheCatalogueBouton
            // 
            this.rechercheCatalogueBouton.Location = new System.Drawing.Point(242, 32);
            this.rechercheCatalogueBouton.Name = "rechercheCatalogueBouton";
            this.rechercheCatalogueBouton.Size = new System.Drawing.Size(93, 28);
            this.rechercheCatalogueBouton.TabIndex = 0;
            this.rechercheCatalogueBouton.Text = "Recherche";
            this.rechercheCatalogueBouton.UseVisualStyleBackColor = true;
            this.rechercheCatalogueBouton.Click += new System.EventHandler(this.rechercheCatalogueButton_Click);
            // 
            // catalogueListBox
            // 
            this.catalogueListBox.FormattingEnabled = true;
            this.catalogueListBox.ItemHeight = 16;
            this.catalogueListBox.Location = new System.Drawing.Point(26, 73);
            this.catalogueListBox.Name = "catalogueListBox";
            this.catalogueListBox.Size = new System.Drawing.Size(127, 244);
            this.catalogueListBox.TabIndex = 1;
            this.catalogueListBox.SelectedIndexChanged += new System.EventHandler(this.catalogueListBox_SelectedIndexChanged);
            // 
            // imageAlbumCatalogue
            // 
            this.imageAlbumCatalogue.ImageLocation = "";
            this.imageAlbumCatalogue.Location = new System.Drawing.Point(440, 23);
            this.imageAlbumCatalogue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageAlbumCatalogue.Name = "imageAlbumCatalogue";
            this.imageAlbumCatalogue.Size = new System.Drawing.Size(80, 77);
            this.imageAlbumCatalogue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageAlbumCatalogue.TabIndex = 3;
            this.imageAlbumCatalogue.TabStop = false;
            // 
            // editCatalogue
            // 
            this.editCatalogue.AutoSize = true;
            this.editCatalogue.Location = new System.Drawing.Point(265, 245);
            this.editCatalogue.Name = "editCatalogue";
            this.editCatalogue.Size = new System.Drawing.Size(0, 17);
            this.editCatalogue.TabIndex = 22;
            // 
            // editCatalogueLabel
            // 
            this.editCatalogueLabel.AutoSize = true;
            this.editCatalogueLabel.Location = new System.Drawing.Point(189, 245);
            this.editCatalogueLabel.Name = "editCatalogueLabel";
            this.editCatalogueLabel.Size = new System.Drawing.Size(63, 17);
            this.editCatalogueLabel.TabIndex = 21;
            this.editCatalogueLabel.Text = "Edition : ";
            // 
            // genreCatalogue
            // 
            this.genreCatalogue.AutoSize = true;
            this.genreCatalogue.Location = new System.Drawing.Point(265, 212);
            this.genreCatalogue.Name = "genreCatalogue";
            this.genreCatalogue.Size = new System.Drawing.Size(0, 17);
            this.genreCatalogue.TabIndex = 20;
            // 
            // genreCatalogueLabel
            // 
            this.genreCatalogueLabel.AutoSize = true;
            this.genreCatalogueLabel.Location = new System.Drawing.Point(193, 212);
            this.genreCatalogueLabel.Name = "genreCatalogueLabel";
            this.genreCatalogueLabel.Size = new System.Drawing.Size(60, 17);
            this.genreCatalogueLabel.TabIndex = 19;
            this.genreCatalogueLabel.Text = "Genre : ";
            // 
            // catCatalogue
            // 
            this.catCatalogue.AutoSize = true;
            this.catCatalogue.Location = new System.Drawing.Point(265, 180);
            this.catCatalogue.Name = "catCatalogue";
            this.catCatalogue.Size = new System.Drawing.Size(0, 17);
            this.catCatalogue.TabIndex = 18;
            // 
            // catCatalogueLabel
            // 
            this.catCatalogueLabel.AutoSize = true;
            this.catCatalogueLabel.Location = new System.Drawing.Point(171, 180);
            this.catCatalogueLabel.Name = "catCatalogueLabel";
            this.catCatalogueLabel.Size = new System.Drawing.Size(81, 17);
            this.catCatalogueLabel.TabIndex = 17;
            this.catCatalogueLabel.Text = "Catégorie : ";
            // 
            // auteurCatalogue
            // 
            this.auteurCatalogue.AutoSize = true;
            this.auteurCatalogue.Location = new System.Drawing.Point(264, 151);
            this.auteurCatalogue.Name = "auteurCatalogue";
            this.auteurCatalogue.Size = new System.Drawing.Size(0, 17);
            this.auteurCatalogue.TabIndex = 16;
            // 
            // auteurCatalogueLabel
            // 
            this.auteurCatalogueLabel.AutoSize = true;
            this.auteurCatalogueLabel.Location = new System.Drawing.Point(190, 151);
            this.auteurCatalogueLabel.Name = "auteurCatalogueLabel";
            this.auteurCatalogueLabel.Size = new System.Drawing.Size(62, 17);
            this.auteurCatalogueLabel.TabIndex = 15;
            this.auteurCatalogueLabel.Text = "Auteur : ";
            // 
            // serieCatalogue
            // 
            this.serieCatalogue.AutoSize = true;
            this.serieCatalogue.Location = new System.Drawing.Point(265, 125);
            this.serieCatalogue.Name = "serieCatalogue";
            this.serieCatalogue.Size = new System.Drawing.Size(0, 17);
            this.serieCatalogue.TabIndex = 14;
            // 
            // serieCatalogueLabel
            // 
            this.serieCatalogueLabel.AutoSize = true;
            this.serieCatalogueLabel.Location = new System.Drawing.Point(200, 125);
            this.serieCatalogueLabel.Name = "serieCatalogueLabel";
            this.serieCatalogueLabel.Size = new System.Drawing.Size(53, 17);
            this.serieCatalogueLabel.TabIndex = 13;
            this.serieCatalogueLabel.Text = "Série : ";
            // 
            // nomAlbumCatalogue
            // 
            this.nomAlbumCatalogue.AutoSize = true;
            this.nomAlbumCatalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomAlbumCatalogue.Location = new System.Drawing.Point(245, 91);
            this.nomAlbumCatalogue.Name = "nomAlbumCatalogue";
            this.nomAlbumCatalogue.Size = new System.Drawing.Size(0, 17);
            this.nomAlbumCatalogue.TabIndex = 23;
            // 
            // addAlbumButton
            // 
            this.addAlbumButton.Location = new System.Drawing.Point(402, 282);
            this.addAlbumButton.Name = "addAlbumButton";
            this.addAlbumButton.Size = new System.Drawing.Size(115, 45);
            this.addAlbumButton.TabIndex = 24;
            this.addAlbumButton.Text = "Ajouter un album";
            this.addAlbumButton.UseVisualStyleBackColor = true;
            this.addAlbumButton.Click += new System.EventHandler(this.AddAlbumToMarket_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(244, 282);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(115, 45);
            this.delButton.TabIndex = 25;
            this.delButton.Text = "Supprimer cet album";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.DelAlbumToMarket_Click);
            // 
            // ConsultAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 445);
            this.Controls.Add(this.rechercheCatalogueTextBox);
            this.Controls.Add(this.catalogueGroupBox);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.logOutButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConsultAdminForm";
            this.Text = "BDThèque : Administrateur";
            this.catalogueGroupBox.ResumeLayout(false);
            this.catalogueGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumCatalogue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.GroupBox catalogueGroupBox;
        private System.Windows.Forms.TextBox rechercheCatalogueTextBox;
        private System.Windows.Forms.Button rechercheCatalogueBouton;
        private System.Windows.Forms.ListBox catalogueListBox;
        private System.Windows.Forms.PictureBox imageAlbumCatalogue;
        private System.Windows.Forms.Label editCatalogue;
        private System.Windows.Forms.Label editCatalogueLabel;
        private System.Windows.Forms.Label genreCatalogue;
        private System.Windows.Forms.Label genreCatalogueLabel;
        private System.Windows.Forms.Label catCatalogue;
        private System.Windows.Forms.Label catCatalogueLabel;
        private System.Windows.Forms.Label auteurCatalogue;
        private System.Windows.Forms.Label auteurCatalogueLabel;
        private System.Windows.Forms.Label serieCatalogue;
        private System.Windows.Forms.Label serieCatalogueLabel;
        private System.Windows.Forms.Label nomAlbumCatalogue;
        private System.Windows.Forms.Button addAlbumButton;
        private System.Windows.Forms.Button delButton;
    }
}