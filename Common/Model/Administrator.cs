using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Common.Model
{
    [Serializable]
    public class Administrator : IEntity
    {
        public int AdministratorId { get; set; }
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }
        public string TableName => "Administrator";

        public string InsertValues => $"'{KorisnickoIme}', '{Sifra}'";

        public string UpdateValues => "";

        public string Join => "";

        public string PrimaryKeyName => "AdministratorId";

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> administratori = new List<IEntity>();
            while (reader.Read())
            {
                Administrator admin = new Administrator();
                admin.AdministratorId = reader.GetInt32(0);
                admin.KorisnickoIme = reader.GetString(1);
                admin.Sifra = reader.GetString(2);

                administratori.Add(admin);
            }
            return administratori;
        }
    }
}
