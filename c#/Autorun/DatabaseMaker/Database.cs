using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseMaker
{
    class Database
    {
        public static Database Instance = new Database();

        FbConnection connection;
        FbConnectionStringBuilder csBuilder;

        PlatformTableAdapter platform;
        CategoryTableAdapter category;
        ItemTableAdapter item;
        ItemPlatformTableAdapter itemPlatform;

        internal ItemPlatformTableAdapter ItemPlatform
        {
            get { return itemPlatform; }
        }

        internal ItemTableAdapter Item
        {
            get { return item; }
        }

        public CategoryTableAdapter Category
        {
            get { return category; }
        }

        public PlatformTableAdapter Platform
        {
            get { return platform; }
        }

        private Database()
        {
            csBuilder = new FbConnectionStringBuilder();
            csBuilder.Charset = "UTF8";
            csBuilder.DataSource = "localhost";
            csBuilder.Database = @"D:\AUTORUN_V1.1.fdb";
            csBuilder.UserID = "SYSDBA";
            csBuilder.Password = "masterkey";

            connection = new FbConnection(csBuilder.ConnectionString);

            platform = new PlatformTableAdapter(connection);
            category = new CategoryTableAdapter(connection);
            item = new ItemTableAdapter(connection);
            itemPlatform = new ItemPlatformTableAdapter(connection);
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
