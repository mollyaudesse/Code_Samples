--Molly Audesse Section 5
USE master;
GO

IF EXISTS(SELECT name FROM sys.databases WHERE name = 'Lab8_GG_DB')
     DROP DATABASE Lab8_GG_DB
GO

CREATE DATABASE Lab8_GG_DB;
GO
USE Lab8_GG_DB;
GO

CREATE TABLE OWNER(
	OwnerID			Int				NOT NULL IDENTITY(1,1),
	OwnerName		Char(50)		NOT NULL,
	OwnerEmail		VarChar(100)	NULL,
	OwnerType		Char(12)		NULL,
	);

CREATE TABLE [PROPERTY](
	PropertyID		Int				NOT NULL IDENTITY(1,1),
	PropertyName	Char(50)		NOT NULL,
	Street			Char(35)		NOT NULL,
	City			Char(35)		NOT NULL,
	[State]			Char(2)			NOT NULL,
	ZIP				Char(10)		NOT NULL,
	OwnerID			Int				NOT NULL,
	);

CREATE TABLE EMPLOYEE(
	EmployeeID		Int				NOT NULL IDENTITY(1,1),
	LastName		Char(25)		NOT NULL,
	FirstName		Char(25)		NOT NULL,
	CellPhone		Char(12)		NOT NULL,
	ExperienceLevel	Char(15)		NOT NULL,
	);

CREATE TABLE [SERVICE](
	PropertyID		Int				NOT NULL,
	EmployeeID		Int				NOT NULL,
	ServiceDate		DateTime		NOT NULL,
	HoursWorked		Numeric (4,2)	NULL,
	);

/********************************************************************************/

-- *******************************************
-- *** Now create constraints before inserting data
-- *******************************************


ALTER TABLE [OWNER]
ADD CONSTRAINT OWNER_PK PRIMARY KEY (OwnerID);

ALTER TABLE PROPERTY
ADD CONSTRAINT PROPERTY_PK PRIMARY KEY (PropertyID);

ALTER TABLE EMPLOYEE
ADD CONSTRAINT EMPLOYEE_PK PRIMARY KEY(EmployeeID);

ALTER TABLE [SERVICE]
ADD CONSTRAINT SERVICE_PK PRIMARY KEY (PropertyID, EmployeeID);

ALTER TABLE [PROPERTY]
ADD CONSTRAINT PROP_OWNER_PK FOREIGN KEY (OwnerID)
	REFERENCES[OWNER](OwnerID)
	ON DELETE NO ACTION;

ALTER TABLE [SERVICE]
ADD CONSTRAINT SERVICE_PROP_PK FOREIGN KEY (PropertyID)
	REFERENCES PROPERTY (PropertyID)
	ON DELETE NO ACTION;

ALTER TABLE [SERVICE]
ADD CONSTRAINT SERVICE_EMP_FK FOREIGN KEY (EmployeeID)
	REFERENCES EMPLOYEE(EmployeeID)
	ON DELETE NO ACTION
	ON UPDATE CASCADE;

