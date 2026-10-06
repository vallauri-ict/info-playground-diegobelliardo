-- 5- Per ciascuna Assicurazione, il nome, la sede ed il numero
-- di auto assicurate
SELECT ass.Nome, ass.Sede, count(*) as AutoAssicurate
FROM Assicurazioni ass, [Auto] a
WHERE ass.Id=a.CodAss
GROUP BY ass.Id,ass.Nome, ass.Sede

-- L'assicurazione Vuota non viene fuori
-- Quindi proviamo:
SELECT ass.Nome, ass.Sede, count(a.CodAss) as AutoAssicurate
FROM Assicurazioni ass LEFT JOIN [Auto] a ON ass.Id=a.CodAss
GROUP BY ass.Id,ass.Nome, ass.Sede


-- 6- Per ciascuna auto “Fiat”, la targa dell’auto ed il numero 
-- di sinistri in cui è stata coinvolta
SELECT a.Targa, count(*) as NumeroSinistri
FROM Auto a, AutoCoinvolte ac
WHERE a.Targa=ac.Targa
AND a.Marca='Fiat'
GROUP BY a.Targa

-- Per avere tutte le auto, come la precedente
SELECT a.Targa, count(ac.CodS) as NumeroSinistri
FROM Auto a LEFT JOIN AutoCoinvolte ac ON a.Targa=ac.Targa
WHERE a.Marca='Fiat'
GROUP BY a.Targa

-- 7- Per ciascuna auto coinvolta in più di un sinistro, 
-- la targa dell’auto, il nome dell’ Assicurazione
-- ed il totale dei danni riportati
SELECT a.Targa, ass.Nome, sum(ac.ImportoDelDanno)
FROM Auto a, AutoCoinvolte ac, Assicurazioni ass
WHERE a.Targa=ac.Targa
AND ass.Id=a.CodAss
GROUP BY a.Targa, ass.Nome
HAVING count(*)>1

-- 8- CodF e Nome di coloro che possiedono più di un’auto
SELECT p.CodF, p.Nome
FROM [Auto] a, Proprietari p
WHERE p.CodF=a.CodF
GROUP BY p.CodF, p.Nome
HAVING count(*)>1

-- OPPURE
SELECT p.CodF, p.Nome
FROM Proprietari p
WHERE 1 < (SELECT count(*)
			FROM Auto a
			WHERE a.CodF=p.CodF)

-- 9- La targa delle auto che non sono state coinvolte in 
-- sinistri dopo il 20/01/01
SELECT a.Targa
FROM Auto a
WHERE NOT EXISTS (SELECT *
					FROM AutoCoinvolte ac, Sinistro s
					WHERE s.CodS=ac.CodS
					AND ac.Targa=a.Targa
					AND s.Data>'2001-01-20')

-- OPPURE
SELECT a.Targa
FROM Auto a
WHERE a.Targa NOT IN (SELECT ac.Targa
						FROM AutoCoinvolte ac, Sinistro s
						WHERE s.CodS=ac.CodS
						AND ac.Targa=a.Targa
						AND s.Data>'2001-01-20')

-- 10- Il codice dei sinistri in cui non sono state coinvolte 
-- auto con cilindrata inferiore a 2000 cc
SELECT s.CodS
FROM Sinistro s
WHERE NOT EXISTS (SELECT *
				FROM AutoCoinvolte ac, Auto a
				WHERE a.Targa=ac.Targa
				AND ac.CodS=s.CodS
				AND a.Cilindrata<2000)

-- OPPURE
SELECT s.CodS
FROM Sinistro s
WHERE 2000<= ALL (SELECT a.Cilindrata
				FROM AutoCoinvolte ac, Auto a
				WHERE a.Targa=ac.Targa
				AND ac.CodS=s.CodS)