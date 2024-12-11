using eCommerce;
using System.Text.Json;
using System.IO;
using static System.Net.WebRequestMethods;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq;

namespace eCommerceForm
{
    public partial class Form1 : Form
    {
        Carrello C;
        Prodotto prodotto;
        string jsonString;
        string filePath = "prodotti.json"; //Crea un file "prodotti.json" in cui verranno salvati gli oggetti della lista
        double sommaPrezzoBase = 0;
        double sommaPrezzoEffettivo = 0;

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
            if(comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                CreaOggetto();
                if (C.ProdottiCarrello.Contains(prodotto) != true)
                {
                    sommaPrezzoBase += prodotto.PrezzoBase;
                    sommaPrezzoEffettivo += prodotto.calcolaPrezzoEffettivo();
                    C.aggiungiProdotto(prodotto);
                    AggiornaInterfaccia();
                }
            }
           
            /*bool elementoPresente = false;

            foreach (Prodotto p in C.ProdottiCarrello)
            {
                if (p.Identificativo == prodotto.Identificativo && p.Tipo == prodotto.Tipo)
                {
                    elementoPresente = true;
                    break;
                }     
            }

            if (elementoPresente == false)
                C.aggiungiProdotto(prodotto);
            else
                MessageBox.Show("L'elemento è già stato aggiunto al carrello");*/
        }

        private void CreaOggetto()
        {
            if(comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                string selezionato = comboBox1.SelectedItem.ToString();

                string[] dati = selezionato.Split(" - "); //In questo modo posso dividere il tipo e il numero seriale di ogni prodotto inseriti tramite la comboBox1 

                string tipoProdotto = dati[0];
                string numeroSeriale = dati[1];

                if (comboBox2.SelectedItem == "ProdottoAlimentare")
                {
                    prodotto = new ProdottoAlimentare(tipoProdotto, "A1", numeroSeriale, 50);
                }
                else if (comboBox2.SelectedItem == "ProdottoElettronico")
                {
                    prodotto = new ProdottoElettronico(tipoProdotto, "A1", numeroSeriale, 50);
                }
            }
        }

        private void Rimuovi_Click(object sender, EventArgs e)
        {
            Prodotto prodotto = (Prodotto)listBox1.SelectedItem;
            C.rimuoviProdottoVistaInClasse((Prodotto)listBox1.SelectedItem);
            sommaPrezzoBase -= prodotto.PrezzoBase;
            sommaPrezzoEffettivo -= prodotto.calcolaPrezzoEffettivo();
            AggiornaInterfaccia();
        }

        private void AggiornaInterfaccia()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = C.ProdottiCarrello;
            listBox1.DisplayMember = "Nome";
            totProdotti.Text = "Tot. prodotti: " + listBox1.Items.Count.ToString();
            prezzoBase.Text = "Tot. Prezzo base: " + sommaPrezzoBase.ToString();
            prezzoEffettivo.Text = "Tot. Prezzo effettivo: " + sommaPrezzoEffettivo.ToString();
        }

        private void Salva_Click(object sender, EventArgs e)
        {
            //Serializzazione
            jsonString = JsonSerializer.Serialize(C);

            System.IO.File.WriteAllText(filePath, jsonString);
        }

        private void Carica_Click(object sender, EventArgs e)
        {
            string jsonFromFile = System.IO.File.ReadAllText("prodotti.json");

            if (System.IO.File.Exists(filePath))
            {
                FileInfo fileInfo = new FileInfo(filePath); //Crea FileInfo usando il percorso del file

                //Deserializzazione
                if (fileInfo.Length != 0) //Controlla se FileInfo non e' vuoto
                {
                    var prodottoDalFile = JsonSerializer.Deserialize<Carrello>(jsonFromFile);
                    foreach (var p in prodottoDalFile.ProdottiCarrello)
                    {
                        p.calcolaPrezzoEffettivo();
                    }
                    C.ProdottiCarrello = prodottoDalFile.ProdottiCarrello;

                    //Mostra i dati deserializzati
                    string message = $"Carrello Identificativo: {prodottoDalFile.Identificativo}\nProdotti salvati e caricati:\n";
                    foreach (var p in prodottoDalFile.ProdottiCarrello)
                    {
                        message += $"Nome: {p.Nome}, Tipo: {p.Tipo}, Modello: {p.Modello}, Prezzo base: {p.PrezzoBase}, Prezzo effettivo: {p.calcolaPrezzoEffettivo()}, Identificativo: {p.Identificativo}\n";
                    }

                    MessageBox.Show(message, "Dettagli Prodotti");

                    AggiornaInterfaccia();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "ProdottoAlimentare")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Budino - 13573");
                comboBox1.Items.Add("Budino - 13574");
                comboBox1.Items.Add("Budino - 13575");
                comboBox1.Items.Add("Budino - 13576");
                comboBox1.Items.Add("Budino - 13577");
                comboBox1.Items.Add("Budino - 13578");
            }
            else if (comboBox2.SelectedItem == "ProdottoElettronico")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Televisore - 13579");
                comboBox1.Items.Add("Televisore - 13580");
                comboBox1.Items.Add("Televisore - 13581");
                comboBox1.Items.Add("Televisore - 13582");
                comboBox1.Items.Add("Televisore - 13583");
                comboBox1.Items.Add("Televisore - 13584");
            }
        }
    }
}
