using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_RONCELLI_CANCELLAZIONE
{
    public partial class Form1 : Form
    {
        public struct prodotto
        {
            public string nome;
            public Double prezzo;
        }
        public prodotto[] p;
        public int dim;
        public Form1()
        {
            InitializeComponent();
            p = new prodotto[100];
            dim = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aggiungi(nome.Text, Convert.ToDouble(prezzo.Text));
            aggiornaVista(dim);
            nome.Text = "";
            nome.Focus();
            MessageBox.Show("aggiunto");
        }

        public void aggiungi(string nome, Double prezzo)
        {
            p[dim].nome = nome;
            p[dim].prezzo = prezzo;
            dim++;
        }

        public void aggiornaVista(int dim)
        {
            LISTAP.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                LISTAP.Items.Add(" Nome: " + p[i].nome + " Prezzo: " + p[i].prezzo.ToString() + "€");
            }
        }

        public string prodString(prodotto p)
        {
            return "Nome:" + p.nome + " prezzo:" + p.prezzo.ToString() + "€";
        }

        public void visualizza(prodotto[] pp)
        {
            LISTAP.Items.Clear();
            for (int i = 0; i < dim; i++)

            {
                LISTAP.Items.Add(prodString(pp[i]));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ricerca = search.Text;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].nome == search.Text)
                {
                    p[i].nome = newname.Text;
                    MessageBox.Show("Modificato");
                    visualizza(p);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ricerca = search.Text;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].nome == ricerca) // Confronta con il nome del prodotto cercato
                {
                    p[i].prezzo = Convert.ToDouble(newwprice.Text); // Converti il prezzo in double
                    MessageBox.Show("Modificato");
                    visualizza(p);
                    break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string eliminanome = search.Text;

            for (int i = 0; i < dim; i++)
            {
                if (p[i].nome == eliminanome)
                {
                    // Sposta tutti gli elementi successivi indietro di una posizione
                    for (int j = i; j < dim - 1; j++)
                    {
                        p[j] = p[j + 1];
                    }

                    // Decrementa la dimensione dell'array
                    dim--;

                    MessageBox.Show("Prodotto eliminato");
                    aggiornaVista(dim);
                    return; // Esci dalla funzione dopo l'eliminazione
                }
            }

            MessageBox.Show("Prodotto non trovato");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Array.Sort(p, 0, dim, new ComparatoreProdotti());
            aggiornaVista(dim);
        }

        private class ComparatoreProdotti : IComparer<prodotto> // Classe di confronto personalizzata per ordinare in base al campo "nome"
        {
            public int Compare(prodotto x, prodotto y)
            {
                return x.nome.CompareTo(y.nome);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double somma = 0;
            for (int i = 0; i < dim; i++)
            {
                somma += p[i].prezzo;
            }
            MessageBox.Show("La somma dei prezzi è: " + somma.ToString("0.00") + "€");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double percentuale;
            if (double.TryParse(textBoxPercentuale.Text, out percentuale))
            {
                for (int i = 0; i < dim; i++)
                {
                    p[i].prezzo += p[i].prezzo * (percentuale / 100);
                }
                aggiornaVista(dim);
                MessageBox.Show("Percentuale aggiunta/sottratta con successo");
            }
            else
            {
                MessageBox.Show("Inserire una percentuale valida.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("prodotti.txt"))
            {
                for (int i = 0; i < dim; i++)
                {
                    sw.WriteLine(p[i].nome + "," + p[i].prezzo);
                }
                MessageBox.Show("Prodotti salvati su file.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (File.Exists("prodotti.txt"))
            {
                using (StreamReader sr = new StreamReader("prodotti.txt"))
                {
                    dim = 0;
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            p[dim].nome = parts[0];
                            p[dim].prezzo = Convert.ToDouble(parts[1]);
                            dim++;
                        }
                    }
                    aggiornaVista(dim);
                    MessageBox.Show("Prodotti letti da file.");
                }
            }
            else
            {
                MessageBox.Show("Il file dei prodotti non esiste.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (dim > 0)
            {
                double prezzoMinimo = p[0].prezzo;
                string prodottoMinimo = p[0].nome;
                for (int i = 1; i < dim; i++)
                {
                    if (p[i].prezzo < prezzoMinimo)
                    {
                        prezzoMinimo = p[i].prezzo;
                        prodottoMinimo = p[i].nome;
                    }
                }
                MessageBox.Show("Prodotto con prezzo minimo:\nNome: " + prodottoMinimo + "\nPrezzo: " + prezzoMinimo.ToString("0.00") + "€");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (dim > 0)
            {
                double prezzoMassimo = p[0].prezzo;
                string prodottoMassimo = p[0].nome;
                for (int i = 1; i < dim; i++)
                {
                    if (p[i].prezzo > prezzoMassimo)
                    {
                        prezzoMassimo = p[i].prezzo;
                        prodottoMassimo = p[i].nome;
                    }
                }
                MessageBox.Show("Prodotto con prezzo massimo:\nNome: " + prodottoMassimo + "\nPrezzo: " + prezzoMassimo.ToString("0.00") + "€");
            }
            else
            {
                MessageBox.Show("Nessun prodotto presente.");
            }
        }
    }
}
