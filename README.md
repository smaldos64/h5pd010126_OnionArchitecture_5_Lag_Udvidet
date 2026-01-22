# OnionArchitecture\_5\_Lag_Udvidet

For at få lavet de 2 nødvendige Databaser, skal man gøre som følger, når man står i Package Manger Console vinduet.:

1) For at få lavet (MsSQL) Databasen.

Add-Migration "NavnHer" -Project MyBank.Infrastructure.Persistence.SQL -StartupProject MyBank.WebApi.SQL

Og når man efterfølgende skal lave Databasen kan man bruge denne kommando:

Update-Database -Project MyBank.Infrastructure.Persistence.SQL -StartupProject MyBank.WebApi.SQL

2) For at få lavet (MySQL) Databasen for Audit Web Api'et.

Add-Migration "NavnHer" -Project Audit.Infrastructure -StartupProject Audit.WebApi

Og når man efterfølgende skal lave Databasen kan man bruge denne kommando:

Update-Database -Project Audit.Infrastructure -StartupProject Audit.WebApi
