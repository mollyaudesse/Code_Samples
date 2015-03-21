-- Molly Audesse
-- IT140 Section 5

USE master;
GO

IF EXISTS(SELECT name FROM sys.databases WHERE name = 'Lab6')
     DROP DATABASE Lab6
GO

CREATE DATABASE Lab7;
GO

USE Lab7;
GO

--2. Add four tables to your database. The 2 tables and field names are listed below. You have 
--   to add the other two tables. You have to create 2 more tables. See Figure 3.7 of the
--   textbook (page 123).

CREATE  TABLE DEPARTMENT(
	DepartmentName	Char(35)		NOT NULL,
	BudgetCode		Char(30)		NOT NULL,
	OfficeNumber	Char(15)		NOT NULL,
	Phone			Char(12)		NOT NULL,
	CONSTRAINT 		DEPARTMENT_PK 	PRIMARY KEY(DepartmentName)
	); 

CREATE  TABLE EMPLOYEE(
	EmployeeNumber	Int 			NOT NULL IDENTITY (1, 1),
	FirstName		Char(25) 		NOT NULL,
	LastName        Char(25) 		NOT NULL,
	Department		Char(35)		NOT NULL DEFAULT 'Human Resources',
	Phone			Char(12)		NULL,
	Email 			VarChar(100)	NOT NULL UNIQUE,
	CONSTRAINT 		EMPLOYEE_PK 	PRIMARY KEY(EmployeeNumber),
	CONSTRAINT 		EMP_DEPART_FK	FOREIGN KEY(Department)
							REFERENCES DEPARTMENT(DepartmentName)
								ON UPDATE CASCADE
	);

CREATE	TABLE PROJECT(
	ProjectID		Int				NOT NULL IDENTITY (1000, 100),
	ProjectName		Char (50)		NOT NULL,
	Department		Char(35)		NOT NULL,
	MaxHours		Numeric(8,2)	NOT NULL DEFAULT 100,
	StartDate		Date			NULL,
	EndDate			Date			NULL,
	CONSTRAINT		PROJECT_PK		PRIMARY KEY (ProjectID),
	CONSTRAINT		PROJ_DEPART_FK	FOREIGN KEY(Department)
							REFERENCES DEPARTMENT(DepartmentName)
								ON UPDATE CASCADE 
	);

CREATE	TABLE ASSIGNMENT(
	ProjectID		Int				NOT NULL,
	EmployeeNumber	Int				NOT NULL,
	HoursWorked		Numeric(6,2)	NULL,
	CONSTRAINT		ASSIGNMENT_PK	PRIMARY KEY (ProjectID, EmployeeNumber),
	CONSTRAINT		ASSIGN_PROJ_FK	FOREIGN KEY (ProjectID)
						REFERENCES PROJECT(ProjectID)
						ON UPDATE NO ACTION
						ON DELETE CASCADE,
	CONSTRAINT		ASSIGN_EMP_FK	FOREIGN KEY (EmployeeNumber)	
						REFERENCES EMPLOYEE(EmployeeNumber)
						ON UPDATE NO ACTION
						ON DELETE CASCADE

	);


-- *********************************************************
	-- You have to add two tables yourself. Chapter 2
-- *********************************************************

--3. Insert data into the tables 
/*****   DEPARTMENT DATA   ******************************************************/

INSERT INTO DEPARTMENT VALUES('Administration', 'BC-100-10', 'BLDG01-300', '360-285-8100');
INSERT INTO DEPARTMENT VALUES('Legal', 'BC-200-10', 'BLDG01-200', '360-285-8200');
INSERT INTO DEPARTMENT VALUES('Accounting', 'BC-300-10', 'BLDG01-100', '360-285-8300');
INSERT INTO DEPARTMENT VALUES('Finance', 'BC-400-10', 'BLDG01-140', '360-285-8400');
INSERT INTO DEPARTMENT VALUES('Human Resources', 'BC-500-10', 'BLDG01-180', '360-285-8500');
INSERT INTO DEPARTMENT VALUES('Production', 'BC-600-10', 'BLDG02-100', '360-287-8600');
INSERT INTO DEPARTMENT VALUES('Marketing', 'BC-700-10', 'BLDG02-200', '360-287-8700');
INSERT INTO DEPARTMENT VALUES('InfoSystems', 'BC-800-10', 'BLDG02-270', '360-287-8800');

