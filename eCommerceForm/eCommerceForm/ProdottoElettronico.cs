namespace eCommerce
{
    class ProdottoElettronico : Prodotto
    {
        public ProdottoElettronico(string tipo, string modello, string identificativo, double prezzoBase) : base(tipo, modello, identificativo, prezzoBase)
        {

        }
        override public double calcolaPrezzoEffettivo()
        {
            //Nome = Tipo + " - " + Identificativo + " - PrezzoBase: " + PrezzoBase + " - PrezzoEffettivo: " + calcolaPrezzoEffettivo();
            return PrezzoBase * 0.9;
        }
    }
}
