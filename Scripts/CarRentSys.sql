DROP Table Rentals;
DROP Table Cars;
DROP Table Rates;
DROP Table Customers;

CREATE TABLE Rates
(Class char(1),
Rate_Per_Day decimal(6,2) NOT NULL,
Late_Fee_Rate decimal(5,2) NOT NULL,
Description varchar(30),
CONSTRAINT pk_Class PRIMARY KEY(Class));

CREATE TABLE Cars
(RegNo char(13) NOT NULL,
Make char(20),
Model char(20),
Colour char(8),
Year_of_Make char(4),
Fuel_Type char(1) CHECK (Fuel_Type IN ('P','D')),
Class char(1)CHECK (Class IN ('A','B','C')),
Status char(1) DEFAULT 'A',
Rented numeric(3) DEFAULT 0,
Date_Registered Date,
CONSTRAINT  pk_RegNo PRIMARY KEY(RegNo),
CONSTRAINT fk_Class FOREIGN KEY(Class) REFERENCES Rates);


CREATE TABLE Customers
(Cust_Id numeric(5) NOT NULL,
Surname  varchar(25),
Forename varchar(15),
Street varchar(25),
Town varchar(15),
County char(10),
Phone_No char(10),
Email varchar(30),
Status char(1) DEFAULT 'A',
Rental_Out char(1) DEFAULT 'N',
Num_Rentals numeric(3) DEFAULT 0,
Date_Registered Date,
CONSTRAINT pk_Cust PRIMARY KEY(Cust_Id));

CREATE TABLE Rentals
(Rent_Id numeric(5) NOT NULL,
Cust_Id numeric(5),
RegNo char(13),
Date_From Date,
Date_Due Date,
Date_Returned Date,
Cost decimal(6,2),
Returned char(1) DEFAULT 'N',
Condition_On_Return varchar(30) DEFAULT 'NOT YET RETURNED',
Is_Late char(1) DEFAULT 'N',
CONSTRAINT pk_Rent PRIMARY KEY(Rent_Id),
CONSTRAINT fk_RegNo FOREIGN KEY(RegNo) REFERENCES Cars,
CONSTRAINT fk_Cust FOREIGN KEY(Cust_Id)REFERENCES Customers);



INSERT INTO RATES VALUES ('A',64.99,9,'For High Range Value Cars');

INSERT INTO RATES VALUES ('B',49.99,8,'For Mid Range Value Cars');

INSERT INTO RATES VALUES ('C',34.99,7,'For Low Range Value Cars');

INSERT INTO CUSTOMERS(Cust_Id, Forename, Surname, Street, Town, County, Phone_No, Email, Num_Rentals,Date_Registered)
VALUES (1,'JOHN','SNOW','8 DEER PARK','TRALEE','KERRY','0854124579','jsnow@gmail.com', 1, '11-MAY-15');

INSERT INTO CUSTOMERS(Cust_Id, Forename, Surname, Street, Town, County, Phone_No, Email,Rental_Out, Num_Rentals,Date_Registered)
VALUES (2,'JIM','CAREY','24 HYDE ROW','NEWCASTLE WEST','LIMERICK','0896541327','jcar@hmail.com','Y', 3,'02-FEB-14');

INSERT INTO CUSTOMERS(Cust_Id, Forename, Surname, Street, Town, County, Phone_No, Email, Rental_Out,Num_Rentals,Date_Registered)
VALUES (3,'CAROLINE','GRIFFIN','27 CAHERULLA','BALLYHEIGUE','KERRY','0826342357','cgrif@yahoo.com', 'Y',0, '21-JAN-15');

INSERT INTO CUSTOMERS(Cust_Id, Forename, Surname, Street, Town, County, Phone_No, Email,Rental_Out, Num_Rentals,Date_Registered)
VALUES (4,'THOMAS','HEALY','66 GALLOWSFIELD','TRALEE','KERRY','0894123547','th@ittralee.ie','Y', 4,'14-DEC-14');

INSERT INTO CUSTOMERS(Cust_Id, Forename, Surname, Street, Town, County, Phone_No, Email, Num_Rentals,Date_Registered)
VALUES (5,'RACHEL','SMITH','19 HAWLEY PARK','BANDON','CORK','0835684120','rsmith@yahoo.com',1,'22-MAR-15');

INSERT INTO CUSTOMERS(Cust_Id, Forename, Surname, Street, Town, County, Phone_No, Email,Rental_Out, Num_Rentals,Date_Registered)
VALUES (6,'MICHAEL','SMITH','54 OAK TERRACE','TALLAGHT','DUBLIN','0874124598','ms@bebo.com','N', 5,'16-OCT-14');

