namespace eCommerce
{
    class Prodotto : IEquatable<Prodotto>
    {
        private string tipo;
        private string modello;
        private double prezzoBase;
        private double prezzoEffettivo;
        private string identificativo;
        private string nome;

        public string Nome
        {
            get { return nome; }
            protected set { nome = value; }
        }
        public string Tipo
        {
            get { return tipo; }
        }
        public string Modello
        {
            get { return modello; }
        }
        public double PrezzoBase
        {
            get { return prezzoBase; }
        }
        public double PrezzoEffettivo
        {
            get { return prezzoEffettivo; }
            protected set { prezzoEffettivo = value; }
        }

        public string Identificativo
        {
            get { return identificativo; }
        }
        virtual public double calcolaPrezzoEffettivo()
        {
            double PrezzoEffettivo = PrezzoBase;
            nome = tipo + " - " + identificativo + " - PrezzoBase: " + prezzoBase + " - PrezzoEffettivo: " + PrezzoEffettivo;
            return PrezzoEffettivo;
        }

        public Prodotto(string tipo, string modello, string identificativo, double prezzoBase)
        {
            this.tipo = tipo;
            this.modello = modello;
            this.identificativo = identificativo;
            this.prezzoBase = prezzoBase;
        }

        public bool Equals(Prodotto other)
        {
            if (other == null)
                return false;

            return this.Identificativo == other.Identificativo;
        }
    }
}
