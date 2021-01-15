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
            this.imgTextBox = new System.Windows.Forms.TextBox();
            this.imgImportButton = new System.Windows.Forms.Button();
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
            this.imgOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.newAlbumGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newAlbumGroupBox
            // 
            this.newAlbumGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newAlbumGroupBox.AutoSize = true;
            this.newAlbumGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
            this.newAlbumGroupBox.Location = new System.Drawing.Point(28, 34);
            this.newAlbumGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newAlbumGroupBox.Name = "newAlbumGroupBox";
            this.newAlbumGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newAlbumGroupBox.Size = new System.Drawing.Size(363, 500);
            this.newAlbumGroupBox.TabIndex = 0;
            this.newAlbumGroupBox.TabStop = false;
            this.newAlbumGroupBox.Text = "Nouvel Album";
            // 
            // imgTextBox
            // 
            this.imgTextBox.Location = new System.Drawing.Point(115, 358);
            this.imgTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgTextBox.Name = "imgTextBox";
            this.imgTextBox.Size = new System.Drawing.Size(162, 26);
            this.imgTextBox.TabIndex = 15;
            // 
            // imgImportButton
            // 
            this.imgImportButton.Location = new System.Drawing.Point(284, 354);
            this.imgImportButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgImportButton.Name = "imgImportButton";
            this.imgImportButton.Size = new System.Drawing.Size(73, 36);
            this.imgImportButton.TabIndex = 14;
            this.imgImportButton.Text = "Ouvrir";
            this.imgImportButton.UseVisualStyleBackColor = true;
            this.imgImportButton.Click += new System.EventHandler(this.imgImportButton_Click);
            // 
            // editeurTextBox
            // 
            this.editeurTextBox.Location = new System.Drawing.Point(115, 300);
            this.editeurTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editeurTextBox.Name = "editeurTextBox";
            this.editeurTextBox.Size = new System.Drawing.Size(241, 26);
            this.editeurTextBox.TabIndex = 13;
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(115, 245);
            this.genreTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(241, 26);
            this.genreTextBox.TabIndex = 12;
            // 
            // categorieTextBox
            // 
            this.categorieTextBox.Location = new System.Drawing.Point(115, 192);
            this.categorieTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categorieTextBox.Name = "categorieTextBox";
            this.categorieTextBox.Size = new System.Drawing.Size(241, 26);
            this.categorieTextBox.TabIndex = 11;
            // 
            // auteurTextBox
            // 
            this.auteurTextBox.Location = new System.Drawing.Point(115, 138);
            this.auteurTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.auteurTextBox.Name = "auteurTextBox";
            this.auteurTextBox.Size = new System.Drawing.Size(241, 26);
            this.auteurTextBox.TabIndex = 10;
            // 
            // serieTextBox
            // 
            this.serieTextBox.Location = new System.Drawing.Point(115, 91);
            this.serieTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.serieTextBox.Name = "serieTextBox";
            this.serieTextBox.Size = new System.Drawing.Size(241, 26);
            this.serieTextBox.TabIndex = 9;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(115, 46);
            this.nomTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(241, 26);
            this.nomTextBox.TabIndex = 8;
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(46, 358);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(62, 20);
            this.imageLabel.TabIndex = 7;
            this.imageLabel.Text = "Image :";
            // 
            // editeurLabel
            // 
            this.editeurLabel.AutoSize = true;
            this.editeurLabel.Location = new System.Drawing.Point(38, 300);
            this.editeurLabel.Name = "editeurLabel";
            this.editeurLabel.Size = new System.Drawing.Size(68, 20);
            this.editeurLabel.TabIndex = 6;
            this.editeurLabel.Text = "Editeur :";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(44, 245);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(62, 20);
            this.genreLabel.TabIndex = 5;
            this.genreLabel.Text = "Genre :";
            // 
            // categorieLabel
            // 
            this.categorieLabel.AutoSize = true;
            this.categorieLabel.Location = new System.Drawing.Point(20, 192);
            this.categorieLabel.Name = "categorieLabel";
            this.categorieLabel.Size = new System.Drawing.Size(86, 20);
            this.categorieLabel.TabIndex = 4;
            this.categorieLabel.Text = "Catégorie :";
            // 
            // auteurLabel
            // 
            this.auteurLabel.AutoSize = true;
            this.auteurLabel.Location = new System.Drawing.Point(22, 141);
            this.auteurLabel.Name = "auteurLabel";
            this.auteurLabel.Size = new System.Drawing.Size(83, 20);
            this.auteurLabel.TabIndex = 3;
            this.auteurLabel.Text = "Auteur(s) :";
            // 
            // serieLabel
            // 
            this.serieLabel.AutoSize = true;
            this.serieLabel.Location = new System.Drawing.Point(52, 91);
            this.serieLabel.Name = "serieLabel";
            this.serieLabel.Size = new System.Drawing.Size(54, 20);
            this.serieLabel.TabIndex = 2;
            this.serieLabel.Text = "Série :";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(56, 46);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(50, 20);
            this.nomLabel.TabIndex = 1;
            this.nomLabel.Text = "Nom :";
            // 
            // addButton
            // 
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addButton.Location = new System.Drawing.Point(146, 425);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 48);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Ajouter";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // imgOpenFileDialog
            // 
            this.imgOpenFileDialog.Filter = "\"Image Files (*.png;*.jpg)|*.png;*.jpg\"";
            // 
            // AddAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 562);
            this.Controls.Add(this.newAlbumGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(506, 618);
            this.Name = "AddAlbumForm";
            this.Text = "BDtheque - Admin - Ajout au marché";
            this.newAlbumGroupBox.ResumeLayout(false);
            this.newAlbumGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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