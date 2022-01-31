INSERT INTO Driver VALUES(1, 'Pippo Pluto', 'IT', '2000-1-1', 1, 23);

UPDATE Driver SET full_name = 'Pluto Pippo', country = 'UK', date_birth = '2000-1-2', team_id = 2, podiums_number = 30 WHERE number = 1;

DELETE FROM Driver WHERE number = 1;