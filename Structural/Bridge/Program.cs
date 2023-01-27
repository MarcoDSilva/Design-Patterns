using Structural.Bridge.DatabasesExample.Logic;

DatabaseClient postgresDb = new DatabaseClient(new PostgreSQL());
postgresDb.Connect();
postgresDb.ExecuteQuery("select * from users");
postgresDb.Disconnect();

DatabaseClient mysqlDb = new DatabaseClient(new MySQL());
mysqlDb.Connect();
mysqlDb.ExecuteQuery("select * from users");
mysqlDb.Disconnect();


DatabaseClient sqlLiteDb = new DatabaseClient(new SQLite());
sqlLiteDb.Connect();
sqlLiteDb.ExecuteQuery("select * from users");
sqlLiteDb.Disconnect();