<img width="958" height="446" alt="image" src="https://github.com/user-attachments/assets/721e9392-09b8-40eb-8359-a5c610ad0270" />


To create your initial database migration (create the app.db file) 

From Package Manager Console inside Visual Studio

> Add-Migration

Above command create the migrations in the Migrations folder.

Apply the Migration to Create the app.db File

> Update-Database

To Remove the last Migration

- If Update-Database is not called. (Never delete the migration manually)

> Remove-Migration

- If Database is updated 

> Update-Database -TargetMigration NameOfPreviousMigration

> Remove-Migration

--------------------------

Command to create a .gitignore file for dotnet

> dotnet new gitignore
