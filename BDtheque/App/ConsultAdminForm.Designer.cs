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
            this.delButton = new System.Windows.Forms.Button();
            this.addAlbumButton = new System.Windows.Forms.Button();
            this.nomAlbumCatalogue = new System.Windows.Forms.Label();
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
            this.imageAlbumCatalogue = new System.Windows.Forms.PictureBox();
            this.catalogueListBox = new System.Windows.Forms.ListBox();
            this.rechercheCatalogueBouton = new System.Windows.Forms.Button();
            this.rechercheCatalogueTextBox = new System.Windows.Forms.TextBox();
            this.catalogueGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumCatalogue)).BeginInit();
            this.SuspendLayout();
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logOutButton.Location = new System.Drawing.Point(282, 509);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(122, 35);
            this.logOutButton.TabIndex = 0;
            this.logOutButton.Text = "Déconnexion";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.deconnectionButton_Click);
            // 
            // adminLabel
            // 
            this.adminLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adminLabel.AutoSize = true;
            this.adminLabel.Location = new System.Drawing.Point(29, 24);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(0, 20);
            this.adminLabel.TabIndex = 1;
            // 
            // catalogueGroupBox
            // 
            this.catalogueGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.catalogueGroupBox.Location = new System.Drawing.Point(33, 64);
            this.catalogueGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.catalogueGroupBox.Name = "catalogueGroupBox";
            this.catalogueGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.catalogueGroupBox.Size = new System.Drawing.Size(611, 422);
            this.catalogueGroupBox.TabIndex = 2;
            this.catalogueGroupBox.TabStop = false;
            this.catalogueGroupBox.Text = "Catalogue";
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(274, 352);
            this.delButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(129, 56);
            this.delButton.TabIndex = 25;
            this.delButton.Text = "Supprimer cet album";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.DelAlbumToMarket_Click);
            // 
            // addAlbumButton
            // 
            this.addAlbumButton.Location = new System.Drawing.Point(452, 352);
            this.addAlbumButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addAlbumButton.Name = "addAlbumButton";
            this.addAlbumButton.Size = new System.Drawing.Size(129, 56);
            this.addAlbumButton.TabIndex = 24;
            this.addAlbumButton.Text = "Ajouter un album";
            this.addAlbumButton.UseVisualStyleBackColor = true;
            this.addAlbumButton.Click += new System.EventHandler(this.AddAlbumToMarket_Click);
            // 
            // nomAlbumCatalogue
            // 
            this.nomAlbumCatalogue.AutoSize = true;
            this.nomAlbumCatalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomAlbumCatalogue.Location = new System.Drawing.Point(276, 114);
            this.nomAlbumCatalogue.Name = "nomAlbumCatalogue";
            this.nomAlbumCatalogue.Size = new System.Drawing.Size(0, 20);
            this.nomAlbumCatalogue.TabIndex = 23;
            // 
            // editCatalogue
            // 
            this.editCatalogue.AutoSize = true;
            this.editCatalogue.Location = new System.Drawing.Point(298, 306);
            this.editCatalogue.Name = "editCatalogue";
            this.editCatalogue.Size = new System.Drawing.Size(0, 20);
            this.editCatalogue.TabIndex = 22;
            // 
            // editCatalogueLabel
            // 
            this.editCatalogueLabel.AutoSize = true;
            this.editCatalogueLabel.Location = new System.Drawing.Point(213, 306);
            this.editCatalogueLabel.Name = "editCatalogueLabel";
            this.editCatalogueLabel.Size = new System.Drawing.Size(70, 20);
            this.editCatalogueLabel.TabIndex = 21;
            this.editCatalogueLabel.Text = "Edition : ";
            // 
            // genreCatalogue
            // 
            this.genreCatalogue.AutoSize = true;
            this.genreCatalogue.Location = new System.Drawing.Point(298, 265);
            this.genreCatalogue.Name = "genreCatalogue";
            this.genreCatalogue.Size = new System.Drawing.Size(0, 20);
            this.genreCatalogue.TabIndex = 20;
            // 
            // genreCatalogueLabel
            // 
            this.genreCatalogueLabel.AutoSize = true;
            this.genreCatalogueLabel.Location = new System.Drawing.Point(217, 265);
            this.genreCatalogueLabel.Name = "genreCatalogueLabel";
            this.genreCatalogueLabel.Size = new System.Drawing.Size(66, 20);
            this.genreCatalogueLabel.TabIndex = 19;
            this.genreCatalogueLabel.Text = "Genre : ";
            // 
            // catCatalogue
            // 
            this.catCatalogue.AutoSize = true;
            this.catCatalogue.Location = new System.Drawing.Point(298, 225);
            this.catCatalogue.Name = "catCatalogue";
            this.catCatalogue.Size = new System.Drawing.Size(0, 20);
            this.catCatalogue.TabIndex = 18;
            // 
            // catCatalogueLabel
            // 
            this.catCatalogueLabel.AutoSize = true;
            this.catCatalogueLabel.Location = new System.Drawing.Point(192, 225);
            this.catCatalogueLabel.Name = "catCatalogueLabel";
            this.catCatalogueLabel.Size = new System.Drawing.Size(90, 20);
            this.catCatalogueLabel.TabIndex = 17;
            this.catCatalogueLabel.Text = "Catégorie : ";
            // 
            // auteurCatalogue
            // 
            this.auteurCatalogue.AutoSize = true;
            this.auteurCatalogue.Location = new System.Drawing.Point(297, 189);
            this.auteurCatalogue.Name = "auteurCatalogue";
            this.auteurCatalogue.Size = new System.Drawing.Size(0, 20);
            this.auteurCatalogue.TabIndex = 16;
            // 
            // auteurCatalogueLabel
            // 
            this.auteurCatalogueLabel.AutoSize = true;
            this.auteurCatalogueLabel.Location = new System.Drawing.Point(214, 189);
            this.auteurCatalogueLabel.Name = "auteurCatalogueLabel";
            this.auteurCatalogueLabel.Size = new System.Drawing.Size(69, 20);
            this.auteurCatalogueLabel.TabIndex = 15;
            this.auteurCatalogueLabel.Text = "Auteur : ";
            // 
            // serieCatalogue
            // 
            this.serieCatalogue.AutoSize = true;
            this.serieCatalogue.Location = new System.Drawing.Point(298, 156);
            this.serieCatalogue.Name = "serieCatalogue";
            this.serieCatalogue.Size = new System.Drawing.Size(0, 20);
            this.serieCatalogue.TabIndex = 14;
            // 
            // serieCatalogueLabel
            // 
            this.serieCatalogueLabel.AutoSize = true;
            this.serieCatalogueLabel.Location = new System.Drawing.Point(225, 156);
            this.serieCatalogueLabel.Name = "serieCatalogueLabel";
            this.serieCatalogueLabel.Size = new System.Drawing.Size(58, 20);
            this.serieCatalogueLabel.TabIndex = 13;
            this.serieCatalogueLabel.Text = "Série : ";
            // 
            // imageAlbumCatalogue
            // 
            this.imageAlbumCatalogue.ImageLocation = "";
            this.imageAlbumCatalogue.Location = new System.Drawing.Point(471, 25);
            this.imageAlbumCatalogue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageAlbumCatalogue.Name = "imageAlbumCatalogue";
            this.imageAlbumCatalogue.Size = new System.Drawing.Size(122, 172);
            this.imageAlbumCatalogue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageAlbumCatalogue.TabIndex = 3;
            this.imageAlbumCatalogue.TabStop = false;
            // 
            // catalogueListBox
            // 
            this.catalogueListBox.FormattingEnabled = true;
            this.catalogueListBox.ItemHeight = 20;
            this.catalogueListBox.Location = new System.Drawing.Point(29, 91);
            this.catalogueListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.catalogueListBox.Name = "catalogueListBox";
            this.catalogueListBox.Size = new System.Drawing.Size(142, 304);
            this.catalogueListBox.TabIndex = 1;
            this.catalogueListBox.SelectedIndexChanged += new System.EventHandler(this.catalogueListBox_SelectedIndexChanged);
            // 
            // rechercheCatalogueBouton
            // 
            this.rechercheCatalogueBouton.Location = new System.Drawing.Point(272, 40);
            this.rechercheCatalogueBouton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rechercheCatalogueBouton.Name = "rechercheCatalogueBouton";
            this.rechercheCatalogueBouton.Size = new System.Drawing.Size(105, 35);
            this.rechercheCatalogueBouton.TabIndex = 0;
            this.rechercheCatalogueBouton.Text = "Recherche";
            this.rechercheCatalogueBouton.UseVisualStyleBackColor = true;
            this.rechercheCatalogueBouton.Click += new System.EventHandler(this.rechercheCatalogueButton_Click);
            // 
            // rechercheCatalogueTextBox
            // 
            this.rechercheCatalogueTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rechercheCatalogueTextBox.Location = new System.Drawing.Point(62, 106);
            this.rechercheCatalogueTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rechercheCatalogueTextBox.Name = "rechercheCatalogueTextBox";
            this.rechercheCatalogueTextBox.Size = new System.Drawing.Size(222, 26);
            this.rechercheCatalogueTextBox.TabIndex = 4;
            // 
            // ConsultAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 556);
            this.Controls.Add(this.rechercheCatalogueTextBox);
            this.Controls.Add(this.catalogueGroupBox);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.logOutButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(694, 612);
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