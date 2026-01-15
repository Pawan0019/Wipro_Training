## Departments Table SQL Script

### Create Table

```sql
CREATE TABLE Departments (
    DepartmentID INT IDENTITY(1, 1) PRIMARY KEY,
    DepartmentName VARCHAR(100) NOT NULL
);

INSERT INTO Departments (DepartmentName)
VALUES 
('Computer Science'),
('Mechanical'),
('Electrical');

SELECT * FROM Departments;
```