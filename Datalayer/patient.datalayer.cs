using System;
using System.Data;
using System.Diagnostics;

namespace Leaf.Datalayers.Patient
{
    public class DataLayer : Leaf.Data.DataLayerBase
    {

        public DataLayer()
            : base(Data.ConnectionDB.ConnectionString(Data.ConnectionDB.CENTER.LEAF_PRE))
        {

        }
        public DataLayer(Data.ConnectionDB.CENTER centre)
            : base(Data.ConnectionDB.ConnectionString(centre))
        {

        }

        public DataTable GetPatients(string user)
        {
            try
            {
                string sql = @"SELECT * FROM patients";

                return GetDataTable(sql, new Parameters("USUARI", DbType.String, user.ToLower()));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }
    }
}