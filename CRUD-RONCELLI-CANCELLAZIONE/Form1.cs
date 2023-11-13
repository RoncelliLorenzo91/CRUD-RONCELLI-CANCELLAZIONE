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
        // Dichiarazioni di variabili globali
        public int RecordLength = 64; // Lunghezza di ciascun record nel file
        public string FilePath = "prodotti.dat"; // Percorso del file

        // Dichiarazione di una struttura per rappresentare un prodotto
        public struct Prodotto
        {
            public string Nome;
            public double Prezzo;
        }
        public Prodotto[] p; // Array di prodotti
        public int dim; // Dimensione dell'array di prodotti

        // Costruttore della classe Form1
        public Form1()
        {
            InitializeComponent();
            p = new Prodotto[100]; // Inizializzazione dell'array di prodotti con dimensione 100
            dim = 0; // Inizializzazione della dimensione a 0
        }
        public int indice = 0; // Dichiarazione e inizializzazione di una variabile globale indice

        // Gestisce il click sul pulsante "Aggiungi"
        private void Aggiungi_Click(object sender, EventArgs e)
        {
            // Controlli sull'inserimento di nome e prezzo
            if (nome.Text == "")
            {
                MessageBox.Show("Inserire un nome");
            }
            else if (prezzo.Text == "")
            {
                MessageBox.Show("Inserire un prezzo");
            }
            else
            {
                // Aggiunta del prodotto all'array e al file
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

        // Funzione che aggiunge un prodotto al file
        private void aggiungi(string nome, double prezzo, string percorso)
        {
            var apertura = new FileStream(percorso, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter salva = new StreamWriter(apertura);
            salva.WriteLine($"{nome};{prezzo};1;0;".PadRight(RecordLength - 4) + "##");
            salva.Close();
        }

        // Funzione che gestisce la modifica di un prodotto nel file
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

        // Funzione che ricerca un prodotto nel file
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

        // Funzione che ricerca un prodotto cancellato logicamente nel file
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

        // Gestisce il click sul pulsante "Modifica Prodotto"
        private void modificaprodottoprezzo_Click(object sender, EventArgs e)
        {
            // Controlli sull'inserimento di dati per la modifica
            if (search.Text == "")
            {
                MessageBox.Show("Inserire il prodotto da cercare");
            }
            else if (newname.Text == "")
            {
                MessageBox.Show("Inserire il nuovo nome");
            }
            else if (newwprice.Text == "")
            {
                MessageBox.Show("Inserire il nuovo prezzo");
            }
            else
            {
                // Chiamata alla funzione di modifica
                Modifica(newname.Text, double.Parse(newwprice.Text), FilePath, RecordLength);
                search.Clear();
                newname.Clear();
                newwprice.Clear();
            }
        }

        // Funzione che restituisce i dati di un prodotto cercato nel file
        public string[] ricercaprod(string nome)
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

        // Funzione che gestisce la cancellazione fisica di un prodotto nel file specificato dal percorso.
        public void CancellazioneFisica(string percorso)
        {
            int indice = Ricerca(search.Text); // Ottiene l'indice del prodotto da cancellare

            if (string.IsNullOrEmpty(search.Text)) // Verifica se il campo di ricerca è vuoto
            {
                MessageBox.Show("Inserire un prodotto"); // Mostra un messaggio di avviso
                return; // Esce dalla funzione
            }
            else if (indice == -1) // Verifica se il prodotto non è stato trovato
            {
                MessageBox.Show("Il prodotto non esiste"); // Mostra un messaggio di avviso
                return; // Esce dalla funzione
            }

            List<string> righe = File.ReadAllLines(FilePath).ToList(); // Legge tutte le righe del file e le converte in una lista
            righe.RemoveAt(indice); // Rimuove la riga corrispondente al prodotto da cancellare
            File.WriteAllLines(FilePath, righe); // Scrive tutte le righe aggiornate nel file

            MessageBox.Show("Eliminato"); // Mostra un messaggio di conferma
        }


        // Funzione che gestisce la cancellazione logica di un prodotto nel file specificato dal percorso.
        public void CancellaLogica(string FilePath, string nome, int lunghezza)
        {
            List<string> righe = File.ReadAllLines(FilePath).ToList(); // Legge tutte le righe del file e le converte in una lista
            int indice = Ricerca(search.Text); // Ottiene l'indice del prodotto da cancellare logicamente

            if (indice != -1) // Verifica se il prodotto è stato trovato
            {
                string[] prodotto = righe[indice].Split(';'); // Splitta la riga del prodotto in un array di stringhe
                righe[indice] = $"{prodotto[0]};{prodotto[1]};{prodotto[2]};1;".PadRight(RecordLength - 4) + "##";

                // Aggiunge eventuali spazi bianchi alla fine della riga se necessario
                righe[indice] = righe[indice].PadRight(RecordLength, ' ');

                // Scrive le righe modificate nel file
                File.WriteAllLines(FilePath, righe);

                MessageBox.Show("Prodotto cancellato logicamente"); // Mostra un messaggio di conferma
            }
            else
            {
                MessageBox.Show("Il prodotto non esiste"); // Mostra un messaggio di avviso
            }
        }


        // Gestisce il click sul pulsante "Cancellazione Logica"
        private void cancellazioneL_Click(object sender, EventArgs e)
        {
            CancellaLogica(FilePath, search.Text, RecordLength);
            search.Clear();
        }

        // Gestisce l'evento di clic sul pulsante per il recupero logico di un prodotto.
        private void recuperaFF_Click(object sender, EventArgs e)
        {
            // Verifica se la casella di ricerca è vuota o se il prodotto non esiste logicamente
            if (string.IsNullOrEmpty(search.Text) || (Ricercadarecu(search.Text) == -1))
            {
                MessageBox.Show("Inserire un prodotto o il prodotto non esiste"); // Mostra un messaggio di avviso
                return; // Esce dalla funzione
            }
            else if (indice >= 0) // Controlla se l'indice è valido (questa condizione sembra sempre vera)
            {
                string[] prodotto = ricercaprod(search.Text); // Ottiene i dati del prodotto dalla funzione ricercaprod
                string line;

                // Apre il file in modalità scrittura binaria
                var salva = new FileStream(FilePath, FileMode.Open, FileAccess.Write);
                BinaryWriter scrivi = new BinaryWriter(salva);

                // Sposta il puntatore nel file alla posizione del record del prodotto da recuperare logicamente
                salva.Seek(RecordLength * indice, SeekOrigin.Begin);

                // Costruisce una nuova riga con il prodotto recuperato logicamente
                line = $"{prodotto[0]};{prodotto[1]};{prodotto[3]};0;".PadRight(RecordLength - 4) + "##";

                // Converte la riga in un array di byte e scrive nel file
                byte[] bytes = Encoding.UTF8.GetBytes(line);
                scrivi.Write(bytes, 0, bytes.Length);

                // Chiude gli stream
                scrivi.Close();
                salva.Close();

                MessageBox.Show("Prodotto recuperato logicamente"); // Mostra un messaggio di conferma
            }
        }

        // Gestisce il click sul pulsante "Apri File"
        private void openF_Click(object sender, EventArgs e)
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

        // Gestisce il click sul pulsante "Resetta File"
        private void RESET_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(FilePath, string.Empty);
                MessageBox.Show("File resettato");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Si è verificato un errore durante il reset del file: {ex.Message}");
            }
        }

        // Funzione che visualizza i prodotti non cancellati logicamente nella ListBox
        public void Visualizza(string filePath)
        {
            LISTAP.Items.Clear();

            // Utilizza 'using' per garantire la corretta chiusura del lettore
            using (StreamReader reader = new StreamReader(filePath))
            {
                string lettura;

                while ((lettura = reader.ReadLine()) != null)
                {
                    string[] dati = lettura.Split(';');

                    // Controlla se il prodotto è cancellato logicamente prima di aggiungerlo alla ListBox
                    if (dati.Length >= 4 && dati[3] == "0")
                    {
                        LISTAP.Items.Add($"{dati[0]},{dati[1]}, {dati[2]},{dati[3]}");
                    }
                }
            }
        }

        // Gestisce il click sul pulsante "Visualizza"
        private void button1_Click(object sender, EventArgs e)
        {
            Visualizza(FilePath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
