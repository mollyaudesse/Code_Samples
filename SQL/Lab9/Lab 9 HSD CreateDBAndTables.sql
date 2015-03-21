USE master;
GO

IF EXISTS(SELECT name FROM sys.databases WHERE name = 'Lab9_HSD')
     DROP DATABASE Lab9_HSD
GO

CREATE DATABASE Lab9_HSD;
GO

USE Lab9_HSD;
GO

CREATE  TABLE SEMINAR(
	SeminarID		Int				NOT NULL IDENTITY (1, 1),
	SeminarDate		DateTime		NOT NULL,
	SeminarTime		DateTime		NOT NULL,
	Location		VarChar(100)	NOT NULL,
	SeminarTitle	VarChar(100)	NOT NULL,
	CONSTRAINT 		SEMINAR_PK 		PRIMARY KEY(SeminarID)
	);


CREATE  TABLE CUSTOMER(
	EmailAddress	VarChar(100)	NOT NULL,
	LastName		Char(25)		NOT NULL,
	FirstName		Char(25)		NOT NULL,
	Phone			Char(12)		NOT NULL,
	StreetAddress	Char(35)		NULL,
	City			Char(35)		NULL DEFAULT 'Dallas',
	[State]			Char(2)			NULL DEFAULT 'TX',
	ZIP				Char(10)		NULL DEFAULT '75201',
	CONSTRAINT 		CUSTOMER_PK 	PRIMARY KEY(EmailAddress)
	);


CREATE  TABLE SEMINAR_CUSTOMER(
	SeminarID		Int				NOT NULL,
	EmailAddress	VarChar(100)	NOT NULL,
	CONSTRAINT 		S_C_PK 			PRIMARY KEY(SeminarID,EmailAddress),
	CONSTRAINT 		S_C_SEMINAR_FK  FOREIGN KEY(SeminarID)
						REFERENCES SEMINAR(SeminarID)
							ON UPDATE NO ACTION
							ON DELETE NO ACTION,
	CONSTRAINT 		S_C_CUSTOMER_FK    FOREIGN KEY(EmailAddress)
						REFERENCES CUSTOMER(EmailAddress)
							ON UPDATE CASCADE
							ON DELETE NO ACTION
	);


CREATE  TABLE CONTACT(
	EmailAddress	VarChar(100)	NOT NULL,
	ContactDate		DateTime		NOT NULL,
	ContactNumber	Int				NOT NULL,
	ContactType		Char(15)		NOT NULL,
	SeminarID		Int				NULL,
	CONSTRAINT 		CONTACT_PK 	PRIMARY KEY(EmailAddress, ContactDate),
	CONSTRAINT 		CONTACT_SEMINAR_FK FOREIGN KEY(SeminarID)
						REFERENCES SEMINAR(SeminarID)
							ON UPDATE NO ACTION
							ON DELETE NO ACTION,
	CONSTRAINT 		CONTACT_CUSTOMER_FK FOREIGN KEY(EmailAddress)
							REFERENCES CUSTOMER(EmailAddress)
							ON UPDATE CASCADE
							ON DELETE NO ACTION
	);


CREATE  TABLE PRODUCT(
	ProductNumber	Char(35)		NOT NULL,
	[Description]	VarChar(100)	NOT NULL,
	UnitPrice		Numeric(9,2)	NOT NULL,
	QuantityOnHand	Int				NOT NULL DEFAULT 0,
	CONSTRAINT 		PRODUCT_PK 		PRIMARY KEY (ProductNumber),
	);


CREATE  TABLE INVOICE(
    InvoiceNumber	Int				NOT NULL IDENTITY (35000, 1),
	InvoiceDate		DateTime		NOT NULL,
	PaymentType		Char(25) 		NOT NULL DEFAULT 'Cash',
	SubTotal		Numeric(9,2)	NULL,
	Shipping		Numeric(9,2)	NULL,
	Tax				Numeric(9,2)	NULL,
	Total			Numeric(9,2)	NULL,
	EmailAddress	VarChar(100)	NOT NULL,
    CONSTRAINT 		INVOICE_PK 	PRIMARY KEY (InvoiceNumber),
	CONSTRAINT 		INVOICE_CUSTOMER_FK FOREIGN KEY(EmailAddress)
						REFERENCES Customer(EmailAddress)
							ON UPDATE CASCADE
							ON DELETE NO ACTION
    );


CREATE  TABLE LINE_ITEM(
    InvoiceNumber	Int				NOT NULL,
	LineNumber		Int				NOT NULL,
	Quantity		Int				NOT NULL,
	UnitPrice		Numeric(9,2)	NOT NULL,
	Total			Numeric(9,2)	NULL,
	ProductNumber	Char(35) 		NOT NULL,
    CONSTRAINT 		LINE_ITEM_PK 	PRIMARY KEY (InvoiceNumber, LineNumber),
	CONSTRAINT 		L_I_INVOICE_FK 	FOREIGN KEY(InvoiceNumber)
						REFERENCES INVOICE(InvoiceNumber)
							ON UPDATE NO ACTION
							ON DELETE CASCADE,
	CONSTRAINT 		L_I_PRODUCT_FK 	FOREIGN KEY(ProductNumber)
						REFERENCES PRODUCT (ProductNumber)
							ON UPDATE CASCADE
							ON DELETE NO ACTION
    );

/********************************************************************************/