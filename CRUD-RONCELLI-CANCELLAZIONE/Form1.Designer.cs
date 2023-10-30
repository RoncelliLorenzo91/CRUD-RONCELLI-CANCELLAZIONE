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
            this.LISTAP = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.TextBox();
            this.prezzo = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.TextBox();
            this.newname = new System.Windows.Forms.TextBox();
            this.newwprice = new System.Windows.Forms.TextBox();
            this.textBoxPercentuale = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LISTAP
            // 
            this.LISTAP.FormattingEnabled = true;
            this.LISTAP.Location = new System.Drawing.Point(589, 30);
            this.LISTAP.Name = "LISTAP";
            this.LISTAP.Size = new System.Drawing.Size(319, 446);
            this.LISTAP.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(243, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "aggiungi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.Location = new System.Drawing.Point(243, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modifica il nome";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button3.Location = new System.Drawing.Point(241, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 61);
            this.button3.TabIndex = 3;
            this.button3.Text = "Modfica il prezzo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button4.Location = new System.Drawing.Point(241, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 57);
            this.button4.TabIndex = 4;
            this.button4.Text = "Elimina";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button5.Location = new System.Drawing.Point(241, 339);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 62);
            this.button5.TabIndex = 5;
            this.button5.Text = "Ordinamento";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button6.Location = new System.Drawing.Point(406, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 61);
            this.button6.TabIndex = 6;
            this.button6.Text = "Somma prezzi";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button7.Location = new System.Drawing.Point(404, 89);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(127, 67);
            this.button7.TabIndex = 7;
            this.button7.Text = "Aggiunta o sottrazione di una percentuale";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button8.Location = new System.Drawing.Point(404, 174);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(127, 60);
            this.button8.TabIndex = 8;
            this.button8.Text = "Salvataggio su file";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button9.Location = new System.Drawing.Point(404, 260);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(126, 60);
            this.button9.TabIndex = 9;
            this.button9.Text = "Lettura da file";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button10.Location = new System.Drawing.Point(404, 342);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(126, 59);
            this.button10.TabIndex = 10;
            this.button10.Text = "Trova prodotto min";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button11.Location = new System.Drawing.Point(337, 418);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(122, 58);
            this.button11.TabIndex = 11;
            this.button11.Text = "Trova prodotto max";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(44, 53);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(152, 20);
            this.nome.TabIndex = 12;
            // 
            // prezzo
            // 
            this.prezzo.Location = new System.Drawing.Point(44, 151);
            this.prezzo.Name = "prezzo";
            this.prezzo.Size = new System.Drawing.Size(152, 20);
            this.prezzo.TabIndex = 13;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(44, 235);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(152, 20);
            this.search.TabIndex = 14;
            // 
            // newname
            // 
            this.newname.Location = new System.Drawing.Point(44, 362);
            this.newname.Name = "newname";
            this.newname.Size = new System.Drawing.Size(152, 20);
            this.newname.TabIndex = 15;
            // 
            // newwprice
            // 
            this.newwprice.Location = new System.Drawing.Point(44, 439);
            this.newwprice.Name = "newwprice";
            this.newwprice.Size = new System.Drawing.Size(152, 20);
            this.newwprice.TabIndex = 16;
            // 
            // textBoxPercentuale
            // 
            this.textBoxPercentuale.Location = new System.Drawing.Point(44, 515);
            this.textBoxPercentuale.Name = "textBoxPercentuale";
            this.textBoxPercentuale.Size = new System.Drawing.Size(152, 20);
            this.textBoxPercentuale.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "prodottto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "prezzo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "inserisci il prodotto da cercare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Inserisci il nuovo nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Aggiungi/sottrai percentuale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Inserisci il nuovo prezzo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 576);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPercentuale);
            this.Controls.Add(this.newwprice);
            this.Controls.Add(this.newname);
            this.Controls.Add(this.search);
            this.Controls.Add(this.prezzo);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LISTAP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LISTAP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox prezzo;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.TextBox newname;
        private System.Windows.Forms.TextBox newwprice;
        private System.Windows.Forms.TextBox textBoxPercentuale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

