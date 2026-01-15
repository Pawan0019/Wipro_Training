## --Practice: https://drive.google.com/file/d/1MnOzVEJh-sSO9F9fXfdKN5yP8c95eGpP/view

```sql
CREATE TABLE Customers(
CustomerId INT PRIMARY KEY,
CustomerName VARCHAR(50),
City VARCHAR(50)
);

CREATE TABLE Orders (
OrderId INT PRIMARY KEY,
OrderAmount DECIMAL(10, 2),
CustomerId INT NULL
);

INSERT INTO Customers VALUES
(1, 'Amit', 'Hyderabad'),
(2, 'Neha', 'Bangalore'),
(3, 'Rahul', 'Delhi'),
(4, 'Priya', 'Mumbai');

INSERT INTO Orders VALUES
(1001, 5000, 1),
(1002, 12000, 1),
(1003, 7000, 2),
(1004, 9000, NULL),
(1005, 15000, 99);
--1
SELECT * FROM Customers;

--2
INSERT INTO Customers VALUES(5, 'Suresh', 'Chennai');
SELECT * FROM Customers;

--3
UPDATE Customers SET City = 'Pune' WHERE CustomerId = 4;
SELECT * FROM Customers;

--4
DELETE FROM Customers WHERE CustomerName = 'Rahul';
SELECT * FROM Customers;

--5
SELECT * FROM Customers WHERE City = 'Bangalore';

--6
SELECT c.CustomerName, o.OrderAmount FROM Customers c INNER JOIN Orders o ON c.CustomerId = o.CustomerId;

--7
SELECT c.CustomerName, o.OrderAmount FROM Customers c LEFT JOIN Orders o ON c.CustomerId = o.CustomerId;

--8
SELECT o.OrderId, o.OrderAmount, c.CustomerName FROM Customers c RIGHT JOIN Orders o ON c.CustomerId = o.CustomerId;

--9
SELECT c.CustomerId, c.CustomerName FROM Customers c LEFT JOIN Orders o ON c.CustomerId = o.CustomerId WHERE o.CustomerId IS NULL; 

--10
SELECT o.OrderId, o.OrderAmount, o.CustomerId FROM Orders o LEFT JOIN Customers c ON c.CustomerId = o.CustomerId WHERE c.CustomerId IS NULL;
```