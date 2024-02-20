select v.data
from VenditeNegozio v
UNION
select v.data
from VenditeInternet v

select v.data
from VenditeInternet v
UNION
select v.data
from VenditeNegozio v
order by v.data desc

select v.data
from VenditeNegozio v
INTERSECT
select v.data
from VenditeInternet v

select N.data
from VenditeNegozio N
except
select I.data
from VenditeInternet I