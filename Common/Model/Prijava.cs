using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Common.Model
{
    public class Prijava : IEntity
    {
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
