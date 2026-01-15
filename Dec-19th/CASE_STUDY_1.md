## --Case Study: https://drive.google.com/file/d/1tG8Symf9yzss2py7Pk4wrkCKBVSyKSMT/view

```sql
CREATE DATABASE EmpMgmtDB;
USE EmpMgmtDB;

CREATE TABLE Departments (
    DepartmentId INT PRIMARY KEY,
    DepartmentName VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE Employees(
    EmployeeId INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE,
    Salary DECIMAL(10,2) CHECK (Salary > 0),
    JoinDate DATE NOT NULL,
    DepartmentId INT,
    CONSTRAINT FK_Employee_Department
    FOREIGN KEY (DepartmentId)
    REFERENCES Departments(DepartmentId)
);

ALTER TABLE Employees
ADD Status VARCHAR(20) DEFAULT 'Active';

ALTER TABLE Employees
ALTER COLUMN EmployeeName VARCHAR(100);

ALTER TABLE Employees
DROP COLUMN Email;

ALTER TABLE Employees
DROP CONSTRAINT FK_Employee_Department;

DROP TABLE Departments;

CREATE INDEX IDX_Employees_Name
ON Employees(EmployeeName);

CREATE INDEX IDX_Employees_Department
ON Employees(DepartmentId);

SELECT EmployeeId, EmployeeName, Salary FROM Employees WHERE DepartmentId = 101;
```