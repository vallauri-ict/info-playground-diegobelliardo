# 03-EsTrigger

_Prof. Diego Belliardo_


### Esercizio sull'uso dei Trigger:

Data la seguente tabella:

CREATE TABLE [Driver] (
    [number] int PRIMARY KEY,
    [full_name] varchar(100),
    [country] char(2) NOT NULL,
    [date_birth] date,
    [team_id] int,
    [podiums_number] int,
    [helmet_image] image,
    [full_image] image
);

- Realizzare un trigger che salvi in una seconda tabella StoricoCancellazioni tutti i dati di eventuali
record cancellati con in aggiunta anche la data e ora.
- Realizzare un secondo trigger che salvi in una terza tabella StoricoAggiornamenti tutte le update
effettuate, riportando solo i campi modificati (con indicazione del dato prima della modifica e del
dato aggiornato) con in aggiunta anche la data e ora dell’update.
- Realizzare un programma C# che permetta di visualizzare tutti i dati all’interno della tabella Driver e
che permetta anche di effettuare inserimenti e aggiornamenti dei record. Nella stessa form si dovrà
andar a visualizzare anche le tabelle “Storico”
