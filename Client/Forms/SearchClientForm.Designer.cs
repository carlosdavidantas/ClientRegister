namespace Client.Forms
{
    partial class SearchClientForm
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
            this.InsertIdTextBox = new System.Windows.Forms.TextBox();
            this.InsertIdLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.SearchClientButton = new System.Windows.Forms.Button();
            this.NameToChangeLabel = new System.Windows.Forms.Label();
            this.AgeToChangeLabel = new System.Windows.Forms.Label();
            this.GenderToChangeLabel = new System.Windows.Forms.Label();
            this.DeleteClientButton = new System.Windows.Forms.Button();
            this.ModifyClientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InsertIdTextBox
            // 
            this.InsertIdTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertIdTextBox.Location = new System.Drawing.Point(251, 52);
            this.InsertIdTextBox.Name = "InsertIdTextBox";
            this.InsertIdTextBox.Size = new System.Drawing.Size(528, 35);
            this.InsertIdTextBox.TabIndex = 0;
            // 
            // InsertIdLabel
            // 
            this.InsertIdLabel.AutoSize = true;
            this.InsertIdLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertIdLabel.Location = new System.Drawing.Point(12, 52);
            this.InsertIdLabel.Name = "InsertIdLabel";
            this.InsertIdLabel.Size = new System.Drawing.Size(127, 32);
            this.InsertIdLabel.TabIndex = 1;
            this.InsertIdLabel.Text = "Insert ID:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(12, 114);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(93, 32);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name:";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(12, 178);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(70, 32);
            this.AgeLabel.TabIndex = 4;
            this.AgeLabel.Text = "Age:";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.Location = new System.Drawing.Point(12, 242);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(112, 32);
            this.GenderLabel.TabIndex = 5;
            this.GenderLabel.Text = "Gender:";
            // 
            // SearchClientButton
            // 
            this.SearchClientButton.Location = new System.Drawing.Point(341, 281);
            this.SearchClientButton.Name = "SearchClientButton";
            this.SearchClientButton.Size = new System.Drawing.Size(142, 23);
            this.SearchClientButton.TabIndex = 6;
            this.SearchClientButton.Text = "Search";
            this.SearchClientButton.UseVisualStyleBackColor = true;
            this.SearchClientButton.Click += new System.EventHandler(this.SearchClientButton_Click);
            // 
            // NameToChangeLabel
            // 
            this.NameToChangeLabel.AutoSize = true;
            this.NameToChangeLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameToChangeLabel.Location = new System.Drawing.Point(245, 114);
            this.NameToChangeLabel.Name = "NameToChangeLabel";
            this.NameToChangeLabel.Size = new System.Drawing.Size(0, 32);
            this.NameToChangeLabel.TabIndex = 7;
            // 
            // AgeToChangeLabel
            // 
            this.AgeToChangeLabel.AutoSize = true;
            this.AgeToChangeLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeToChangeLabel.Location = new System.Drawing.Point(245, 178);
            this.AgeToChangeLabel.Name = "AgeToChangeLabel";
            this.AgeToChangeLabel.Size = new System.Drawing.Size(0, 32);
            this.AgeToChangeLabel.TabIndex = 8;
            // 
            // GenderToChangeLabel
            // 
            this.GenderToChangeLabel.AutoSize = true;
            this.GenderToChangeLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderToChangeLabel.Location = new System.Drawing.Point(245, 242);
            this.GenderToChangeLabel.Name = "GenderToChangeLabel";
            this.GenderToChangeLabel.Size = new System.Drawing.Size(0, 32);
            this.GenderToChangeLabel.TabIndex = 9;
            // 
            // DeleteClientButton
            // 
            this.DeleteClientButton.Enabled = false;
            this.DeleteClientButton.Location = new System.Drawing.Point(637, 281);
            this.DeleteClientButton.Name = "DeleteClientButton";
            this.DeleteClientButton.Size = new System.Drawing.Size(142, 23);
            this.DeleteClientButton.TabIndex = 10;
            this.DeleteClientButton.Text = "Delete";
            this.DeleteClientButton.UseVisualStyleBackColor = true;
            this.DeleteClientButton.Click += new System.EventHandler(this.DeleteClientButton_Click);
            // 
            // ModifyClientButton
            // 
            this.ModifyClientButton.Enabled = false;
            this.ModifyClientButton.Location = new System.Drawing.Point(489, 281);
            this.ModifyClientButton.Name = "ModifyClientButton";
            this.ModifyClientButton.Size = new System.Drawing.Size(142, 23);
            this.ModifyClientButton.TabIndex = 11;
            this.ModifyClientButton.Text = "Modify";
            this.ModifyClientButton.UseVisualStyleBackColor = true;
            this.ModifyClientButton.Click += new System.EventHandler(this.ModifyClientButton_Click);
            // 
            // SearchClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 316);
            this.Controls.Add(this.ModifyClientButton);
            this.Controls.Add(this.DeleteClientButton);
            this.Controls.Add(this.GenderToChangeLabel);
            this.Controls.Add(this.AgeToChangeLabel);
            this.Controls.Add(this.NameToChangeLabel);
            this.Controls.Add(this.SearchClientButton);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.InsertIdLabel);
            this.Controls.Add(this.InsertIdTextBox);
            this.Name = "SearchClientForm";
            this.Text = "SearchClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InsertIdTextBox;
        private System.Windows.Forms.Label InsertIdLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Button SearchClientButton;
        private System.Windows.Forms.Label NameToChangeLabel;
        private System.Windows.Forms.Label AgeToChangeLabel;
        private System.Windows.Forms.Label GenderToChangeLabel;
        private System.Windows.Forms.Button DeleteClientButton;
        private System.Windows.Forms.Button ModifyClientButton;
    }
}