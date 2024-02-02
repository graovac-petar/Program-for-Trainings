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
        public override bool Equals(object obj)
        {
            return obj is Prijava prijava &&
                   EqualityComparer<Korisnik>.Default.Equals(Korisnik, prijava.Korisnik) &&
                   EqualityComparer<ProgramTreninga>.Default.Equals(ProgramTreninga, prijava.ProgramTreninga) &&
                   DatumPrijave == prijava.DatumPrijave;
        }
        [Browsable(false)]
        public string SearchQuery { get; set; }
        [Browsable(false)]
        public string TableName => "Prijavazaprogram";
        [Browsable(false)]
        public string InsertValues => $"{Korisnik.KorisnikId}, {ProgramTreninga.ProgramTreningaId}, '{DatumPrijave.ToString("yyyy-MM-dd HH:mm:ss")}' , '{Napomena}', {(UplacenaClanarina ? 1 : 0)}, " + (Grupa == null ? $"NULL" : $"'{Grupa.GrupaId}'");
        [Browsable(false)]
        public string UpdateValues => $"grupaid={(Grupa == null ? $"NULL" : $"'{Grupa.GrupaId}'")}";
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
                    ProgramTreninga pt = new ProgramTreninga();

                    pt.ProgramTreningaId = reader.GetInt32(11);
                    pt.NazivProgramaTreninga = reader.GetString(12);
                    pt.BrojTreningaNedeljno = reader.GetInt32(13);
                    pt.Cena = reader.GetDouble(14);
                    if (!reader.IsDBNull(15))
                        pt.Opis = reader.GetString(15);
                    else
                        pt.Opis = "";

                    Korisnik korisnik = new Korisnik()
                    {
                        KorisnikId = reader.GetInt32(16),
                        Ime = reader.GetString(17),
                        Prezime = reader.GetString(18),
                        DatumRodjenja = reader.GetDateTime(19),
                        KontaktTelefon = reader.GetString(20),
                        Email = reader.GetString(21),
                        Sifra = reader.GetString(22)
                    };
                    Prijava pk = new Prijava();
                    pk.Korisnik = korisnik;
                    pk.ProgramTreninga = pt;
                    pk.UplacenaClanarina = reader.GetBoolean(4);
                    pk.DatumPrijave = DateTime.Parse(reader[2].ToString());
                    if (!reader.IsDBNull(3))
                        pk.Napomena = reader.GetString(3);
                    else
                        pk.Napomena = "";



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
