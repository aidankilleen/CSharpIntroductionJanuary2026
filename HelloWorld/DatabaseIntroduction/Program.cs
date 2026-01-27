using System.Data.SQLite;

Console.WriteLine("Database Introduction");
string connectionString = @"Data Source=c:\work\training\java\users.db";
SQLiteConnection conn = new SQLiteConnection(connectionString);
conn.Open();

string sql = "SELECT * FROM users";
var cmd = conn.CreateCommand();
cmd.CommandText = sql;
var rdr = cmd.ExecuteReader();

while (rdr.Read())
{
    var id = rdr["id"];
    var name = rdr["name"];
    var email = rdr["email"];
    var active = rdr.GetBoolean(3);

    Console.WriteLine($"{id} - {name} - {email} - {active}");
}
rdr.Close();

// insert 
sql = "INSERT INTO users (name, email, active) VALUES('New User', 'new.user@gmail.com', 1)";
cmd = conn.CreateCommand();
cmd.CommandText = sql;
int n = cmd.ExecuteNonQuery();

if (n > 0)
{
    Console.WriteLine("Row added");
}

sql = "";
cmd = conn.CreateCommand();
cmd.CommandText = sql;
n = cmd.ExecuteNonQuery();
if (n > 0)
{
    Console.WriteLine("Row updated");
}

// delete
sql = "DELETE FROM users WHERE id > 82";
cmd = conn.CreateCommand();
cmd.CommandText = sql;
n = cmd.ExecuteNonQuery();
if (n > 0)
{
    Console.WriteLine("Row deleted");
}



conn.Close();






