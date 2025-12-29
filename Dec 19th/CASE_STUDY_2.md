## --Case Study: https://drive.google.com/file/d/1tG8Symf9yzss2py7Pk4wrkCKBVSyKSMT/view

```sql
CREATE DATABASE OrderDB;
GO
USE OrderDB;
Go

CREATE TABLE Customers(
CustomerId INT IDENTITY(1,1) PRIMARY KEY,
CustomerName VARCHAR(100) NOT NULL,
Email VARCHAR(100) UNIQUE
);

CREATE TABLE Orders(
OrderId INT IDENTITY(1001, 1) PRIMARY KEY,
OrderAmount DECIMAL(10,2) NOT NULL,
CustomerId INT NULL,
CONSTRAINT FK_Order_Customer
FOREIGN KEY (CustomerId)
REFERENCES Customers(CustomerId)
);

ALTER TABLE Orders
ADD OrderStatus VARCHAR(20) DEFAULT 'Pending';

DROP TABLE Orders;

CREATE TABLE Orders(
OrderId INT IDENTITY(1001,1) PRIMARY KEY,
OrderAmount DECIMAL(12,2) NOT NULL CHECK (OrderAmount > 0),
CustomerId INT NULL,
OrderStatus VARCHAR(20) NOT NULL DEFAULT 'Pending',
OrderDate DATETIME DEFAULT GETDATE(),
CONSTRAINT FK_Order_Customer
FOREIGN KEY (CustomerId)
REFERENCES Customers(CustomerId)
);

CREATE INDEX IDX_Orders_CustomerId
ON Orders(CustomerId);

CREATE INDEX IDX_Orders_Amount
ON Orders(OrderAmount);
```