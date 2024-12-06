using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    class ProdottoElettronico : Prodotto
    {
        public ProdottoElettronico(string tipo, string modello, string identificativo, double prezzo) : base(tipo, modello, identificativo, prezzo)
        {

        }
    }
}
