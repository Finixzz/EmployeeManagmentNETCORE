USE EmployeeManagmentNETCORE
GO

SET IDENTITY_INSERT Employees ON
INSERT INTO Employees(Id,FirstName,LastName,Email,DepartmentId)
select 
	E.BusinessEntityID,
	P.FirstName,
	P.LastName,
	SUBSTRING(E.LoginID,CHARINDEX('\',E.LoginID)+1,len(E.LoginID))+'@gmail.com',
	D.DepartmentID
from 
	[AdventureWorks2014].HumanResources.Employee as E inner join [AdventureWorks2014].HumanResources.EmployeeDepartmentHistory as D
		on E.BusinessEntityID=D.BusinessEntityID
	inner join [AdventureWorks2014].Person.Person as P
		on E.BusinessEntityID=P.BusinessEntityID
where E.BusinessEntityID not in (4,16,224,234,250)
order by E.BusinessEntityID
SET IDENTITY_INSERT Employees OFF
