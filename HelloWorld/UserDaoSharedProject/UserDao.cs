using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UserDaoLibrary
{
    /// <summary>
    /// Class <c>UserDao</c> used to read and write User objects to a database.
    /// NB: Please call .Close() when finished with the DAO
    /// </summary>
    class UserDao
    {
        private SQLiteConnection conn;
        public string DatabaseFileName { get; set; } 
                
        public UserDao()
            :this("c:\\work\\training\\java\\users.db")
        {
           
        }
        public UserDao (string databaseFileName)
        {
            // TODO - move this somewhere else 
            // in case the db moves location
            DatabaseFileName = databaseFileName;
            string connectionString = @$"Data Source={DatabaseFileName}";
            conn = new SQLiteConnection(connectionString);
            conn.Open();
            DatabaseFileName = databaseFileName;
        }

        public void Close()
        {
            conn.Close();
        }
        /// <summary>
        /// Method <c>GetAll</c> get list of Users from database.
        /// </summary>
        public List<User> GetAll()
        {
            List<User> users = new List<User>();
            string sql = "SELECT * FROM users";
            var cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                var id = rdr.GetInt32(0);
                var name = rdr.GetString(1);
                var email = rdr.GetString(2);
                var active = rdr.GetBoolean(3);

                User u = new User
                {
                    Id = id,
                    Name = name,
                    Email = email,
                    Active = active
                };
                users.Add(u);
            }
            return users;
        }
        /// <summary>
        /// This method returns a specific user
        /// </summary>
        /// <param name="id">the id of the User to return.</param>
        public User GetById(long id)
        {
            User user = new User();

            string sql = @$"SELECT * FROM users WHERE id = @id";

            var cmd = conn.CreateCommand();
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.CommandText = sql;
            var rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                user.Id = rdr.GetInt64(0);
                user.Name = rdr.GetString(1);
                user.Email = rdr.GetString(2);
                user.Active = rdr.GetBoolean(3);
            }
            return user;
        }
        
        public int Delete(long id)
        {
            String sql = $"DELETE FROM users WHERE id = @id";
            var cmd = conn.CreateCommand();
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.CommandText = sql;
            int n = cmd.ExecuteNonQuery();
            return n;
        }


        public int Update(User user)
        {
            string sql = @$"UPDATE users 
                        SET name=@name, 
                            email=@email, 
                            active=@active
                        WHERE id = @id";
            
            var cmd = conn.CreateCommand();
            cmd.Parameters.Add(new SQLiteParameter("@name", user.Name));
            cmd.Parameters.Add(new SQLiteParameter("@email", user.Email));
            cmd.Parameters.Add(new SQLiteParameter("@active", user.Active));
            cmd.Parameters.Add(new SQLiteParameter("@id", user.Id));

            cmd.CommandText = sql;
            int n = cmd.ExecuteNonQuery();
            return n;
        }

        public User Add(User user)
        {
            string sql = $@"INSERT INTO users 
                        (name, email, active) 
                        VALUES(@name, @email, @active)";
            var cmd = conn.CreateCommand();
            cmd.Parameters.Add(new SQLiteParameter("@name", user.Name));
            cmd.Parameters.Add(new SQLiteParameter("@email", user.Email));
            cmd.Parameters.Add(new SQLiteParameter("@active", user.Active));

            cmd.CommandText = sql;
            int n = cmd.ExecuteNonQuery();

            // get the generated id 
            cmd.CommandText = "SELECT last_insert_rowid()";
            // if your query only returns a single value 
            // ExecuteScalar saves us having to create a Reader
            // and iterate to the first row
            long id = (long)cmd.ExecuteScalar();
            user.Id = id;
            return user;
        }
    }
}
