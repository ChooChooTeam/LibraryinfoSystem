SELECT * FROM circuBookClass
WHERE isbn in 
(
	SELECT DISTINCT isbn FROM circuBook
)