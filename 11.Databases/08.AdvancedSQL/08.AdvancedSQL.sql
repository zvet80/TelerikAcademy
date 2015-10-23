
--1. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
--Use a nested SELECT statement.

SELECT [FirstName]
      ,[LastName]      
      ,[Salary]
  FROM [TelerikAcademy].[dbo].[Employees]
  where [Salary] = (select min([Salary]) from [TelerikAcademy].[dbo].[Employees])

--2. Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.

SELECT [FirstName]
      ,[LastName]      
      ,[Salary]
  FROM [TelerikAcademy].[dbo].[Employees]
  where [Salary] < 1.1*(select min([Salary]) from [TelerikAcademy].[dbo].[Employees])

--3. Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
--Use a nested SELECT statement.

SELECT [FirstName]
      ,[LastName]      
      ,[Salary]
	  ,b.[Name] as Department
  FROM [TelerikAcademy].[dbo].[Employees] a
  join [TelerikAcademy].[dbo].[Departments] b on a.[DepartmentID] = b.[DepartmentID]
  where [Salary] = (select min([Salary]) from [TelerikAcademy].[dbo].[Employees]
					where a.[DepartmentID]=[DepartmentID])

--4. Write a SQL query to find the average salary in the department #1.

SELECT avg([Salary])
  FROM [TelerikAcademy].[dbo].[Employees]  
  where [DepartmentID]=1

--5. Write a SQL query to find the average salary in the "Sales" department.

SELECT avg([Salary])
  FROM [TelerikAcademy].[dbo].[Employees] a 
  join [TelerikAcademy].[dbo].[Departments] b on a.[DepartmentID] = b.[DepartmentID]
  where b.[Name]='Sales'

--6. Write a SQL query to find the number of employees in the "Sales" department.

  SELECT count([EmployeeID])
  FROM [TelerikAcademy].[dbo].[Employees] a 
  join [TelerikAcademy].[dbo].[Departments] b on a.[DepartmentID] = b.[DepartmentID]
  where b.[Name]='Sales'

--7. Write a SQL query to find the number of all employees that have manager.

  SELECT count([EmployeeID])
  FROM [TelerikAcademy].[dbo].[Employees] 
  where [ManagerID] is not null

--8. Write a SQL query to find the number of all employees that have no manager.

  SELECT count([EmployeeID])
  FROM [TelerikAcademy].[dbo].[Employees] 
  where [ManagerID] is null

--9. Write a SQL query to find all departments and the average salary for each of them.

SELECT avg([Salary]) as AverageSalary
	,b.[Name] as Department
  FROM [TelerikAcademy].[dbo].[Employees] a 
  join [TelerikAcademy].[dbo].[Departments] b on a.[DepartmentID] = b.[DepartmentID]
  group by b.[Name]

--10. Write a SQL query to find the count of all employees in each department and for each town.

SELECT count([EmployeeID]) as EmployeeCount
	,b.[Name] as Department
	,d.[Name] as Town
  FROM [TelerikAcademy].[dbo].[Employees] a 
  join [TelerikAcademy].[dbo].[Departments] b on a.[DepartmentID] = b.[DepartmentID]
  join [TelerikAcademy].[dbo].[Addresses] c on a.[AddressID] = c.[AddressID]
  join [TelerikAcademy].[dbo].[Towns] d on d.[TownID] = c.[TownID]
  group by b.[Name], d.[Name]

--11. Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.

SELECT m.[FirstName]
      ,m.[LastName]
	  ,count(e.[ManagerID]) as ManagedPeopleCount
  FROM [TelerikAcademy].[dbo].[Employees] e
   join [TelerikAcademy].[dbo].[Employees] m on e.[ManagerID] = m.[EmployeeID]
   group by m.[FirstName]
      ,m.[LastName]
   Having count(e.[ManagerID])=5
   
--12. Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".

SELECT a.[FirstName]
      ,a.[LastName]
	  ,isnull(b.[FirstName] + ' ' + b.[LastName], 'no manager') as Manager
  FROM [TelerikAcademy].[dbo].[Employees] a
   left join [TelerikAcademy].[dbo].[Employees] b on a.[ManagerID] = b.[EmployeeID]

--13. Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-inLEN(str) function.

SELECT [FirstName]
      ,[LastName]
  FROM [TelerikAcademy].[dbo].[Employees]
  where len([LastName])=5

--14. Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds".
--Search in Google to find how to format dates in SQL Server.

select FORMAT ( getdate(), 'dd.MM.yy hh:mm:ss:ms')

--15. Write a SQL statement to create a table Users. Users should have username, password, full name and last login time.
--Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
--Define the primary key column as identity to facilitate inserting records.
--Define unique constraint to avoid repeating usernames.
--Define a check constraint to ensure the password is at least 5 characters long.

