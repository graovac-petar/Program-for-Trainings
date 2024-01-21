using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Common.Model
{
    public class Grupa : IEntity
    {
        [Browsable(false)]
        public int GrupaId { get; set; }
        public string NazivGrupe { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumKraja { get; set; }
        public override string ToString()
        {
            return NazivGrupe;
        }

        public string TableName => throw new NotImplementedException();

        public string InsertValues => throw new NotImplementedException();

        public string UpdateValues => throw new NotImplementedException();

        public string Join => throw new NotImplementedException();

        public string PrimaryKeyName => throw new NotImplementedException();

        public List<IEntity> GetList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
