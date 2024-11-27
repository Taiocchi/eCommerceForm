using eCommerce;
using System.Text.Json;
using System.IO;
using static System.Net.WebRequestMethods;
using System.Windows.Forms;

namespace eCommerceForm
{
    public partial class Form1 : Form
    {
        Carrello C;
        Prodotto prodotto;
        string jsonString;

        public Form1()
        {
            InitializeComponent();

            C = new Carrello("00001");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cambia colore di sfondo dei pulsanti Aggiungi e Rimuovi
            Aggiungi.BackColor = Color.FromArgb(0, 122, 204);

            Rimuovi.BackColor = Color.FromArgb(255, 59, 48);
        }

        private void Aggiungi_Click(object sender, EventArgs e)
        {
            CreaOggetto();

            C.aggiungiProdotto(prodotto);

            AggiornaInterfaccia();
        }

        private void CreaOggetto()
        {
            string selezionato = comboBox1.SelectedItem.ToString();

            string[] dati = selezionato.Split(" - "); //In questo modo posso dividere il tipo e il numero seriale di ogni prodotto inseriti tramite la comboBox1 

            string tipoProdotto = dati[0];
            string numeroSeriale = dati[1];

            prodotto = new Prodotto(tipoProdotto, "A1", numeroSeriale, 121);
        }

        private void Rimuovi_Click(object sender, EventArgs e)
        {
            //Verifica che l'elemento selezionato sia di tipo Prodotto e, se è vero, lo assegna direttamente alla variabile prodottoSelezionato
            if (listBox1.SelectedItem is Prodotto prodottoSelezionato)
            {
                C.rimuoviProdotto(prodottoSelezionato);
                AggiornaInterfaccia();
            }
        }

        private void AggiornaInterfaccia()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = C.ProdottiCarrello;
            listBox1.DisplayMember = "Nome";
            label2.Text = "Tot. prodotti: " + listBox1.Items.Count.ToString();
        }

        /*
        private void Salva_Click(object sender, EventArgs e)
        {
            //Serializzazione
            jsonString = JsonSerializer.Serialize(C);

            string filePath = "prodotti.json";

            System.IO.File.WriteAllText(filePath, jsonString);
            
            string jsonFromFile = System.IO.File.ReadAllText("prodotti.json");

            //Deserializzazione
            var prodottoDalFile = JsonSerializer.Deserialize<Carrello>(jsonFromFile);

            // Mostra i dati dei prodotti deserializzati
            string message = "Prodotti salvati e caricati:\n";
            foreach (var p in C)
            {
                message += $"Tipo: {p.Tipo}, Identificativo: {p.Identificativo}\n";
            }

            MessageBox.Show(message, "Dettagli Prodotti");
        }
        */
    }
}
