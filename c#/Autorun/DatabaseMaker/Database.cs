using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMaker
{
    class Database
    {
        public static Database Instance = new Database();

        DatabaseMaker.DataSet ds;
        DataSetTableAdapters.TableAdapterManager adapter;

        DataSetTableAdapters.CATEGORYTableAdapter category;
        DataSetTableAdapters.ITEM_PLATFORMTableAdapter itemPlatform;
        DataSetTableAdapters.ITEMTableAdapter item;
        DataSetTableAdapters.PLATFORMTableAdapter platform;

        private Database()
        {
            ds = new DataSet();

            category = new DataSetTableAdapters.CATEGORYTableAdapter();
            itemPlatform = new DataSetTableAdapters.ITEM_PLATFORMTableAdapter();
            item = new DataSetTableAdapters.ITEMTableAdapter();
            platform = new DataSetTableAdapters.PLATFORMTableAdapter();

        }
    }
}
