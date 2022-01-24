SELECT Data
from VenditeInternet
EXCEPT
SELECT Data
from VenditeNegozio
ORDER BY Data desc