To add a new migration use: 
```
dotnet ef migrations add MigrationName --project Infraestructure/Repository --startup-project Application/BingoAPI
```

To update the database to the latest migration use: 
```
dotnet ef database update --project Infraestructure/Repository --startup-project Application/BingoAPI
```
