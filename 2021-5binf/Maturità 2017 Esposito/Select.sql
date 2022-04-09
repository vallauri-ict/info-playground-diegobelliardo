SELECT a.nome, v.costo, a.datiAuto, v.ora
FROM Viaggio v, Autisti a
WHERE v.idAutista = a.id_Autista 
AND v.cittaArrivo = 'Alba'
AND v.cittaPartenza = 'Savigliano'
AND v.data = '2022-04-02'
AND v.isPrenotabile = 1
ORDER BY 4

SELECT pas.email, pas.cognome, pas.nome
FROM Prenotazioni p, Passeggeri pas
WHERE p.stato = 1 
AND p.id_Utente = pas.id_Utente

SELECT p.nome, p.cognome, AVG(fp.voto) AS average
FROM Passeggeri p, FeedbackAutista fp, Viaggio v, Prenotazioni pren
WHERE p.id_Utente = fp.idUtente
AND v.id_Viaggio = pren.id_Viaggio
AND pren.id_Utente = p.id_Utente
AND v.id_Viaggio = 1
GROUP BY p.nome, p.cognome
HAVING AVG(fp.voto) > 1