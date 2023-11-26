using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneLinq4
{
    internal class Carrello
    {
        public List<Prodotto> prodotti {  get; set; } = new List<Prodotto>();

        public void aggiungiProdotto(Prodotto prodotto) {
            Prodotto prodottoTrovato = prodotti.Find(x => x.codice == prodotto.codice);
            if (prodottoTrovato == null)
            {
                prodotti.Add(prodotto);
            }
            else 
            {
                prodottoTrovato.quantita++;
            }
        }
        public void eliminaProdotto(int codiceProdotto) 
        {
            Prodotto prodottoTrovato = prodotti.Find(x => x.codice == codiceProdotto);
            if (prodottoTrovato != null) 
            {
                prodotti.Remove(prodottoTrovato);
            }
        }
        public void modificaProdotto(int codiceProdotto,string descrizione, decimal prezzo) 
        { 
            Prodotto prodottoTrovato = prodotti.Find(x => x.codice == codiceProdotto);
            if (prodottoTrovato != null) 
            {
                prodottoTrovato.descrizione = descrizione;
                prodottoTrovato.prezzo = prezzo;

            }
        }
        public void calcolaTotale()
        {
            decimal totale = 0;
            foreach (Prodotto p in prodotti) 
            {
                totale += ((p.prezzo - (p.prezzo * p.sconto) / 100) * p.quantita);
            }
            Console.WriteLine($"Totale: {totale} euro");
        }
        public void stampaCarrello() 
        {
            foreach (Prodotto p in prodotti) 
            {
                Console.WriteLine($"{p.codice} | {p.descrizione} | {p.quantita} | {(p.prezzo - (p.prezzo * p.sconto) / 100) * p.quantita}");
            }
            calcolaTotale();
        }
    }
}
