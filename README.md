# IKHWEZI Driving School Management System

This repository contains the Windows desktop application, built with C#, Windows Forms, .NET Framework 4.7.2, and Microsoft SQL Server. It uses ADO.NET and typed DataSets to work with driving school records.

## Desktop workflows

| Role | Workflows in the source |
| --- | --- |
| Manager | Review dashboard summaries and manage student, instructor, and vehicle records |
| Receptionist | Register students, book lessons, view session assignments, and verify or record payments |
| Instructor | View assigned sessions,and update lesson status |

The desktop application includes transaction history, password reset, and email notifications. Password reset emails and notifications require email settings to be configured.

## Run locally

1. On Windows, install Visual Studio with the **.NET desktop development** workload and the **.NET Framework 4.7.2 Developer Pack**. Install SQL Server or SQL Server Express LocalDB.
2. Copy `App.config.example` to `App.config` in the solution folder. Set the connection string in that copy to your local SQL Server test database. The example uses Windows authentication and a database named `IkhweziDemo`.
3. Open `Driving school login form.sln`, restore NuGet packages, and build the solution.
4. To test sign-in and other features that use the database, set up the required tables in a local SQL Server database and create test staff accounts. This repository does not include a database setup script or sample accounts.

