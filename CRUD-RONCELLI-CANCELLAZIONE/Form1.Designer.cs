namespace CRUD_RONCELLI_CANCELLAZIONE
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
            this.Aggiungi = new System.Windows.Forms.Button();
            this.modificaprodottoprezzo = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.TextBox();
            this.prezzo = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.TextBox();
            this.newname = new System.Windows.Forms.TextBox();
            this.newwprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cancellazioneL = new System.Windows.Forms.Button();
            this.cancellazioneF = new System.Windows.Forms.Button();
            this.recuperaFF = new System.Windows.Forms.Button();
            this.openF = new System.Windows.Forms.Button();
            this.RESET = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LISTAP = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Aggiungi
            // 
            this.Aggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Aggiungi.Location = new System.Drawing.Point(461, 23);
            this.Aggiungi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Aggiungi.Name = "Aggiungi";
            this.Aggiungi.Size = new System.Drawing.Size(168, 75);
            this.Aggiungi.TabIndex = 1;
            this.Aggiungi.Text = "Aggiungi su file";
            this.Aggiungi.UseVisualStyleBackColor = true;
            this.Aggiungi.Click += new System.EventHandler(this.Aggiungi_Click);
            // 
            // modificaprodottoprezzo
            // 
            this.modificaprodottoprezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.modificaprodottoprezzo.Location = new System.Drawing.Point(327, 116);
            this.modificaprodottoprezzo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modificaprodottoprezzo.Name = "modificaprodottoprezzo";
            this.modificaprodottoprezzo.Size = new System.Drawing.Size(168, 80);
            this.modificaprodottoprezzo.TabIndex = 2;
            this.modificaprodottoprezzo.Text = "Modifica il prodotto e prezzo su file";
            this.modificaprodottoprezzo.UseVisualStyleBackColor = true;
            this.modificaprodottoprezzo.Click += new System.EventHandler(this.modificaprodottoprezzo_Click);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(59, 65);
            this.nome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(201, 22);
            this.nome.TabIndex = 12;
            // 
            // prezzo
            // 
            this.prezzo.Location = new System.Drawing.Point(59, 186);
            this.prezzo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prezzo.Name = "prezzo";
            this.prezzo.Size = new System.Drawing.Size(201, 22);
            this.prezzo.TabIndex = 13;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(59, 289);
            this.search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(201, 22);
            this.search.TabIndex = 14;
            // 
            // newname
            // 
            this.newname.Location = new System.Drawing.Point(59, 446);
            this.newname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newname.Name = "newname";
            this.newname.Size = new System.Drawing.Size(201, 22);
            this.newname.TabIndex = 15;
            // 
            // newwprice
            // 
            this.newwprice.Location = new System.Drawing.Point(59, 540);
            this.newwprice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newwprice.Name = "newwprice";
            this.newwprice.Size = new System.Drawing.Size(201, 22);
            this.newwprice.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(108, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "prodotto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(137, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "prezzo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(39, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "inserisci il prodotto da cercare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(55, 417);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Inserisci il nuovo nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(55, 514);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Inserisci il nuovo prezzo";
            // 
            // cancellazioneL
            // 
            this.cancellazioneL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cancellazioneL.Location = new System.Drawing.Point(324, 213);
            this.cancellazioneL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancellazioneL.Name = "cancellazioneL";
            this.cancellazioneL.Size = new System.Drawing.Size(171, 78);
            this.cancellazioneL.TabIndex = 24;
            this.cancellazioneL.Text = "Cancellazione logica file";
            this.cancellazioneL.UseVisualStyleBackColor = true;
            this.cancellazioneL.Click += new System.EventHandler(this.cancellazioneL_Click);
            // 
            // cancellazioneF
            // 
            this.cancellazioneF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cancellazioneF.Location = new System.Drawing.Point(540, 118);
            this.cancellazioneF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancellazioneF.Name = "cancellazioneF";
            this.cancellazioneF.Size = new System.Drawing.Size(169, 78);
            this.cancellazioneF.TabIndex = 25;
            this.cancellazioneF.Text = "Cancellazione fisica file";
            this.cancellazioneF.UseVisualStyleBackColor = true;
            this.cancellazioneF.Click += new System.EventHandler(this.cancellazioneF_Click);
            // 
            // recuperaFF
            // 
            this.recuperaFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.recuperaFF.Location = new System.Drawing.Point(324, 320);
            this.recuperaFF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recuperaFF.Name = "recuperaFF";
            this.recuperaFF.Size = new System.Drawing.Size(167, 71);
            this.recuperaFF.TabIndex = 26;
            this.recuperaFF.Text = "Recupera (canc.logica)";
            this.recuperaFF.UseVisualStyleBackColor = true;
            this.recuperaFF.Click += new System.EventHandler(this.recuperaFF_Click);
            // 
            // openF
            // 
            this.openF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.openF.Location = new System.Drawing.Point(540, 217);
            this.openF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openF.Name = "openF";
            this.openF.Size = new System.Drawing.Size(169, 74);
            this.openF.TabIndex = 27;
            this.openF.Text = "Apri file";
            this.openF.UseVisualStyleBackColor = true;
            this.openF.Click += new System.EventHandler(this.openF_Click);
            // 
            // RESET
            // 
            this.RESET.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.RESET.Location = new System.Drawing.Point(539, 320);
            this.RESET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(171, 70);
            this.RESET.TabIndex = 28;
            this.RESET.Text = "Reset";
            this.RESET.UseVisualStyleBackColor = true;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(436, 417);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 71);
            this.button1.TabIndex = 29;
            this.button1.Text = "Visualizza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LISTAP
            // 
            this.LISTAP.FormattingEnabled = true;
            this.LISTAP.ItemHeight = 16;
            this.LISTAP.Location = new System.Drawing.Point(832, 95);
            this.LISTAP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LISTAP.Name = "LISTAP";
            this.LISTAP.Size = new System.Drawing.Size(404, 468);
            this.LISTAP.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 709);
            this.Controls.Add(this.LISTAP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RESET);
            this.Controls.Add(this.openF);
            this.Controls.Add(this.recuperaFF);
            this.Controls.Add(this.cancellazioneF);
            this.Controls.Add(this.cancellazioneL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newwprice);
            this.Controls.Add(this.newname);
            this.Controls.Add(this.search);
            this.Controls.Add(this.prezzo);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.modificaprodottoprezzo);
            this.Controls.Add(this.Aggiungi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Aggiungi;
        private System.Windows.Forms.Button modificaprodottoprezzo;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox prezzo;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.TextBox newname;
        private System.Windows.Forms.TextBox newwprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cancellazioneL;
        private System.Windows.Forms.Button cancellazioneF;
        private System.Windows.Forms.Button recuperaFF;
        private System.Windows.Forms.Button openF;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox LISTAP;
    }
}

