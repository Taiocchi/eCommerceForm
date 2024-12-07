using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    internal class ProdottoAlimentare : Prodotto
    {
        public ProdottoAlimentare(string tipo, string modello, string identificativo, double prezzo) : base(tipo, modello, identificativo, prezzo)
        {

        }
    }
}
