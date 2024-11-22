using eCommerce;

namespace eCommerceForm
{
    public partial class Form1 : Form
    {
        Carrello C;
        Prodotto prodotto;

        public Form1()
        {
            InitializeComponent();

            C = new Carrello("00001"); //Creo l'oggetto C di tipo Carrello
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Aggiungi_Click(object sender, EventArgs e)
        {
            CreaOggetto();

            C.aggiungiProdotto(prodotto);

            AggiornaInterfaccia();
        }

        private void CreaOggetto()
        {
            string numeroSeriale = comboBox1.Text;

            Prodotto prodotto = new Prodotto("Philips", "A1", numeroSeriale, 121);
        }

        private void Rimuovi_Click(object sender, EventArgs e)
        {
            C.rimuoviProdotto(prodotto);

            AggiornaInterfaccia();
        }

        private void AggiornaInterfaccia()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = C.ProdottiCarrello;
            listBox1.DisplayMember = "Nome";
        }
    }
}
