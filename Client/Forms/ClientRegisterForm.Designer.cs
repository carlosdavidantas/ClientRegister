namespace Client.Forms
{
    partial class ClientRegisterForm
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.GenderTextBox = new System.Windows.Forms.TextBox();
            this.IdentificationLabel = new System.Windows.Forms.Label();
            this.IdentificationTextBox = new System.Windows.Forms.TextBox();
            this.RegisterClientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(192, 39);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(596, 35);
            this.NameTextBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(12, 39);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(100, 32);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(12, 80);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(75, 32);
            this.AgeLabel.TabIndex = 2;
            this.AgeLabel.Text = "Age:";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTextBox.Location = new System.Drawing.Point(192, 80);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(596, 35);
            this.AgeTextBox.TabIndex = 3;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.Location = new System.Drawing.Point(12, 121);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(120, 32);
            this.GenderLabel.TabIndex = 4;
            this.GenderLabel.Text = "Gender:";
            // 
            // GenderTextBox
            // 
            this.GenderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderTextBox.Location = new System.Drawing.Point(192, 121);
            this.GenderTextBox.Name = "GenderTextBox";
            this.GenderTextBox.Size = new System.Drawing.Size(596, 35);
            this.GenderTextBox.TabIndex = 5;
            // 
            // IdentificationLabel
            // 
            this.IdentificationLabel.AutoSize = true;
            this.IdentificationLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdentificationLabel.Location = new System.Drawing.Point(12, 162);
            this.IdentificationLabel.Name = "IdentificationLabel";
            this.IdentificationLabel.Size = new System.Drawing.Size(49, 32);
            this.IdentificationLabel.TabIndex = 6;
            this.IdentificationLabel.Text = "Id:";
            // 
            // IdentificationTextBox
            // 
            this.IdentificationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdentificationTextBox.Location = new System.Drawing.Point(192, 162);
            this.IdentificationTextBox.Name = "IdentificationTextBox";
            this.IdentificationTextBox.Size = new System.Drawing.Size(596, 35);
            this.IdentificationTextBox.TabIndex = 7;
            // 
            // RegisterClientButton
            // 
            this.RegisterClientButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RegisterClientButton.Location = new System.Drawing.Point(602, 216);
            this.RegisterClientButton.Name = "RegisterClientButton";
            this.RegisterClientButton.Size = new System.Drawing.Size(186, 23);
            this.RegisterClientButton.TabIndex = 8;
            this.RegisterClientButton.Text = "Register";
            this.RegisterClientButton.UseVisualStyleBackColor = true;
            this.RegisterClientButton.Click += new System.EventHandler(this.RegisterClientButton_Click);
            // 
            // ClientRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 251);
            this.Controls.Add(this.RegisterClientButton);
            this.Controls.Add(this.IdentificationTextBox);
            this.Controls.Add(this.IdentificationLabel);
            this.Controls.Add(this.GenderTextBox);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Name = "ClientRegisterForm";
            this.Text = "ClientRegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.TextBox GenderTextBox;
        private System.Windows.Forms.Label IdentificationLabel;
        private System.Windows.Forms.TextBox IdentificationTextBox;
        private System.Windows.Forms.Button RegisterClientButton;
    }
}