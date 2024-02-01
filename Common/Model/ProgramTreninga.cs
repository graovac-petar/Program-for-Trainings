using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Common.Model
{
    [Serializable]
    public class ProgramTreninga : IEntity
    {
        public int ProgramTreningaId { get; set; }
        public string NazivProgramaTreninga { get; set; }
        public int BrojTreningaNedeljno { get; set; }
        public double Cena { get; set; }
        public string Opis { get; set; }

        public override string ToString()
        {
            return NazivProgramaTreninga;
        }
        [Browsable(false)]
        public List<Trening> TreninziZaDodavanje { get; set; }

        [Browsable(false)]
        public List<Trening> TreninziZaBrisanje { get; set; }
        [Browsable(false)]
        public string TableName => "ProgramTreninga";
        [Browsable(false)]
        public string InsertValues => $"'{NazivProgramaTreninga}',{BrojTreningaNedeljno},{Cena},'{Opis}'";
        [Browsable(false)]
        public string UpdateValues => $"nazivprogramatreninga='{NazivProgramaTreninga}',brojtreninganedeljno={BrojTreningaNedeljno},cena={Cena},Description='{Opis}'";
        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string PrimaryKeyName => "ProgramTreningaId";
        [Browsable(false)]
        public String SearchQuery { get; set; }

        public List<IEntity> GetList(SqlDataReader reader)
        {
            try
            {
                List<IEntity> programiTreninga = new List<IEntity>();
                while (reader.Read())
                {
                    ProgramTreninga programTreninga = new ProgramTreninga();

                    programTreninga.ProgramTreningaId = reader.GetInt32(0);
                    programTreninga.NazivProgramaTreninga = reader.GetString(1);
                    programTreninga.BrojTreningaNedeljno = reader.GetInt32(2);
                    programTreninga.Cena = reader.GetDouble(3);
                    if (!reader.IsDBNull(4))
                        programTreninga.Opis = reader.GetString(4);
                    else
                        programTreninga.Opis = "";

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
