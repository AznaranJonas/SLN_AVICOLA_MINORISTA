using System.Data;
using Microsoft.Data.SqlClient;



namespace AVICOLA.DAL
{
    public class AccesoBD
    {

        private IDbCommand cmd = new SqlCommand();
        private string strConnectionString = "";
        private bool handleErrors = false;
        private string strLastErrors = "";
        public AccesoBD()
        {
            strConnectionString = "Data Source=localhost;Initial Catalog=AVICOLA_MINORISTA;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = strConnectionString;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
        }
        public IDataReader ExecuteReader()
        {
            IDataReader reader = null;
            try
            {
                this.Open();
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                if (handleErrors)
                    strLastErrors = ex.Message;
                else
                    throw;
            }
            catch
            {
                throw;
            }
            return reader;
        }
        public IDataReader ExecuteReader(string commandtext)
        {
            IDataReader reader = null;
            try
            {
                cmd.CommandText = commandtext;
                reader = this.ExecuteReader();
            }
            catch (Exception ex)
            {
                if (handleErrors)
                    strLastErrors = ex.Message;
                else
                    throw;
            }
            catch
            {
                throw;
            }
            return reader;
        }
        public object ExecuteScalar()
        {
            object obj = null;
            try
            {
                this.Open();
                obj = cmd.ExecuteScalar();
                this.Close();
            }
            catch (Exception ex)
            {
                if (handleErrors)
                    strLastErrors = ex.Message;
                else
                    throw;
            }
            catch
            {
                throw;
            }
            return obj;
        }
        public object ExecuteScalar(string commandtext)
        {
            object obj = null;
            try
            {
                cmd.CommandText = commandtext;
                obj = this.ExecuteScalar();
            }
            catch (Exception ex)
            {
                if (handleErrors)
                    strLastErrors = ex.Message;
                else
                    throw;
            }
            catch
            {
                throw;
            }
            return obj;
        }
        public int ExecuteNonQuery()
        {
            int i = -1;
            try
            {
                this.Open();
                i = cmd.ExecuteNonQuery();
                this.Close();
            }
            catch (Exception ex)
            {
                if (handleErrors)
                    strLastErrors = ex.Message;
                else
                    throw;
            }
            catch
            {
                throw;
            }
            return i;
        }
        public int ExecuteNonQuery(string commandtext)
        {
            int i = -1;
            try
            {
                cmd.CommandText = commandtext;
                i = this.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (handleErrors)
                    strLastErrors = ex.Message;
                else
                    throw;
            }
            catch
            {
                throw;
            }
            return i;
        }
        public DataSet ExecuteDataSet()
        {
            SqlDataAdapter da = null;
            DataSet ds = null;
            try
            {
                da = new SqlDataAdapter();
                da.SelectCommand = (SqlCommand)cmd;
                ds = new DataSet();
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                if (handleErrors)
                    strLastErrors = ex.Message;
                else
                    throw;
            }
            catch
            {
                throw;
            }
            return ds;
        }
        public DataSet ExecuteDataSet(string commandtext)
        {
            DataSet ds = null;
            try
            {
                cmd.CommandText = commandtext;
                ds = this.ExecuteDataSet();
            }
            catch (Exception ex)
            {
                if (handleErrors)
                    strLastErrors = ex.Message;
                else
                    throw;
            }
            catch
            {
                throw;
            }
            return ds;
        }
        public string CommandText
        {
            get
            {
                return cmd.CommandText;
            }
            set
            {
                cmd.CommandText = value;
                cmd.Parameters.Clear();
            }
        }
        public IDataParameterCollection Parameters
        {
            get
            {
                return cmd.Parameters;
            }
        }
        public void AddParameter(string paramname, object paramvalue)
        {
            SqlParameter param = new SqlParameter(paramname, paramvalue);
            cmd.Parameters.Add(param);
        }
        public void AddParameter(IDataParameter param)
        {
            cmd.Parameters.Add(param);
        }
        public string ConnectionStrin
        {
            get
            {
                return strConnectionString;
            }
            set
            {
                strConnectionString = value;
            }
        }
        private void Open()
        {
            cmd.Connection.Open();
        }
        private void Close()
        {
            cmd.Connection.Close();
        }
        public bool HandleException
        {
            get
            {
                return handleErrors;
            }
            set
            {
                handleErrors = value;
            }
        }
        public string LastError
        {
            get
            {
                return strLastErrors;
            }
        }
        public void Dispose()
        {
            cmd.Dispose();
        }



      



    }
}
