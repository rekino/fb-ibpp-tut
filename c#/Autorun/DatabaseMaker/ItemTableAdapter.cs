using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMaker
{
    class ItemTableAdapter
    {
        public class Row
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public byte[] Icon { get; set; }
            public int Category { get; set; }
            public byte[] Image { get; set; }
            public string Version { get; set; }
            public float FileSize { get; set; }
            public int Disk { get; set; }
            public string Path { get; set; }
            public string Help { get; set; }
            public string Tags { get; set; }
        }

        FbConnection connection;

        string deleteCommand;
        string insertCommand;
        string selectCommand;

        public ItemTableAdapter(FbConnection connection)
        {
            deleteCommand = "DELETE FROM item WHERE ID=@id";
            insertCommand = "INSERT INTO item (id,name,description,icon,category,image,version,file_size,disk,path,help,tags)" +
                            "VALUES (@id,@name,@description,@icon,@category,@image,@version,@file_size,@disk,@path,@help,@tags)";
            selectCommand = "SELECT * FROM item";

            this.connection = connection;
        }

        public int Insert(string name, string description, byte[] icon, int category, 
            byte[] image, string version, float fileSize, int disk, string path, string help,
            string tags)
        {
            int new_id = 0;
            FbTransaction transaction = connection.BeginTransaction();

            FbCommand gen = new FbCommand("SELECT NEXT VALUE FOR gen_id FROM RDB$DATABASE", connection, transaction);

            using (var dr = gen.ExecuteReader())
            {
                if (dr.Read())
                {
                    new_id = dr.GetInt32(0);
                }
            }

            FbCommand cmd = new FbCommand(insertCommand, connection, transaction);
            cmd.Parameters.Add("@id", FbDbType.Integer);
            cmd.Parameters.Add("@name", FbDbType.VarChar);
            cmd.Parameters.Add("@description", FbDbType.Text);
            cmd.Parameters.Add("@icon", FbDbType.Binary);
            cmd.Parameters.Add("@category", FbDbType.Integer);
            cmd.Parameters.Add("@image", FbDbType.Binary);
            cmd.Parameters.Add("@version", FbDbType.VarChar);
            cmd.Parameters.Add("@file_size", FbDbType.Float);
            cmd.Parameters.Add("@disk", FbDbType.Integer);
            cmd.Parameters.Add("@path", FbDbType.VarChar);
            cmd.Parameters.Add("@help", FbDbType.Text);
            cmd.Parameters.Add("@tags", FbDbType.Text);

            cmd.Parameters[0].Value = new_id;
            cmd.Parameters[1].Value = name;
            cmd.Parameters[2].Value = description;
            cmd.Parameters[3].Value = icon;
            cmd.Parameters[4].Value = category;
            cmd.Parameters[5].Value = image;
            cmd.Parameters[6].Value = version;
            cmd.Parameters[7].Value = fileSize;
            cmd.Parameters[8].Value = disk;
            cmd.Parameters[9].Value = path;
            cmd.Parameters[10].Value = help;
            cmd.Parameters[11].Value = tags;

            cmd.ExecuteNonQuery();
            transaction.Commit();

            return new_id;
        }

        public int Insert(Row row)
        {
            return Insert(row.Name, row.Description, row.Icon, row.Category, row.Image, row.Version,
                row.FileSize, row.Disk, row.Path, row.Help, row.Tags);
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
                            nr.Icon = mStream.ToArray();
                        }
                    }
                    nr.Category = dr.GetInt32(4);
                    using (System.IO.Stream stream = dr.GetStream(5))
                    {
                        using (System.IO.MemoryStream mStream = new System.IO.MemoryStream())
                        {
                            stream.CopyTo(mStream);
                            nr.Image = mStream.ToArray();
                        }
                    }
                    nr.Version = dr.GetString(6);
                    nr.FileSize = dr.GetFloat(7);
                    nr.Disk = dr.GetInt32(8);
                    nr.Path = dr.GetString(9);
                    nr.Help = dr.GetString(10);
                    nr.Tags = dr.GetString(11);

                    rows.Add(nr);
                }
            }


            transaction.Commit();

            return rows.ToArray();
        }
    }
}
