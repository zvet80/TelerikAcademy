
--1. What is SQL? What is DML? What is DDL? Recite the most important SQL commands.
--------------------------------------------------------------------------------------------
	--SQL-Structured Query Language) is a special-purpose programming language designed for managing data held in a relational database management system
	--DML - Data Manipulation Language statements are used for managing data
	--		SELECT - retrieve data from the a database
	--		INSERT - insert data into a table
	--		UPDATE - updates existing data within a table
	--		DELETE - deletes all records from a table, the space for the records remain
	--DDL - Data Definition Language statements are used to define the database structure or schema
	--		CREATE - to create objects in the database
	--		ALTER - alters the structure of the database
	--		DROP - delete objects from the database
	--		TRUNCATE - remove all records from a table, including all spaces allocated for the records are removed
---------------------------------------------------------------------------------------------
--2. What is Transact-SQL (T-SQL)?
---------------------------------------------------------------------------------------------
--T-SQL (Transact-SQL) is a set of programming extensions from Sybase and Microsoft that add several features to SQL including transaction control, exception and error handling, row processing, and declared variables. 
---------------------------------------------------------------------------------------------
--3. Start SQL Management Studio and connect to the database TelerikAcademy. Examine the major tables in the "TelerikAcademy" database.
---------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------
--4. Write a SQL query to find all information about all departments (use "TelerikAcademy" database).
---------------------------------------------------------------------------------------------
SELECT *
  FROM [TelerikAcademy].[dbo].[Departments]
---------------------------------------------------------------------------------------------
--5. Write a SQL query to find all department names.
---------------------------------------------------------------------------------------------
SELECT [Name]
  FROM [TelerikAcademy].[dbo].[Departments]
---------------------------------------------------------------------------------------------
--6. Write a SQL query to find the salary of each employee.
---------------------------------------------------------------------------------------------
SELECT [FirstName]
      ,[LastName]
      ,[Salary]
  FROM [TelerikAcademy].[dbo].[Employees]
---------------------------------------------------------------------------------------------
--7. Write a SQL to find the full name of each employee.
---------------------------------------------------------------------------------------------
SELECT [FirstName] + ' ' + 
		isnull([MiddleName], '')
		+ ' ' + [LastName] as FullName
  FROM [TelerikAcademy].[dbo].[Employees]
---------------------------------------------------------------------------------------------
--8. Write a SQL query to find the email addresses of each employee (by his first and last name). Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". The produced column should be named "Full Email Addresses".
---------------------------------------------------------------------------------------------
SELECT [FirstName] + '.' + [LastName] + '@telerik.com' as FullEmailAddresses
  FROM [TelerikAcademy].[dbo].[Employees]
---------------------------------------------------------------------------------------------
--9. Write a SQL query to find all different employee salaries.
---------------------------------------------------------------------------------------------
SELECT distinct [Salary]
  FROM [TelerikAcademy].[dbo].[Employees]
---------------------------------------------------------------------------------------------
--10. Write a SQL query to find all information about the employees whose job title is “Sales Representative“.
---------------------------------------------------------------------------------------------
SELECT *
  FROM [TelerikAcademy].[dbo].[Employees]
  where [JobTitle] = 'Sales Representative'
---------------------------------------------------------------------------------------------
--11. Write a SQL query to find the names of all employees whose first name starts with "SA".
---------------------------------------------------------------------------------------------
SELECT [FirstName]
      ,[LastName]
      ,[MiddleName]
  FROM [TelerikAcademy].[dbo].[Employees]
  where [FirstName] like 'SA%' 
---------------------------------------------------------------------------------------------
--12. Write a SQL query to find the names of all employees whose last name contains "ei".
---------------------------------------------------------------------------------------------
SELECT [FirstName]
      ,[LastName]
      ,[MiddleName]
  FROM [TelerikAcademy].[dbo].[Employees]
  where [LastName] like '%ei%'
---------------------------------------------------------------------------------------------
--13. Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].
---------------------------------------------------------------------------------------------
SELECT [FirstName]
      ,[LastName]
      ,[MiddleName]
	  ,[Salary]
  FROM [TelerikAcademy].[dbo].[Employees]
  where [Salary] >= 20000 and [Salary] <= 30000
---------------------------------------------------------------------------------------------
--14. Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.
---------------------------------------------------------------------------------------------
SELECT [FirstName]
      ,[LastName]
      ,[MiddleName]
	  ,[Salary]
  FROM [TelerikAcademy].[dbo].[Employees]
  where [Salary] in (25000,14000,12500,23600)
