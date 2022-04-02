SELECT a.nome, v.costo, a.datiAuto,v.ora
FROM Viaggio v, Autisti a
Where v.idAutista=a.id_Autista 
and v.cittaArrivo='Alba'
and v.cittaPartenza='Savigliano'
and v.data = '2022-04-02'
and v.isPrenotabile = 1
order by v.ora

SELECT pas.email, pas.cognome, pas.nome
FROM Prenotazioni p, Passeggeri pas
where p.stato = 1 
and p.id_Utente = pas.id_Utente

SELECT *
FROM Passeggeri p, FeedbackAutista fp, Viaggio v, Prenotazioni pren
where p.id_Utente = fp.idUtente
and v.id_Viaggio = pren.id_Viaggio
and pren.id_Utente= p.id_Utente
and v.id_Viaggio =1
and 8<(select AVG(fa.voto) from FeedbackAutista fa where fa.idUtente=p.id_Utente)

