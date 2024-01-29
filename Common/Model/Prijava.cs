using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Common.Model
{
    [Serializable]
    public class Prijava : IEntity
    {
        public Korisnik Korisnik { get; set; }
        public ProgramTreninga ProgramTreninga { get; set; }
        public DateTime DatumPrijave { get; set; }
        public string Napomena { get; set; }
        public Grupa Grupa { get; set; }
        public bool UplacenaClanarina { get; set; }

        [Browsable(false)]
        public string SearchQuery { get; set; }
        [Browsable(false)]
        public string TableName => "Prijavazaprogram";
        [Browsable(false)]
        public string InsertValues => $"{Korisnik.KorisnikId}, {ProgramTreninga.ProgramTreningaId}, '{DatumPrijave.ToString("yyyy-MM-dd HH:mm:ss")}' , '{Napomena}', {(UplacenaClanarina ? 1 : 0)}, " + (this.Grupa == null ? $"NULL" : $"'{Grupa.GrupaId}'");
        [Browsable(false)]
        public string UpdateValues => $" grupaid='{Grupa.GrupaId}'";
        [Browsable(false)]
        public string Join => "left join grupa g on prijavazaprogram.grupaid=g.grupaid join programtreninga pt on prijavazaprogram.programtreningaid=pt.programtreningaid join korisnik kor on prijavazaprogram.korisnikid=kor.korisnikid";
        [Browsable(false)]
        public string PrimaryKeyName => null;
        [Browsable(false)]
        public List<IEntity> GetList(SqlDataReader reader)
        {
            try
            {
                List<IEntity> prijave = new List<IEntity>();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine($"{i} {reader.GetName(i)}");
                }
                while (reader.Read())
                {
                    ProgramTreninga pt = new ProgramTreninga()
                    {
                        ProgramTreningaId = reader.GetInt32(10),
                        NazivProgramaTreninga = reader.GetString(11),
                        BrojTreningaNedeljno = reader.GetInt32(12),
                        Cena = reader.GetDouble(13),
                        Opis = reader.GetString(14)
                    };
                    Korisnik korisnik = new Korisnik()
                    {
                        KorisnikId = reader.GetInt32(15),
                        Ime = reader.GetString(16),
                        Prezime = reader.GetString(17),
                        DatumRodjenja = reader.GetDateTime(18),
                        KontaktTelefon = reader.GetString(19),
                        Email = reader.GetString(20),
                        Sifra = reader.GetString(21)
                    };
                    Prijava pk = new Prijava()
                    {
                        Korisnik = korisnik,
                        ProgramTreninga = pt,
                        UplacenaClanarina = reader.GetBoolean(4),
                        DatumPrijave = DateTime.Parse(reader[2].ToString()),
                        Napomena = reader.GetString(3)

                    };

                    if (!reader.IsDBNull(5))
                    {
                        Grupa g = new Grupa();
                        g.GrupaId = reader.GetInt32(6);
                        g.NazivGrupe = reader.GetString(7);
                        g.DatumPocetka = DateTime.Parse(reader[8].ToString());
                        g.DatumKraja = DateTime.Parse(reader[9].ToString());

                        pk.Grupa = g;
                    }

                    prijave.Add(pk);
                }
                return prijave;
            }
            catch (Exception ex)
            {
                reader.Close();
                throw ex;
            }
        }
    }
}
