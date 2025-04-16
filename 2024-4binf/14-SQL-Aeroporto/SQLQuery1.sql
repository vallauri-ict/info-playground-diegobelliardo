--- Trovare le città da cui partono voli diretti a Roma,
--ordinate alfabeticamente- 
SELECT v.CittàPart
FROM VOLO v
WHERE v.CittàArr = 'roma'
ORDER BY v.CittàPart;

--- Trovare le città con un aeroporto di cui non è noto il numero di piste
SELECT c.Città
FROM AEROPORTO c
WHERE c.NumPiste IS NULL

--- Di ogni volo misto (merci e passeggeri)
--estrarre il codice e i dati relativi al trasporto
SELECT v.IdVolo, a.*
FROM AEREO a, VOLO v
WHERE a.NumPasseggeri is not null
AND a.QtaMerci is not null
AND v.TipoAereo = a.TipoAereo

