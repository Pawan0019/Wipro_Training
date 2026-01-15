# SECTION A: RDBMS FUNDAMENTALS (50 MCQs)

## Introduction to RDBMS

1. What does RDBMS stand for?  
   A. Remote Database Management System  
   B. Relational Database Management System  
   C. Real-time Database Management System  
   D. Rapid Database Management System  
   **Answer:** B

2. In RDBMS, data is stored in the form of:  
   A. Files  
   B. Objects  
   C. Tables  
   D. Trees  
   **Answer:** C

3. Which concept ensures relationships among tables?  
   A. Indexing  
   B. Normalization  
   C. Keys  
   D. Views  
   **Answer:** C

4. Which of the following best defines a relation?  
   A. Database  
   B. Table  
   C. Record  
   D. Field  
   **Answer:** B

5. RDBMS mainly follows which mathematical theory?  
   A. Graph Theory  
   B. Set Theory  
   C. Probability  
   D. Calculus  
   **Answer:** B

## Importance & Characteristics

6. Which is NOT a characteristic of RDBMS?  
   A. Data integrity  
   B. Redundancy control  
   C. File dependency  
   D. ACID compliance  
   **Answer:** C

7. Data independence in RDBMS means:  
   A. Data stored without tables  
   B. Applications unaffected by schema changes  
   C. No redundancy  
   D. No relationships  
   **Answer:** B

8. Which feature ensures accuracy and consistency of data?  
   A. Normalization  
   B. Data Integrity  
   C. Indexing  
   D. Partitioning  
   **Answer:** B

## Database Design & ER Model

9. In ER model, an object is represented as:  
   A. Attribute  
   B. Entity  
   C. Relationship  
   D. Tuple  
   **Answer:** B

10. Cardinality represents:  
    A. Attribute type  
    B. Number of entities involved  
    C. Degree of relationship  
    D. Primary key  
    **Answer:** C

11. One-to-many relationship means:  
    A. One entity relates to one entity  
    B. Many entities relate to many  
    C. One entity relates to many  
    D. None  
    **Answer:** C

12. Which is a multivalued attribute?  
    A. Age  
    B. Name  
    C. Phone Numbers  
    D. Salary  
    **Answer:** C

## Normalization

13. Goal of normalization is to:  
    A. Increase redundancy  
    B. Improve security  
    C. Reduce data anomalies  
    D. Improve UI  
    **Answer:** C

14. Which normal form removes partial dependency?  
    A. 1NF  
    B. 2NF  
    C. 3NF  
    D. BCNF  
    **Answer:** B

15. Transitive dependency is removed in:  
    A. 2NF  
    B. 3NF  
    C. 1NF  
    D. 4NF  
    **Answer:** B

## Architecture

16. Single-user system allows:  
    A. Multiple users simultaneously  
    B. Only one user at a time  
    C. Distributed access  
    D. Web access  
    **Answer:** B

17. Client-Server architecture separates:  
    A. Hardware and software  
    B. UI and database  
    C. Client requests and server processing  
    D. Tables and views  
    **Answer:** C

18. Which database architecture improves scalability?  
    A. Centralized  
    B. Distributed  
    C. Single-user  
    D. Flat-file  
    **Answer:** B

## Keys & Constraints

19. Primary key must be:  
    A. Nullable  
    B. Duplicate  
    C. Unique and NOT NULL  
    D. Indexed only  
    **Answer:** C

20. Foreign key ensures:  
    A. Uniqueness  
    B. Performance  
    C. Referential integrity  
    D. Indexing  
    **Answer:** C

21. UNIQUE constraint allows:  
    A. NULL values  
    B. Duplicate values  
    C. Only one NULL (DB dependent)  
    D. No indexing  
    **Answer:** C

22. CHECK constraint is used to:  
    A. Enforce domain integrity  
    B. Create indexes  
    C. Join tables  
    D. Encrypt data  
    **Answer:** A

## Transactions & ACID

23. Atomicity means:  
    A. Transaction speed  
    B. All or nothing execution  
    C. Data encryption  
    D. Parallel execution  
    **Answer:** B

