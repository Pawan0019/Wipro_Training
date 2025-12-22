BEGIN TRANSACTION;
INSERT INTO Employees (EmployeeName, Salary) VALUES
('User1', 50000);

SAVE TRANSACTION SavePoint1;

INSERT INTO Employees (EmployeeName, Salary) VALUES
('User2', 60000);

ROLLBACK TRANSACTION SavePoint1;

COMMIT;

SELECT * FROM Employees;