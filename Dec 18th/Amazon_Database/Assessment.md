# Product Table SQL Script

## Create Table

```sql
CREATE TABLE Product ( 
    ProdID INT IDENTITY (1, 1) PRIMARY KEY,
    Name VARCHAR(50),
    Brand VARCHAR(50),
    ManuDate DATE,
    ExpDate DATE,
    Price INT
);

INSERT INTO Product (Name, Brand, ManuDate, ExpDate, Price)
VALUES
('Bread', 'Britannia', '2025-08-12', '2025-10-12', 45),
('Milk', 'Amul', '2025-11-12', '2025-11-13', 62),
('Chips', 'Lays', '2025-12-12', '2026-12-12', 20),
('Chocolate', 'Dairy Milk', '2025-12-12', '2020-12-12', 45),
('Noodles', 'Maggie', '2025-05-12', '2026-04-12', 14),
('Face Wash', 'Himalaya', '2025-06-12', '2025-06-12', 108),
('Oil', 'Fortune', '2024-06-24', '2025-10-20', 200),
('Toothpaste', 'Colgate', '2025-01-12', '2027-01-12', 130),
('Water', 'Bisleri', '2025-08-21', '2027-03-30', 20),
('Oats', 'Kellogg', '2025-01-22', '2026-10-21', 300);

SELECT * FROM Product;

--Update
UPDATE Product 
SET ManuDate = '2025-06-24' 
WHERE Name = 'Oil';

--Delete
SELECT * FROM Product;
DELETE FROM Product 
WHERE Price = 14;

SELECT * FROM Product;
```