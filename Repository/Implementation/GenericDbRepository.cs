using Common;
using Repository.DbConnection;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Repository.Implementation
{
    public class GenericDbRepository : IDbRepository<IEntity>
    {
        public void Add(IEntity entity)
        {
            string komanda = $"insert into {entity.TableName}";
            if (entity.PrimaryKeyName != null)
                komanda += $" output inserted.{entity.PrimaryKeyName} ";
            komanda += $" values ({entity.InsertValues})";

            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(komanda);
            if (entity.PrimaryKeyName != null)
            {
                int primarniVrednost = (int)cmd.ExecuteScalar();
                entity.GetType().GetProperty(entity.PrimaryKeyName).SetValue(entity, primarniVrednost);
            }
            else
            {
                int x = cmd.ExecuteNonQuery();
                Console.WriteLine("Affected rows insert: " + x);
            }
        }

        public void Delete(IEntity entity, string criteria)
        {
            string komanda = $"delete from {entity.TableName} where {criteria}";
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(komanda);
            int x = cmd.ExecuteNonQuery();

            Console.WriteLine("Affected rows delete: " + x);
        }

        public IEntity Get(IEntity entity, string criteria)
        {
            string komanda = $"select * from {entity.TableName} ";
            komanda += " " + entity.Join;
            komanda += $" where {criteria} ";
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(komanda);


            var reader = cmd.ExecuteReader();
            List<IEntity> lista = entity.GetList(reader);

            reader.Close();
            if (lista.Count > 0) return lista[0];
            return null;
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            string komanda = $"select * from {entity.TableName}";

            komanda += " " + entity.Join;
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(komanda);
            var reader = cmd.ExecuteReader();
            List<IEntity> lista = entity.GetList(reader);
            reader.Close();

            if (lista == null) throw new Exception("Greska pri operaciji");
            return lista;
        }

        public List<IEntity> Search(IEntity entity, string criteria)
        {
            string komanda = $"select * from {entity.TableName} ";
            komanda += " " + entity.Join;
            komanda += $" where {criteria} ";
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(komanda);
            var reader = cmd.ExecuteReader();
            List<IEntity> lista = entity.GetList(reader);

            reader.Close();
            return lista;
        }

        public void Update(IEntity entity, string criteria)
        {
            string komanda = $"update {entity.TableName} set {entity.UpdateValues} where {criteria}";
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(komanda);
            int x = cmd.ExecuteNonQuery();

            Console.WriteLine("Affected rows update: " + x);
        }

        public void Close()
        {
            DbConnectionFactory.Instance.GetDbConnection().Close();
        }

        public void Commit()
        {
            DbConnectionFactory.Instance.GetDbConnection().Commit();
        }

        public void Rollback()
        {
            DbConnectionFactory.Instance.GetDbConnection().Rollback();
        }
    }
}
