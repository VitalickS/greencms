using Modules.TestModule;

var mysqlManager = new MySqlManager(args.First());
await mysqlManager.CreateDatabaseAsync(args.Skip(1).First());
Console.WriteLine("Database created");

