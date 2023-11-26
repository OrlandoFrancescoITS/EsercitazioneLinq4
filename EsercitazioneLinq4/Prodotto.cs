using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneLinq4
{
    internal class Prodotto
    {
        public int codice { get; set; }
        public string descrizione { get; set; }
        public decimal prezzo { get; set; }
        public int quantita { get; set; }
        public decimal sconto { get; set; }

        public Prodotto(int codice, string descrizione, decimal prezzo, int quantita, decimal sconto)
        {
            this.codice = codice;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.quantita = quantita;
            this.sconto = sconto;
        }
    }
}
