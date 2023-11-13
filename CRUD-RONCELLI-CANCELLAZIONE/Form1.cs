using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static CRUD_RONCELLI_CANCELLAZIONE.Form1;

namespace CRUD_RONCELLI_CANCELLAZIONE
{
    public partial class Form1 : Form
    {
        public int RecordLength = 64;
        public string FilePath = "prodotti.dat"; //creazione variabile file

        public struct Prodotto
        {
            public string Nome;
            public double Prezzo;
        }
        public Prodotto[] p;
        public int dim;

        public Form1()
        {
            InitializeComponent();
            p = new Prodotto[100];
            dim = 0;
        }
        public int indice = 0;

        private void Aggiungi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nome.Text))
            {
                MessageBox.Show("Inserire un nome");
            }
            else if (string.IsNullOrEmpty(prezzo.Text))
            {
                MessageBox.Show("Inserire un prezzo");
            }
            else
            {
                p[dim].Nome = nome.Text;
                p[dim].Prezzo = float.Parse(prezzo.Text);
                aggiungi(p[dim].Nome, p[dim].Prezzo, FilePath);
                dim++;
                indice++;
                nome.Clear();
                prezzo.Clear();
                MessageBox.Show("Prodotto aggiunto al file");
            }
        }

        private void aggiungi(string nome, double prezzo, string percorso)
        {
            var apertura = new FileStream(percorso, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter salva = new StreamWriter(apertura);
            salva.WriteLine($"{nome};{prezzo};1;0;".PadRight(RecordLength - 4) + "##");
            salva.Close();
        }
        public void Modifica(string nome, double prezzo, string filePath, int recordLenght)
        {
            int indice = Ricerca(search.Text);
            if (indice == -1)
            {
                MessageBox.Show("Il prodotto non esiste");
            }
            else if (indice >= 0)
            {
                string riga;
                var salva = new FileStream(FilePath, FileMode.Open, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(salva);
                salva.Seek(recordLenght * indice, SeekOrigin.Begin);
                riga = $"{nome};{prezzo};1;0;".PadRight(recordLenght - 4) + "##";
                byte[] bytes = Encoding.UTF8.GetBytes(riga);
                writer.Write(bytes);
                writer.Close();
                salva.Close();
                MessageBox.Show("Prodotto e prezzo modificato nel file");
            }
        }
        private int Ricerca(string nome)
        {
            int riga = 0;
            using (StreamReader salva = File.OpenText("prodotti.dat"))
            {
                string lettore;
                while ((lettore = salva.ReadLine()) != null)
                {
                    string[] dati = lettore.Split(';');
                    if (dati[3] == "0" && dati[0] == nome)
                    {
                        salva.Close();
                        return riga;
                    }
                    riga++;
                }
            }
            return -1;
        }

        private int Ricercadarecu(string nome)
        {
            int riga = 0;
            using (StreamReader salva = File.OpenText("prodotti.dat"))
            {
                string lettore;
                while ((lettore = salva.ReadLine()) != null)
                {
                    string[] dati = lettore.Split(';');
                    if (dati[3] == "1" && dati[0] == nome)
                    {
                        salva.Close();
                        return riga;
                    }
                    riga++;
                }
            }
            return -1;
        }
        private void modificaprodottoprezzo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(search.Text))
            {
                MessageBox.Show("Inserire il prodotto da cercare");
            }
            else if (string.IsNullOrEmpty(newname.Text))
            {
                MessageBox.Show("Inserire il nuovo nome");
            }
            else if (string.IsNullOrEmpty(newwprice.Text))
            {
                MessageBox.Show("Inserire il nuovo prezzo");
            }
            else
            {
                Modifica(newname.Text, double.Parse(newwprice.Text), FilePath, RecordLength);
                search.Clear();
                newname.Clear();
                newwprice.Clear();
            }
        }

        public string[] ricercaprod(string nome)// funzione ricerca prodotto
        {
            int riga = 0;
            using (StreamReader sr = File.OpenText("prodotti.dat"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dati = line.Split(';');
                    if (dati[3] == "1" && dati[0] == nome)
                    {
                        sr.Close();
                        return dati;
                    }
                    riga++;
                }
            }
            return null;
        }

        public void CancellazioneF(string percorso)// funzione cancellazione fisica
        {
            int indice = Ricerca(search.Text);
            if (string.IsNullOrEmpty(search.Text))
            {
                // se la text box è vuota
                MessageBox.Show("Inserire un prodotto");
                return;
            }
            else if (indice == -1)
            {
                // se il prodotto non è presente
                MessageBox.Show("Il prodotto non esiste");
            }
            else if (indice >= 0)
            {
                List<string> righe = new List<string>();

                // legge tutte le righe dal file e salva in memoria, escludendo quella da eliminare
                using (StreamReader salva = File.OpenText(FilePath))
                {
                    string lettore;
                    while ((lettore = salva.ReadLine()) != null)
                    {
                        righe.Add(lettore);
                    }
                }

                // rimuove la riga desiderata
                righe.RemoveAt(indice);

                // scrive tutte le righe aggiornate nel file
                using (StreamWriter scrivi = new StreamWriter(percorso, false))
                {
                    foreach (string riga in righe)
                    {
                        scrivi.WriteLine(riga);
                    }
                }
                MessageBox.Show("Eliminato");
            }
        }

        private void cancellazioneF_Click(object sender, EventArgs e)
        {
            CancellazioneF(FilePath);
            search.Clear();
        }
        public void CancellaL(string FilePath, string nome, int lunghezza)// funzione cancellazione logica
        {
            List<string> righe = File.ReadAllLines(FilePath).ToList();
            int indice = Ricerca(search.Text);

            if (indice != -1)
            {
                string[] prodotto = righe[indice].Split(';');
                righe[indice] = $"{prodotto[0]};{prodotto[1]};{prodotto[2]};1;".PadRight(RecordLength - 4) + "##";

                // Aggiungi eventuali spazi bianchi alla fine della riga se necessario
                righe[indice] = righe[indice].PadRight(RecordLength, ' ');

                // Ora, scrivi le righe modificate nel file
                File.WriteAllLines(FilePath, righe);

                MessageBox.Show("Prodotto cancellato logicamente");
            }
            else
            {
                MessageBox.Show("Il prodotto non esiste");
            }
        }




        private void cancellazioneL_Click(object sender, EventArgs e)//
        {
            CancellaL(FilePath, search.Text, RecordLength);
            search.Clear();
        }



        private void recuperaFF_Click(object sender, EventArgs e)
        {
            int indice = Ricercadarecu(search.Text);

            if (string.IsNullOrEmpty(search.Text))
            {
                MessageBox.Show("Inserire un prodotto");
                return;
            }
            else if (indice == -1)
            {
                MessageBox.Show("Il prodotto non esiste");
            }
            else if (indice >= 0)
            {
                string[] prodotto = ricercaprod(search.Text);
                string line;
                var salva = new FileStream(FilePath, FileMode.Open, FileAccess.Write);
                BinaryWriter scrivi = new BinaryWriter(salva);
                salva.Seek(RecordLength * indice, SeekOrigin.Begin);
                line = $"{prodotto[0]};{prodotto[1]};{prodotto[3]};0;".PadRight(RecordLength - 4) + "##";
                byte[] bytes = Encoding.UTF8.GetBytes(line);
                scrivi.Write(bytes, 0, bytes.Length);
                scrivi.Close();
                salva.Close();
                MessageBox.Show("Prodotto recuperato logicamente");
            }
        }

        private void openF_Click(object sender, EventArgs e) //apri file
        {
            string Pfile = Path.Combine(Application.StartupPath, "prodotti.dat");
            if (File.Exists(Pfile))
            {
                System.Diagnostics.Process.Start(Pfile);
            }
            else
            {
                MessageBox.Show("Il file non esiste.");
            }
        }

        private void RESET_Click(object sender, EventArgs e) //resetta il file "prodotti.dat"
        {
            File.WriteAllText(FilePath, string.Empty);
            MessageBox.Show("File resettato");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        public void Visualizza(string FilePath)
        {
            string lettura;
            StreamReader reader = new StreamReader(FilePath);
            lettura = reader.ReadLine();   
            LISTAP.Items.Clear();
            while (lettura != null)
            {
                string[] dati = lettura.Split(';');
                if (dati[3] == "0")
                {
                    LISTAP.Items.Add($"{dati[0]},{dati[1]}, {dati[2]},{dati[3]}");
                    lettura = reader.ReadLine();
                }
                
                else{ 
                    LISTAP.Items.Add("");
                    lettura = reader.ReadLine();

                }
               
            }
            reader.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Visualizza(FilePath);

        }
    }
}