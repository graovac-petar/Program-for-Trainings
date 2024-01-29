using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Common.Model
{
    [Serializable]
    public class Trening : IEntity
    {
        [Browsable(false)]
        public int TreningId { get; set; }
        public string NaziTreninga { get; set; }
        public string OpisTreninga { get; set; }
        public int TrajanjeUMinutima { get; set; }
        public DanUNedelji DanUNedelji { get; set; }
        [Browsable(false)]
        public int ProgramTreningaId { get; set; }
        [Browsable(false)]
        public ProgramTreninga ProgramTreninga { get; set; }

        public override string ToString()
        {
            return NaziTreninga;
        }
        [Browsable(false)]
        public string TableName => "Trening";
        [Browsable(false)]
        public string InsertValues => $"'{NaziTreninga}','{OpisTreninga}',{TrajanjeUMinutima},{DanUNedelji},{ProgramTreningaId}";
        [Browsable(false)]
        public string UpdateValues => $"'{NaziTreninga}','{OpisTreninga}',{TrajanjeUMinutima},{DanUNedelji},{ProgramTreningaId}";
        [Browsable(false)]
        public string Join => "join programtreninga pt on pt.programtreningaid=trening.programtreningaid";
        [Browsable(false)]
        public string PrimaryKeyName => "treningId";

        public List<IEntity> GetList(SqlDataReader reader)
        {
            Console.WriteLine("NO");
            for (int i = 0; i < reader.FieldCount; i++)
            {
                // Console.WriteLine(i + " " + reader.GetName(i));
            }
            List<IEntity> treninzi = new List<IEntity>();
            while (reader.Read())
            {
                ProgramTreninga pt = new ProgramTreninga()
                {
                    ProgramTreningaId = reader.GetInt32(6),
                    NazivProgramaTreninga = reader.GetString(7),
                    BrojTreningaNedeljno = reader.GetInt32(8),
                    Cena = reader.GetDouble(9),
                    Opis = reader.GetString(10)
                };
                Trening t = new Trening()
                {
                    TreningId = reader.GetInt32(0),
                    NaziTreninga = reader.GetString(1),
                    OpisTreninga = reader.GetString(2),
                    TrajanjeUMinutima = reader.GetInt32(3),
                    DanUNedelji = (DanUNedelji)reader.GetInt32(4),
                    ProgramTreningaId = reader.GetInt32(5),
                    ProgramTreninga = pt

                };
                treninzi.Add(t);
            };

            return treninzi;
        }
    }
}
