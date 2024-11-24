namespace eCommerce
{
    class Prodotto : IEquatable<Prodotto>
    {
        private string tipo;
        private string modello;
        private double prezzo;
        private string identificativo;
        private string nome;

        public string Nome
        {
            get { return nome; }
        }
        public string Tipo
        {
            get { return tipo; }
        }
        public string Modello
        {
            get { return modello; }
        }
        public double Prezzo
        {
            get { return prezzo; }
            set { prezzo = value; }
        }
        public string Identificativo
        {
            get { return identificativo; }
        }

        public Prodotto(string tipo, string modello, string identificativo, double prezzo)
        {
            this.tipo = tipo;
            this.modello = modello;
            this.identificativo = identificativo;
            this.prezzo = prezzo;
            nome = tipo + " - " + identificativo; //Concateno l'attributo tipo e identificativo in modo che possa visualizzarli insieme nella lista
        }

        public bool Equals(Prodotto other) //Per confrontare l'identificativo di 2 prodotti, il quale e' univoco
        {
            if (other == null)
                return false;

            if (this == other)
                return true;

            return Identificativo.Equals(other.Identificativo);
        }
    }
}
