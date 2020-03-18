/*
Data for seeding department model was imported from AdwentureWorks2014
database inside MSSql server. In order to import data, do a restore 
on AdwentureWorks database, use current db, and run following query

set identity_insert  [EmployeeManagmentNETCORE].[dbo].[Departments] on
insert into [EmployeeManagmentNETCORE].[dbo].[Departments](Id,Name,GroupName)
select DepartmentID,Name,GroupName from HumanResources.Department
set identity_insert  [EmployeeManagmentNETCORE].[dbo].[Departments] off

*/
