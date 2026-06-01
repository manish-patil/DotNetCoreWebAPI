Command to create a .gitignore file for dotnet

> dotnet new gitignore


To create your initial database migration (create the app.db file) 

From Package Manager Console inside Visual Studio

> Add-Migration InitialCreate

Above command create the migrations in the Migrations folder.

Apply the Migration to Create the app.db File

> Update-Database