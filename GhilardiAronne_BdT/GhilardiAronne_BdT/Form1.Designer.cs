namespace GhilardiAronne_BdT
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.listUtenti = new System.Windows.Forms.ListBox();
            this.listDebiti = new System.Windows.Forms.ListBox();
            this.listPrestiti = new System.Windows.Forms.ListBox();
            this.listRegistro = new System.Windows.Forms.ListBox();
            this.buttonDebito = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRegistro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPrestiti = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listUtenti
            // 
            this.listUtenti.FormattingEnabled = true;
            this.listUtenti.ItemHeight = 16;
            this.listUtenti.Location = new System.Drawing.Point(12, 29);
            this.listUtenti.Name = "listUtenti";
            this.listUtenti.Size = new System.Drawing.Size(188, 388);
            this.listUtenti.TabIndex = 0;
            // 
            // listDebiti
            // 
            this.listDebiti.FormattingEnabled = true;
            this.listDebiti.ItemHeight = 16;
            this.listDebiti.Location = new System.Drawing.Point(206, 285);
            this.listDebiti.Name = "listDebiti";
            this.listDebiti.Size = new System.Drawing.Size(264, 132);
            this.listDebiti.TabIndex = 1;
            // 
            // listPrestiti
            // 
            this.listPrestiti.FormattingEnabled = true;
            this.listPrestiti.ItemHeight = 16;
            this.listPrestiti.Location = new System.Drawing.Point(206, 49);
            this.listPrestiti.Name = "listPrestiti";
            this.listPrestiti.Size = new System.Drawing.Size(264, 196);
            this.listPrestiti.TabIndex = 2;
            // 
            // listRegistro
            // 
            this.listRegistro.FormattingEnabled = true;
            this.listRegistro.ItemHeight = 16;
            this.listRegistro.Location = new System.Drawing.Point(12, 463);
            this.listRegistro.Name = "listRegistro";
            this.listRegistro.Size = new System.Drawing.Size(458, 228);
            this.listRegistro.TabIndex = 3;
            // 
            // buttonDebito
            // 
            this.buttonDebito.Location = new System.Drawing.Point(385, 261);
            this.buttonDebito.Name = "buttonDebito";
            this.buttonDebito.Size = new System.Drawing.Size(85, 23);
            this.buttonDebito.TabIndex = 4;
            this.buttonDebito.Text = "Visualizza";
            this.buttonDebito.UseVisualStyleBackColor = true;
            this.buttonDebito.Click += new System.EventHandler(this.buttonDebito_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "REGISTRO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRegistro
            // 
            this.buttonRegistro.Location = new System.Drawing.Point(385, 439);
            this.buttonRegistro.Name = "buttonRegistro";
            this.buttonRegistro.Size = new System.Drawing.Size(85, 23);
            this.buttonRegistro.TabIndex = 6;
            this.buttonRegistro.Text = "Visualizza";
            this.buttonRegistro.UseVisualStyleBackColor = true;
            this.buttonRegistro.Click += new System.EventHandler(this.buttonRegistro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "UTENTI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPrestiti
            // 
            this.buttonPrestiti.Location = new System.Drawing.Point(385, 25);
            this.buttonPrestiti.Name = "buttonPrestiti";
            this.buttonPrestiti.Size = new System.Drawing.Size(85, 23);
            this.buttonPrestiti.TabIndex = 8;
            this.buttonPrestiti.Text = "Visualizza";
            this.buttonPrestiti.UseVisualStyleBackColor = true;
            this.buttonPrestiti.Click += new System.EventHandler(this.buttonPrestiti_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "DEBITI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "PRESTITI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 703);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPrestiti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRegistro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDebito);
            this.Controls.Add(this.listRegistro);
            this.Controls.Add(this.listPrestiti);
            this.Controls.Add(this.listDebiti);
            this.Controls.Add(this.listUtenti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listUtenti;
        private System.Windows.Forms.ListBox listDebiti;
        private System.Windows.Forms.ListBox listPrestiti;
        private System.Windows.Forms.ListBox listRegistro;
        private System.Windows.Forms.Button buttonDebito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPrestiti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

