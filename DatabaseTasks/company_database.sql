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