# 03-EsTrigger fatto Assieme

_Prof. Diego Belliardo_


### Esercizio sull'uso dei Trigger:

CREATE TABLE [Cliente] (
[IdCliente] int,
[Nome] varchar(50),
[Cognome] varchar(50),
[IdCarrello] int,
PRIMARY KEY ([IdCliente])
);

- Realizzare un trigger che salvi in una seconda tabella StoricoCancellazioni tutti i dati
di eventuali record cancellati con in aggiunta anche la data e ora.
- Realizzare un secondo trigger che salvi in una struttura di tabelle realizzata a vostro
piacimento tutte le update effettuate, riportando solo i campi modificati (con
indicazione del dato prima della modifica e del dato aggiornato) con in aggiunta
anche la data e ora dell’update.
- Realizzare un programma C# che permetta di visualizzare tutti i dati all’interno
della tabella Cliente e che permetta anche di effettuare aggiornamenti e
cancellazione dei record presenti. Nella stessa form si dovrà andar a visualizzare
anche le tabelle “Storico”