INSERT INTO CUSTOMERS(Cust_Id, Forename, Surname, Street, Town, County, Phone_No, Email, Num_Rentals,Date_Registered)
VALUES (7,'SARAH','FITZGERALD','23 SPRING STREET','BLANCHESTOWN','DUBLIN','0841253654','af@yahoo.com',0,'15-MAY-15');

INSERT INTO CUSTOMERS(Cust_Id, Forename, Surname, Street, Town, County, Phone_No, Email,Rental_Out, Num_Rentals,Date_Registered)
VALUES (8,'DENNIS','MCKAY','33 PRINCES STREET','ENNIS','CLARE','0845236412','DmcKay@gmail.com','N',7,'30-JUN-13');

INSERT INTO CUSTOMERS(Cust_Id, Forename, Surname, Street, Town, County, Phone_No, Email, Num_Rentals,Date_Registered)
VALUES (9,'SARAH','GIVEN','44 GREEN HILL','LETTERKENNY','DONEGAL','0896541231','SG@hmail.com', 1,'2-APR-15');

INSERT INTO CUSTOMERS(Cust_Id, Forename, Surname, Street, Town, County, Phone_No, Email,Rental_Out, Num_Rentals,Date_Registered)
VALUES (10,'TOM','JONES','21 GREEN HILL','LETTERKENNY','DONEGAL','084124578','TJ@hmail.com','Y',1,'27-SEP-14');

INSERT INTO CUSTOMERS(Cust_Id, Forename, Surname, Street, Town, County, Phone_No, Email,Rental_Out, Status,Num_Rentals,Date_Registered)
VALUES (11,'SEAN','HAYES','22 JIMMY STREET','MILTOWN','LEITRIM','081265478','shay@hmail.com','N','D',1,'21-SEP-14');

INSERT INTO Cars(RegNo, Make, Model, Colour, Year_of_Make, Fuel_Type,Rented,Class,Status,Date_Registered)
VALUES ('141-G-78154','AUDI','A6','SILVER','2014','P',8,'A','O','07-JUN-14');

INSERT INTO Cars(RegNo, Make, Model, Colour, Year_of_Make, Fuel_Type,Rented,Class,Date_Registered)
VALUES ('152-D-45612','ALFA ROMEO','GTV','MAROON','2015','D',3,'A','17-AUG-14');

INSERT INTO Cars(RegNo, Make, Model, Colour, Year_of_Make, Fuel_Type,Rented,Class,Date_Registered)
VALUES ('15-D-2341','BMW','5 SERIES','BLACK','2015','D',1,'A','01-FEB-15');

INSERT INTO Cars(RegNo, Make, Model, Colour, Year_of_Make, Fuel_Type,Rented,Class,Status,Date_Registered)
VALUES ('152-C-3124','BUGATTI','VEYRON','VIOLET','2015','P',3,'A','O','01-FEB-15');

INSERT INTO Cars(RegNo, Make, Model, Colour, Year_of_Make, Fuel_Type,Rented,Class,Status,Date_Registered)
VALUES ('04-LD-87445','FORD','FOCUS','BRONZE','2004','P',1,'B','D','19-JUL-13');

INSERT INTO Cars(RegNo, Make, Model, Colour, Year_of_Make, Fuel_Type,Rented,Class,Status,Date_Registered)
VALUES ('10-WW-5445','HONDA','CIVIC','WHITE','2010','D',6,'B','O','23-MAY-14');

INSERT INTO Cars(RegNo, Make, Model, Colour, Year_of_Make, Fuel_Type,Rented,Class,Status,Date_Registered)
VALUES ('03-KY-12345','VOLKSWAGEN','GOLF','SILVER','2003','P',5,'B','D','12-FEB-15');

INSERT INTO Cars(RegNo, Make, Model, Colour, Year_of_Make, Fuel_Type,Rented,Class,Date_Registered)
VALUES ('13-D-427777','VOLKSWAGEN','POLO','SILVER','2013','D',3,'B','22-MAR-15');

INSERT INTO Cars(RegNo, Make, Model, Colour, Year_of_Make, Fuel_Type,Rented,Class,Date_Registered)
VALUES ('142-KY-546456','VOLKSWAGEN','GOLF','SILVER','2014','P',2,'B','02-APR-15');

