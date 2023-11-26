using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneLinq4
{
    internal class Utente
    {
        public string username { get; set; }
        private string password { get; set; }
        public Carrello carrello { get; set; }

        public Utente(string username, string password, Carrello carrello)
        {
            this.username = username;
            this.password = password;
            this.carrello = carrello;
        }
    }
}
