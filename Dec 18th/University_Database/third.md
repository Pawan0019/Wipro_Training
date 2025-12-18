## Select Specific Columns

```sql
SELECT FirstName, Email 
FROM Students;

-- Filter
SELECT * 
FROM Students
WHERE FirstName = 'Punam';

-- Sort
SELECT * 
FROM Students
ORDER BY DateOfBirth;
```