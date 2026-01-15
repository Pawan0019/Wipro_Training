CREATE DATABASE AdoNetDemoDB;
GO
USE AdoNetDemoDB;
GO

CREATE TABLE Orders
(
    OrderId INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName NVARCHAR(100),
    ProductName NVARCHAR(100),
    Quantity INT,
    TotalAmount DECIMAL(10,2),
    OrderDate DATETIME
);