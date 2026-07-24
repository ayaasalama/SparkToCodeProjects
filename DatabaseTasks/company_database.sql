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