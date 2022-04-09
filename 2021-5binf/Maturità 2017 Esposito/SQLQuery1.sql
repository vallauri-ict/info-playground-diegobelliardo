SELECT a.id_Autista, a.nome as nomeAutista, a.cognome as cognomeAutista, v.costo, v.cittaPartenza, v.cittaArrivo, v.[data], p.nome as nomePasseggero, p.cognome as cognomePasseggero 
FROM Viaggio v, Autisti a, Passeggeri p, Prenotazioni pr 
WHERE v.idAutista = a.id_Autista 
AND pr.id_Viaggio = v.id_Viaggio 
AND pr.id_Utente = p.id_Utente 
AND v.isPrenotabile = 1
AND a.id_Autista = 2
ORDER BY v.[data];