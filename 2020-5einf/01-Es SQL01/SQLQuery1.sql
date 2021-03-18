/*SELECT f.Titolo
FROM Film f 
WHERE 'Mastroianni' IN (SELECT a.Nome
FROM Attori a, Recita r
WHERE r.CodFilm=f.CodFilm
AND r.CodAttore=a.CodAttore)
AND 'Loren' IN (SELECT a.Nome
FROM Attori a, Recita r
WHERE r.CodFilm=f.CodFilm
AND r.CodAttore=a.CodAttore)*/

--15
/*SELECT s.Citta, count(*)
FROM Sale s
GROUP BY s.Citta
*/

--16
/*SELECT s.Citta, count(*) as Numero_sale
FROM Sale s
WHERE s.Posti>60
GROUP BY s.Citta*/

--17 per ogni regista il numero di film diretti dopo 1990
/*SELECT f.Regista, count(*)
FROM Film f
WHERE f.AnnoProduzione>1990
GROUP BY f.Regista*/

--18 per ogni regista l'incasso totale di tutte le proiezioni dei suoi film
/*SELECT f.Regista, sum(p.Incasso) as Totale_incasso
FROM Film f, Proiezioni p
WHERE p.CodFilm=f.CodFilm
GROUP BY f.Regista*/

--19 per ogni film di X il numero totale di proiezioni a Pisa e l'incasso totale (sempre a Pisa)
/*SELECT f.Titolo, COUNT(*) as NumeroProiezioni, sum(p.Incasso) as IncassoTotale
FROM Film f, Proiezioni p, Sale s
WHERE f.CodFilm=p.CodFilm
AND s.CodSala=p.CodSala
AND s.Citta='Pisa'
AND f.Regista='Spielberg'
GROUP BY f.CodFilm, f.Titolo*/

--20 per ogni regista e per ogni attore, il numero d film del regista con l'attore
/*SELECT f.Regista, a.Nome, count(*) as NumeroFilm
FROM Film f, Attori a, Recita r
WHERE r.CodFilm=f.CodFilm
AND r.CodAttore=a.CodAttore
GROUP BY f.Regista, a.CodAttore, a.Nome*/

--21 il regista ed il titolo dei film in cui recitano meno di 6 attori
/*SELECT f.Regista, f.Titolo
FROM Film f, Recita r
WHERE r.CodFilm=f.CodFilm
GROUP BY f.CodFilm,f.Regista, f.Titolo
HAVING count(*)<6*/

--26 per ogni film di fantascenza che non è mai stato proiettato primna dell'01/01/01 il titolo e l'incasso totale di tutte le proiezioni
/*SELECT f.titolo
FROM Film f, Proiezioni p
WHERE p.CodFilm=f.CodFilm
AND f.Genere='Fantascienza'
GROUP BY f.CodFilm, f.titolo
HAVING min(p.DataProiezione)>=Cast('2001-01-01' as Date);*/

--26 per ogni film di fantascenza che non è mai stato proiettato primna dell'01/01/01 il titolo e l'incasso totale di tutte le proiezioni
/*SELECT f.titolo, sum(p.Incasso) as IncassoTotale
FROM Film f, Proiezioni p
WHERE p.CodFilm=f.CodFilm
AND f.Genere='Fantascienza'
GROUP BY f.CodFilm, f.titolo
HAVING min(p.DataProiezione)>=Cast('2001-01-01' as Date);*/

--30 I titoli dei film dei quali non vi è mai stata una proiezione con incasso superiore a 500 €
/*SELECT *
FROM Film f
WHERE Not exists (SELECT * FROM Proiezioni p
WHERE p.CodFilm=f.CodFilm
AND p.Incasso>500)

SELECT *
FROM Film f
WHERE 500 >= All(SELECT p.Incasso FROM Proiezioni p
WHERE p.CodFilm=f.CodFilm)*/

--I titoli dei film le cui proiezioni hanno sempre ottenuto un incasso superiore a 500 €
/*SELECT *
FROM Film f
WHERE Not exists (SELECT * FROM Proiezioni p
WHERE p.Incasso<=500 
AND p.CodFilm=f.CodFilm)*/

--Il nome degli attori italiani che non hanno mai recitato in film di Fellini
/*SELECT *
FROM Attori	a
WHERE a.Nazionalita='Italia'
AND not exists (SELECT * FROM Film f, Recita r
WHERE r.CodFilm=f.CodFilm
AND a.CodAttore=r.CodAttore
AND f.Regista='Fellini')*/

--33 Il titolo dei film di Fellini in cui non recitano attori italiani
/*SELECT *
FROM Film f
WHERE f.Regista='Fellini'
AND not exists (SELECT * FROM
Attori a, Recita r
WHERE f.CodFilm=r.CodFilm
AND r.CodAttore=a.CodAttore
AND a.Nazionalita='Italia')*/

--34 Il titolo dei film senza attori
/*SELECT *
FROM Film f
WHERE not exists (SELECT * FROM Recita r
WHERE r.CodFilm=f.CodFilm) */

--35 Gli attori che prima del 1960 (Anno produzione) hanno recitato solo nei film di Fellini
/*SELECT *
FROM Attori a
WHERE not exists (SELECT * FROM Film f, Recita r
WHERE a.CodAttore=r.CodAttore
AND f.CodFilm=r.CodFilm
AND f.AnnoProduzione < 1960
AND f.Regista<>'Fellini')*/

--36 Gli attori che hanno recitato in film di Fellini solo prima del 1960
SELECT *
FROM Attori	a
WHERE not exists (SELECT * FROM Film f, Recita r
WHERE a.CodAttore=r.CodAttore
AND f.CodFilm=r.CodFilm
AND f.AnnoProduzione>1960
AND f.Regista='Fellini')