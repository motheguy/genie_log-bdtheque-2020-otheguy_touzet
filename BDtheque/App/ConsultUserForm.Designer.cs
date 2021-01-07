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
            this.ajoutSouhaitButton = new System.Windows.Forms.Button();
            this.rechercheCatalogueButton = new System.Windows.Forms.Button();
            this.achatCatalogueButton = new System.Windows.Forms.Button();
            this.rechercheCatalogueTextBox = new System.Windows.Forms.TextBox();
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
            this.nomAlbumCatalogue = new System.Windows.Forms.Label();
            this.catalogueListBox = new System.Windows.Forms.ListBox();
            this.possessionPage = new System.Windows.Forms.TabPage();
            this.recherchePossessButton = new System.Windows.Forms.Button();
            this.recherchePossessTextBox = new System.Windows.Forms.TextBox();
            this.nomAlbumPossess = new System.Windows.Forms.Label();
            this.editPossess = new System.Windows.Forms.Label();
            this.editPossessLabel = new System.Windows.Forms.Label();
            this.genrePossess = new System.Windows.Forms.Label();
            this.genrePossessLabel = new System.Windows.Forms.Label();
            this.catPossess = new System.Windows.Forms.Label();
            this.catPossessLabel = new System.Windows.Forms.Label();
            this.auteurPossess = new System.Windows.Forms.Label();
            this.auteurPossessLabel = new System.Windows.Forms.Label();
            this.seriePossess = new System.Windows.Forms.Label();
            this.seriePossessLabel = new System.Windows.Forms.Label();
            this.possessionListBox = new System.Windows.Forms.ListBox();
            this.souhaitsPage = new System.Windows.Forms.TabPage();
            this.rechercheSouhaitButton = new System.Windows.Forms.Button();
            this.rechercheSouhaitTextBox = new System.Windows.Forms.TextBox();
            this.achatSouhaitButton = new System.Windows.Forms.Button();
            this.editSouhait = new System.Windows.Forms.Label();
            this.editSouhaitLabel = new System.Windows.Forms.Label();
            this.genreSouhait = new System.Windows.Forms.Label();
            this.genreSouhaitLabel = new System.Windows.Forms.Label();
            this.catSouhait = new System.Windows.Forms.Label();
            this.catSouhaitLabel = new System.Windows.Forms.Label();
            this.auteurSouhait = new System.Windows.Forms.Label();
            this.auteurSouhaitLabel = new System.Windows.Forms.Label();
            this.serieSouhait = new System.Windows.Forms.Label();
            this.serieSouhaitLabel = new System.Windows.Forms.Label();
            this.nomAlbumSouhait = new System.Windows.Forms.Label();
            this.souhaitsListBox = new System.Windows.Forms.ListBox();
            this.decconectionButton = new System.Windows.Forms.Button();
            this.deleteSouhaitButton = new System.Windows.Forms.Button();
            this.imageAlbumPossess = new System.Windows.Forms.PictureBox();
            this.imageAlbumSouhait = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.cataloguePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumCatalogue)).BeginInit();
            this.possessionPage.SuspendLayout();
            this.souhaitsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPossess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumSouhait)).BeginInit();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(26, 19);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(0, 17);
            this.userLabel.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.cataloguePage);
            this.tabControl.Controls.Add(this.possessionPage);
            this.tabControl.Controls.Add(this.souhaitsPage);
            this.tabControl.Location = new System.Drawing.Point(29, 51);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(543, 338);
            this.tabControl.TabIndex = 2;
            // 
            // cataloguePage
            // 
            this.cataloguePage.BackColor = System.Drawing.Color.Transparent;
            this.cataloguePage.Controls.Add(this.ajoutSouhaitButton);
            this.cataloguePage.Controls.Add(this.rechercheCatalogueButton);
            this.cataloguePage.Controls.Add(this.achatCatalogueButton);
            this.cataloguePage.Controls.Add(this.rechercheCatalogueTextBox);
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
            this.cataloguePage.Location = new System.Drawing.Point(4, 25);
            this.cataloguePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cataloguePage.Name = "cataloguePage";
            this.cataloguePage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cataloguePage.Size = new System.Drawing.Size(535, 309);
            this.cataloguePage.TabIndex = 0;
            this.cataloguePage.Text = "Catalogue";
            this.cataloguePage.Click += new System.EventHandler(this.cataloguePage_Click);
            // 
            // ajoutSouhaitButton
            // 
            this.ajoutSouhaitButton.Location = new System.Drawing.Point(305, 95);
            this.ajoutSouhaitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ajoutSouhaitButton.Name = "ajoutSouhaitButton";
            this.ajoutSouhaitButton.Size = new System.Drawing.Size(115, 45);
            this.ajoutSouhaitButton.TabIndex = 14;
            this.ajoutSouhaitButton.Text = "Ajouter à mes souhaits";
            this.ajoutSouhaitButton.Click += new System.EventHandler(this.ajoutSouhaitButton_Click);
            // 
            // rechercheCatalogueButton
            // 
            this.rechercheCatalogueButton.Location = new System.Drawing.Point(250, 13);
            this.rechercheCatalogueButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rechercheCatalogueButton.Name = "rechercheCatalogueButton";
            this.rechercheCatalogueButton.Size = new System.Drawing.Size(93, 28);
            this.rechercheCatalogueButton.TabIndex = 4;
            this.rechercheCatalogueButton.Text = "Rechercher";
            this.rechercheCatalogueButton.Click += new System.EventHandler(this.rechercheCatalogueButton_Click);
            // 
            // achatCatalogueButton
            // 
            this.achatCatalogueButton.Location = new System.Drawing.Point(169, 95);
            this.achatCatalogueButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.achatCatalogueButton.Name = "achatCatalogueButton";
            this.achatCatalogueButton.Size = new System.Drawing.Size(115, 45);
            this.achatCatalogueButton.TabIndex = 13;
            this.achatCatalogueButton.Text = "Acheter";
            this.achatCatalogueButton.Click += new System.EventHandler(this.achatCatalogueButton_Click);
            // 
            // rechercheCatalogueTextBox
            // 
            this.rechercheCatalogueTextBox.Location = new System.Drawing.Point(23, 16);
            this.rechercheCatalogueTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rechercheCatalogueTextBox.Name = "rechercheCatalogueTextBox";
            this.rechercheCatalogueTextBox.Size = new System.Drawing.Size(198, 22);
            this.rechercheCatalogueTextBox.TabIndex = 3;
            // 
            // editCatalogue
            // 
            this.editCatalogue.AutoSize = true;
            this.editCatalogue.Location = new System.Drawing.Point(259, 275);
            this.editCatalogue.Name = "editCatalogue";
            this.editCatalogue.Size = new System.Drawing.Size(0, 17);
            this.editCatalogue.TabIndex = 12;
            // 
            // editCatalogueLabel
            // 
            this.editCatalogueLabel.AutoSize = true;
            this.editCatalogueLabel.Location = new System.Drawing.Point(183, 275);
            this.editCatalogueLabel.Name = "editCatalogueLabel";
            this.editCatalogueLabel.Size = new System.Drawing.Size(63, 17);
            this.editCatalogueLabel.TabIndex = 11;
            this.editCatalogueLabel.Text = "Edition : ";
            // 
            // genreCatalogue
            // 
            this.genreCatalogue.AutoSize = true;
            this.genreCatalogue.Location = new System.Drawing.Point(259, 242);
            this.genreCatalogue.Name = "genreCatalogue";
            this.genreCatalogue.Size = new System.Drawing.Size(0, 17);
            this.genreCatalogue.TabIndex = 10;
            // 
            // genreCatalogueLabel
            // 
            this.genreCatalogueLabel.AutoSize = true;
            this.genreCatalogueLabel.Location = new System.Drawing.Point(187, 242);
            this.genreCatalogueLabel.Name = "genreCatalogueLabel";
            this.genreCatalogueLabel.Size = new System.Drawing.Size(60, 17);
            this.genreCatalogueLabel.TabIndex = 9;
            this.genreCatalogueLabel.Text = "Genre : ";
            // 
            // catCatalogue
            // 
            this.catCatalogue.AutoSize = true;
            this.catCatalogue.Location = new System.Drawing.Point(259, 210);
            this.catCatalogue.Name = "catCatalogue";
            this.catCatalogue.Size = new System.Drawing.Size(0, 17);
            this.catCatalogue.TabIndex = 8;
            // 
            // catCatalogueLabel
            // 
            this.catCatalogueLabel.AutoSize = true;
            this.catCatalogueLabel.Location = new System.Drawing.Point(165, 210);
            this.catCatalogueLabel.Name = "catCatalogueLabel";
            this.catCatalogueLabel.Size = new System.Drawing.Size(81, 17);
            this.catCatalogueLabel.TabIndex = 7;
            this.catCatalogueLabel.Text = "Catégorie : ";
            // 
            // auteurCatalogue
            // 
            this.auteurCatalogue.AutoSize = true;
            this.auteurCatalogue.Location = new System.Drawing.Point(258, 181);
            this.auteurCatalogue.Name = "auteurCatalogue";
            this.auteurCatalogue.Size = new System.Drawing.Size(0, 17);
            this.auteurCatalogue.TabIndex = 6;
            // 
            // auteurCatalogueLabel
            // 
            this.auteurCatalogueLabel.AutoSize = true;
            this.auteurCatalogueLabel.Location = new System.Drawing.Point(184, 181);
            this.auteurCatalogueLabel.Name = "auteurCatalogueLabel";
            this.auteurCatalogueLabel.Size = new System.Drawing.Size(62, 17);
            this.auteurCatalogueLabel.TabIndex = 5;
            this.auteurCatalogueLabel.Text = "Auteur : ";
            // 
            // serieCatalogue
            // 
            this.serieCatalogue.AutoSize = true;
            this.serieCatalogue.Location = new System.Drawing.Point(259, 155);
            this.serieCatalogue.Name = "serieCatalogue";
            this.serieCatalogue.Size = new System.Drawing.Size(0, 17);
            this.serieCatalogue.TabIndex = 4;
            // 
            // serieCatalogueLabel
            // 
            this.serieCatalogueLabel.AutoSize = true;
            this.serieCatalogueLabel.Location = new System.Drawing.Point(194, 155);
            this.serieCatalogueLabel.Name = "serieCatalogueLabel";
            this.serieCatalogueLabel.Size = new System.Drawing.Size(53, 17);
            this.serieCatalogueLabel.TabIndex = 3;
            this.serieCatalogueLabel.Text = "Série : ";
            // 
            // imageAlbumCatalogue
            // 
            this.imageAlbumCatalogue.ImageLocation = "";
