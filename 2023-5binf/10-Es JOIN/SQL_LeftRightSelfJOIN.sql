select *
from Studenti s, Voti v
WHERE s.matricola=v.matricola

select *
from Studenti s LEFT JOIN Voti v ON s.matricola=v.matricola

select *
from Voti v RIGHT JOIN Studenti s ON s.matricola=v.matricola

select *
from Studenti s LEFT JOIN Voti v ON s.matricola=v.matricola
where v.matricola is null

select g1.genitore AS Nonni
from Genitori g1, Genitori g2
where g1.figlio=g2.genitore
AND g2.figlio='Anna'