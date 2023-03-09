Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
-------Migration Script
Add-Migration Init
Update-Database
--------------------Angular
npm install -g @angular/cli
Set-ExecutionPolicy -Scope CurrentUser -ExecutionPolicy RemoteSigned
ng new CRUD
----
cd CRUD
ng serve --open
---
ng generate component student