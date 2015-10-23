--1. Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and Accounts(Id(PK), PersonId(FK), Balance).

CREATE DATABASE AccountsData
USE AccountsData

CREATE TABLE Persons(
	Id int identity PRIMARY KEY,
	FirstName nvarchar(50) unique not null,
	LastName nvarchar(50) unique not null,
	SSN int not null
)
GO

CREATE TABLE Accounts(
	Id int identity PRIMARY KEY,
	PersonId int not null,
	Balance money not null,
	CONSTRAINT FK_PersonId
	FOREIGN KEY (PersonId)
	REFERENCES Persons(Id)
)
GO

--Insert few records for testing.

INSERT INTO Persons(FirstName,LastName,SSN)
VALUES ('Guy','Gilbert',166),
('Kevin','Brown',102),
('Roberto','Tamburello',193),
('Rob','Walters',155),
('Thierry','DHers',40),
('David','Bradley',199),
('JoLynn','Dobney',275),
('Ruth','Ellerbrock',108),
('Gail','Erickson',22),
('Barry','Johnson',285)
GO

INSERT INTO Accounts(PersonId,Balance)
VALUES (1,1166),
(2,1102),
(3,1193),
(4,1155),
(5,1040),
(6,1199),
(7,1275),
(8,1108),
(9,1022),
(10,1285)
GO


--Write a stored procedure that selects the full names of all persons.

CREATE PROC dbo.usp_PersonsFullName
AS
  SELECT FirstName+' ' + LastName as FullName 
  FROM Persons
GO

EXEC usp_PersonsFullName

--2. Create a stored procedure that accepts a number as a parameter and returns all persons who have more money in their accounts than the supplied number.

CREATE PROC usp_SelectPersonsByMoney(
  @minBalance int )
AS
  SELECT FirstName, LastName, Balance
  FROM Persons p,Accounts a
  WHERE p.Id=a.PersonId
  and Balance > @minBalance
  ORDER BY Balance desc
GO

EXEC usp_SelectPersonsByMoney 1100

--3. Create a function that accepts as parameters – sum, yearly interest rate and number of months.
--It should calculate and return the new sum.
--Write a SELECT to test whether the function works as expected.

CREATE FUNCTION dbo.ufn_CalcSumAfterInterest(
@sum money,
@annualInterest money,
@numberOfMonths int)
  RETURNS money
AS
BEGIN
  RETURN ROUND(@sum * (1+(@annualInterest/12)*@numberOfMonths),2)
END
GO

SELECT Balance
	 , ROUND(dbo.ufn_CalcSumAfterInterest(Balance,0.02,5),2) as BalaneAfterInterest
FROM Accounts

--4. Create a stored procedure that uses the function from the previous example to give an interest to a person's account for one month.
--It should take the AccountId and the interest rate as parameters.

CREATE PROCEDURE dbo.usp_AddInterestForOneMonth(@AccountId int, @InterestRate money)
AS
	DECLARE @currentBalance money = 
	(SELECT Balance FROM Accounts WHERE Id = @AccountId)
	UPDATE Accounts
	SET Balance = dbo.ufn_CalcSumAfterInterest(@currentBalance,@InterestRate,1)
	WHERE Id = @AccountId
GO

EXEC usp_AddInterestForOneMonth 2,0.05

--5. Add two more stored procedures WithdrawMoney(AccountId, money) and DepositMoney(AccountId, money) that operate in transactions.

CREATE PROCEDURE dbo.usp_WithdrawMoney(@AccountId int, @money money)
AS
	DECLARE @currentBalance money = 
	(SELECT Balance FROM Accounts WHERE Id = @AccountId)
	IF (@currentBalance>= @money)
		BEGIN
			BEGIN TRAN
				UPDATE Accounts
					SET Balance-= @money
					WHERE Id = @AccountId
			COMMIT TRAN
		END
	ELSE 
		BEGIN 
			PRINT 'Amount exceeds accout''s balance'
		END
GO
EXEC usp_WithdrawMoney 2,1000

CREATE PROCEDURE dbo.usp_DepositMoney(@AccountId int, @money money)
AS
	BEGIN TRAN
		UPDATE Accounts
			SET Balance+= @money
			WHERE Id = @AccountId
	COMMIT TRAN
GO
EXEC usp_DepositMoney 2,1000

--6. Create another table – Logs(LogID, AccountID, OldSum, NewSum).
--Add a trigger to the Accounts table that enters a new entry into the Logs table every time the sum on an account changes.

CREATE TABLE Logs(
	LogID int identity PRIMARY KEY,
	AccountID int not null,
	OldSum money not null,
	NewSum money not null
)
GO

CREATE TRIGGER tr_AccountUpdate ON Accounts FOR UPDATE
AS
  INSERT INTO Logs(AccountID,NewSum,OldSum)
		SELECT i.Id,i.Balance,d.Balance
		FROM inserted i, deleted d
		WHERE d.Id=i.Id
