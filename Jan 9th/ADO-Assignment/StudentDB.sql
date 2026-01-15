CREATE DATABASE StudentDB;
GO

USE StudentDB;
GO

CREATE TABLE Students
(
	StudentId INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(50),
	Age INT,
	Course VARCHAR(50)
);

INSERT INTO Students(Name, Age, Course) VALUES
('Amit', 21, 'C#'),
('Neha', 22, 'Java'),
('Rahul', 24, 'Python');
