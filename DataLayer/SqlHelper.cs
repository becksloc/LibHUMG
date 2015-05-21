using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Transactions;
using System.Data.Common;


namespace LibHUMG.DataAccess
{
    public class SqlHelper
    {

        public SqlHelper()
        {
        }

        #region private methods
        private static object CheckValue(object value)
        {
            if (value == null)
            {
                return DBNull.Value;
            }
            return value;
        }
        private static SqlConnection GetTransactionSqlConnection(string connectionString)
        {
            LocalDataStoreSlot namedDataSlot = Thread.GetNamedDataSlot("ConnectionDictionary");
            Dictionary<string, SqlConnection> data = (Dictionary<string, SqlConnection>)Thread.GetData(namedDataSlot);
            if (data == null)
            {
                data = new Dictionary<string, SqlConnection>();
                Thread.SetData(namedDataSlot, data);
            }
            SqlConnection connection = null;
            if (data.ContainsKey(connectionString))
            {
                return data[connectionString];
            }
            connection = new SqlConnection(connectionString);
            data.Add(connectionString, connection);
            Transaction.Current.TransactionCompleted += new TransactionCompletedEventHandler(Current_TransactionCompleted);
            return connection;
        }
        private static void Current_TransactionCompleted(object sender, TransactionEventArgs e)
        {
            Dictionary<string, SqlConnection> data = (Dictionary<string, SqlConnection>)Thread.GetData(Thread.GetNamedDataSlot("ConnectionDictionary"));
            if (data != null)
            {
                foreach (SqlConnection connection in data.Values)
                {
                    if ((connection != null) && (connection.State != ConnectionState.Closed))
                    {
                        connection.Close();
                    }
                }
                data.Clear();
            }
            Thread.FreeNamedDataSlot("ConnectionDictionary");
        }

        private static SqlCommand CreateCommand(SqlConnection connection, CommandType commandType, string commandText)
        {
            if ((connection != null) && (connection.State == ConnectionState.Closed))
            {
                connection.Open();
            }
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandText = commandText;
                command.CommandType = commandType;
                return command;
            }
        }

        private static SqlCommand CreateCommand(SqlConnection connection, CommandType commandType, string commandText, params object[] values)
        {
            if ((connection != null) && (connection.State == ConnectionState.Closed))
            {
                connection.Open();
            }
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandText = commandText;
                command.CommandType = commandType;
                if ((values == null) || (values.Length == 0))
                {
                    for (int j = 0; j < command.Parameters.Count; j++)
                    {
                        command.Parameters[j].Value = DBNull.Value;
                    }
                    return command;
                }
                command.Parameters.AddRange(values);
                return command;
            }
        }

        private static DataSet CreateDataSet(SqlCommand command)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
            }
        }

        private static DataTable CreateDataTable(SqlCommand command)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
        #endregion
        
        #region public methods
        public static DataSet ExecuteDataSet(string connectionString, CommandType commandType, string commandText)
        {
            return ExecuteDataSet(connectionString, commandType, commandText, (DbParameter[])null);
        }

        public static DataSet ExecuteDataSet(string connectionString, CommandType commandType, string commandText, params DbParameter[] parameters)
        {
            if (Transaction.Current == null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = CreateCommand(connection, commandType, commandText, parameters))
                    {
                        return CreateDataSet(command);
                    }
                }
            }
            using (SqlCommand command2 = CreateCommand(GetTransactionSqlConnection(connectionString), commandType, commandText, parameters))
            {
                return CreateDataSet(command2);
            }
        }

        public static void ExecuteNonQuery(string connectionString, CommandType commandType, string commandText)
        {
            ExecuteNonQuery(connectionString, commandType, commandText, (DbParameter[])null);
        }

        public static void ExecuteNonQuery(string connectionString, CommandType commandType, string commandText, params DbParameter[] parameters)
        {
            if (Transaction.Current == null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = CreateCommand(connection, commandType, commandText, parameters))
                    {
                        command.ExecuteNonQuery();
                    }
                    return;
                }
            }
            using (SqlCommand command2 = CreateCommand(GetTransactionSqlConnection(connectionString), commandType, commandText, parameters))
            {
                command2.ExecuteNonQuery();
            }
        }

        public static IDataReader ExecuteReader(string connectionString, CommandType commandType, string commandText)
        {
            return ExecuteReader(connectionString, commandType, commandText, (DbParameter[])null);
        }

        public static IDataReader ExecuteReader(string connectionString, CommandType commandType, string commandText, params DbParameter[] parameters)
        {
            if (Transaction.Current == null)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                using (SqlCommand command = CreateCommand(connection, commandType, commandText, parameters))
                {
                    return command.ExecuteReader(CommandBehavior.CloseConnection);
                }
            }
            using (SqlCommand command2 = CreateCommand(GetTransactionSqlConnection(connectionString), commandType, commandText, parameters))
            {
                return command2.ExecuteReader();
            }
        }

        public static object ExecuteScalar(string connectionString, CommandType commandType, string commandText, params DbParameter[] parameters)
        {
            if (Transaction.Current == null)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                using (SqlCommand command = CreateCommand(connection, commandType, commandText, parameters))
                {
                    return command.ExecuteScalar();
                }
            }
            using (SqlCommand command2 = CreateCommand(GetTransactionSqlConnection(connectionString), commandType, commandText, parameters))
            {
                return command2.ExecuteScalar();
            }
        }

        #endregion
    }
}