24. Consistency ensures:  
    A. Data remains valid  
    B. Faster execution  
    C. Locks applied  
    D. Rollback enabled  
    **Answer:** A

25. Isolation prevents:  
    A. Redundancy  
    B. Dirty reads  
    C. Indexing  
    D. Deadlocks  
    **Answer:** B

26. Durability ensures:  
    A. Rollback  
    B. Locking  
    C. Permanent commit  
    D. Temporary storage  
    **Answer:** C

## Locking & Isolation Levels

27. Which isolation level prevents phantom reads?  
    A. Read Uncommitted  
    B. Read Committed  
    C. Repeatable Read  
    D. Serializable  
    **Answer:** D

28. Dirty read occurs when:  
    A. Reading committed data  
    B. Reading uncommitted data  
    C. Reading indexed data  
    D. Reading encrypted data  
    **Answer:** B

## Integrity & Concurrency

29. Concurrency control ensures:  
    A. Multiple users access without conflicts  
    B. Single user access  
    C. Indexing  
    D. Encryption  
    **Answer:** A

30. Lost update problem occurs when:  
    A. Two transactions update same data  
    B. Data is deleted  
    C. Data is indexed  
    D. Data is encrypted  
    **Answer:** A

## Miscellaneous

31. A tuple represents:  
    A. Column  
    B. Row  
    C. Table  
    D. Database  
    **Answer:** B

32. Degree of a relation means:  
    A. Number of rows  
    B. Number of columns  
    C. Number of keys  
    D. Number of constraints  
    **Answer:** B

33. Which ensures referential integrity?  
    A. Primary key  
    B. Foreign key  
    C. Unique key  
    D. Index  
    **Answer:** B

34. Logical design focuses on:  
    A. Physical storage  
    B. Hardware  
    C. Schema structure  
    D. Index files  
    **Answer:** C

35. Physical design focuses on:  
    A. ER diagrams  
    B. Storage and indexing  
    C. Relationships  
    D. Attributes  
    **Answer:** B

36. Which is NOT an integrity constraint?  
    A. Domain  
    B. Entity  
    C. Referential  
    D. Performance  
    **Answer:** D

37. Redundancy leads to:  
    A. Consistency  
    B. Anomalies  
    C. Security  
    D. Speed  
    **Answer:** B

38. Update anomaly occurs when:  
    A. Insert fails  
    B. Delete fails  
    C. Data inconsistency arises  
    D. Index missing  
    **Answer:** C

39. Which is mandatory for every table?  
    A. Foreign key  
    B. Index  
    C. Primary key  
    D. View  
    **Answer:** C

40. Which supports multi-user access?  
    A. File system  
    B. RDBMS  
    C. Spreadsheet  
    D. Text file  
    **Answer:** B

41. Which ensures uniqueness of rows?  
    A. Index  
    B. Primary key  
    C. Constraint  
    D. Trigger  
    **Answer:** B

42. Which constraint sets default value?  
    A. CHECK  
    B. DEFAULT  
    C. UNIQUE  
    D. NOT NULL  
    **Answer:** B

43. Which transaction state follows COMMIT?  
    A. Active  
    B. Failed  
    C. Terminated  
    D. Aborted  
    **Answer:** C

44. Which ensures no partial updates?  
    A. Isolation  
    B. Atomicity  
    C. Durability  
    D. Consistency  
    **Answer:** B

45. Which is an example of centralized DB?  
    A. Cloud DB  
    B. Single server DB  
    C. Blockchain  
    D. Distributed DB  
    **Answer:** B

46. Which allows multiple DB servers?  
    A. Single-user  
    B. Centralized  
    C. Distributed  
    D. Flat-file  
    **Answer:** C

47. Which reduces storage cost?  
    A. Denormalization  
    B. Normalization  
    C. Replication  
    D. Indexing  
    **Answer:** B

48. Which anomaly occurs during deletion?  
    A. Insert anomaly  
    B. Update anomaly  
    C. Delete anomaly  
    D. Join anomaly  
    **Answer:** C

