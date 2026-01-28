using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UserDaoLibrary
{
    class UserDao
    {
        private SQLiteConnection conn;

        public UserDao ()
        {
            // TODO - move this somewhere else 
            // in case the db moves location
            string connectionString = @"Data Source=c:\work\training\java\users.db";
            conn = new SQLiteConnection (connectionString);
            conn.Open ();
        }

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

        public User GetById(long id)
        {
            User user = new User();

            string sql = @$"SELECT * FROM users
                               WHERE id = {id}";

            var cmd = conn.CreateCommand();
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
            String sql = $"DELETE FROM users WHERE id = {id}";
            var cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            int n = cmd.ExecuteNonQuery();
            return n;
        }


        public int Update(User user)
        {
            string sql = @$"UPDATE users 
                SET name='{user.Name}', 
                    email='{user.Email}', 
                    active={(user.Active ? 1:0)} 
                WHERE id = {user.Id}";

            var cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            int n = cmd.ExecuteNonQuery();
            return n;
        }

        public User Add(User user)
        {
            string sql = $@"INSERT INTO users 
                    (name, email, active) 
                    VALUES(
                        '{user.Name}', 
                        '{user.Email}', 
                        {(user.Active?1:0)})";
            var cmd = conn.CreateCommand();
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
