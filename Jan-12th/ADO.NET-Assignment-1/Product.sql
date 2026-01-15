CREATE DATABASE ShopDB;
GO
USE ShopDB;
GO

CREATE TABLE Products
(
	ProductId INT IDENTITY(1,1) PRIMARY KEY,
	Name NVARCHAR(100),
	Price DECIMAL(10,2),
	Quantity INT
);

INSERT INTO Products (Name, Price, Quantity)
VALUES
('Laptop', 75000, 5),
('Mouse', 500, 50),
('Keyboard', 1500, 20);