INSERT INTO Cars(RegNo, Make, Model, Colour, Year_of_Make, Fuel_Type,Rented,Class,Date_Registered)
VALUES ('07-MO-645454','OPEL','ASTRA','VIOLET','2007','P',4,'B','22-NOV-14');

INSERT INTO Cars(RegNo, Make, Model, Colour, Year_of_Make, Fuel_Type,Rented,Class,Date_Registered)
VALUES ('10-OY-6554','SUZUKI','SWIFT','RED','2010','P',2,'B','30-JAN-14');

INSERT INTO Cars(RegNo, Make, Model, Colour, Year_of_Make, Fuel_Type,Rented,Class,Date_Registered)
VALUES ('05-T-94541','TOYOTA','YARIS','GOLD','2005','P',3,'B','02-FEB-15');

INSERT INTO Cars(RegNo, Make, Model, Colour, Year_of_Make, Fuel_Type,Rented,Class,Date_Registered)
VALUES ('08-C-77854','RENAULT','MEGANE','MAGENTA','2008','D',2,'B','18-MAR-15');

INSERT INTO Cars(RegNo, Make, Model, Colour, Year_of_Make, Fuel_Type,Rented,Class,Status,Date_Registered)
VALUES ('03-L-98772','VOLKSWAGEN','GOLF','BLACK','2003','D',4,'C','O','06-NOV-14');

INSERT INTO Cars(RegNo, Make, Model, Colour, Year_of_Make, Fuel_Type,Rented,Class,Date_Registered)
VALUES ('02-D-14180','VOLKSWAGEN','POLO','BLACK','2002','P',4,'C','05-DEC-14');

INSERT INTO Cars(RegNo, Make, Model, Colour, Year_of_Make, Fuel_Type,Rented,Class,Status,Date_Registered)
VALUES ('04-SO-45781','CITREON','BERLINGO','WHITE','2004','D',2,'C','D','29-OCT-13');

INSERT INTO Cars(RegNo, Make, Model, Colour, Year_of_Make, Fuel_Type,Rented,Class,Status,Date_Registered)
VALUES ('01-T-7841','FORD','FIESTA','RED','2001','D',0,'C','D','11-JUN-13');

INSERT INTO Cars(RegNo, Make, Model, Colour, Year_of_Make, Fuel_Type,Rented,Class,Status,Date_Registered)
VALUES ('02-DL-32121','HYUNDAI','ACCENT','SILVER','2002','P',7,'C','A','25-MAR-15');

INSERT INTO Cars(RegNo, Make, Model, Colour, Year_of_Make, Fuel_Type,Rented,Class,Status,Date_Registered)
VALUES ('132-D-54123','MERCEDES','GLA','BRONZE','2013','D',7,'A','A','25-MAR-15');


INSERT INTO Rentals(Rent_Id, Cust_Id, RegNo, Date_From, Date_Due, Date_Returned, Cost, Returned, Condition_On_Return)
VALUES (1,3,'05-T-94541','06-AUG-2014','13-AUG-2014','13-AUG-2014',349.93,'Y','FLAT TIRE');

INSERT INTO Rentals(Rent_Id, Cust_Id, RegNo, Date_From, Date_Due, Date_Returned, Cost, Returned, Condition_On_Return)
VALUES (2,2,'132-D-54123','15-AUG-2014','22-AUG-2014','22-AUG-2014',454.93,'Y','WET SEATS');

INSERT INTO Rentals(Rent_Id, Cust_Id, RegNo, Date_From, Date_Due, Date_Returned, Cost, Is_Late, Returned, Condition_On_Return)
VALUES (3,1,'15-D-2341','23-AUG-2014','30-AUG-2014','31-AUG-2014',525.76,'Y','Y','BROKEN HEADLIGHT');

INSERT INTO Rentals(Rent_Id, Cust_Id, RegNo, Date_From, Date_Due, Date_Returned, Cost, Returned, Condition_On_Return)
VALUES (4,5,'10-OY-6554','01-SEP-2014','01-SEP-2014','07-SEP-2014',349.93,'Y','DENTED ON REAR');

INSERT INTO Rentals(Rent_Id, Cust_Id, RegNo, Date_From, Date_Due, Date_Returned, Cost, Returned, Condition_On_Return)
VALUES (5,10,'132-D-54123','10-SEP-2014','17-SEP-2014','17-SEP-2014',454.93,'Y','NO DAMAGE');

