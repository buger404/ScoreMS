using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManageSystem
{
    public class DatabaseContext
    {
        public bool Success { get; set; }
        public Exception? Exception { get; set; }

        public DatabaseContext Else(Action<Exception> handler)
        {
            if (!Success)
            {
                handler(Exception!);
            }
            return this;
        }

        public DatabaseContext Else(Action handler) 
        { 
            if (!Success)
            {
                handler();
            }
            return this;
        }

        public DatabaseContext Then(Action handler)
        {
            if (Success)
            {
                handler();
            }
            return this;
        }
    }

    public static class Database
    {
        public static string databaseFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database.mdf");
        public static string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;
                                                   AttachDbFilename={databaseFilePath};
                                                   Integrated Security=True;
                                                   Connect Timeout=30";

        public static T Get<T>(this SqlDataReader reader, string name)
            => (T)reader[name];

        public static SqlCommand ToSqlCommand(this string command, params (string name, object value)[] args)
        {
            SqlCommand cmd = new SqlCommand(command);
            foreach(var arg in args)
            {
                cmd.Parameters.AddWithValue(arg.name, arg.value);
            }
            return cmd;
        }

        public static DatabaseContext Execute(params SqlCommand[] commands)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    foreach (SqlCommand command in commands)
                    {
                        command.Connection = connection;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                return new DatabaseContext()
                {
                    Success = false,
                    Exception = ex
                };
            }
            return new DatabaseContext()
            {
                Success = true
            };
        }

        public static void Query(SqlCommand command, Action<SqlDataReader> handler)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command.Connection = connection;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        handler.Invoke(reader);
                    }
                }
            }
        }

        public static DatabaseContext QueryFirst(SqlCommand command, Action<SqlDataReader> handler)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command.Connection = connection;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        return new DatabaseContext() 
                        { 
                            Success = false
                        };
                    }
                    handler.Invoke(reader);
                }
            }
            return new DatabaseContext()
            {
                Success = true
            };
        }
    }
}