<<<<<<< HEAD
            this.imageAlbumCatalogue.Location = new System.Drawing.Point(444, 55);
            this.imageAlbumCatalogue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageAlbumCatalogue.Name = "imageAlbumCatalogue";
            this.imageAlbumCatalogue.Size = new System.Drawing.Size(80, 77);
=======
            this.imageAlbumCatalogue.Location = new System.Drawing.Point(489, 20);
            this.imageAlbumCatalogue.Name = "imageAlbumCatalogue";
            this.imageAlbumCatalogue.Size = new System.Drawing.Size(108, 155);
            this.imageAlbumCatalogue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
>>>>>>> d528b043798a7c09ad7903ff6c64911fa3287043
            this.imageAlbumCatalogue.TabIndex = 2;
            this.imageAlbumCatalogue.TabStop = false;
            // 
            // nomAlbumCatalogue
            // 
            this.nomAlbumCatalogue.AutoSize = true;
            this.nomAlbumCatalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomAlbumCatalogue.Location = new System.Drawing.Point(187, 55);
            this.nomAlbumCatalogue.Name = "nomAlbumCatalogue";
            this.nomAlbumCatalogue.Size = new System.Drawing.Size(0, 17);
            this.nomAlbumCatalogue.TabIndex = 1;
            // 
            // catalogueListBox
            // 
            this.catalogueListBox.FormattingEnabled = true;
            this.catalogueListBox.ItemHeight = 16;
            this.catalogueListBox.Location = new System.Drawing.Point(23, 55);
            this.catalogueListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.catalogueListBox.Name = "catalogueListBox";
            this.catalogueListBox.Size = new System.Drawing.Size(127, 244);
            this.catalogueListBox.TabIndex = 0;
            this.catalogueListBox.SelectedIndexChanged += new System.EventHandler(this.catalogueListBox_SelectedIndexChanged);
            // 
            // possessionPage
            // 
            this.possessionPage.BackColor = System.Drawing.Color.Transparent;
            this.possessionPage.Controls.Add(this.imageAlbumPossess);
            this.possessionPage.Controls.Add(this.recherchePossessButton);
            this.possessionPage.Controls.Add(this.recherchePossessTextBox);
            this.possessionPage.Controls.Add(this.nomAlbumPossess);
            this.possessionPage.Controls.Add(this.editPossess);
            this.possessionPage.Controls.Add(this.editPossessLabel);
            this.possessionPage.Controls.Add(this.genrePossess);
            this.possessionPage.Controls.Add(this.genrePossessLabel);
            this.possessionPage.Controls.Add(this.catPossess);
            this.possessionPage.Controls.Add(this.catPossessLabel);
            this.possessionPage.Controls.Add(this.auteurPossess);
            this.possessionPage.Controls.Add(this.auteurPossessLabel);
            this.possessionPage.Controls.Add(this.seriePossess);
            this.possessionPage.Controls.Add(this.seriePossessLabel);
            this.possessionPage.Controls.Add(this.possessionListBox);
            this.possessionPage.Location = new System.Drawing.Point(4, 25);
            this.possessionPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.possessionPage.Name = "possessionPage";
            this.possessionPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.possessionPage.Size = new System.Drawing.Size(535, 309);
            this.possessionPage.TabIndex = 1;
            this.possessionPage.Text = "Mes Albums";
            this.possessionPage.Click += new System.EventHandler(this.possessionPage_Click);
            // 
            // recherchePossessButton
            // 
            this.recherchePossessButton.Location = new System.Drawing.Point(249, 11);
            this.recherchePossessButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recherchePossessButton.Name = "recherchePossessButton";
            this.recherchePossessButton.Size = new System.Drawing.Size(93, 28);
            this.recherchePossessButton.TabIndex = 25;
            this.recherchePossessButton.Text = "Rechercher";
            this.recherchePossessButton.Click += new System.EventHandler(this.recherchePossessButton_Click);
            // 
            // recherchePossessTextBox
            // 
            this.recherchePossessTextBox.Location = new System.Drawing.Point(22, 14);
            this.recherchePossessTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recherchePossessTextBox.Name = "recherchePossessTextBox";
            this.recherchePossessTextBox.Size = new System.Drawing.Size(198, 22);
            this.recherchePossessTextBox.TabIndex = 24;
            // 
            // nomAlbumPossess
            // 
            this.nomAlbumPossess.AutoSize = true;
            this.nomAlbumPossess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomAlbumPossess.Location = new System.Drawing.Point(191, 51);
            this.nomAlbumPossess.Name = "nomAlbumPossess";
            this.nomAlbumPossess.Size = new System.Drawing.Size(0, 17);
            this.nomAlbumPossess.TabIndex = 23;
            // 
            // editPossess
            // 
            this.editPossess.AutoSize = true;
            this.editPossess.Location = new System.Drawing.Point(256, 261);
            this.editPossess.Name = "editPossess";
            this.editPossess.Size = new System.Drawing.Size(0, 17);
            this.editPossess.TabIndex = 22;
            // 
            // editPossessLabel
            // 
            this.editPossessLabel.AutoSize = true;
            this.editPossessLabel.Location = new System.Drawing.Point(180, 261);
            this.editPossessLabel.Name = "editPossessLabel";
            this.editPossessLabel.Size = new System.Drawing.Size(63, 17);
            this.editPossessLabel.TabIndex = 21;
            this.editPossessLabel.Text = "Edition : ";
            // 
            // genrePossess
            // 
            this.genrePossess.AutoSize = true;
            this.genrePossess.Location = new System.Drawing.Point(256, 228);
            this.genrePossess.Name = "genrePossess";
            this.genrePossess.Size = new System.Drawing.Size(0, 17);
            this.genrePossess.TabIndex = 20;
            // 
            // genrePossessLabel
            // 
            this.genrePossessLabel.AutoSize = true;
            this.genrePossessLabel.Location = new System.Drawing.Point(184, 228);
            this.genrePossessLabel.Name = "genrePossessLabel";
            this.genrePossessLabel.Size = new System.Drawing.Size(60, 17);
            this.genrePossessLabel.TabIndex = 19;
            this.genrePossessLabel.Text = "Genre : ";
            // 
            // catPossess
            // 
            this.catPossess.AutoSize = true;
            this.catPossess.Location = new System.Drawing.Point(256, 195);
            this.catPossess.Name = "catPossess";
            this.catPossess.Size = new System.Drawing.Size(0, 17);
            this.catPossess.TabIndex = 18;
            // 
            // catPossessLabel
            // 
            this.catPossessLabel.AutoSize = true;
            this.catPossessLabel.Location = new System.Drawing.Point(163, 195);
            this.catPossessLabel.Name = "catPossessLabel";
            this.catPossessLabel.Size = new System.Drawing.Size(81, 17);
            this.catPossessLabel.TabIndex = 17;
            this.catPossessLabel.Text = "Catégorie : ";
            // 
            // auteurPossess
            // 
            this.auteurPossess.AutoSize = true;
            this.auteurPossess.Location = new System.Drawing.Point(255, 166);
            this.auteurPossess.Name = "auteurPossess";
            this.auteurPossess.Size = new System.Drawing.Size(0, 17);
            this.auteurPossess.TabIndex = 16;
            // 
            // auteurPossessLabel
            // 
            this.auteurPossessLabel.AutoSize = true;
            this.auteurPossessLabel.Location = new System.Drawing.Point(181, 166);
            this.auteurPossessLabel.Name = "auteurPossessLabel";
            this.auteurPossessLabel.Size = new System.Drawing.Size(62, 17);
            this.auteurPossessLabel.TabIndex = 15;
            this.auteurPossessLabel.Text = "Auteur : ";
            // 
            // seriePossess
            // 
            this.seriePossess.AutoSize = true;
            this.seriePossess.Location = new System.Drawing.Point(256, 141);
            this.seriePossess.Name = "seriePossess";
            this.seriePossess.Size = new System.Drawing.Size(0, 17);
            this.seriePossess.TabIndex = 14;
            // 
            // seriePossessLabel
            // 
            this.seriePossessLabel.AutoSize = true;
            this.seriePossessLabel.Location = new System.Drawing.Point(191, 141);
            this.seriePossessLabel.Name = "seriePossessLabel";
            this.seriePossessLabel.Size = new System.Drawing.Size(53, 17);
            this.seriePossessLabel.TabIndex = 13;
            this.seriePossessLabel.Text = "Série : ";
            // 
            // possessionListBox
            // 
            this.possessionListBox.FormattingEnabled = true;
            this.possessionListBox.ItemHeight = 16;
            this.possessionListBox.Location = new System.Drawing.Point(22, 51);
            this.possessionListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.possessionListBox.Name = "possessionListBox";
            this.possessionListBox.Size = new System.Drawing.Size(127, 244);
            this.possessionListBox.TabIndex = 1;
            this.possessionListBox.SelectedIndexChanged += new System.EventHandler(this.possessionListBox_SelectedIndexChanged);
            // 
            // souhaitsPage
            // 
            this.souhaitsPage.BackColor = System.Drawing.Color.Transparent;
            this.souhaitsPage.Controls.Add(this.imageAlbumSouhait);
            this.souhaitsPage.Controls.Add(this.deleteSouhaitButton);
            this.souhaitsPage.Controls.Add(this.rechercheSouhaitButton);
            this.souhaitsPage.Controls.Add(this.rechercheSouhaitTextBox);
            this.souhaitsPage.Controls.Add(this.achatSouhaitButton);
            this.souhaitsPage.Controls.Add(this.editSouhait);
            this.souhaitsPage.Controls.Add(this.editSouhaitLabel);
            this.souhaitsPage.Controls.Add(this.genreSouhait);
            this.souhaitsPage.Controls.Add(this.genreSouhaitLabel);
            this.souhaitsPage.Controls.Add(this.catSouhait);
            this.souhaitsPage.Controls.Add(this.catSouhaitLabel);
            this.souhaitsPage.Controls.Add(this.auteurSouhait);
            this.souhaitsPage.Controls.Add(this.auteurSouhaitLabel);
            this.souhaitsPage.Controls.Add(this.serieSouhait);
            this.souhaitsPage.Controls.Add(this.serieSouhaitLabel);
            this.souhaitsPage.Controls.Add(this.nomAlbumSouhait);
            this.souhaitsPage.Controls.Add(this.souhaitsListBox);
            this.souhaitsPage.Location = new System.Drawing.Point(4, 25);
            this.souhaitsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.souhaitsPage.Name = "souhaitsPage";
            this.souhaitsPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.souhaitsPage.Size = new System.Drawing.Size(535, 309);
            this.souhaitsPage.TabIndex = 2;
            this.souhaitsPage.Text = "Mes Souhaits";
            this.souhaitsPage.Click += new System.EventHandler(this.souhaitsPage_Click);
            // 
            // rechercheSouhaitButton
            // 
            this.rechercheSouhaitButton.Location = new System.Drawing.Point(251, 12);
            this.rechercheSouhaitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rechercheSouhaitButton.Name = "rechercheSouhaitButton";
            this.rechercheSouhaitButton.Size = new System.Drawing.Size(93, 28);
            this.rechercheSouhaitButton.TabIndex = 34;
            this.rechercheSouhaitButton.Text = "Rechercher";
            this.rechercheSouhaitButton.Click += new System.EventHandler(this.rechercheSouhaitButton_Click);
            // 
            // rechercheSouhaitTextBox
            // 
            this.rechercheSouhaitTextBox.Location = new System.Drawing.Point(24, 15);
            this.rechercheSouhaitTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rechercheSouhaitTextBox.Name = "rechercheSouhaitTextBox";
            this.rechercheSouhaitTextBox.Size = new System.Drawing.Size(198, 22);
            this.rechercheSouhaitTextBox.TabIndex = 33;
            // 
            // achatSouhaitButton
            // 