49. Which ensures consistency during crash?  
    A. Index  
    B. Lock  
    C. Log  
    D. View  
    **Answer:** C

50. RDBMS is best suited for:  
    A. Unstructured data  
    B. Structured data  
    C. Image processing  
    D. Audio streaming  
    **Answer:** B

---

# SECTION B: SQL & ADVANCED SQL (50 MCQs)

## SQL Basics

51. SQL stands for:  
    A. Structured Query Language  
    B. Simple Query Language  
    C. Sequential Query Language  
    D. Standard Query Language  
    **Answer:** A

52. SQL is:  
    A. Procedural  
    B. Object-oriented  
    C. Declarative  
    D. Functional  
    **Answer:** C

## DDL

53. Which command creates a table?  
    A. INSERT  
    B. CREATE  
    C. SELECT  
    D. UPDATE  
    **Answer:** B

54. DROP TABLE removes:  
    A. Data only  
    B. Structure only  
    C. Both structure and data  
    D. Index only  
    **Answer:** C

55. ALTER TABLE is used to:  
    A. Insert data  
    B. Modify structure  
    C. Delete rows  
    D. Grant permissions  
    **Answer:** B

## Data Types & Indexes

56. Which data type stores text?  
    A. INT  
    B. CHAR  
    C. FLOAT  
    D. DATE  
    **Answer:** B

57. Index improves:  
    A. Storage  
    B. Security  
    C. Query performance  
    D. Data integrity  
    **Answer:** C

58. Which index allows duplicate values?  
    A. Unique  
    B. Primary  
    C. Non-unique  
    D. Clustered  
    **Answer:** C

## DML

59. Which command adds new records?  
    A. UPDATE  
    B. INSERT  
    C. DELETE  
    D. SELECT  
    **Answer:** B

60. Which modifies existing data?  
    A. INSERT  
    B. UPDATE  
    C. DELETE  
    D. CREATE  
    **Answer:** B

## DQL

61. SELECT is used for:  
    A. Data insertion  
    B. Data retrieval  
    C. Data deletion  
    D. Schema creation  
    **Answer:** B

62. WHERE clause filters:  
    A. Columns  
    B. Tables  
    C. Rows  
    D. Indexes  
    **Answer:** C

63. GROUP BY is used with:  
    A. Scalar functions  
    B. Aggregate functions  
    C. Joins  
    D. Views  
    **Answer:** B

64. HAVING filters:  
    A. Rows  
    B. Columns  
    C. Groups  
    D. Tables  
    **Answer:** C

## Joins

65. INNER JOIN returns:  
    A. Matching rows only  
    B. All rows  
    C. Left table rows  
    D. Right table rows  
    **Answer:** A

66. LEFT JOIN returns:  
    A. Matching rows  
    B. Left table + matches  
    C. Right table only  
    D. Common rows  
    **Answer:** B

67. FULL JOIN returns:  
    A. Only matches  
    B. Left table  
    C. Right table  
    D. All rows from both tables  
    **Answer:** D

## Subqueries

68. Subquery executes:  
    A. After main query  
    B. Before main query  
    C. Parallel  
    D. Randomly  
    **Answer:** B

69. Correlated subquery executes:  
    A. Once  
    B. Multiple times  
    C. Before join  
    D. After commit  
    **Answer:** B

## Set Operators

70. UNION removes:  
    A. Rows  
    B. Columns  
    C. Duplicate rows  
    D. Tables  
    **Answer:** C

71. INTERSECT returns:  
    A. All rows  
    B. Common rows  
    C. Unique rows  
    D. Unmatched rows  
    **Answer:** B

## Functions

72. COUNT(*) returns:  
    A. Sum  
    B. Average  
    C. Total rows  
    D. Max value  
    **Answer:** C

73. AVG works on:  
    A. Strings  
    B. Dates  
    C. Numbers  
    D. Boolean  
    **Answer:** C

## CASE

74. CASE expression is used for:  
    A. Looping  
    B. Conditional logic  
    C. Sorting  
    D. Indexing  
    **Answer:** B

