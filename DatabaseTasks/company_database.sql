CREATE DATABASE CompanyDatabase;

CREATE TABLE EMPLOYEE
(
    Ssn CHAR(9) PRIMARY KEY,
    Fname VARCHAR(50),
    Minit CHAR(1),
    Lname VARCHAR(50),
    Bdate DATE,
    Address VARCHAR(255),
    Sex CHAR(1),
    Salary DECIMAL(10, 2),
    Super_ssn CHAR(9),
    Dno INT,

    FOREIGN KEY (Super_ssn)
        REFERENCES EMPLOYEE(Ssn)
);

CREATE TABLE DEPARTMENT
(
    Dnumber INT PRIMARY KEY,
    Dname VARCHAR(50) UNIQUE,
    Mgr_ssn CHAR(9),
    Mgr_start_date DATE,

    FOREIGN KEY (Mgr_ssn)
        REFERENCES EMPLOYEE(Ssn)
);

ALTER TABLE EMPLOYEE
ADD FOREIGN KEY (Dno)
REFERENCES DEPARTMENT(Dnumber);

CREATE TABLE DEPT_LOCATIONS
(
    Dnumber INT,
    Dlocation VARCHAR(50),

    PRIMARY KEY (Dnumber, Dlocation),

    FOREIGN KEY (Dnumber)
        REFERENCES DEPARTMENT(Dnumber)
);

CREATE TABLE PROJECT
(
    Pname VARCHAR(50),
    Pnumber INT,
    Plocation VARCHAR(50),
    Dnum INT,

    PRIMARY KEY (Pnumber, Plocation),

    FOREIGN KEY (Dnum)
        REFERENCES DEPARTMENT(Dnumber)
);

CREATE TABLE WORKS_ON
(
    Essn CHAR(9),
    Pno INT,
    Hours DECIMAL(4,1),

    PRIMARY KEY (Essn, Pno),

    FOREIGN KEY (Essn)
        REFERENCES EMPLOYEE(Ssn)
);

ALTER TABLE PROJECT
ADD UNIQUE (Pnumber);

ALTER TABLE WORKS_ON
ADD FOREIGN KEY (Pno)
REFERENCES PROJECT(Pnumber);

CREATE TABLE DEPENDENT(
    Essn CHAR(9),
    Dependent_name VARCHAR(50),
    Sex CHAR(1),
    Bdate DATE,
    Relationship VARCHAR(20),
    
    PRIMARY KEY (Essn, Dependent_name),

    FOREIGN KEY (Essn) 
         REFERENCES EMPLOYEE(Ssn)
);