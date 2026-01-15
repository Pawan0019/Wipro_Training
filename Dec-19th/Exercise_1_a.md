SELECT c.CustomerName, o.OrderAmount FROM Customers c INNER JOIN Orders o ON c.CustomerId = o.CustomerId;

SELECT c.CustomerName, o.OrderAmount FROM Customers c LEFT JOIN Orders o ON c.CustomerId = o.CustomerId;

SELECT o.OrderId, o.OrderAmount, c.CustomerName FROM Customers c RIGHT JOIN Orders o ON c.CustomerId = o.CustomerId;

SELECT c.CustomerId, c.CustomerName FROM Customers c LEFT JOIN Orders o ON c.CustomerId = o.CustomerId WHERE o.CustomerId IS NULL; 

SELECT o.OrderId, o.OrderAmount, o.CustomerId FROM Orders o LEFT JOIN Customers c ON c.CustomerId = o.CustomerId WHERE c.CustomerId IS NULL;