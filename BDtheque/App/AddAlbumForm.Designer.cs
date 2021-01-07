namespace App
{
    partial class AddAlbumForm
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
            this.newAlbumGroupBox = new System.Windows.Forms.GroupBox();
            this.editeurTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.categorieTextBox = new System.Windows.Forms.TextBox();
            this.auteurTextBox = new System.Windows.Forms.TextBox();
            this.serieTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.imageLabel = new System.Windows.Forms.Label();
            this.editeurLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.categorieLabel = new System.Windows.Forms.Label();
            this.auteurLabel = new System.Windows.Forms.Label();
            this.serieLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.imgImportButton = new System.Windows.Forms.Button();
            this.imgTextBox = new System.Windows.Forms.TextBox();
            this.imgOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.newAlbumGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newAlbumGroupBox
            // 
            this.newAlbumGroupBox.Controls.Add(this.imgTextBox);
            this.newAlbumGroupBox.Controls.Add(this.imgImportButton);
            this.newAlbumGroupBox.Controls.Add(this.editeurTextBox);
            this.newAlbumGroupBox.Controls.Add(this.genreTextBox);
            this.newAlbumGroupBox.Controls.Add(this.categorieTextBox);
            this.newAlbumGroupBox.Controls.Add(this.auteurTextBox);
            this.newAlbumGroupBox.Controls.Add(this.serieTextBox);
            this.newAlbumGroupBox.Controls.Add(this.nomTextBox);
            this.newAlbumGroupBox.Controls.Add(this.imageLabel);
            this.newAlbumGroupBox.Controls.Add(this.editeurLabel);
            this.newAlbumGroupBox.Controls.Add(this.genreLabel);
            this.newAlbumGroupBox.Controls.Add(this.categorieLabel);
            this.newAlbumGroupBox.Controls.Add(this.auteurLabel);
            this.newAlbumGroupBox.Controls.Add(this.serieLabel);
            this.newAlbumGroupBox.Controls.Add(this.nomLabel);
            this.newAlbumGroupBox.Controls.Add(this.addButton);
            this.newAlbumGroupBox.Location = new System.Drawing.Point(25, 27);
            this.newAlbumGroupBox.Name = "newAlbumGroupBox";
            this.newAlbumGroupBox.Size = new System.Drawing.Size(359, 395);
            this.newAlbumGroupBox.TabIndex = 0;
            this.newAlbumGroupBox.TabStop = false;
            this.newAlbumGroupBox.Text = "Nouvel Album";
            // 
            // editeurTextBox
            // 
            this.editeurTextBox.Location = new System.Drawing.Point(102, 240);
            this.editeurTextBox.Name = "editeurTextBox";
            this.editeurTextBox.Size = new System.Drawing.Size(215, 22);
            this.editeurTextBox.TabIndex = 13;
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(102, 196);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(215, 22);
            this.genreTextBox.TabIndex = 12;
            // 
            // categorieTextBox
            // 
            this.categorieTextBox.Location = new System.Drawing.Point(102, 154);
            this.categorieTextBox.Name = "categorieTextBox";
            this.categorieTextBox.Size = new System.Drawing.Size(215, 22);
            this.categorieTextBox.TabIndex = 11;
            // 
            // auteurTextBox
            // 
            this.auteurTextBox.Location = new System.Drawing.Point(102, 110);
            this.auteurTextBox.Name = "auteurTextBox";
            this.auteurTextBox.Size = new System.Drawing.Size(215, 22);
            this.auteurTextBox.TabIndex = 10;
            // 
            // serieTextBox
            // 
            this.serieTextBox.Location = new System.Drawing.Point(102, 73);
            this.serieTextBox.Name = "serieTextBox";
            this.serieTextBox.Size = new System.Drawing.Size(215, 22);
            this.serieTextBox.TabIndex = 9;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(102, 37);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(215, 22);
            this.nomTextBox.TabIndex = 8;
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(41, 286);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(54, 17);
            this.imageLabel.TabIndex = 7;
            this.imageLabel.Text = "Image :";
            // 
            // editeurLabel
            // 
            this.editeurLabel.AutoSize = true;
            this.editeurLabel.Location = new System.Drawing.Point(34, 240);
            this.editeurLabel.Name = "editeurLabel";
            this.editeurLabel.Size = new System.Drawing.Size(61, 17);
            this.editeurLabel.TabIndex = 6;
            this.editeurLabel.Text = "Editeur :";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(39, 196);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(56, 17);
            this.genreLabel.TabIndex = 5;
            this.genreLabel.Text = "Genre :";
            // 
            // categorieLabel
            // 
            this.categorieLabel.AutoSize = true;
            this.categorieLabel.Location = new System.Drawing.Point(18, 154);
            this.categorieLabel.Name = "categorieLabel";
            this.categorieLabel.Size = new System.Drawing.Size(77, 17);
            this.categorieLabel.TabIndex = 4;
            this.categorieLabel.Text = "Catégorie :";
            // 
            // auteurLabel
            // 
            this.auteurLabel.AutoSize = true;
            this.auteurLabel.Location = new System.Drawing.Point(20, 113);
            this.auteurLabel.Name = "auteurLabel";
            this.auteurLabel.Size = new System.Drawing.Size(75, 17);
            this.auteurLabel.TabIndex = 3;
            this.auteurLabel.Text = "Auteur(s) :";
            // 
            // serieLabel
            // 
            this.serieLabel.AutoSize = true;
            this.serieLabel.Location = new System.Drawing.Point(46, 73);
            this.serieLabel.Name = "serieLabel";
            this.serieLabel.Size = new System.Drawing.Size(49, 17);
            this.serieLabel.TabIndex = 2;
            this.serieLabel.Text = "Série :";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(50, 37);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(45, 17);
            this.nomLabel.TabIndex = 1;
            this.nomLabel.Text = "Nom :";
            // 
            // addButton
            // 
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addButton.Location = new System.Drawing.Point(130, 340);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(93, 38);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Ajouter";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // imgImportButton
            // 
            this.imgImportButton.Location = new System.Drawing.Point(252, 283);
            this.imgImportButton.Name = "imgImportButton";
            this.imgImportButton.Size = new System.Drawing.Size(65, 29);
            this.imgImportButton.TabIndex = 14;
            this.imgImportButton.Text = "Ouvrir";
            this.imgImportButton.UseVisualStyleBackColor = true;
            this.imgImportButton.Click += new System.EventHandler(this.imgImportButton_Click);
            // 
            // imgTextBox
            // 
            this.imgTextBox.Location = new System.Drawing.Point(102, 286);
            this.imgTextBox.Name = "imgTextBox";
            this.imgTextBox.Size = new System.Drawing.Size(144, 22);
            this.imgTextBox.TabIndex = 15;
            // 
            // imgOpenFileDialog
            // 
            this.imgOpenFileDialog.Filter = "\"Image Files (*.png;*.jpg)|*.png;*.jpg\"";
            // 
            // AddAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.newAlbumGroupBox);
            this.Name = "AddAlbumForm";
            this.Text = "BDtheque - Admin - Ajout au marché";
            this.newAlbumGroupBox.ResumeLayout(false);
            this.newAlbumGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox newAlbumGroupBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label serieLabel;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label categorieLabel;
        private System.Windows.Forms.Label auteurLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label editeurLabel;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.TextBox editeurTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox categorieTextBox;
        private System.Windows.Forms.TextBox auteurTextBox;
        private System.Windows.Forms.TextBox serieTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Button imgImportButton;
        private System.Windows.Forms.TextBox imgTextBox;
        private System.Windows.Forms.OpenFileDialog imgOpenFileDialog;
    }
}