CREATE TABLE Users (
	UserId int identity PRIMARY KEY,
	Username nvarchar(50) unique not null,
	Password nvarchar(50) not null check (len(Password)>5),
	FullName nvarchar(50) not null,
	LastLogin datetime
)
GO

--16. Write a SQL statement to create a view that displays the users from the Users table that have been in the system today.
--Test if the view works correctly.

CREATE VIEW UsersToday as
select Username
from Users
where convert(date,LastLogin)=convert(date,getdate())
GO
--17. Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint).
--Define primary key and identity column.

CREATE TABLE Groups (
	GroupId int identity,
	Name nvarchar(50) unique not null,
	constraint PK_Users primary key(GroupId)
)
GO

--18. Write a SQL statement to add a column GroupID to the table Users.
--Fill some data in this new column and as well in the `Groups table.
--Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.

ALTER TABLE Users
ADD GroupId int not null
GO

ALTER TABLE Users
ADD CONSTRAINT FK_GroupId
	FOREIGN KEY (GroupId)
	REFERENCES Groups(GroupId)
GO

--19. Write SQL statements to insert several records in the Users and Groups tables.

INSERT INTO Groups (Name)
VALUES('Apple'),
	  ('Raspberry'),
	  ('Cherry')

INSERT INTO Users(Username,Password,FullName,LastLogin,GroupId)
VALUES('user1','pass11','name1','2015-10-18 12:00:01',1),
	  ('user2','pass21','name2','2015-10-19 12:00:01',2),
	  ('user3','pass31','name3','2015-10-20 12:00:01',3),
	  ('user4','pass41','name4','2015-10-18 12:00:01',1),
	  ('user5','pass51','name5','2015-10-18 12:00:01',1)
GO

--20. Write SQL statements to update some of the records in the Users and Groups tables.

UPDATE Users
SET Username = 'Pesho'	
where GroupId=2	

UPDATE Users
SET Password = Replace(Password,'pass',	'password')

UPDATE Groups
	set Name = 'Coconut'
	where GroupId =2

--21. Write SQL statements to delete some of the records from the Users and Groups tables.

DELETE FROM Users
WHERE LastLogin>'2015-10-19'

DELETE FROM Groups
WHERE GroupId=2

--22. Write SQL statements to insert in the Users table the names of all employees from the Employees table.
--Combine the first and last names as a full name.
--For username use the first letter of the first name + the last name (in lowercase).
--Use the same for the password, and NULL for last login time.

INSERT INTO Users (Username,Password,FullName,LastLogin,GroupId)
(SELECT (LOWER(LEFT([FirstName],1) +[LastName])),
	   (LOWER(LEFT([FirstName],1)+[LastName])),
	   ([FirstName] + ' '+ [LastName]),
	   NULL,1
FROM [TelerikAcademy].[dbo].[Employees] 
where (len(LOWER(LEFT([FirstName],1)+[LastName])))>5)
GO

--23. Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.

UPDATE Users
SET Password = null
WHERE LastLogin<'2010-03-10'

--24. Write a SQL statement that deletes all users without passwords (NULL password).

DELETE FROM Users
WHERE Password is null

--25. Write a SQL query to display the average employee salary by department and job title.

SELECT avg([Salary]) as AverageSalary
	,[JobTitle]
	,b.[Name] as Department
  FROM [TelerikAcademy].[dbo].[Employees] a 
  join [TelerikAcademy].[dbo].[Departments] b on a.[DepartmentID] = b.[DepartmentID]
  group by b.[Name], [JobTitle]

--26. Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.
    
SELECT [FirstName] + ' ' + [LastName] 
	  ,[JobTitle]     
      ,[Salary]
	  ,b.[Name] as Department
  FROM [TelerikAcademy].[dbo].[Employees] a
  join [TelerikAcademy].[dbo].[Departments] b on a.[DepartmentID] = b.[DepartmentID]
  where [Salary] = (select min([Salary]) from [TelerikAcademy].[dbo].[Employees]
					where a.[DepartmentID]=[DepartmentID]
					and a.[JobTitle]=[JobTitle])


--27. Write a SQL query to display the town where maximal number of employees work.

SELECT TOP 1 count(*) as EmployeeCount
	,d.[Name] as Town
  FROM [TelerikAcademy].[dbo].[Employees] a 
  join [TelerikAcademy].[dbo].[Addresses] c on a.[AddressID] = c.[AddressID]
  join [TelerikAcademy].[dbo].[Towns] d on d.[TownID] = c.[TownID]
  group by d.[Name] 
  ORDER BY EmployeeCount DESC

--28. Write a SQL query to display the number of managers from each town.

SELECT count(*) as ManagersCount
	,d.[Name] as Town
  FROM [TelerikAcademy].[dbo].[Employees] a 
  join [TelerikAcademy].[dbo].[Addresses] c on a.[AddressID] = c.[AddressID]
  join [TelerikAcademy].[dbo].[Towns] d on d.[TownID] = c.[TownID]
  where a.EmployeeID in (select distinct ManagerID from [TelerikAcademy].[dbo].[Employees])
  group by d.[Name]  
  ORDER BY ManagersCount DESC 
  
--29. Write a SQL to create table WorkHours to store work reports for each employee (employee id, date, task, hours, comments).
--Don't forget to define identity, primary key and appropriate foreign key.

CREATE TABLE WorkHours (
	WorkHoursId int identity PRIMARY KEY,
	EmployeeID int not null,
	Task nvarchar(50) not null,
	Hours int not null,
	Date date,
	Comments nvarchar(500),
	CONSTRAINT FK_EmployeeID
	FOREIGN KEY (EmployeeID)
	REFERENCES [Employees](EmployeeID)
)
GO

--Issue few SQL statements to insert, update and delete of some data in the table.

INSERT INTO WorkHours([EmployeeID],Task,Hours,Date,Comments)
VALUES(1,'do something usefull 1',4,'2015-10-18',null),
	  (2,'do something usefull 2',5,'2015-10-19','not accomplished'),
	  (3,'do something usefull 3',8,'2015-10-20',null),
	  (4,'do something usefull 4',9,'2015-10-18','too late'),
	  (5,'do something usefull 5',4,'2015-10-18',null)
GO

UPDATE WorkHours
SET Comments='FORGET ABOUT IT'
WHERE Hours > 5

DELETE FROM WorkHours
WHERE Date<'2015-10-19'

--Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers.

CREATE TABLE WorkHoursLogs (
	WorkHoursLogsID int identity PRIMARY KEY,
	WorkHoursId int,
	EmployeeID int not null,
	Task nvarchar(50) not null,
	Hours int not null,
	Date date,
	Comments nvarchar(500),
	Command nvarchar(10) not null,
	CONSTRAINT FK_WorkHoursId
	FOREIGN KEY (WorkHoursId)
	REFERENCES WorkHours(WorkHoursId)
)
GO

--For each change keep the old record data, the new record data and the command (insert / update / delete).

CREATE TRIGGER trg_WorkHours_Insert ON WorkHours
FOR INSERT
AS
INSERT INTO WorkHoursLogs
(WorkHoursId,EmployeeID,Task,Hours,Date,Comments,Command)
SELECT WorkHoursId,EmployeeID,Task,Hours,Date,Comments,'INSERT'
FROM inserted
GO

CREATE TRIGGER trg_WorkHours_Update ON WorkHours
FOR UPDATE
AS
INSERT INTO WorkHoursLogs
(WorkHoursId,EmployeeID,Task,Hours,Date,Comments,Command)
SELECT WorkHoursId,EmployeeID,Task,Hours,Date,Comments,'UPDATE'
FROM inserted
GO

CREATE TRIGGER trg_WorkHours_Delete ON WorkHours
FOR DELETE
AS
INSERT INTO WorkHoursLogs
(WorkHoursId,EmployeeID,Task,Hours,Date,Comments,Command)
SELECT WorkHoursId,EmployeeID,Task,Hours,Date,Comments,'DELETE'
FROM deleted
GO


--30. Start a database transaction, delete all employees from the 'Sales' department along with all dependent records from the pother tables.
--At the end rollback the transaction.

BEGIN TRAN

ALTER TABLE [TelerikAcademy].[dbo].[Departments]
DROP CONSTRAINT FK_Departments_Employees

DELETE FROM [TelerikAcademy].[dbo].[Employees] 
where [DepartmentID] = (select [DepartmentID] from [TelerikAcademy].[dbo].[Departments]
  where [Name]='Sales')
DELETE [TelerikAcademy].[dbo].[Departments]
WHERE [Name]='Sales'

ROLLBACK TRAN


--31. Start a database transaction and drop the table EmployeesProjects.
--Now how you could restore back the lost table data?

BEGIN TRAN
DROP TABLE [TelerikAcademy].[dbo].[EmployeesProjects]
ROLLBACK TRAN

--32. Find how to use temporary tables in SQL Server.
--Using temporary tables backup all records from EmployeesProjects and restore them back after dropping and re-creating the table.

SELECT * INTO #tempEmployeesProjects
FROM [TelerikAcademy].[dbo].[EmployeesProjects]

DROP TABLE [TelerikAcademy].[dbo].[EmployeesProjects]

SELECT * INTO [TelerikAcademy].[dbo].[EmployeesProjects]
FROM #tempEmployeesProjects
