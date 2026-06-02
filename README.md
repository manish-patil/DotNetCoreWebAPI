Command to create a .gitignore file for dotnet

> dotnet new gitignore


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
