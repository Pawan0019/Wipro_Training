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

SELECT * FROM Customers;

INSERT INTO Customers VALUES(5, 'Suresh', 'Chennai');
SELECT * FROM Customers;

UPDATE Customers SET City = 'Pune' WHERE CustomerId = 4;
SELECT * FROM Customers;

DELETE FROM Customers WHERE CustomerName = 'Rahul';
SELECT * FROM Customers;

SELECT * FROM Customers WHERE City = 'Bangalore';
