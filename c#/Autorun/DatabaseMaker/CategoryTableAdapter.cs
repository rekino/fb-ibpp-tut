using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMaker
{
    class CategoryTableAdapter
    {
        public class Row
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public byte[] Image { get; set; }
        }

        FbConnection connection;

        string deleteCommand;
        string insertCommand;
        string selectCommand;

        public CategoryTableAdapter(FbConnection connection)
        {
            deleteCommand = "DELETE FROM category WHERE ID=@id";
            insertCommand = "INSERT INTO category (name,description,image)" +
                            "VALUES (@name,@description,@image)";
            selectCommand = "SELECT * FROM category";

            this.connection = connection;
        }

        public void Insert(string name, string description, byte[] image)
        {
            FbTransaction transaction = connection.BeginTransaction();

            FbCommand cmd = new FbCommand(insertCommand, connection, transaction);
            cmd.Parameters.Add("@name", FbDbType.VarChar);
            cmd.Parameters.Add("@description", FbDbType.Text);
            cmd.Parameters.Add("@image", FbDbType.Binary);

            cmd.Parameters[0].Value = name;
            cmd.Parameters[1].Value = description;
            cmd.Parameters[2].Value = image;

            cmd.ExecuteNonQuery();
            transaction.Commit();
        }

        public void Insert(Row row)
        {
            Insert(row.Name, row.Description, row.Image);
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
                    nr.Description = dr.GetString(2);
                    using (System.IO.Stream stream = dr.GetStream(3))
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
