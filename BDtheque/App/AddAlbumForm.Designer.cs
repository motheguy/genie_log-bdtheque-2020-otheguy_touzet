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
            this.addButton = new System.Windows.Forms.Button();
            this.nomLabel = new System.Windows.Forms.Label();
            this.serieLabel = new System.Windows.Forms.Label();
            this.auteurLabel = new System.Windows.Forms.Label();
            this.categorieLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.editeurLabel = new System.Windows.Forms.Label();
            this.imageLabel = new System.Windows.Forms.Label();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.serieTextBox = new System.Windows.Forms.TextBox();
            this.auteurTextBox = new System.Windows.Forms.TextBox();
            this.categorieTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.editeurTextBox = new System.Windows.Forms.TextBox();
            this.newAlbumGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newAlbumGroupBox
            // 
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
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(50, 37);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(45, 17);
            this.nomLabel.TabIndex = 1;
            this.nomLabel.Text = "Nom :";
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
            // auteurLabel
            // 
            this.auteurLabel.AutoSize = true;
            this.auteurLabel.Location = new System.Drawing.Point(20, 113);
            this.auteurLabel.Name = "auteurLabel";
            this.auteurLabel.Size = new System.Drawing.Size(75, 17);
            this.auteurLabel.TabIndex = 3;
            this.auteurLabel.Text = "Auteur(s) :";
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
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(39, 196);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(56, 17);
            this.genreLabel.TabIndex = 5;
            this.genreLabel.Text = "Genre :";
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
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(41, 286);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(54, 17);
            this.imageLabel.TabIndex = 7;
            this.imageLabel.Text = "Image :";
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(102, 37);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(215, 22);
            this.nomTextBox.TabIndex = 8;
            // 
            // serieTextBox
            // 
            this.serieTextBox.Location = new System.Drawing.Point(102, 73);
            this.serieTextBox.Name = "serieTextBox";
            this.serieTextBox.Size = new System.Drawing.Size(215, 22);
            this.serieTextBox.TabIndex = 9;
            // 
            // auteurTextBox
            // 
            this.auteurTextBox.Location = new System.Drawing.Point(102, 110);
            this.auteurTextBox.Name = "auteurTextBox";
            this.auteurTextBox.Size = new System.Drawing.Size(215, 22);
            this.auteurTextBox.TabIndex = 10;
            // 
            // categorieTextBox
            // 
            this.categorieTextBox.Location = new System.Drawing.Point(102, 154);
            this.categorieTextBox.Name = "categorieTextBox";
            this.categorieTextBox.Size = new System.Drawing.Size(215, 22);
            this.categorieTextBox.TabIndex = 11;
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(102, 196);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(215, 22);
            this.genreTextBox.TabIndex = 12;
            // 
            // editeurTextBox
            // 
            this.editeurTextBox.Location = new System.Drawing.Point(102, 240);
            this.editeurTextBox.Name = "editeurTextBox";
            this.editeurTextBox.Size = new System.Drawing.Size(215, 22);
            this.editeurTextBox.TabIndex = 13;
            // 
            // AddAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.newAlbumGroupBox);
            this.Name = "AddAlbumForm";
            this.Text = "AjoutAlbumForm";
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
    }
}