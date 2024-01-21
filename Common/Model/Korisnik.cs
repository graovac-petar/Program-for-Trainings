using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Common.Model
{
    [Serializable]
    public class Korisnik : IEntity
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string KontaktTelefon { get; set; }
        public string Email { get; set; }
        public string Sifra { get; set; }
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
        public string TableName => "korisnik";
        public string InsertValues => $"'{Ime}', '{Prezime}', '{DatumRodjenja.ToString("yyyy-MM-dd HH:mm:ss")}', '{KontaktTelefon}', '{Email}', '{Sifra}'";
        public string Join => "";
        public string UpdateValues => "";
        public string PrimaryKeyName => "KorisnikId";
        public List<IEntity> GetList(SqlDataReader reader)
        {
            try
            {
                List<IEntity> korisnici = new List<IEntity>();
                while (reader.Read())
                {
                    Korisnik korisnik = new Korisnik();
                    korisnik.KorisnikId = reader.GetInt32(0);
                    korisnik.Ime = reader.GetString(1);
                    korisnik.Prezime = reader.GetString(2);
                    string aa = reader["datumrodjenja"].ToString();
                    korisnik.DatumRodjenja = DateTime.Parse(aa);
                    korisnik.KontaktTelefon = reader.GetString(4);
                    korisnik.Email = reader.GetString(5);
                    korisnik.Sifra = reader.GetString(6);

                    korisnici.Add(korisnik);
                }
                return korisnici;
            }
            catch (Exception ex)
            {
                reader.Close();
                throw ex;
            }
        }
    }


}