INSERT INTO Rentals(Rent_Id, Cust_Id, RegNo, Date_From, Date_Due, Date_Returned, Cost, Is_Late, Returned, Condition_On_Return)
VALUES (6,8,'152-D-45612','20-JAN-2015','27-JAN-2015','28-JAN-2015',525.76,'Y','Y','NO DAMAGE');

INSERT INTO Rentals(Rent_Id, Cust_Id, RegNo, Date_From, Date_Due, Date_Returned, Cost, Returned, Condition_On_Return)
VALUES (7,6,'02-D-14180','03-FEB-2015','10-FEB-2015','10-FEB-2015',244.93,'Y','NO DAMAGE');

INSERT INTO Rentals(Rent_Id, Cust_Id, RegNo, Date_From, Date_Due, Date_Returned, Cost, Returned, Condition_On_Return)
VALUES (8,9,'07-MO-645454','11-MAR-2015','18-MAR-2015','18-MAR-2015',349.93,'Y','MISSING MIRROR');

INSERT INTO Rentals(Rent_Id, Cust_Id, RegNo, Date_From, Date_Due, Date_Returned, Cost, Returned, Condition_On_Return)
VALUES (9,4,'13-D-427777','20-APR-2015','27-APR-2015','27-APR-2015',349.93,'Y','NO DAMAGE');

INSERT INTO Rentals(Rent_Id, Cust_Id, RegNo, Date_From, Date_Due, Date_Returned, Cost, Is_Late, Returned, Condition_On_Return)
VALUES (10,7,'02-DL-32121','09-MAY-2015','16-MAY-2015','18-MAY-2015',299.51,'Y','Y','NO DAMAGE');

INSERT INTO Rentals(Rent_Id, Cust_Id, RegNo, Date_From, Date_Due)
VALUES (11,2,'141-G-78154','11-MAY-2015','18-MAY-2015');

INSERT INTO Rentals(Rent_Id, Cust_Id, RegNo, Date_From, Date_Due)
VALUES (12,10,'152-C-3124','12-MAY-2015','19-MAY-2015');

INSERT INTO Rentals(Rent_Id, Cust_Id, RegNo, Date_From, Date_Due)
VALUES (13,4,'10-WW-5445','16-MAY-2015','23-MAY-2015');

INSERT INTO Rentals(Rent_Id, Cust_Id, RegNo, Date_From, Date_Due)
VALUES (14,3,'03-L-98772','18-MAY-2015','25-MAY-2015');

COMMIT;

SELECT * FROM CUSTOMERS
ORDER BY Cust_Id;

SELECT * FROM CARS;

SELECT * FROM CARS WHERE STATUS = 'A';

SELECT * FROM RATES;

SELECT * FROM RENTALS;

--SELECT * FROM Cars C, Rates R WHERE C.Class = R.Class;

--SELECT C.REGNO, MAKE, MODEL, COLOUR, YEAR_OF_MAKE, C.CLASS, RATE_PER_DAY, LATE_FEE_RATE FROM CARS C, RATES R WHERE C.Status = 'A';

--select Rate_Per_Day From Cars C, Rates R Where C.Class = R.Class;

--UPDATE Cars SET Class ='A' WHERE RegNo = '12-CN-44524';

--Select Rent_Id, R.CUST_ID, Surname, Forename FROM CUSTOMERS C, RENTALS R WHERE C.Cust_Id= R.Cust_Id;

--SELECT CAST(SUM(Rate) AS decimal(6,2)) FROM Rentals BETWEEN Date '01-JAN-15' AND '01-APR-15'";

--SELECT Times_Rented FROM CARS WHERE MAKE LIKE '%Honda%';

--SELECT COUNT(Rent_Id) AS Num_Rentals, AVG(Rate) AS Avg_Income, MAX(Rate) AS Total_Income FROM Rentals;

--SELECT CAST(SUM(Rate) AS decimal(6,2)) AS Avg_Income FROM Rentals WHERE Date_FROM >= '03-MAR-15' AND Date_From <= '15-APR-15';

--SELECT CAST(AVG(Rate) AS decimal(6,2)) AS Avg_Income FROM Rentals WHERE Date_FROM >= '03-MAR-15' AND Date_From <= '15-APR-15';

--SELECT Make FROM CARS C,RENTALS R WHERE Times_Rented = (SELECT MAX(Times_Rented) FROM CARS)
--AND R.Date_FROM >= '13-APR-15';

--SELECT COUNT(Rent_Id) AS Num_Rentals FROM Rentals WHERE Date_FROM >= '13-APR-15';--

--UPDATE CUSTOMERS SET NUM_RENTALS = NUM_RENTALS + 1;
