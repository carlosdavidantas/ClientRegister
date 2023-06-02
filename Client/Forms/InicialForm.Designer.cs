namespace Client
{
    partial class InicialForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchClientButton = new System.Windows.Forms.Button();
            this.RegisterClientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchClientButton
            // 
            this.SearchClientButton.Location = new System.Drawing.Point(208, 12);
            this.SearchClientButton.Name = "SearchClientButton";
            this.SearchClientButton.Size = new System.Drawing.Size(164, 337);
            this.SearchClientButton.TabIndex = 1;
            this.SearchClientButton.Text = "Search Client";
            this.SearchClientButton.UseVisualStyleBackColor = true;
            this.SearchClientButton.Click += new System.EventHandler(this.SearchClientButton_Click);
            // 
            // RegisterClientButton
            // 
            this.RegisterClientButton.Location = new System.Drawing.Point(12, 12);
            this.RegisterClientButton.Name = "RegisterClientButton";
            this.RegisterClientButton.Size = new System.Drawing.Size(164, 337);
            this.RegisterClientButton.TabIndex = 2;
            this.RegisterClientButton.Text = "Register";
            this.RegisterClientButton.UseVisualStyleBackColor = true;
            this.RegisterClientButton.Click += new System.EventHandler(this.RegisterClientButton_Click);
            // 
            // InicialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.RegisterClientButton);
            this.Controls.Add(this.SearchClientButton);
            this.Name = "InicialForm";
            this.Text = "Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchClientButton;
        private System.Windows.Forms.Button RegisterClientButton;
    }
}

