```sql
BEGIN TRANSACTION;

INSERT INTO (EmployeeName, Salary) VALUES
('Neha', 55000); --Implicit Transaction

COMMIT;

SELECT * FROM Employees;

BEGIN TRANSACTION;

INSERT INTO (EmployeeName, Salary) VALUES
('Neha', 55000);

ROLLBACK;

BEGIN T

UPDATE Employees SET Salary = Salary +5000 WHERE EmployeeName = 'Amit';

DELETE FROM Employees WHERE EmployeeName = 'User1';

COMMIT;
```