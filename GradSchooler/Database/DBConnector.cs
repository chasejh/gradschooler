﻿using System;
using MySql.Data.MySqlClient;

namespace GradSchooler.Database{
    // <summary>
    // Connects to database
    // </summary>
    public class DBConnector
    {

        // members
        private MySqlConnection conn;
        //used to be mal.cs.plu.edu
        private const string serverlocal = "localhost";
        private const string server = "SERVER_HERE";
        private const uint port = 2000; 
        private const string userID = "#";
        private const string password = "#";
        private const string database = "#";

        /// <summary>
        /// default constructor
        /// </summary>
        public DBConnector(){}

        /// <summary>
        /// opens the database
        /// </summary>
        public Boolean openDB()
        {
            try
            {
                MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder
                {
                    //Port = port,
                    Server = server,
                    UserID = userID,
                    Password = password,
                    Database = database
                };

                //create connection to database
                conn = new MySqlConnection(conn_string.ToString());
                conn.Open();
                
                return true;
            }
            catch(MySqlException)
            {
                
                return false;
            }//catch

        }//end openDB

        /// <summary>
        /// Closes the instance of the database connection
        /// </summary>
        public void closeDB()
        {
            if (conn != null) conn.Close();
            conn = null;
        }//end closeDB

        /// <summary>
        /// Returns the connection object to the database
        /// </summary>
        /// <returns>The MySQL connection</returns>
        public MySqlConnection getConn()
        {
            return conn;
        }//end getConn

    }//end class DBConnector
}//namespace
