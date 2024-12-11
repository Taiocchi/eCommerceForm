using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    internal class ProdottoAlimentare : Prodotto
    {
        public ProdottoAlimentare(string tipo, string modello, string identificativo, double prezzoBase) : base(tipo, modello, identificativo, prezzoBase)
        {

        }
        override public double calcolaPrezzoEffettivo()
        {
            PrezzoEffettivo = PrezzoBase * 0.8;
            Nome = Tipo + " - " + Identificativo + " - PrezzoBase: " + PrezzoBase + " - PrezzoEffettivo: " + PrezzoEffettivo;
            return PrezzoEffettivo;
        }
    }
}
