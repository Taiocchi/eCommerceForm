namespace eCommerce
{
    class ProdottoElettronico : Prodotto
    {
        public ProdottoElettronico(string tipo, string modello, string identificativo, double prezzoBase) : base(tipo, modello, identificativo, prezzoBase)
        {

        }
        override public double calcolaPrezzoEffettivo()
        {
            PrezzoEffettivo = PrezzoBase * 0.9;
            Nome = Tipo + " - " + Identificativo + " - PrezzoBase: " + PrezzoBase + " - PrezzoEffettivo: " + PrezzoEffettivo;
            return PrezzoEffettivo;
        }
    }
}
