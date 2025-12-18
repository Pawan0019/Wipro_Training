CREATE TABLE Departments (
DepartmentID INT IDENTITY(1 ,1) Primary Key,
DepartmentName VARCHAR(100) NOT NULL
);

INSERT INTO Departments (DepartmentName)
VALUES ('Computer Science'), ('Mechanical'), ('Electrical');

SELECT * FROM Departments;