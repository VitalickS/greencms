using Modules.MySQL.Management;

var mysqlManager = new MySqlManager(args[0]);
await mysqlManager.CreateDatabaseAsync(args[1]);
Console.WriteLine("Database created");