/*****   EMPLOYEE DATA   ********************************************************/

INSERT INTO EMPLOYEE VALUES(
	'Mary', 'Jacobs', 'Administration', '360-285-8110', 'MJacobs@WPC.com');
INSERT INTO EMPLOYEE VALUES(
	'Rosalie', 'Jackson', 'Administration', '360-285-8120', 'RJackson@WPC.com');
INSERT INTO EMPLOYEE VALUES(
	'Richard', 'Bandalone', 'Legal', '360-285-8210', 'RBanalone@WPC.com');
INSERT INTO EMPLOYEE VALUES(
	'Tom', 'Caruthers', 'Accounting', '360-285-8310', 'TCaruthers@WPC.com');
INSERT INTO EMPLOYEE VALUES(
	'Heather', 'Jones', 'Accounting', '360-285-8320', 'HJones@WPC.com');
INSERT INTO EMPLOYEE VALUES(
	'Mary', 'Abernathy', 'Finance', '360-285-8410', 'MAbernathy@WPC.com');
INSERT INTO EMPLOYEE VALUES(
	'George', 'Smith', 'Human Resources', '360-285-8510', 'GSmith@WPC.com');
INSERT INTO EMPLOYEE VALUES(
	'Tom', 'Jackson', 'Production', '360-287-8610', 'TJackson@WPC.com');
INSERT INTO EMPLOYEE VALUES(
	'George', 'Jones', 'Production', '360-287-8620', 'GJones@WPC.com');
INSERT INTO EMPLOYEE VALUES(
	'Ken', 'Numoto', 'Marketing', '360-287-8710', 'KMumoto@WPC.com');
INSERT INTO EMPLOYEE(FirstName, LastName, Department, Email)
	VALUES(
	'James', 'Nestor', 'InfoSystems', 'JNestor@WPC.com');
INSERT INTO EMPLOYEE VALUES(
	'Rick', 'Brown', 'InfoSystems', '360-287-8820', 'RBrown@WPC.com');

/*****   PROJECT DATA   *********************************************************/

INSERT INTO PROJECT VALUES(
	'2010 Q3 Product Plan', 'Marketing', 135.00, '10-MAY-10', '15-JUN-10');
INSERT INTO PROJECT VALUES(
	'2010 Q3 Portfolio Analysis', 'Finance', 120.00, '05-JUL-10', '05-JUL-10' );
INSERT INTO PROJECT VALUES(
	'2010 Q3 Tax Preparation', 'Accounting', 145.00, '10-AUG-10', '15-OCT-10');
INSERT INTO PROJECT VALUES(
	'2010 Q4 Product Plan', 'Marketing', 150.00, '10-AUG-10', '15-SEP-10');
INSERT INTO PROJECT (ProjectName, Department, MaxHours, StartDate)				
	VALUES(										
	'2010 Q4 Portfolio Analysis', 'Finance', 140.00, '05-OCT-10');			

/*****   ASSIGNMENT DATA   ******************************************************/

INSERT INTO ASSIGNMENT VALUES(1000, 1, 30.0);
INSERT INTO ASSIGNMENT VALUES(1000, 8, 75.0);
INSERT INTO ASSIGNMENT VALUES(1000, 10, 55.0);
INSERT INTO ASSIGNMENT VALUES(1100, 4, 40.0);
INSERT INTO ASSIGNMENT VALUES(1100, 6, 45.0);
INSERT INTO ASSIGNMENT VALUES(1200, 1, 25.0);
INSERT INTO ASSIGNMENT VALUES(1200, 2, 20.0);
INSERT INTO ASSIGNMENT VALUES(1200, 4, 45.0);
INSERT INTO ASSIGNMENT VALUES(1200, 5, 40.0);
INSERT INTO ASSIGNMENT VALUES(1300, 1, 35.0);
INSERT INTO ASSIGNMENT VALUES(1300, 8, 80.0);
INSERT INTO ASSIGNMENT VALUES(1300, 10, 50.0);
INSERT INTO ASSIGNMENT VALUES(1400, 4, 15.0);
INSERT INTO ASSIGNMENT VALUES(1400, 5, 10.0);
INSERT INTO ASSIGNMENT VALUES(1400, 6, 27.5);