---------------------------------------------------------------------------------------------
--15. Write a SQL query to find all employees that do not have manager.
---------------------------------------------------------------------------------------------
SELECT [FirstName]
      ,[LastName]
      ,[MiddleName]
  FROM [TelerikAcademy].[dbo].[Employees]
  where [ManagerID] is null
---------------------------------------------------------------------------------------------
--16. Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.
---------------------------------------------------------------------------------------------
SELECT [FirstName]
      ,[LastName]
      ,[MiddleName]
	  ,[Salary]
  FROM [TelerikAcademy].[dbo].[Employees]
  where [Salary] > 50000
  order by [Salary] desc
---------------------------------------------------------------------------------------------
--17. Write a SQL query to find the top 5 best paid employees.
---------------------------------------------------------------------------------------------
SELECT top 5 [FirstName]
      ,[LastName]
      ,[MiddleName]
	  ,[Salary]
  FROM [TelerikAcademy].[dbo].[Employees]
  order by [Salary] desc
---------------------------------------------------------------------------------------------
--18. Write a SQL query to find all employees along with their address. Use inner join with ON clause.
---------------------------------------------------------------------------------------------
SELECT [FirstName]
      ,[LastName]
	  ,[AddressText]
	  ,[Name] as Town
  FROM [TelerikAcademy].[dbo].[Employees] a 
  inner join [TelerikAcademy].[dbo].[Addresses] b on a.[AddressID] = b.[AddressID]
  inner join [TelerikAcademy].[dbo].[Towns] c on c.[TownID] = b.[TownID]
---------------------------------------------------------------------------------------------
--19. Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).
---------------------------------------------------------------------------------------------
SELECT [FirstName]
      ,[LastName]
	  ,[AddressText]
	  ,[Name] as Town
  FROM [TelerikAcademy].[dbo].[Employees] a,
   [TelerikAcademy].[dbo].[Addresses] b, 
   [TelerikAcademy].[dbo].[Towns] c
  where a.[AddressID] = b.[AddressID]
  and  c.[TownID] = b.[TownID]
---------------------------------------------------------------------------------------------
--20. Write a SQL query to find all employees along with their manager.
---------------------------------------------------------------------------------------------
SELECT a.[FirstName]
      ,a.[LastName]
	  ,a.[JobTitle]
	  ,b.[FirstName] + ' ' + b.[LastName] as Manager
  FROM [TelerikAcademy].[dbo].[Employees] a
   left join [TelerikAcademy].[dbo].[Employees] b on a.[ManagerID] = b.[EmployeeID]
---------------------------------------------------------------------------------------------
--21. Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: Employees e,Employees m and Addresses a.
---------------------------------------------------------------------------------------------
SELECT e.[FirstName]
      ,e.[LastName]
	  ,e.[JobTitle]
	  ,m.[FirstName] + ' ' + m.[LastName] as Manager
	  ,[AddressText]
  FROM [TelerikAcademy].[dbo].[Employees] e
   left join [TelerikAcademy].[dbo].[Employees] m on e.[ManagerID] = m.[EmployeeID]
   left join [TelerikAcademy].[dbo].[Addresses] a on a.[AddressID] = e.[AddressID]
---------------------------------------------------------------------------------------------
--22. Write a SQL query to find all departments and all town names as a single list. Use UNION.
---------------------------------------------------------------------------------------------
SELECT [Name]
  FROM [TelerikAcademy].[dbo].[Departments]
union
SELECT [Name]
  FROM [TelerikAcademy].[dbo].[Towns]
---------------------------------------------------------------------------------------------
--23. Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.
---------------------------------------------------------------------------------------------
SELECT a.[FirstName]
      ,a.[LastName]
	  ,a.[JobTitle]
	  ,b.[FirstName] + ' ' + b.[LastName] as Manager
  FROM [TelerikAcademy].[dbo].[Employees] b
   right outer join [TelerikAcademy].[dbo].[Employees] a on a.[ManagerID] = b.[EmployeeID]

SELECT a.[FirstName]
      ,a.[LastName]
	  ,a.[JobTitle]
	  ,b.[FirstName] + ' ' + b.[LastName] as Manager
  FROM [TelerikAcademy].[dbo].[Employees] a
   left outer join [TelerikAcademy].[dbo].[Employees] b on a.[ManagerID] = b.[EmployeeID]
---------------------------------------------------------------------------------------------
--24. Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.
---------------------------------------------------------------------------------------------
SELECT a.[FirstName]
      ,a.[LastName]
	  ,a.[HireDate]
	  ,b.[Name] as Department
  FROM [TelerikAcademy].[dbo].[Employees] a
   left join [TelerikAcademy].[dbo].[Departments] b on a.[DepartmentID] = b.[DepartmentID]
   where b.[Name] in ('Sales', 'Finance')
   and year([HireDate]) between 1995 and 2005