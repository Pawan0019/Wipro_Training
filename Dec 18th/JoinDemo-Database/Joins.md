-- Inner Join
SELECT
e.EmpName,
d.DeptName
FROM Employees e
INNER JOIN Departments d
ON e.DeptID = d.DeptID;

-- LEFT JOin
SELECT
e.EmpName,
d.DeptName
FROM Employees e
LEFT JOIN Departments d
ON e.DeptID = d.DeptID;

-- RIGHT JOIN
SELECT
e.EmpName,
d.DeptName
FROM Employees e
RIGHT JOIN Departments d
ON e.DeptID = d.DeptID;