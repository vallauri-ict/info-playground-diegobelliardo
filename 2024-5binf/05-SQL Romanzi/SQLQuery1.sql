--1- Il titolo dei romanzi del 19° secolo
--2- Il titolo, l’autore e l’anno di pubblicazione dei romanzi di autori russi, ordinati per autore e, per
--lo stesso autore, ordinati per anno di pubblicazione
--3- I personaggi principali (ruolo =”P”) dei romanzi di autori viventi.
--4. I romanzi dai quali è stato tratto un film con lo stesso titolo 
--del romanzo
--5- Il titolo, il regista e l’anno dei film tratti dal romanzo 
--“Robin Hood”


--6- Per ogni autore italiano, l’anno del primo e dell’ultimo romanzo.
SELECT a.nomeAutore, min(r.anno) AS AnnoPrimoR, max(r.anno) AS AnnoUltimoR
FROM romanzi r, autori a
WHERE r.nomeA=a.nomeAutore
AND a.nazione='Italia'
GROUP BY a.nomeAutore

--7- I nomi dei personaggi che compaiono in più di un romanzo, ed il 
--numero dei romanzi nei quali compaiono
SELECT p.nomeP, count(*) AS Num
FROM personaggi p
GROUP BY p.nomeP
having count(*) > 1

--8- I romanzi di autori italiani dai quali è stato tratto più di un film
--9- Il titolo dei romanzi dai quali non è stato tratto un film
--10- Il titolo dei romanzi i cui personaggi principali son tutti femminili.