using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using static Tour.Provider.Connection.ConnectString;

namespace Tour.Provider.Connection
{
    public class ConnectSqlExecute
    {
        private Database dbConnect;

        #region Constructor
        public ConnectSqlExecute(ConnectCode _connect, string appid, string uid)
        {
            try
            {
                var strcon = UtilConnectString.GetConnectString(_connect);
                dbConnect = new SqlDatabase(strcon);
            }
            catch (Exception ex)
            {
                throw ex;
                //throw new DsoftException(ErrorSeverity.Error, ErrorCode.CouldNotOpenDBConnection,
                //    string.Format(ConstValue.ErrorSourceFormat, GetType().Name, MethodBase.GetCurrentMethod().Name),
                //    ex.Message, ex.StackTrace);
            }
        }
        #endregion Constructor

        /// <summary>
        /// Do not implement this method into new Involker
        /// </summary>
        public IEnumerable<T> ExecProcedure<T>(string ProcedureName) where T : new()
        {
            try
            {
                return ExecuteProcedure<T>(ProcedureName, new object[] { });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Do not implement this method into new Involker
        /// </summary>
        public IEnumerable<T> ExecProcedure<T>(string ProcedureName, object[] paramObj) where T : new()
        {
            try
            {
                return ExecuteProcedure<T>(ProcedureName, paramObj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private IEnumerable<T> ExecuteProcedure<T>(string ProcedureName, params object[] paramObj) where T : new()
        {
            try
            {
                return dbConnect.ExecuteSprocAccessor(ProcedureName, MapBuilder<T>.MapAllProperties().Build(), paramObj);
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (UnauthorizedAccessException ex)
            {
                throw ex;
            }
            catch (SecurityException ex)
            {
                throw ex;
            }
            catch (NotSupportedException ex)
            {
                throw ex;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object ExeScalar(string ProcedureName, params object[] paramObj)
        {
            try
            {
                return ExecuteScalar(ProcedureName, paramObj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private object ExecuteScalar(string ProcedureName, params object[] paramObj)
        {
            try
            {
                return dbConnect.ExecuteScalar(ProcedureName, paramObj);
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (UnauthorizedAccessException ex)
            {
                throw ex;
            }
            catch (SecurityException ex)
            {
                throw ex;
            }
            catch (NotSupportedException ex)
            {
                throw ex;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object ExeReader(string ProcedureName, params object[] paramObj)
        {
            try
            {
                return ExecuteReader(ProcedureName, paramObj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private object ExecuteReader(string ProcedureName, params object[] paramObj)
        {
            try
            {
                return dbConnect.ExecuteReader(ProcedureName, paramObj);
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (UnauthorizedAccessException ex)
            {
                throw ex;
            }
            catch (SecurityException ex)
            {
                throw ex;
            }
            catch (NotSupportedException ex)
            {
                throw ex;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        /// <summary>
        /// Build message string from a exception
        /// </summary>
        /// <param name="ex">Exception</param>
        /// <returns></returns>
        public static string ExceptionToMessage(Exception ex)
        {
            return DateTime.Now.ToString()
                + "\r\n Message: \r\n\t" + ex.Message
                + "\r\n StackTrace: \r\n\t" + ex.StackTrace
                + "\r\n Source: \r\n\t" + ex.Source;
        }

    }
}
