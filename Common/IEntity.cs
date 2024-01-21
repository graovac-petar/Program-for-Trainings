using System.Collections.Generic;
using System.Data.SqlClient;

namespace Common
{
    public interface IEntity
    {
        string TableName { get; }
        string InsertValues { get; }
        string UpdateValues { get; }
        string Join { get; }
        string PrimaryKeyName { get; }
        List<IEntity> GetList(SqlDataReader reader);
    }
}
