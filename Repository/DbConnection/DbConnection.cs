using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Repository.DbConnection
{
    public class DbConnection
    {
        private SqlConnection konekcija;
        private SqlTransaction transakcija;

        public void OpenConnection()
        {
            if (konekcija == null || konekcija.State == ConnectionState.Closed)
            {
                konekcija = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
                konekcija.Open();
            }

        }

        public SqlCommand CreateCommand(string sql = "")
        {
            if (transakcija?.Connection == null) transakcija = konekcija.BeginTransaction();

            return new SqlCommand(sql, konekcija, transakcija);
        }

        public void Commit()
        {
            transakcija.Commit();
        }

        public void Rollback()
        {
            transakcija.Rollback();
        }

        public bool IsReady()
        {
            return (konekcija != null && konekcija.State != ConnectionState.Closed);
        }

        public void Close()
        {
            konekcija?.Close();
            transakcija?.Dispose();
            //transaction = null
        }
    }
}
