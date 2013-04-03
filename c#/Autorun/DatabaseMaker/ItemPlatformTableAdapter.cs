using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMaker
{
    class ItemPlatformTableAdapter
    {
        public class Row
        {
            public int ItemId { get; set; }
            public int PlatformId { get; set; }
        }

        FbConnection connection;

        string deleteCommand;
        string insertCommand;
        string selectCommand;

        public ItemPlatformTableAdapter(FbConnection connection)
        {
            deleteCommand = "DELETE FROM item_platform WHERE item_id=@item_id AND platform_id=@plat_id";
            insertCommand = "INSERT INTO platform (ITEM_ID,PLATFORM_ID)" +
                            "VALUES (@item_id,@plat_id)";
            selectCommand = "SELECT * FROM item_platform";

            this.connection = connection;
        }

        public void Insert(int itemId, int platformId)
        {
            FbTransaction transaction = connection.BeginTransaction();

            FbCommand cmd = new FbCommand(insertCommand, connection, transaction);
            cmd.Parameters.Add("@item_id", FbDbType.Integer);
            cmd.Parameters.Add("@plat_id", FbDbType.Integer);

            cmd.Parameters[0].Value = itemId;
            cmd.Parameters[1].Value = platformId;

            cmd.ExecuteNonQuery();
            transaction.Commit();
        }

        public void Insert(Row row)
        {
            Insert(row.ItemId, row.PlatformId);
        }

        public void Delete(int itemId, int platformId)
        {
            FbTransaction transaction = connection.BeginTransaction();

            FbCommand cmd = new FbCommand(deleteCommand, connection, transaction);
            cmd.Parameters.Add("@item_id", FbDbType.Integer);
            cmd.Parameters.Add("@plat_id", FbDbType.Integer);

            cmd.Parameters[0].Value = itemId;
            cmd.Parameters[1].Value = platformId;

            cmd.ExecuteNonQuery();
            transaction.Commit();
        }

        public Row[] Select()
        {
            FbTransaction transaction = connection.BeginTransaction();

            FbCommand cmd = new FbCommand(selectCommand, connection, transaction);

            List<Row> rows = new List<Row>();
            Row nr;
            
            using (FbDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    nr = new Row();
                    nr.ItemId = dr.GetInt32(0);
                    nr.PlatformId = dr.GetInt32(1);

                    rows.Add(nr);
                }
            }
            

            transaction.Commit();

            return rows.ToArray();
        }
    }
}
