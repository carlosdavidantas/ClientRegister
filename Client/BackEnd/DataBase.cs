using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.BackEnd
{
    internal class DataBase
    {
        const string DATABASENAME = "CLIENT"; // Update "CLIENT" if you want another database name.
        const string CONNECTIONSTRING = "Server=localhost;Database=CLIENT;Trusted_Connection=True;"; // Update "CLIENT" if you want another database name.

        public void CreatDataBase()
        {
            string connectionString = "Server=localhost;Integrated security=SSPI;database=master";

            string queryString = $"CREATE DATABASE {DATABASENAME} ON PRIMARY " +
             $"(NAME = {DATABASENAME}_Data, " +
             $@"FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\{DATABASENAME}.mdf', " + //Check if your file location is the same and the version of the MSSQLSERVER.
             "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%)" +
             $"LOG ON (NAME = {DATABASENAME}_Log, " +
             $@"FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\{DATABASENAME}.ldf', " + //Check if your file location is the same and the version of the MSSQLSERVER.
             "SIZE = 1MB, " +
             "MAXSIZE = 5MB, " +
             "FILEGROWTH = 10%);";

            ExecuteQuery(queryString, connectionString);
        }

        public void CreateClientTable()
        {
            string queryString = "CREATE TABLE CLIENTS " +
                "([NAME] [VARCHAR] (100)," +
                "[AGE] [VARCHAR] (100)," +
                "[GENDER] [VARCHAR] (100)," +
                "[ID] [VARCHAR] (100));";

            ExecuteQuery(queryString);
        }

        public void InsertClient(ClientClass client)
        {
            string queryString = $"INSERT INTO [dbo].[CLIENTS]" +
                $"([NAME], [AGE], [GENDER], [ID]) " +
                $" VALUES ('{client.name}', '{client.age}', '{client.gender}', '{client.id}');";

            ExecuteQuery(queryString);
        }

        public ClientClass SearchClient(string id)
        {
            string searchQuery = $"SELECT * FROM [dbo].[CLIENTS] WHERE [ID] = '{id}'";
            ClientClass client = new ClientClass("", "", "", "");

            using (SqlConnection connectionString = new SqlConnection(CONNECTIONSTRING))
            using (SqlCommand myCommand = new SqlCommand(searchQuery, connectionString))
            {
                connectionString.Open();
                using (SqlDataReader reader = myCommand.ExecuteReader())
                {
                    try
                    {
                        while (reader.Read())
                        {
                            client.name = reader[0].ToString();
                            client.age = reader[1].ToString();
                            client.gender = reader[2].ToString();
                            client.id = reader[3].ToString();
                        }
                        Console.WriteLine("Query executed successfully!");
                    }
                    catch (Exception EX)
                    {
                        Console.WriteLine(EX);
                    }
                    if (client.name == null)
                    {
                        return null;
                    }
                    return client;
                }
            }
        }

        public void EditClientInfo(string id, ClientClass client)
        {
            string queryString = $"UPDATE [dbo].[CLIENTS] SET [NAME] = '{client.name}', [AGE] = '{client.age}'," +
                $" [GENDER] = '{client.gender}', [ID] = '{client.id}' " +
                $" WHERE [ID] = '{id}';";

            ExecuteQuery(queryString);
        }

        public void DeleteClient(string id)
        {
            string queryString = $"DELETE FROM [dbo].[CLIENTS] WHERE [ID] = '{id}';";
            ExecuteQuery(queryString);
        }

        private static void ExecuteQuery(string queryString, string stringConnection = CONNECTIONSTRING)
        {
            using (SqlConnection connectionString = new SqlConnection(stringConnection))
            using (SqlCommand myCommand = new SqlCommand(queryString, connectionString))
            {
                try
                {
                    connectionString.Open();
                    myCommand.ExecuteNonQuery();
                    Console.WriteLine("Query was executed successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
               
            }
        }
    }
}
