SELECT *
FROM VenditeInternet;

SELECT *
FROM VenditeNegozio;

SELECT i.DataVendita, i.Importo
FROM VenditeInternet i
UNION
SELECT n.DataVendita,n.Importo
FROM VenditeNegozio n
ORDER BY DataVendita;

SELECT i.DataVendita
FROM VenditeInternet i
INTERSECT
SELECT n.DataVendita
FROM VenditeNegozio n
ORDER BY DataVendita;

SELECT *
FROM VenditeInternet;

SELECT *
FROM VenditeNegozio;

SELECT n.DataVendita
FROM VenditeNegozio n
EXCEPT    -- MINUS per altri DB
SELECT i.DataVendita
FROM VenditeInternet i
ORDER BY DataVendita;

SELECT i.DataVenditaI as DataV
FROM VenditeInternet i
UNION
SELECT n.DataVendita as DataV
FROM VenditeNegozio n
ORDER BY DataV;