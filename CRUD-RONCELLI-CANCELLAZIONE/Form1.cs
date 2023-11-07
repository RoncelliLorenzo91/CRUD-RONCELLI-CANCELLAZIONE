using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CRUD_RONCELLI_CANCELLAZIONE.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_RONCELLI_CANCELLAZIONE
{
    public partial class Form1 : Form
    {
        public struct prodotto
        {
            public string nome;
            public Double prezzo;
        }
        public int dim = 0;
        public string filePath = "prodotti.dat";
        public int recordLenght = 64;
        public prodotto[] p;
        public Form1()
        {
            InitializeComponent();
            p = new prodotto[100];
            dim = 0;
        }

        private void button1_Click(object sender, EventArgs e) //Aggiungi su file
        {
       
        }

        public void aggiungi(string nome, string prezzo, string filePath)
        {
            var oStream = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(oStream);
            sw.WriteLine($"{nome};{prezzo};1;0;".PadRight(recordLenght - 4) + "##");
            sw.Close();
        }

        private int indice(string nome)
        {
            int riga = 0;
            using (StreamReader sw = File.OpenText("prodotti.dat"))
            {
                string lettere;
                while ((lettere = sw.ReadLine()) != null)
                {
                    string[] dati = lettere.Split(';');
                    if (dati[3] == "0" && dati[0] == nome)
                    {
                        sw.Close();
                        return riga;
                    }
                    riga++;
                }
            }
            return -1;
        }


        public int Ricerca(string nome, string filePath)
        { 
            int riga = indice(search.Text);
            using (StreamReader sr = File.OpenText(filePath))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    string[] dati = s.Split(';');
                    if (dati[3] == "0" && dati[0] == nome)
                    {
                        sr.Close();
                        return riga;
                    }
                    riga++;
                }
                sr.Close();
            }
            return -1;
        }


        public void Modifica(int posizione, string nome, float prezzo, string filePath, int recordLenght)
        {
            int prod = indice(search.Text);
            string line;
            var file = new FileStream(filePath, FileMode.Open, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(file);
            file.Seek(recordLenght * posizione, SeekOrigin.Begin);
            line = $"{nome};{prezzo};1;0;".PadRight(recordLenght - 4) + "##";
            byte[] bytes = Encoding.UTF8.GetBytes(line);
            writer.Write(bytes);
            writer.Close();
            file.Close();
        }



        public void Cancellazione(int posizione, string filePath, int recordLenght)
        {

            int prod = indice(search.Text);
            string line;
            var file = new FileStream(filePath, FileMode.Open, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(file);
            file.Seek(recordLenght * posizione, SeekOrigin.Begin);
            line = $"{nome};{prezzo};0;1;".PadRight(recordLenght - 4) + "##";
            byte[] bytes = Encoding.UTF8.GetBytes(line);
            writer.Write(bytes, 0, bytes.Length);
            writer.Close();
            file.Close();
        }










        private void button8_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("prodotti.dat"))
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
            if (File.Exists("prodotti.dat"))
            {
                using (StreamReader sr = new StreamReader("prodotti.dat"))
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
                    
                    MessageBox.Show("Prodotti letti da file.");
                }
            }
            else
            {
                MessageBox.Show("Il file dei prodotti non esiste.");
            }
        }

        

        
        private void button12_Click(object sender, EventArgs e) //D logica file
        {
            
        }

        private void button13_Click(object sender, EventArgs e) //D fisica file
        {

        }

        private void button2_Click(object sender, EventArgs e) //Modifica nome su file
        {

        }

        private void button3_Click(object sender, EventArgs e) //Modifica il prezzo su file
        {

        }
    }
}
