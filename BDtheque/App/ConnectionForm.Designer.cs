namespace App
{
    partial class ConnectionForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.connexionGroupBox = new System.Windows.Forms.GroupBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.connexionButton = new System.Windows.Forms.Button();
            this.mdpTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.notAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            this.adminLabel = new System.Windows.Forms.Label();
            this.mdpLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.connexionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // connexionGroupBox
            // 
            this.connexionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connexionGroupBox.AutoSize = true;
            this.connexionGroupBox.Controls.Add(this.errorLabel);
            this.connexionGroupBox.Controls.Add(this.connexionButton);
            this.connexionGroupBox.Controls.Add(this.mdpTextBox);
            this.connexionGroupBox.Controls.Add(this.loginTextBox);
            this.connexionGroupBox.Controls.Add(this.notAdminCheckBox);
            this.connexionGroupBox.Controls.Add(this.adminCheckBox);
            this.connexionGroupBox.Controls.Add(this.adminLabel);
            this.connexionGroupBox.Controls.Add(this.mdpLabel);
            this.connexionGroupBox.Controls.Add(this.loginLabel);
            this.connexionGroupBox.Location = new System.Drawing.Point(27, 28);
            this.connexionGroupBox.Name = "connexionGroupBox";
            this.connexionGroupBox.Size = new System.Drawing.Size(449, 278);
            this.connexionGroupBox.TabIndex = 0;
            this.connexionGroupBox.TabStop = false;
            this.connexionGroupBox.Text = "Connexion";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(77, 189);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLabel.TabIndex = 8;
            // 
            // connexionButton
            // 
            this.connexionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connexionButton.Location = new System.Drawing.Point(272, 224);
            this.connexionButton.Name = "connexionButton";
            this.connexionButton.Size = new System.Drawing.Size(120, 29);
            this.connexionButton.TabIndex = 7;
            this.connexionButton.Text = "Se connecter";
            this.connexionButton.UseVisualStyleBackColor = true;
            this.connexionButton.Click += new System.EventHandler(this.connexionButton_Click);
            // 
            // mdpTextBox
            // 
            this.mdpTextBox.HideSelection = false;
            this.mdpTextBox.Location = new System.Drawing.Point(239, 142);
            this.mdpTextBox.Name = "mdpTextBox";
            this.mdpTextBox.PasswordChar = '*';
            this.mdpTextBox.Size = new System.Drawing.Size(153, 26);
            this.mdpTextBox.TabIndex = 6;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(239, 95);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(153, 26);
            this.loginTextBox.TabIndex = 5;
            // 
            // notAdminCheckBox
            // 
            this.notAdminCheckBox.AutoSize = true;
            this.notAdminCheckBox.Checked = true;
            this.notAdminCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notAdminCheckBox.Location = new System.Drawing.Point(328, 48);
            this.notAdminCheckBox.Name = "notAdminCheckBox";
            this.notAdminCheckBox.Size = new System.Drawing.Size(64, 24);
            this.notAdminCheckBox.TabIndex = 4;
            this.notAdminCheckBox.Text = "Non";
            this.notAdminCheckBox.UseVisualStyleBackColor = true;
            this.notAdminCheckBox.CheckedChanged += new System.EventHandler(this.notAdminCheckBox_CheckedChanged);
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.Location = new System.Drawing.Point(239, 48);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(59, 24);
            this.adminCheckBox.TabIndex = 3;
            this.adminCheckBox.Text = "Oui";
            this.adminCheckBox.UseVisualStyleBackColor = true;
            this.adminCheckBox.CheckedChanged += new System.EventHandler(this.adminCheckBox_CheckedChanged);
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Location = new System.Drawing.Point(73, 48);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(120, 20);
            this.adminLabel.TabIndex = 2;
            this.adminLabel.Text = "Administrateur :";
            // 
            // mdpLabel
            // 
            this.mdpLabel.AutoSize = true;
            this.mdpLabel.Location = new System.Drawing.Point(73, 145);
            this.mdpLabel.Name = "mdpLabel";
            this.mdpLabel.Size = new System.Drawing.Size(113, 20);
            this.mdpLabel.TabIndex = 1;
            this.mdpLabel.Text = "Mot de passe :";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(73, 98);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(88, 20);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Identifiant :";
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 325);
            this.Controls.Add(this.connexionGroupBox);
            this.MinimumSize = new System.Drawing.Size(534, 381);
            this.Name = "ConnectionForm";
            this.Text = "BDThèque";
            this.connexionGroupBox.ResumeLayout(false);
            this.connexionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox connexionGroupBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Label mdpLabel;
        private System.Windows.Forms.CheckBox notAdminCheckBox;
        private System.Windows.Forms.CheckBox adminCheckBox;
        private System.Windows.Forms.TextBox mdpTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Button connexionButton;
        private System.Windows.Forms.Label errorLabel;
    }
}