## TCL

75. COMMIT makes changes:  
    A. Temporary  
    B. Permanent  
    C. Reversible  
    D. Cancelled  
    **Answer:** B

76. ROLLBACK undoes:  
    A. Schema changes  
    B. Committed data  
    C. Uncommitted data  
    D. Indexes  
    **Answer:** C

77. SAVEPOINT allows:  
    A. Full rollback only  
    B. Partial rollback  
    C. Commit  
    D. Lock  
    **Answer:** B

## Window Functions

78. OVER() is used with:  
    A. GROUP BY  
    B. Window functions  
    C. Subqueries  
    D. Joins  
    **Answer:** B

79. ROW_NUMBER() assigns:  
    A. Rank with gaps  
    B. Unique row number  
    C. Same rank  
    D. NTILE  
    **Answer:** B

80. DENSE_RANK() removes:  
    A. Rows  
    B. Columns  
    C. Rank gaps  
    D. Sorting  
    **Answer:** C

81. NTILE(4) divides data into:  
    A. 2 parts  
    B. 3 parts  
    C. 4 parts  
    D. 5 parts  
    **Answer:** C

## LEAD / LAG

82. LEAD() accesses:  
    A. Previous row  
    B. Next row  
    C. First row  
    D. Last row  
    **Answer:** B

83. LAG() accesses:  
    A. Next row  
    B. Previous row  
    C. Current row  
    D. Random row  
    **Answer:** B

## Performance

84. Execution plan shows:  
    A. SQL syntax  
    B. Query optimization steps  
    C. Permissions  
    D. Constraints  
    **Answer:** B

85. Which improves SELECT performance?  
    A. Views  
    B. Indexes  
    C. Triggers  
    D. Constraints  
    **Answer:** B

## Security

86. SQL Injection is prevented by:  
    A. Dynamic SQL  
    B. Hardcoding values  
    C. Parameterized queries  
    D. Views  
    **Answer:** C

87. GRANT is used to:  
    A. Delete user  
    B. Give permissions  
    C. Revoke access  
    D. Drop role  
    **Answer:** B

88. REVOKE removes:  
    A. Tables  
    B. Indexes  
    C. Permissions  
    D. Users  
    **Answer:** C

89. Role is:  
    A. User  
    B. Group of privileges  
    C. Table  
    D. Index  
    **Answer:** B

90. Data masking hides:  
    A. Tables  
    B. Queries  
    C. Sensitive data  
    D. Indexes  
    **Answer:** C

## Advanced

91. Cumulative sum uses:  
    A. GROUP BY  
    B. OVER()  
    C. JOIN  
    D. UNION  
    **Answer:** B

92. Moving average calculates:  
    A. Total  
    B. Max  
    C. Window-based average  
    D. Count  
    **Answer:** C

93. Optimizer hint is:  
    A. Mandatory  
    B. Optional suggestion  
    C. Error  
    D. Constraint  
    **Answer:** B

94. BULK INSERT is used for:  
    A. Deleting data  
    B. Fast data loading  
    C. Updating data  
    D. Querying data  
    **Answer:** B

95. Transaction log stores:  
    A. Queries  
    B. Table data  
    C. Transaction history  
    D. Indexes  
    **Answer:** C

96. Implicit transaction starts:  
    A. Automatically  
    B. Manually  
    C. After COMMIT  
    D. After ROLLBACK  
    **Answer:** A

97. Explicit transaction starts with:  
    A. SAVEPOINT  
    B. COMMIT  
    C. BEGIN TRANSACTION  
    D. END  
    **Answer:** C

98. Which clause sorts data?  
    A. GROUP BY  
    B. HAVING  
    C. ORDER BY  
    D. WHERE  
    **Answer:** C

99. Which function returns maximum value?  
    A. AVG  
    B. COUNT  
    C. MAX  
    D. SUM  
    **Answer:** C

100. Which ensures secure storage?  
     A. Index  
     B. Encryption  
     C. Join  
     D. View  
     **Answer:** B
