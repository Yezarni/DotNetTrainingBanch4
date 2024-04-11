using System.Data.SqlClient;

Console.WriteLine("Hello, World!");
SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
stringBuilder.DataSource = "USER";//sever name
stringBuilder.InitialCatalog = "Dotnettrainingbatch4"; //database name
stringBuilder.UserID = "sa";
stringBuilder.Password = "sasa@123";
SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);
connection.Open();
connection.Close();
Console.ReadKey();