--Lab 9 
--Molly Audesse 
--Section 5

SELECT * FROM CONTACT;
SELECT * FROM CUSTOMER;
SELECT * FROM INVOICE;
SELECT * FROM LINE_ITEM;
SELECT * FROM PRODUCT;
SELECT * FROM SEMINAR;
SELECT * FROM SEMINAR_CUSTOMER;


--Question E
SELECT	LastName, FirstName, Phone
FROM	CUSTOMER
WHERE	City = 'Dallas';
GO

--Question F
SELECT	LastName, FirstName, Phone
FROM	CUSTOMER
WHERE	City = 'Dallas'
	AND		LastName LIKE 'T%';

--Question G
SELECT	InvoiceNumber
FROM	LINE_ITEM
WHERE	ProductNumber in	
		(SELECT ProductNumber
		FROM	PRODUCT
		WHERE	PRODUCT.Description=
				'Heather Sweeney Seminar Live in Dallas on 25-OCT-09 -Video');

SELECT	InvoiceNumber
FROM	INVOICE
WHERE	InvoiceNumber IN
		(SELECT	InvoiceNumber
		FROM	LINE_ITEM
		WHERE	ProductNumber in
				(SELECT ProductNumber
				FROM	PRODUCT
				WHERE	PRODUCT.Description=
						'Heather Sweeney Seminar Live in Dallas on 25-OCT-09 -Video'));


--Question H
SELECT	LI.InvoiceNumber
FROM	LINE_ITEM AS LI, PRODUCT AS P
WHERE	LI.ProductNumber = P.ProductNumber
	AND	P.Description ='Heather Sweeney Seminar Live in Dallas on 25-OCT-09 -Video';

SELECT	I.InvoiceNumber
FROM	INVOICE AS I, LINE_ITEM AS LI, PRODUCT AS P
WHERE	I.InvoiceNumber = LI.InvoiceNumber
	AND	LI.ProductNumber = P.ProductNumber
	AND	P.Description= 'Heather Sweeney Seminar Live in Dallas on 25-OCT-09 -Video';
	

--Question I
SELECT	DISTINCT FirstName, LastName, Phone
FROM	CUSTOMER AS C, SEMINAR_CUSTOMER AS SC, SEMINAR AS S
WHERE	C.EmailAddress = SC.EmailAddress
	AND	SC.SeminarID = S.SeminarID
	AND	S.SeminarTitle = 'Kitchen on a Big D Budget'
ORDER BY LastName, FirstName;


--Question J
SELECT	DISTINCT FirstName, LastName, Phone, P.ProductNumber, P.Description
FROM	CUSTOMER AS C, INVOICE AS I, LINE_ITEM AS LI, PRODUCT AS P
WHERE	C.EmailAddress = I.EmailAddress
	AND	I.InvoiceNumber = LI.InvoiceNumber
	AND	LI.ProductNumber = P.ProductNumber
	AND P.ProductNumber LIKE 'VK%'
ORDER BY LastName, FirstName, ProductNumber;

--Question K
SELECT	SUM (SubTotal) AS SumOfSubTotal
FROM	INVOICE;

--Question L
SELECT	AVG (SubTotal) AS AverageOfSubTotal
FROM	INVOICE;

--Question M
SELECT	SUM (SubTotal) AS SumOfSubTotal,
		AVG (SubTotal) AS AverageOfSubTotal
FROM	INVOICE;

--Question N
SELECT	*
FROM	PRODUCT
WHERE	ProductNumber = 'VK004';

UPDATE	PRODUCT
	SET UnitPrice = 34.95
	WHERE	ProductNumber = 'VK004';

SELECT	*
FROM	PRODUCT
WHERE	ProductNumber = 'VK004';


--Question O
UPDATE	PRODUCT
	SET	UnitPrice = 24.95
	WHERE	ProductNumber = 'VK004';

SELECT	*
FROM	PRODUCT
WHERE	ProductNumber = 'VK004';

--Question P
DELETE	FROM LINE_ITEM
DELETE	FROM PRODUCT
DELETE	FROM INVOICE
DELETE  FROM CONTACT
DELETE	FROM SEMINAR_CUSTOMER
DELETE	FROM SEMINAR
DELETE	FROM CUSTOMER
