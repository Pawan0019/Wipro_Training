CREATE DATABASE FunctionDemoDB;
GO
USE FunctionDemoDB;
GO

CREATE TABLE Employees (
EmployeeId INT IDENTITY PRIMARY KEY,
EmployeeName VARCHAR(50),
Department VARCHAR(50),
Salary INT,
JoinDate DATE
);

INSERT INTO Employees (EmployeeName, Department, Salary, JoinDate) VALUES
('Amit' , 'IT', 60000,'2021-01-10'),
('Neha', 'HR', 50000, '2020-06-15'),
('Rahul', 'Finance', 70000, '2019-03-20'),
('Priya', 'IT', 65000, '2022-08-01'),
('Sonal', 'HR', 48000, '2023-02-12');

SELECT Salary, ABS(Salary - 60000) AS SalaryDifference FROM Employees;

SELECT Salary, ROUND(Salary / 3.0, 2) AS SalaryRound FROM Employees;

SELECT EmployeeName, UPPER(EmployeeName) AS Uppername, LOWER(EmployeeName) As LowerName FROM Employees;

SELECT EmployeeName, LEN(EmployeeName) AS NameLength FROM Employees;

SELECT EmployeeName, LEFT(EmployeeName, 2) AS ShortName FROM Employees;

SELECT GETDATE() AS CurrentDateTime FROM Employees;

SELECT EmployeeName, YEAR(JoinDate) AS JoinYear, MONTH(JoinDate) AS JoinMonth FROM Employees;

SELECT EmployeeName, DATEDIFF(DAY, JoinDate, GETDATE()) AS DaysInCompany FROM Employees;

SELECT COUNT(*) AS TotalEm9ployees FROM Employees;

SELECT Department, COUNT(*) AS EmployeeCount FROM Employees GROUP BY Department;

SELECT Department, SUM(Salary) AS TotalSalary FROM Employees GROUP BY Department;

SELECT AVG(Salary) AS AvgSalary FROM Employees;

SELECT MIN(Salary) AS MinimumSalary, MAX(Salary) AS MaximumSalary FROM Employees;