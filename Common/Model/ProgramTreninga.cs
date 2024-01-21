using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Common.Model
{
    public class ProgramTreninga : IEntity
    {
        public int ProgramTreningaId { get; set; }
        public string NazivProgramaTreninga { get; set; }
        public int BrojTreningaNedeljno { get; set; }
        public override string ToString()
        {
            return NazivProgramaTreninga;
        }

        public string TableName => "ProgramTreninga";

        public string InsertValues => $"'{NazivProgramaTreninga}',{BrojTreningaNedeljno}";

        public string UpdateValues => $"'{NazivProgramaTreninga}',{BrojTreningaNedeljno}";

        public string Join => "";

        public string PrimaryKeyName => "ProgramTreningaId";

        public List<IEntity> GetList(SqlDataReader reader)
        {
            try
            {
                List<IEntity> programiTreninga = new List<IEntity>();
                while (reader.Read())
                {
                    ProgramTreninga programTreninga = new ProgramTreninga()
                    {
                        ProgramTreningaId = reader.GetInt32(0),
                        NazivProgramaTreninga = reader.GetString(1),
                        BrojTreningaNedeljno = reader.GetInt32(2)
                    };
                    programiTreninga.Add(programTreninga);
                }
                return programiTreninga;
            }
            catch (Exception ex)
            {
                reader.Close();
                throw ex;
            }
        }
    }
}
