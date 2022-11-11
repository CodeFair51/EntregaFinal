using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace AccessData
{
    public class DataBase
    {
        private MySqlConnection _objSqlConnection;
        private MySqlDataAdapter _objSqlDataAdapter;
        private MySqlCommand _objSqlCommand;
        private DataSet _dsResults;
        private DataTable _dtParameters;
        private string _nameDB, _tableName, _nameSP, _errorMessageDB, _scalarValue, _stringConnection;
        private bool _scalar;

        public MySqlConnection ObjSqlConnection { get => _objSqlConnection; set => _objSqlConnection = value; }
        public MySqlDataAdapter ObjSqlDataAdapter { get => _objSqlDataAdapter; set => _objSqlDataAdapter = value; }
        public MySqlCommand ObjSqlCommand { get => _objSqlCommand; set => _objSqlCommand = value; }
        public DataSet DsResults { get => _dsResults; set => _dsResults = value; }
        public DataTable DtParameters { get => _dtParameters; set => _dtParameters = value; }
        public string NameDB { get => _nameDB; set => _nameDB = value; }
        public string TableName { get => _tableName; set => _tableName = value; }
        public string NameSP { get => _nameSP; set => _nameSP = value; }
        public string ErrorMessageDB { get => _errorMessageDB; set => _errorMessageDB = value; }
        public string ScalarValue { get => _scalarValue; set => _scalarValue = value; }
        public string StringConnection { get => _stringConnection; set => _stringConnection = value; }
        public bool Scalar { get => _scalar; set => _scalar = value; }

        public DataBase()
        {
            DtParameters = new DataTable("SpParameters");
            DtParameters.Columns.Add("Name");
            DtParameters.Columns.Add("DataType");
            DtParameters.Columns.Add("Value");

            NameDB = "db_proyecto";
        }

        private void CreateStringConnection(ref DataBase objDataBase)
        {
            MySqlConnectionStringBuilder objSqlConnectionBuilder = new MySqlConnectionStringBuilder()
            {
                Server = "localhost",
                Database = objDataBase.NameDB,
                UserID = "root",
                Password = "matiti12"
            };
            objDataBase.StringConnection = objSqlConnectionBuilder.ConnectionString;
        }

        private void CreateConnection(ref DataBase objDataBase)
        {
            CreateStringConnection(ref objDataBase);
            objDataBase.ObjSqlConnection = new MySqlConnection(objDataBase.StringConnection);
        }

        private void ConnectionValidate(ref DataBase objDataBase)
        {
            if (objDataBase.ObjSqlConnection.State == ConnectionState.Closed)
            {
                objDataBase.ObjSqlConnection.Open();
            } else
            {
                objDataBase.ObjSqlConnection.Close();
                objDataBase.ObjSqlConnection.Dispose();
            }
        }

        private void AddParameters(ref DataBase objDataBase)
        {
            if (objDataBase.DtParameters != null)
            {
                MySqlDbType sqlDataType = new MySqlDbType();
                object value;

                foreach (DataRow var in objDataBase.DtParameters.Rows)
                {
                    switch (var[1])
                    {
                        case "1":
                            sqlDataType = MySqlDbType.Bit;
                            break;
                        case "2":
                            sqlDataType = MySqlDbType.Byte;
                            break;
                        case "3":
                            sqlDataType = MySqlDbType.Int32;
                            break;
                        case "4":
                            sqlDataType = MySqlDbType.Int64;
                            break;
                        case "5":
                            sqlDataType = MySqlDbType.Float;
                            break;
                        case "6":
                            sqlDataType = MySqlDbType.VarChar;
                            break;
                        case "7":
                            sqlDataType = MySqlDbType.TinyText;
                            break;
                        case "8":
                            sqlDataType = MySqlDbType.Text;
                            break;
                        case "9":
                            sqlDataType = MySqlDbType.Enum;
                            break;
                        case "10":
                            sqlDataType = MySqlDbType.Date;
                            break;
                        case "11":
                            sqlDataType = MySqlDbType.Time;
                            break;
                        case "12":
                            sqlDataType = MySqlDbType.DateTime;
                            break;
                        case "13":
                            sqlDataType = MySqlDbType.Blob;
                            break;
                    }

                    if (var[2].ToString() == string.Empty)
                    {
                        value = DBNull.Value;
                    }else
                    {
                        value = var[2].ToString();
                    }

                    if (objDataBase.Scalar)
                    {
                        objDataBase.ObjSqlCommand.Parameters.Add(var[0].ToString(), sqlDataType).Value = value;
                    }else
                    {
                        objDataBase.ObjSqlDataAdapter.SelectCommand.Parameters.Add(var[0].ToString(), sqlDataType).Value = value;
                    }
                }
            }
        }

        private void PrepareConnection(ref DataBase objDataBase)
        {
            CreateStringConnection(ref objDataBase);
            CreateConnection(ref objDataBase);
            ConnectionValidate(ref objDataBase);
        }

        private void ExecuteDataAdapter(ref DataBase objDataBase)
        {
            try
            {
                PrepareConnection(ref objDataBase);
                objDataBase.ObjSqlDataAdapter = new MySqlDataAdapter(objDataBase.NameSP, objDataBase.ObjSqlConnection);
                objDataBase.ObjSqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                AddParameters(ref objDataBase);
                objDataBase.DsResults = new DataSet();
                objDataBase.ObjSqlDataAdapter.Fill(objDataBase.DsResults, objDataBase.TableName);

            }catch (Exception ex)
            {
                objDataBase.ErrorMessageDB = ex.Message.ToString();
            }
            finally
            {
                if (objDataBase.ObjSqlConnection.State == ConnectionState.Open)
                {
                    ConnectionValidate(ref objDataBase);
                }
            }
        }

        private void ExecuteCommand(ref DataBase objDataBase)
        {
            try
            {
                PrepareConnection(ref objDataBase);
                objDataBase.ObjSqlCommand = new MySqlCommand(objDataBase.NameSP, objDataBase.ObjSqlConnection);
                objDataBase.ObjSqlCommand.CommandType = CommandType.StoredProcedure;
                AddParameters(ref objDataBase);
                objDataBase.ScalarValue = objDataBase.ObjSqlCommand.ExecuteScalar().ToString().Trim();

            }catch(Exception ex)
            {
                objDataBase.ErrorMessageDB = ex.Message.ToString();
            }
            finally
            {
                if (objDataBase.ObjSqlConnection.State == ConnectionState.Open)
                {
                    ConnectionValidate(ref objDataBase);
                }
            }
        }

        public void CRUD(ref DataBase objDataBase)
        {
            if (objDataBase.Scalar)
            {
                ExecuteCommand(ref objDataBase);
            }else
            {
                ExecuteDataAdapter(ref objDataBase);
            }
        }
    }
}
