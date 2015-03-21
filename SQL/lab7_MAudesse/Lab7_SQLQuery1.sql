BEGIN TRAN
SELECT * FROM DEPARTMENT;
GO
UPDATE DEPARTMENT
SET	 BudgetCode = 'BC-100-05'
WHERE DepartmentName = 'Administration'
GO
SELECT * FROM DEPARTMENT;
COMMIT
GO
BEGIN TRAN
UPDATE ASSIGNMENT
SET EmployeeNumber = 7, HoursWorked = 65
WHERE ProjectID = 1000 AND EmployeeNumber = 8;
COMMIT

SELECT A.EmployeeNumber AS [Emp ID],
	(E.FirstName + E.LastName) AS [Employee Name],
	A.HoursWorked AS [Hours worked], A.ProjectID AS [Project ID]
FROM EMPLOYEE E, ASSIGNMENT A
WHERE E.EmployeeNumber = A.EmployeeNumber 

SELECT Department, COUNT(Department) AS NumberOfDepartments
FROM PROJECT
GROUP BY Department

SELECT E.EmployeeNumber, FirstName, LastName, HoursWorked
FROM EMPLOYEE E, ASSIGNMENT A 
WHERE  HoursWorked > 50 AND E.EmployeeNumber = A.EmployeeNumber 
ORDER BY E.EmployeeNumber;

SELECT A.ProjectID, E.FirstName, E.LastName, A.HoursWorked
FROM EMPLOYEE E, ASSIGNMENT A
WHERE E.EmployeeNumber = A.EmployeeNumber
ORDER BY A.ProjectID;

SELECT  E.Department AS [DepartmentName], E.FirstName, E.LastName, A.ProjectID
FROM EMPLOYEE E, ASSIGNMENT A
WHERE E.EmployeeNumber = A.EmployeeNumber
ORDER BY E.Department

SELECT P.ProjectID, P.ProjectName, A.EmployeeNumber, E.FirstName, E.LastName 
FROM PROJECT P, ASSIGNMENT A, EMPLOYEE E
WHERE P.ProjectID = A.ProjectID
	AND E.EmployeeNumber = A.EmployeeNumber
ORDER BY P.ProjectID

SELECT A.EmployeeNumber, P.ProjectID, P.Department, P.ProjectName, A.HoursWorked, P.MaxHours
FROM ASSIGNMENT A, PROJECT P
WHERE A.ProjectID = P.ProjectID
ORDER BY P.ProjectID