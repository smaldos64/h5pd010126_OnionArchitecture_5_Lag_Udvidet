# OnionArchitecture\_5\_Lag_Udvidet
Dette projekt er lavet for at vise, hvor let det er at f.eks. addere en ekstra database til et Onion Architecture Web APi projekt. I tilfældet her adderes der en MySQL Databse til den eksisterende MsSQL Database. 
For at opnå denne funktionalitet er Infrastructure laget splittet lidt op. Der er lavet 2 nye Class Library Projekter her i form af : MyBank.Infrastructure.Persistence.SQL og MyBank.Infrastructure.Persistence.MySQL. Det eneste formål disse 2 projekter har er, at de skal indeholde Migrations for henholdsvis MsSQL Databasen og MySQL Databasen. 
Herudover er der lavet/splittet op i 2 Web APi'er: MyBank.WebApi.SQL og MyBank.WebApi.MySQL. Dette er nødvendig, da formålet har været at begge Databaser skal være i spil på samme tid. Ellers kunne man have klaret det med en simpel konfigurationsstyring i ét Web APi projekt. 

For at få lavet de 2 nødvendige Databaser, skal man gøre som følger, når man står i Package Manger Console vinduet.:

1) For at få lavet (MsSQL) Databasen.

Add-Migration "NavnHer" -Project MyBank.Infrastructure.Persistence.SQL -StartupProject MyBank.WebApi.SQL

Og når man efterfølgende skal lave Databasen kan man bruge denne kommando:

Update-Database -Project MyBank.Infrastructure.Persistence.SQL -StartupProject MyBank.WebApi.SQL

2) For at få lavet (MySQL) Databasen.

Add-Migration "NavnHer" -Project MyBank.Infrastructure.Persistence.MySQL -StartupProject MyBank.WebApi.MySQL

Og når man efterfølgende skal lave Databasen kan man bruge denne kommando:

Update-Database -Project MyBank.Infrastructure.Persistence.MySQL -StartupProject MyBank.WebApi.SQL
