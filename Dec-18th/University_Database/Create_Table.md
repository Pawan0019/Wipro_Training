# Students Table SQL Script

## Create Table

```sql
CREATE TABLE Students ( 
    StudentId INT IDENTITY(1, 1) PRIMARY KEY, 
    FirstName VARCHAR(50), 
    LastName VARCHAR(50), 
    Email VARCHAR(100), 
    DateOfBirth DATE 
);
-- Varchar means String 
-- Date means Date data 
-- Int means Number Data 
-- Identity means whenever I insert values it auto-increments
-- Example: 1, 2, 3, 4, 5
SELECT * FROM Students;
```