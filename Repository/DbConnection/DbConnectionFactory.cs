namespace Repository.DbConnection
{
    public class DbConnectionFactory
    {
        private static DbConnectionFactory instanca;
        private DbConnection konekcija = new DbConnection();
        public static DbConnectionFactory Instance
        {
            get
            {
                if (instanca == null)
                {
                    instanca = new DbConnectionFactory();
                }
                return instanca;
            }
        }
        private DbConnectionFactory()
        {

        }

        public DbConnection GetDbConnection()
        {
            if (!konekcija.IsReady())
            {
                konekcija.OpenConnection();
            }
            return konekcija;
        }
    }
}
