using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ConfigConection
    {
        public OracleConnection Connection;

        public ConfigConection(string conection)
        {
            Connection = new OracleConnection(conection);
        }

        public void Open()
        {
            Connection.Open();
        }
        public void Close()
        {
            Connection.Close();
        }


    }
}