GO

EXEC usp_DepositMoney 2,1000
EXEC usp_AddInterestForOneMonth 2,0.05
SELECT * FROM Logs

--7. Define a function in the database TelerikAcademy that returns all Employee's names (first or middle or last name) and all town's names that are comprised of given set of letters.
--Example: 'oistmiahf' will return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.

USE TelerikAcademy

CREATE FUNCTION dbo.ufn_NamesComprisedOf(
@letters nvarchar(50))
RETURNS TABLE
AS
RETURN(
  SELECT Name
  FROM
	  (SELECT FirstName as Name FROM Employees
	  UNION
	  SELECT LastName as Name FROM Employees
	  UNION
	  SELECT MiddleName as Name FROM Employees
	  UNION
	  SELECT Name as Name FROM Towns) as #temp
  WHERE Name not LIKE '%[^'+@letters+']%'
  )
GO

SELECT * FROM ufn_NamesComprisedOf ('oistmiahf')

--8. Using database cursor write a T-SQL script that scans all employees and their addresses and prints all pairs of employees that live in the same town.

DECLARE @name1 nvarchar(50), 
@name2 nvarchar(50),
@town nvarchar(50)

DECLARE sameTownEmploeeysCursor CURSOR FOR
SELECT  e1.FirstName + ' ' + e1.LastName
	  , e2.FirstName + ' ' + e2.LastName
	  , t1.[Name] as Town	
  FROM [TelerikAcademy].[dbo].[Employees] e1 
  join [TelerikAcademy].[dbo].[Addresses] a1 on a1.[AddressID] = e1.[AddressID]
  join [TelerikAcademy].[dbo].[Towns] t1 on t1.[TownID] = a1.[TownID]
  join [TelerikAcademy].[dbo].[Employees] e2 on e1.EmployeeID <> e2.EmployeeID 
  join [TelerikAcademy].[dbo].[Addresses] a2 on a2.[AddressID] = e2.[AddressID]
  join [TelerikAcademy].[dbo].[Towns] t2 on t2.[TownID] = a2.[TownID] and t1.Name = t2.Name

OPEN sameTownEmploeeysCursor

FETCH NEXT FROM sameTownEmploeeysCursor INTO @name1, @name2, @town
WHILE @@FETCH_STATUS = 0
BEGIN
 PRINT @name1  + ' and ' + @name2 + ' live in ' +@town
 FETCH NEXT FROM sameTownEmploeeysCursor INTO @name1, @name2, @town
END
CLOSE sameTownEmploeeysCursor
DEALLOCATE sameTownEmploeeysCursor
GO

--9. *Write a T-SQL script that shows for each town a list of all employees that live in it.
--Sample output:
--Sofia -> Martin Kulov, George Denchev
--Ottawa -> Jose Saraiva

DECLARE @name nvarchar(50),
@town nvarchar(50),
@names nvarchar(2550),
@currentTown nvarchar(50)

DECLARE townCursor CURSOR FOR
SELECT e.FirstName + ' ' + e.LastName
	 , t.[Name] as Town
  FROM [TelerikAcademy].[dbo].[Employees] e
  join [TelerikAcademy].[dbo].[Addresses] a on e.[AddressID] = a.[AddressID]
  join [TelerikAcademy].[dbo].[Towns] t on t.[TownID] = a.[TownID]
  order by t.[Name]

OPEN townCursor

FETCH NEXT FROM townCursor INTO @name, @town
WHILE @@FETCH_STATUS = 0

BEGIN
 SET @names += @name + ','
 set @currentTown=@town
 FETCH NEXT FROM townCursor INTO @name, @town
 if(@currentTown<>@town)
	 begin
		 print @currentTown + ' -> ' + @names
		 set @names=''
	 end
END
CLOSE townCursor
DEALLOCATE townCursor

--10. Define a .NET aggregate function StrConcat that takes as input a sequence of strings and return a single string that consists of the input strings separated by ','.
--For example the following SQL statement should return a single string:
--SELECT StrConcat(FirstName + ' ' + LastName)
--FROM Employees

IF OBJECT_ID('dbo.StringConcat') IS NOT NULL DROP Aggregate StringConcat 
GO 

IF EXISTS (SELECT * FROM sys.assemblies WHERE name = 'StringConcat_assembly') 
       DROP assembly StringConcat_assembly; 
GO      

CREATE Assembly StringConcat_assembly 
   AUTHORIZATION dbo 
   FROM '..\bin\Debug\SqlClassLibrary.dll' 
   WITH PERMISSION_SET = SAFE; 
GO 

CREATE AGGREGATE dbo.StringConcat ( 

    @Value NVARCHAR(MAX) 
  , @Delimiter NVARCHAR(50) 

) RETURNS NVARCHAR(MAX) 
EXTERNAL Name StringConcat_assembly.StringConcat; 
GO  