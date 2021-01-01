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
            this.possessionPage = new System.Windows.Forms.TabPage();
            this.souhaitsPge = new System.Windows.Forms.TabPage();
            this.rechercheTextBox = new System.Windows.Forms.TextBox();
            this.rechercheButton = new System.Windows.Forms.Button();
            this.decconectionButton = new System.Windows.Forms.Button();
            this.catalogueListBox = new System.Windows.Forms.ListBox();
            this.nom = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.cataloguePage.SuspendLayout();
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
            this.tabControl.Controls.Add(this.souhaitsPge);
            this.tabControl.Location = new System.Drawing.Point(33, 117);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(611, 369);
            this.tabControl.TabIndex = 2;
            // 
            // cataloguePage
            // 
            this.cataloguePage.Controls.Add(this.nom);
            this.cataloguePage.Controls.Add(this.catalogueListBox);
            this.cataloguePage.Location = new System.Drawing.Point(4, 29);
            this.cataloguePage.Name = "cataloguePage";
            this.cataloguePage.Padding = new System.Windows.Forms.Padding(3);
            this.cataloguePage.Size = new System.Drawing.Size(603, 336);
            this.cataloguePage.TabIndex = 0;
            this.cataloguePage.Text = "Catalogue";
            this.cataloguePage.UseVisualStyleBackColor = true;
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
            this.possessionPage.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // souhaitsPge
            // 
            this.souhaitsPge.Location = new System.Drawing.Point(4, 29);
            this.souhaitsPge.Name = "souhaitsPge";
            this.souhaitsPge.Padding = new System.Windows.Forms.Padding(3);
            this.souhaitsPge.Size = new System.Drawing.Size(603, 336);
            this.souhaitsPge.TabIndex = 2;
            this.souhaitsPge.Text = "Mes Souhaits";
            this.souhaitsPge.UseVisualStyleBackColor = true;
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
            this.rechercheButton.Size = new System.Drawing.Size(105, 25);
            this.rechercheButton.TabIndex = 4;
            this.rechercheButton.Text = "Rechercher";
            this.rechercheButton.UseVisualStyleBackColor = true;
            // 
            // decconectionButton
            // 
            this.decconectionButton.Location = new System.Drawing.Point(282, 509);
            this.decconectionButton.Name = "decconectionButton";
            this.decconectionButton.Size = new System.Drawing.Size(122, 25);
            this.decconectionButton.TabIndex = 5;
            this.decconectionButton.Text = "Déconnexion";
            this.decconectionButton.UseVisualStyleBackColor = true;
            this.decconectionButton.Click += new System.EventHandler(this.deconnectionButton_Click);
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
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(367, 17);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(0, 20);
            this.nom.TabIndex = 1;
            this.nom.Click += new System.EventHandler(this.label1_Click);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage cataloguePage;
        private System.Windows.Forms.TabPage possessionPage;
        private System.Windows.Forms.TabPage souhaitsPge;
        private System.Windows.Forms.TextBox rechercheTextBox;
        private System.Windows.Forms.Button rechercheButton;
        private System.Windows.Forms.Button decconectionButton;
        private System.Windows.Forms.ListBox catalogueListBox;
        private System.Windows.Forms.Label nom;
    }
}