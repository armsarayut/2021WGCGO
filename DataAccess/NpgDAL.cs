using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Npgsql;
using System.Linq;
using System.Threading.Tasks;
using NpgsqlTypes;
using System.Text;

namespace GoWMS.Server.DataAccess
{
    public class NpgDAL
    {
        public DataSet SQLExecuteSQLQueryFill(NpgsqlCommand sqlCmd)
        {
            DataSet retDS = new DataSet();
        //    NpgsqlConnection objConn = new NpgsqlConnection();
        //    try
        //    {
        //        objConn.Open();
        //    }
        //    catch (NpgsqlException exp)
        //    {
        //        string msgexcep = exp.Message.ToString();
        //        goto ConnClose;
        //    }
            
        //    try
        //    {
        //        sqlCmd.Connection = objConn;
        //        NpgDataAdapter da = new NpgDataAdapter();
        //        da.SelectCommand = sqlCmd;
        //        da.SelectCommand.CommandTimeout = 0;
        //        da.Fill(retDS);

        //    }
        //    catch (NpgsqlException exp)
        //    {
        //        string msgexcep = exp.Message.ToString();
        //    }
        //    finally
        //    {
        //        objConn.Close();
        //    }
        //ConnClose:
            return retDS;
        }
    }
}
