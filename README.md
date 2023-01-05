# CleanArchitectureTraining

To create a migrations in other layer, you must run this command (.NET 6)

dotnet ef --startup-project ../CleanArchitectureTraining migrations add InitialMigration

dotnet ef --startup-project ../ CleanArchitectureTraining database update
