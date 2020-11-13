# 07-Form di registrazione

_Prof. Diego Belliardo_


### Esercizio su RegEx

Form di registrazione:
cognome
nome
indirizzo
città
cap (5 caratteri numerici)
mail (formato mail)
cod fisc (formato corretto)
user
pwd (almeno 8 caratteri con almeno 1 numero e almeno 1 maiuscola)
al click sul pulsante registra se è tutto ok allora salvo i dati su un file in formato json

INTEGRAZIONE:
- per creare la stringa in formato Json utilizzare l’override del metodo ToString()
- creare una classe Utenti istanziabile una volta sola (singleton) contenente una Lista che viene
valorizzata con i dati contenuti nel file.
o Le nuove registrazioni possono avvenire solo se l’utente (campo user) non è presente nella
lista
o Consiglio: per realizzare il punto precedente costruire un metodo bool presente() che
ricerca se lo user esiste già e restituisce un bool