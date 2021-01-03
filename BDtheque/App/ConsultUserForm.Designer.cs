namespace App
{
    partial class ConsultUserForm
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
            this.userLabel = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.cataloguePage = new System.Windows.Forms.TabPage();
            this.catCatalogue = new System.Windows.Forms.Label();
            this.catCatalogueLabel = new System.Windows.Forms.Label();
            this.auteurCatalogue = new System.Windows.Forms.Label();
            this.auteurCatalogueLabel = new System.Windows.Forms.Label();
            this.serieCatalogue = new System.Windows.Forms.Label();
            this.serieCatalogueLabel = new System.Windows.Forms.Label();
            this.imageAlbumCatalogue = new System.Windows.Forms.PictureBox();
            this.nomAlbumCatalogue = new System.Windows.Forms.Label();
            this.catalogueListBox = new System.Windows.Forms.ListBox();
            this.possessionPage = new System.Windows.Forms.TabPage();
            this.souhaitsPage = new System.Windows.Forms.TabPage();
            this.rechercheTextBox = new System.Windows.Forms.TextBox();
            this.rechercheButton = new System.Windows.Forms.Button();
            this.decconectionButton = new System.Windows.Forms.Button();
            this.genreCatalogueLabel = new System.Windows.Forms.Label();
            this.genreCatalogue = new System.Windows.Forms.Label();
            this.editCatalogueLabel = new System.Windows.Forms.Label();
            this.editCatalogue = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.cataloguePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumCatalogue)).BeginInit();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(29, 24);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(0, 20);
            this.userLabel.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.cataloguePage);
            this.tabControl.Controls.Add(this.possessionPage);
            this.tabControl.Controls.Add(this.souhaitsPage);
            this.tabControl.Location = new System.Drawing.Point(33, 117);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(611, 369);
            this.tabControl.TabIndex = 2;
            // 
            // cataloguePage
            // 
            this.cataloguePage.Controls.Add(this.editCatalogue);
            this.cataloguePage.Controls.Add(this.editCatalogueLabel);
            this.cataloguePage.Controls.Add(this.genreCatalogue);
            this.cataloguePage.Controls.Add(this.genreCatalogueLabel);
            this.cataloguePage.Controls.Add(this.catCatalogue);
            this.cataloguePage.Controls.Add(this.catCatalogueLabel);
            this.cataloguePage.Controls.Add(this.auteurCatalogue);
            this.cataloguePage.Controls.Add(this.auteurCatalogueLabel);
            this.cataloguePage.Controls.Add(this.serieCatalogue);
            this.cataloguePage.Controls.Add(this.serieCatalogueLabel);
            this.cataloguePage.Controls.Add(this.imageAlbumCatalogue);
            this.cataloguePage.Controls.Add(this.nomAlbumCatalogue);
            this.cataloguePage.Controls.Add(this.catalogueListBox);
            this.cataloguePage.Location = new System.Drawing.Point(4, 29);
            this.cataloguePage.Name = "cataloguePage";
            this.cataloguePage.Padding = new System.Windows.Forms.Padding(3);
            this.cataloguePage.Size = new System.Drawing.Size(603, 336);
            this.cataloguePage.TabIndex = 0;
            this.cataloguePage.Text = "Catalogue";
            this.cataloguePage.UseVisualStyleBackColor = true;
            // 
            // catCatalogue
            // 
            this.catCatalogue.AutoSize = true;
            this.catCatalogue.Location = new System.Drawing.Point(282, 138);
            this.catCatalogue.Name = "catCatalogue";
            this.catCatalogue.Size = new System.Drawing.Size(0, 20);
            this.catCatalogue.TabIndex = 8;
            // 
            // catCatalogueLabel
            // 
            this.catCatalogueLabel.AutoSize = true;
            this.catCatalogueLabel.Location = new System.Drawing.Point(177, 138);
            this.catCatalogueLabel.Name = "catCatalogueLabel";
            this.catCatalogueLabel.Size = new System.Drawing.Size(90, 20);
            this.catCatalogueLabel.TabIndex = 7;
            this.catCatalogueLabel.Text = "Catégorie : ";
            // 
            // auteurCatalogue
            // 
            this.auteurCatalogue.AutoSize = true;
            this.auteurCatalogue.Location = new System.Drawing.Point(281, 102);
            this.auteurCatalogue.Name = "auteurCatalogue";
            this.auteurCatalogue.Size = new System.Drawing.Size(0, 20);
            this.auteurCatalogue.TabIndex = 6;
            // 
            // auteurCatalogueLabel
            // 
            this.auteurCatalogueLabel.AutoSize = true;
            this.auteurCatalogueLabel.Location = new System.Drawing.Point(198, 102);
            this.auteurCatalogueLabel.Name = "auteurCatalogueLabel";
            this.auteurCatalogueLabel.Size = new System.Drawing.Size(69, 20);
            this.auteurCatalogueLabel.TabIndex = 5;
            this.auteurCatalogueLabel.Text = "Auteur : ";
            // 
            // serieCatalogue
            // 
            this.serieCatalogue.AutoSize = true;
            this.serieCatalogue.Location = new System.Drawing.Point(282, 70);
            this.serieCatalogue.Name = "serieCatalogue";
            this.serieCatalogue.Size = new System.Drawing.Size(0, 20);
            this.serieCatalogue.TabIndex = 4;
            // 
            // serieCatalogueLabel
            // 
            this.serieCatalogueLabel.AutoSize = true;
            this.serieCatalogueLabel.Location = new System.Drawing.Point(209, 70);
            this.serieCatalogueLabel.Name = "serieCatalogueLabel";
            this.serieCatalogueLabel.Size = new System.Drawing.Size(58, 20);
            this.serieCatalogueLabel.TabIndex = 3;
            this.serieCatalogueLabel.Text = "Série : ";
            // 
            // imageAlbumCatalogue
            // 
            this.imageAlbumCatalogue.ImageLocation = "";
            this.imageAlbumCatalogue.Location = new System.Drawing.Point(499, 17);
            this.imageAlbumCatalogue.Name = "imageAlbumCatalogue";
            this.imageAlbumCatalogue.Size = new System.Drawing.Size(90, 85);
            this.imageAlbumCatalogue.TabIndex = 2;
            this.imageAlbumCatalogue.TabStop = false;
            // 
            // nomAlbumCatalogue
            // 
            this.nomAlbumCatalogue.AutoSize = true;
            this.nomAlbumCatalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomAlbumCatalogue.Location = new System.Drawing.Point(209, 17);
            this.nomAlbumCatalogue.Name = "nomAlbumCatalogue";
            this.nomAlbumCatalogue.Size = new System.Drawing.Size(0, 20);
            this.nomAlbumCatalogue.TabIndex = 1;
            // 
            // catalogueListBox
            // 
            this.catalogueListBox.FormattingEnabled = true;
            this.catalogueListBox.ItemHeight = 20;
            this.catalogueListBox.Location = new System.Drawing.Point(25, 17);
            this.catalogueListBox.Name = "catalogueListBox";
            this.catalogueListBox.Size = new System.Drawing.Size(142, 304);
            this.catalogueListBox.TabIndex = 0;
            this.catalogueListBox.SelectedIndexChanged += new System.EventHandler(this.catalogueListBox_SelectedIndexChanged);
            // 
            // possessionPage
            // 
            this.possessionPage.Location = new System.Drawing.Point(4, 29);
            this.possessionPage.Name = "possessionPage";
            this.possessionPage.Padding = new System.Windows.Forms.Padding(3);
            this.possessionPage.Size = new System.Drawing.Size(603, 336);
            this.possessionPage.TabIndex = 1;
            this.possessionPage.Text = "Mes Albums";
            this.possessionPage.UseVisualStyleBackColor = true;
            // 
            // souhaitsPage
            // 
            this.souhaitsPage.Location = new System.Drawing.Point(4, 29);
            this.souhaitsPage.Name = "souhaitsPage";
            this.souhaitsPage.Padding = new System.Windows.Forms.Padding(3);
            this.souhaitsPage.Size = new System.Drawing.Size(603, 336);
            this.souhaitsPage.TabIndex = 2;
            this.souhaitsPage.Text = "Mes Souhaits";
            // 
            // rechercheTextBox
            // 
            this.rechercheTextBox.Location = new System.Drawing.Point(37, 65);
            this.rechercheTextBox.Name = "rechercheTextBox";
            this.rechercheTextBox.Size = new System.Drawing.Size(222, 26);
            this.rechercheTextBox.TabIndex = 3;
            // 
            // rechercheButton
            // 
            this.rechercheButton.Location = new System.Drawing.Point(282, 65);
            this.rechercheButton.Name = "rechercheButton";
            this.rechercheButton.Size = new System.Drawing.Size(105, 35);
            this.rechercheButton.TabIndex = 4;
            this.rechercheButton.Text = "Rechercher";
            // 
            // decconectionButton
            // 
            this.decconectionButton.Location = new System.Drawing.Point(282, 509);
            this.decconectionButton.Name = "decconectionButton";
            this.decconectionButton.Size = new System.Drawing.Size(122, 35);
            this.decconectionButton.TabIndex = 5;
            this.decconectionButton.Text = "Déconnexion";
            this.decconectionButton.UseVisualStyleBackColor = true;
            this.decconectionButton.Click += new System.EventHandler(this.deconnectionButton_Click);
            // 
            // genreCatalogueLabel
            // 
            this.genreCatalogueLabel.AutoSize = true;
            this.genreCatalogueLabel.Location = new System.Drawing.Point(201, 179);
            this.genreCatalogueLabel.Name = "genreCatalogueLabel";
            this.genreCatalogueLabel.Size = new System.Drawing.Size(66, 20);
            this.genreCatalogueLabel.TabIndex = 9;
            this.genreCatalogueLabel.Text = "Genre : ";
            // 
            // genreCatalogue
            // 
            this.genreCatalogue.AutoSize = true;
            this.genreCatalogue.Location = new System.Drawing.Point(282, 179);
            this.genreCatalogue.Name = "genreCatalogue";
            this.genreCatalogue.Size = new System.Drawing.Size(0, 20);
            this.genreCatalogue.TabIndex = 10;
            // 
            // editCatalogueLabel
            // 
            this.editCatalogueLabel.AutoSize = true;
            this.editCatalogueLabel.Location = new System.Drawing.Point(197, 220);
            this.editCatalogueLabel.Name = "editCatalogueLabel";
            this.editCatalogueLabel.Size = new System.Drawing.Size(70, 20);
            this.editCatalogueLabel.TabIndex = 11;
            this.editCatalogueLabel.Text = "Edition : ";
            // 
            // editCatalogue
            // 
            this.editCatalogue.AutoSize = true;
            this.editCatalogue.Location = new System.Drawing.Point(282, 220);
            this.editCatalogue.Name = "editCatalogue";
            this.editCatalogue.Size = new System.Drawing.Size(0, 20);
            this.editCatalogue.TabIndex = 12;
            // 
            // ConsultUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 556);
            this.Controls.Add(this.decconectionButton);
            this.Controls.Add(this.rechercheButton);
            this.Controls.Add(this.rechercheTextBox);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.userLabel);
            this.Name = "ConsultUserForm";
            this.Text = "BDThèque : Utilisateur";
            this.tabControl.ResumeLayout(false);
            this.cataloguePage.ResumeLayout(false);
            this.cataloguePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumCatalogue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage cataloguePage;
        private System.Windows.Forms.TabPage possessionPage;
        private System.Windows.Forms.TabPage souhaitsPage;
        private System.Windows.Forms.TextBox rechercheTextBox;
        private System.Windows.Forms.Button rechercheButton;
        private System.Windows.Forms.Button decconectionButton;
        private System.Windows.Forms.ListBox catalogueListBox;
        private System.Windows.Forms.Label nomAlbumCatalogue;
        private System.Windows.Forms.PictureBox imageAlbumCatalogue;
        private System.Windows.Forms.Label serieCatalogueLabel;
        private System.Windows.Forms.Label serieCatalogue;
        private System.Windows.Forms.Label auteurCatalogue;
        private System.Windows.Forms.Label auteurCatalogueLabel;
        private System.Windows.Forms.Label catCatalogueLabel;
        private System.Windows.Forms.Label catCatalogue;
        private System.Windows.Forms.Label editCatalogue;
        private System.Windows.Forms.Label editCatalogueLabel;
        private System.Windows.Forms.Label genreCatalogue;
        private System.Windows.Forms.Label genreCatalogueLabel;
    }
}