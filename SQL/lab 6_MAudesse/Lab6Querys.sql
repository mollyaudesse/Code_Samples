--1.Display all fields from the DEPARTMENT table. 
SELECT * FROM dbo.DEPARTMENT;
GO

--2.Display all fields from the ASSIGNMENT table. 
SELECT * FROM dbo.ASSIGNMENT;
GO

--3.Display all fields from the EMPLOYEE table. 
SELECT * FROM dbo.EMPLOYEE;
GO

--4.Display all fields from the PROJECT table. 
SELECT * FROM dbo.PROJECT;
GO

--5.Display all the fields from the DEPARTMENT table. Use field names. 
SELECT		DepartmentName, BudgetCode, OfficeNumber, Phone
FROM		DEPARTMENT;
GO

--6.Display all the fields from the PROJECT	 table. Using wild card. 
SELECT		*
FROM		PROJECT P
WHERE		Department = 'Finance';
GO

--7.Display all the fields from the PROJECT table. Using wild card. 
SELECT		*
FROM		PROJECT
WHERE		MaxHours > 135;
GO

--8.Display all the fields from the PROJECT table. For projects from the fianace department when max hours are greater than 135.
SELECT		*
FROM		PROJECT
WHERE		Department = 'Finance'
	and			MaxHours > 135;
GO

--9.Display all except email and employee number from EMPLOYEE table. Use field names.
SELECT		FirstName, LastName, Phone, Department
FROM		EMPLOYEE
WHERE		Phone = '360-285-8310';
GO


--10.Display all employees who are in Accounting, Finance and Marketing. Show use of ‘IN’ keyword.
SELECT		FirstName, LastName, Phone, Department
FROM		EMPLOYEE
WHERE		Department IN ('Accounting', 'Finance', 'Marketing');
GO

--11.Display all employees who are NOT in Accounting, Finance and Marketing. Show use of ‘IN’ and ‘NOT’ keywords.
SELECT		FirstName, LastName, Phone, Department
FROM		EMPLOYEE
WHERE		Department NOT IN ('Accounting', 'Finance', 'Marketing');
GO

--12.Display  all employees whose Employee ID is between 2 and 5. Display all the fields. Show use of ‘Between’ keyword.
SELECT		*
FROM		EMPLOYEE
WHERE		EmployeeNumber BETWEEN 2 AND 5;
GO

--13.Display all employees whose Employee ID is NOT between 2 and 5. Display all the fields. Show use of ‘NOT’ and ‘Between’ keywords.
SELECT		*
FROM		EMPLOYEE	
WHERE		EmployeeNumber NOT BETWEEN 2 AND 5;
GO

--14.Display all employees whose Employee ID is between 2 and 5. Display all the fields. Do not use ‘Between’ keyword.
SELECT		*
FROM		EMPLOYEE	
WHERE		EmployeeNumber >= 2
	AND		EmployeeNumber <=5;
GO

--15.Display all employees whose phone numbers start with ‘360-287-‘. Display all the fields Show use of ‘_’ wildcard. 
SELECT		*
FROM		EMPLOYEE
WHERE		Phone LIKE '360-287-____';
GO

--16.Display all employees whose phone numbers start with ‘360-287-‘. Display all the fields Show use of ‘%’ wildcard. 
SELECT		*
FROM		EMPLOYEE
WHERE		PHONE LIKE '360-287-%';
GO

--17.Display all employees whose phone numbers are NULL. Display all the fields.
SELECT		*
FROM		EMPLOYEE
WHERE		Phone IS NULL;
GO

--18.Display all employees whose phone numbers are NOT NULL. Display all the fields.
SELECT		*
FROM		EMPLOYEE
WHERE		Phone IS NOT NULL;
GO

--19.Display all employees such that Department and Lastname are both sorted in descending order.
SELECT		*
FROM		EMPLOYEE
ORDER BY	Department DESC, LastName DESC;
GO

