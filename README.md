ASP NET.core application that covers mvc concepts of real-world enterprise class data driven web applications.

1. Delete migrations folder
2. To set instance of your LocalDB, open appsettings.json
"ConnectionStrings": {
    "FactoryDemo": "server=YourLocalDBInstanceName;database=FactoryDemo;Trusted_Connection=true"
  }
3. Open package manager console, enable migrations, add initial one and update the database 

OPTIONAL: For populating Department and Employee models I used AdwentureWorks database data. To import data, run DepartmentsImport.sql and EmployeesImport.sql on your SQL Server Management Studio.
