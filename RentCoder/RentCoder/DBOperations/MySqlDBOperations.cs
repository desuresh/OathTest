using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RentCoder.Models;
using MySql.Data.MySqlClient;
using System.Configuration;
namespace RentCoder.Repository
{
    public class MySqlDBOperations : IDBOperations
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public MySqlDBOperations()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
          
            string connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();

            connection = new MySqlConnection(connectionString);
        }

        //Insert statement
        public void Insert(string query)
        {
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
             
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

      
    }
}