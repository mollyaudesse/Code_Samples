USE Lab8_GG_DB 
GO
--D
SELECT * FROM [OWNER] O;
SELECT * FROM [PROPERTY] P;
SELECT * FROM [EMPLOYEE] E;
SELECT * FROM [SERVICE] S;

--STEP E
SELECT E.FirstName, E.LastName, E.CellPhone
FROM EMPLOYEE E
WHERE E.ExperienceLevel = 'Master';

--STEP F
SELECT E.FirstName, E.LastName, E.CellPhone
FROM EMPLOYEE E 
WHERE E.ExperienceLevel = 'Master'
	AND E.FirstName LIKE ('J%')
GO

--STEP G
SELECT P.PropertyID
FROM [PROPERTY] P
WHERE P.[STATE] = 'NY';
GO
--STEP G PART 2
SELECT  DISTINCT S.EmployeeID
FROM [SERVICE] S
WHERE S.PropertyID IN (5,8);

--STEP G PART 3
SELECT E.FirstName, E.LastName
FROM EMPLOYEE E
WHERE E.EMPLOYEEID in (4);
GO

--STEP G PART 4
SELECT DISTINCT S.EmployeeID
FROM [SERVICE] S
WHERE S.PropertyID IN
	(SELECT P.PropertyID FROM [PROPERTY] P WHERE P.[STATE] = 'NY')
GO

--STEP G PART 5
SELECT E.FirstName, E.LastName
FROM EMPLOYEE E
WHERE EmployeeID IN
		(SELECT DISTINCT  S.EmployeeID
		FROM			  [SERVICE] S
		WHERE			  S.PropertyID IN
			(SELECT		  P.PropertyID
			FROM          [PROPERTY] P
			WHERE		  P.[State] = 'NY'));
GO

--STEP G PART 6
SELECT FirstName, LastName
FROM   EMPLOYEE
WHERE  EmployeeID IN
			(SELECT PropertyID 
			FROM	PROPERTY
			WHERE	State = 'WA'));
GO

--STEP H
SELECT DISTINCT LastName, FirstName
FROM	EMPLOYEE, SERVICE, PROPERTY
WHERE	EMPLOYEE.EmployeeID = SERVICE.EmployeeID
	AND SERVICE.PropertyID = PROPERTY.PropertyID
	AND State = 'NY'
GO


SELECT DISTINCT E.LastName, E.FirstName
FROM	[EMPLOYEE] E, [SERVICE] S, [PROPERTY] P
WHERE	E.EmployeeID = S.EmployeeID AND S.PropertyID = P.PropertyID
				AND State = 'WA'
GO

SELECT DISTINCT E.FirstName, E.LastName
FROM [SERVICE] S
	JOIN EMPLOYEE AS E ON S.EmployeeID = E.EmployeeID
	JOIN [PROPERTY] AS P ON S.PropertyID = P.PropertyID
WHERE P.[State] = 'WA';
GO

SELECT DISTINCT LastName, FirstName
FROM			EMPLOYEE, SERVICE, PROPERTY
WHERE			EMPLOYEE.EmployeeID = SERVICE.EmployeeID
		AND Service.PropertyID = PROPERTY.PropertyID
		AND State = 'WA';
GO

--STEP I
SELECT	LastName, FirstName
FROM	EMPLOYEE
WHERE	EmployeeID IN
		(SELECT EmployeeID
		FROM	SERVICE
		WHERE	OwnerID IN
				(SELECT OwnerID
				FROM	OWNER
				WHERE	Type =
					'Corporation')));
GO

--STEP J
SELECT DISTINCT E.LastName, E.FirstName
FROM			EMPLOYEE E, [SERVICE] S, PROPERTY P, [OWNER] O
WHERE			P.OwnerID = O.OwnerID
			AND P.PropertyID = S.PropertyID
			AND S.EmployeeID = E.EmployeeID
			AND O.OwnerType = 'Corporation';
GO

SELECT DISTINCT E.LastName, E.FirstName
FROM			EMPLOYEE E
			JOIN [SERVICE] S ON E.EmployeeID = S.EmployeeID
			JOIN [PROPERTY] P ON S.PropertyID = P.PropertyID
			JOIN [OWNER] O ON P.OwnerID = O.OwnerID
			AND O.OwnerType = 'Corporation';
GO

--STEP K
SELECT		E.LastName, E.FirstName, SUM (S.HoursWorked) AS [Total Hours Worked]
FROM		EMPLOYEE E, [SERVICE] S
WHERE		E.EmployeeID = S.EmployeeID
GROUP BY	E.LastName, E.FirstName;
GO

--STEP L
SELECT		E.ExperiencedLevel, SUM (S.HoursWorked) AS [Total Hours Worked]
FROM		EMPLOYEE E, [SERVICE] S
WHERE		E.EmployeeID = S.EmployeeID
GROUP BY	E.ExperienceLevel
ORDER BY	E.ExperienceLevel DESC;
GO

--STEP M
SELECT		O.OwnerType, SUM(HoursWorked) AS TotalHoursWorked
FROM		EMPLOYEE E, [SERVICE] S, PROPERTY P, [OWNER] O
WHERE		E.EmployeeID = S.EmployeeID
		AND S.PropertyID = P.PropertyID
		AND P.OwnerID = O.OwnerID
		AND ExperienceLevel <> 'Junior'
GROUP BY	O.OwnerType
HAVING		COUNT(*) > 2;
GO

--STEP N
BEGIN TRAN
SELECT * FROM EMPLOYEE;

UPDATE EMPLOYEE
	SET ExperienceLevel = 'SuperMaster'
	WHERE ExperienceLevel = 'MASTER';

SELECT * FROM EMPLOYEE;

COMMIT

--STEP O
SELECT * FROM EMPLOYEE;
UPDATE	EMPLOYEE
	SET ExperienceLevel ='temp'
	WHERE ExperienceLevel = 'Senior';
UPDATE	EMPLOYEE
	SET ExperienceLevel = 'Senior'
	WHERE ExperienceLevel = 'Junior';
UPDATE	EMPLOYEE
	SET ExperienceLevel = 'Junior'
	WHERE	ExperienceLevel = 'temp';
SELECT * FROM EMPLOYEE;

--STEP P
DELETE FROM SERVICE;
DELETE FROM EMPLOYEE;
DELETE FROM PROPERTY;
DELETE FROM OWNER;



