## Product and Orders Tables with JOIN Queries

### Create Product Table

```sql
CREATE TABLE Product (
    ProdID INT PRIMARY KEY,
    ProdName VARCHAR(50),
    Brand VARCHAR(50),
    OrderID INT
);

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerName VARCHAR(50),
    TotalAmount INT
);

INSERT INTO Product (ProdID, ProdName, Brand, OrderID) VALUES
(101, 'Milk', 'Amul', 001),
(102, 'Chips', 'Lays', 002),
(103, 'Chocolate', 'Dairy Milk', 003),
(104, 'Noodles', 'Maggie', 004),
(105, 'Face Wash', 'Himalaya', 005),
(106, 'Oil', 'Fortune', 006);

INSERT INTO Orders (OrderID, CustomerName, TotalAmount) VALUES
(001, 'Pawan', 90),
(002, 'Punam', 99),
(003, 'Sudhanshu', 30),
(009, 'Tarun', 20),
(005, 'Neha', 50),
(007, 'Payal', 6);

--Inner Join
SELECT *
FROM Product P
INNER JOIN Orders O
ON P.OrderID = O.OrderID;

--Left Join
SELECT *
FROM Product P
LEFT JOIN Orders O
ON P.OrderID = O.OrderID;

--Right Join
SELECT *
FROM Product P
RIGHT JOIN Orders O
ON P.OrderID = O.OrderID;
```