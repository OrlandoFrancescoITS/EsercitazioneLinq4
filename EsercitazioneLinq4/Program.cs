using EsercitazioneLinq4;

Carrello carrelloUtente1 = new Carrello();
Utente utente1 = new Utente("franco","passwordsicura",carrelloUtente1);

Prodotto telefono = new Prodotto(101, "Smartphone Android", 250, 1, 10);

carrelloUtente1.aggiungiProdotto(telefono);

Prodotto cuffie = new Prodotto(102, "Cuffie Bluetooth 5.2", 20, 1, 0);

carrelloUtente1.aggiungiProdotto(cuffie);
carrelloUtente1.eliminaProdotto(104);
carrelloUtente1.modificaProdotto(101, "Smartphone Android", 350);
carrelloUtente1.calcolaTotale();
carrelloUtente1.stampaCarrello();

// utente1.carrello.stampaCarrello();