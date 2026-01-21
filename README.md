# OnionArchitecture\_5\_Lag



For at lave en Migration på projektet kan man bruge denne kommando i Package Manager Console vinduet for at være sikker på, at det rigtige Migrations projekt er valgt. 

Og det rigtige projekt der indeholder Connectionstring til Databasen er valgt. 



**Add-Migration "NavnHer" -Project MyBank.Infrastructure -StartupProject MyBank.WebApi**



Og når man efterfølgende skal lave Databasen kan man bruge denne kommando i Package Manager Console vinduet:



**Update-Database -Project MyBank.Infrastructure -StartupProject MyBank.WebApi**

