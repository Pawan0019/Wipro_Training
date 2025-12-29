```sql
CREATE INDEX IDX_Employees_Department ON Employees(Department);

EXEC sp_helpindex 'Employees';
```