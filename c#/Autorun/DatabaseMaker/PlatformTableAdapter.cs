using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FirebirdSql.Data.FirebirdClient;

namespace DatabaseMaker
{
    class PlatformTableAdapter
    {
        public class Row
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public byte[] Image { get; set; }
        }

        FbConnection connection;

        string deleteCommand;
        string insertCommand;
        string selectCommand;

        public PlatformTableAdapter(FbConnection connection)
        {
            deleteCommand = "DELETE FROM platform WHERE ID=@id";
            insertCommand = "INSERT INTO platform (NAME,IMAGE)" +
                            "VALUES (@name,@image)";
            selectCommand = "SELECT * FROM platform";

            this.connection = connection;
        }

        public void Insert(string name, byte[] image)
        {
            FbTransaction transaction = connection.BeginTransaction();

            FbCommand cmd = new FbCommand(insertCommand, connection, transaction);
            cmd.Parameters.Add("@name", FbDbType.VarChar);
            cmd.Parameters.Add("@image", FbDbType.Binary);

            cmd.Parameters[0].Value = name;
            cmd.Parameters[1].Value = image;

            cmd.ExecuteNonQuery();
            transaction.Commit();
        }

        public void Insert(Row row)
        {
            Insert(row.Name, row.Image);
        }

        public void Delete(int id)
        {
            FbTransaction transaction = connection.BeginTransaction();

            FbCommand cmd = new FbCommand(deleteCommand, connection, transaction);
            cmd.Parameters.Add("@id", FbDbType.Integer);

            cmd.Parameters[0].Value = id;

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
                    nr.ID = dr.GetInt32(0);
                    nr.Name = dr.GetString(1);
                    using (System.IO.Stream stream = dr.GetStream(2))
                    {
                        using (System.IO.MemoryStream mStream = new System.IO.MemoryStream())
                        {
                            stream.CopyTo(mStream);
                            nr.Image = mStream.ToArray();
                        }
                    }

                    rows.Add(nr);
                }
            }
            

            transaction.Commit();

            return rows.ToArray();
        }
    }
}
