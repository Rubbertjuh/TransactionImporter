﻿using System.Data.SqlClient;

namespace TransactionImporter.DAL
{
    public class ConnectionBuilder
    {
        private string Database = "dbi387545";
        private string Server = "mssql.fhict.local";
        private string User = "dbi387545";
        private string Password = "V3RiEXQArtZ8";

        public SqlConnection ConnectionString()
        {
            return new SqlConnection($"Server={Server};Database={Database};User Id={User};Password={Password}");
        }
    }
}