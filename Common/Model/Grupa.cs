using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Common.Model
{
    [Serializable]
    public class Grupa : IEntity
    {
        [Browsable(false)]
        public int GrupaId { get; set; }
        public string NazivGrupe { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumKraja { get; set; }
        public ProgramTreninga ProgramTreninga { get; set; }
        public override string ToString()
        {
            return NazivGrupe;
        }
        public override bool Equals(object obj)
        {
            return obj is Grupa grupa &&
                   NazivGrupe == grupa.NazivGrupe &&
                   DatumPocetka == grupa.DatumPocetka &&
                   DatumKraja == grupa.DatumKraja &&
                   EqualityComparer<ProgramTreninga>.Default.Equals(ProgramTreninga, grupa.ProgramTreninga);
        }
        [Browsable(false)]
        public string TableName => "Grupa";
        [Browsable(false)]
        public string InsertValues => $"{NazivGrupe},'{DatumPocetka.ToString("yyyy-MM-dd")}','{DatumKraja.ToString("yyyy-MM-dd")}',{ProgramTreninga.ProgramTreningaId}";
        [Browsable(false)]
        public string UpdateValues => $" nazivgrupe='{NazivGrupe}', datumpocetkakursa='{DatumPocetka.ToString("yyyy-MM-dd")}', programtreningaid='{ProgramTreninga.ProgramTreningaId}'";
        [Browsable(false)]
        public string Join => "join programtreninga pt on grupa.programtreningaId=pt.programTreningaId left join prijavazaprogram p on grupa.grupaid=p.grupaid";
        [Browsable(false)]
        public string PrimaryKeyName => "GrupaId";
        [Browsable(false)]
        public String SearchQuery { get; set; }
        [Browsable(false)]
        public List<Prijava> zaDodavanje { get; set; }
        [Browsable(false)]
        public List<Prijava> zaBrisanje { get; set; }

        public List<IEntity> GetList(SqlDataReader reader)
        {
            try
            {
                List<IEntity> grupe = new List<IEntity>();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine($"{i} {reader.GetName(i)}");
                }
                while (reader.Read())
                {
                    ProgramTreninga programTreninga = new ProgramTreninga()
                    {
                        ProgramTreningaId = reader.GetInt32(5),
                        NazivProgramaTreninga = reader.GetString(6),
                        BrojTreningaNedeljno = reader.GetInt32(7),
                        Cena = reader.GetDouble(8),
                        Opis = reader.GetString(9),


                    };
                    Grupa grupa = new Grupa()
                    {
                        GrupaId = reader.GetInt32(0),
                        NazivGrupe = reader.GetString(1),
                        DatumPocetka = DateTime.Parse(reader[2].ToString()),
                        DatumKraja = DateTime.Parse(reader[3].ToString()),
                        ProgramTreninga = programTreninga
                    };
                    grupe.Add(grupa);
                }
                return grupe;
            }
            catch (Exception ex)
            {
                reader.Close();
                throw ex;
            }
        }


    }
}