<<<<<<< HEAD
            this.achatSouhaitButton.Location = new System.Drawing.Point(176, 95);
            this.achatSouhaitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.achatSouhaitButton.Name = "achatSouhaitButton";
            this.achatSouhaitButton.Size = new System.Drawing.Size(93, 28);
=======
            this.achatSouhaitButton.Location = new System.Drawing.Point(189, 108);
            this.achatSouhaitButton.Name = "achatSouhaitButton";
            this.achatSouhaitButton.Size = new System.Drawing.Size(129, 56);
>>>>>>> d528b043798a7c09ad7903ff6c64911fa3287043
            this.achatSouhaitButton.TabIndex = 6;
            this.achatSouhaitButton.Text = "Acheter";
            this.achatSouhaitButton.Click += new System.EventHandler(this.achatSouhaitButton_Click);
            // 
            // editSouhait
            // 
            this.editSouhait.AutoSize = true;
            this.editSouhait.Location = new System.Drawing.Point(266, 272);
            this.editSouhait.Name = "editSouhait";
            this.editSouhait.Size = new System.Drawing.Size(0, 17);
            this.editSouhait.TabIndex = 32;
            // 
            // editSouhaitLabel
            // 
            this.editSouhaitLabel.AutoSize = true;
            this.editSouhaitLabel.Location = new System.Drawing.Point(190, 272);
            this.editSouhaitLabel.Name = "editSouhaitLabel";
            this.editSouhaitLabel.Size = new System.Drawing.Size(63, 17);
            this.editSouhaitLabel.TabIndex = 31;
            this.editSouhaitLabel.Text = "Edition : ";
            // 
            // genreSouhait
            // 
            this.genreSouhait.AutoSize = true;
            this.genreSouhait.Location = new System.Drawing.Point(266, 239);
            this.genreSouhait.Name = "genreSouhait";
            this.genreSouhait.Size = new System.Drawing.Size(0, 17);
            this.genreSouhait.TabIndex = 30;
            // 
            // genreSouhaitLabel
            // 
            this.genreSouhaitLabel.AutoSize = true;
            this.genreSouhaitLabel.Location = new System.Drawing.Point(194, 239);
            this.genreSouhaitLabel.Name = "genreSouhaitLabel";
            this.genreSouhaitLabel.Size = new System.Drawing.Size(60, 17);
            this.genreSouhaitLabel.TabIndex = 29;
            this.genreSouhaitLabel.Text = "Genre : ";
            // 
            // catSouhait
            // 
            this.catSouhait.AutoSize = true;
            this.catSouhait.Location = new System.Drawing.Point(266, 206);
            this.catSouhait.Name = "catSouhait";
            this.catSouhait.Size = new System.Drawing.Size(0, 17);
            this.catSouhait.TabIndex = 28;
            // 
            // catSouhaitLabel
            // 
            this.catSouhaitLabel.AutoSize = true;
            this.catSouhaitLabel.Location = new System.Drawing.Point(172, 206);
            this.catSouhaitLabel.Name = "catSouhaitLabel";
            this.catSouhaitLabel.Size = new System.Drawing.Size(81, 17);
            this.catSouhaitLabel.TabIndex = 27;
            this.catSouhaitLabel.Text = "Catégorie : ";
            // 
            // auteurSouhait
            // 
            this.auteurSouhait.AutoSize = true;
            this.auteurSouhait.Location = new System.Drawing.Point(265, 178);
            this.auteurSouhait.Name = "auteurSouhait";
            this.auteurSouhait.Size = new System.Drawing.Size(0, 17);
            this.auteurSouhait.TabIndex = 26;
            // 
            // auteurSouhaitLabel
            // 
            this.auteurSouhaitLabel.AutoSize = true;
            this.auteurSouhaitLabel.Location = new System.Drawing.Point(191, 178);
            this.auteurSouhaitLabel.Name = "auteurSouhaitLabel";
            this.auteurSouhaitLabel.Size = new System.Drawing.Size(62, 17);
            this.auteurSouhaitLabel.TabIndex = 25;
            this.auteurSouhaitLabel.Text = "Auteur : ";
            // 
            // serieSouhait
            // 
            this.serieSouhait.AutoSize = true;
            this.serieSouhait.Location = new System.Drawing.Point(266, 152);
            this.serieSouhait.Name = "serieSouhait";
            this.serieSouhait.Size = new System.Drawing.Size(0, 17);
            this.serieSouhait.TabIndex = 24;
            // 
            // serieSouhaitLabel
            // 
            this.serieSouhaitLabel.AutoSize = true;
            this.serieSouhaitLabel.Location = new System.Drawing.Point(201, 152);
            this.serieSouhaitLabel.Name = "serieSouhaitLabel";
            this.serieSouhaitLabel.Size = new System.Drawing.Size(53, 17);
            this.serieSouhaitLabel.TabIndex = 23;
            this.serieSouhaitLabel.Text = "Série : ";
            // 
            // nomAlbumSouhait
            // 
            this.nomAlbumSouhait.AutoSize = true;
            this.nomAlbumSouhait.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomAlbumSouhait.Location = new System.Drawing.Point(201, 52);
            this.nomAlbumSouhait.Name = "nomAlbumSouhait";
            this.nomAlbumSouhait.Size = new System.Drawing.Size(0, 17);
            this.nomAlbumSouhait.TabIndex = 2;
            // 
            // souhaitsListBox
            // 
            this.souhaitsListBox.FormattingEnabled = true;
            this.souhaitsListBox.ItemHeight = 16;
            this.souhaitsListBox.Location = new System.Drawing.Point(24, 52);
            this.souhaitsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.souhaitsListBox.Name = "souhaitsListBox";
            this.souhaitsListBox.Size = new System.Drawing.Size(127, 244);
            this.souhaitsListBox.TabIndex = 1;
            this.souhaitsListBox.SelectedIndexChanged += new System.EventHandler(this.souhaitsListBox_SelectedIndexChanged);
            // 
            // decconectionButton
            // 
            this.decconectionButton.Location = new System.Drawing.Point(251, 407);
            this.decconectionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decconectionButton.Name = "decconectionButton";
            this.decconectionButton.Size = new System.Drawing.Size(108, 28);
            this.decconectionButton.TabIndex = 5;
            this.decconectionButton.Text = "Déconnexion";
            this.decconectionButton.UseVisualStyleBackColor = true;
            this.decconectionButton.Click += new System.EventHandler(this.deconnectionButton_Click);
            // 
            // deleteSouhaitButton
            // 
            this.deleteSouhaitButton.Location = new System.Drawing.Point(333, 108);
            this.deleteSouhaitButton.Name = "deleteSouhaitButton";
            this.deleteSouhaitButton.Size = new System.Drawing.Size(129, 56);
            this.deleteSouhaitButton.TabIndex = 35;
            this.deleteSouhaitButton.Text = "Supprimer de mes souhaits";
            this.deleteSouhaitButton.Click += new System.EventHandler(this.deleteSouhaitButton_Click);
            // 
            // imageAlbumPossess
            // 
            this.imageAlbumPossess.ImageLocation = "";
            this.imageAlbumPossess.Location = new System.Drawing.Point(489, 18);
            this.imageAlbumPossess.Name = "imageAlbumPossess";
            this.imageAlbumPossess.Size = new System.Drawing.Size(108, 155);
            this.imageAlbumPossess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageAlbumPossess.TabIndex = 26;
            this.imageAlbumPossess.TabStop = false;
            // 
            // imageAlbumSouhait
            // 
            this.imageAlbumSouhait.ImageLocation = "";
            this.imageAlbumSouhait.Location = new System.Drawing.Point(489, 15);
            this.imageAlbumSouhait.Name = "imageAlbumSouhait";
            this.imageAlbumSouhait.Size = new System.Drawing.Size(108, 155);
            this.imageAlbumSouhait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageAlbumSouhait.TabIndex = 36;
            this.imageAlbumSouhait.TabStop = false;
            // 
            // ConsultUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 445);
            this.Controls.Add(this.decconectionButton);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.userLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConsultUserForm";
            this.Text = "BDThèque : Utilisateur";
            this.tabControl.ResumeLayout(false);
            this.cataloguePage.ResumeLayout(false);
            this.cataloguePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumCatalogue)).EndInit();
            this.possessionPage.ResumeLayout(false);
            this.possessionPage.PerformLayout();
            this.souhaitsPage.ResumeLayout(false);
            this.souhaitsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPossess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumSouhait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage cataloguePage;
        private System.Windows.Forms.TabPage possessionPage;
        private System.Windows.Forms.TabPage souhaitsPage;
        private System.Windows.Forms.TextBox rechercheCatalogueTextBox;
        private System.Windows.Forms.Button rechercheCatalogueButton;
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
        private System.Windows.Forms.Label nomAlbumPossess;
        private System.Windows.Forms.Label editPossess;
        private System.Windows.Forms.Label editPossessLabel;
        private System.Windows.Forms.Label genrePossess;
        private System.Windows.Forms.Label genrePossessLabel;
        private System.Windows.Forms.Label catPossess;
        private System.Windows.Forms.Label catPossessLabel;
        private System.Windows.Forms.Label auteurPossess;
        private System.Windows.Forms.Label auteurPossessLabel;
        private System.Windows.Forms.Label seriePossess;
        private System.Windows.Forms.Label seriePossessLabel;
        private System.Windows.Forms.ListBox possessionListBox;
        private System.Windows.Forms.Label editSouhait;
        private System.Windows.Forms.Label editSouhaitLabel;
        private System.Windows.Forms.Label genreSouhait;
        private System.Windows.Forms.Label genreSouhaitLabel;
        private System.Windows.Forms.Label catSouhait;
        private System.Windows.Forms.Label catSouhaitLabel;
        private System.Windows.Forms.Label auteurSouhait;
        private System.Windows.Forms.Label auteurSouhaitLabel;
        private System.Windows.Forms.Label serieSouhait;
        private System.Windows.Forms.Label serieSouhaitLabel;
        private System.Windows.Forms.Label nomAlbumSouhait;
        private System.Windows.Forms.ListBox souhaitsListBox;
        private System.Windows.Forms.Button achatSouhaitButton;
        private System.Windows.Forms.Button ajoutSouhaitButton;
        private System.Windows.Forms.Button achatCatalogueButton;
        private System.Windows.Forms.Button recherchePossessButton;
        private System.Windows.Forms.TextBox recherchePossessTextBox;
        private System.Windows.Forms.Button rechercheSouhaitButton;
        private System.Windows.Forms.TextBox rechercheSouhaitTextBox;
        private System.Windows.Forms.Button deleteSouhaitButton;
        private System.Windows.Forms.PictureBox imageAlbumPossess;
        private System.Windows.Forms.PictureBox imageAlbumSouhait;
    }
}