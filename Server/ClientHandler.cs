using Common.Communication;
using Common.Model;
using System;
using System.Net.Sockets;

namespace Server
{
    public class ClientHandler
    {
        private Socket socket;
        private Sender sender;
        private Receiver receiver;

        public string IPAdresa => socket.RemoteEndPoint.ToString();
        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }

        public void StopSocket()
        {
            socket.Close();
        }
        public void HandlerRequests()
        {
            try
            {
                while (Server.Instance.pokrenutServer)
                {
                    Request req = receiver.Receive<Request>();
                    Response response = ProcessRequest(req);
                    sender.Send(response);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(">>EXC in client thread: " + ex.Message);

            }
            finally
            {
                Server.Instance.ListaKlijenata.Remove(this);

                Server.Instance.RemoveKlijenata(this);
            }
        }

        public Korisnik korisnik;
        public Administrator administrator;

        private Response ProcessRequest(Request req)
        {
            Response res = new Response();
            try
            {
                res.Success = true;
                #region Korisnik i administrator
                if (req.Operation == Operation.PrijaviSeKorisnik)
                {
                    Korisnik kor = (Korisnik)req.Body;
                    Korisnik k = Controller.Instance.KorisnikPrijavljivanje(kor);
                    res.Data = k;
                    res.Message = "Uspešno prijavljivanje!";
                    this.korisnik = k;

                }
                else if (req.Operation == Operation.RegistrujSe)
                {
                    Korisnik k = (Korisnik)req.Body;
                    Korisnik kor = Controller.Instance.KorisnikRegistracija(k);
                    res.Data = kor;
                    res.Message = "Uspešna registracija!";
                }
                else if (req.Operation == Operation.PrijaviSeAdmin)
                {
                    Administrator a = (Administrator)req.Body;
                    Administrator admin = Controller.Instance.AdministratorPrijavljivanje(a);
                    res.Data = admin;
                    res.Message = "Uspešno prijavljivanje";
                    this.administrator = admin;

                }
                else if (req.Operation == Operation.OdjaviSeKorisnik)
                {
                    Korisnik k = (Korisnik)req.Body;
                    this.korisnik = null;
                    res.Message = "Korisnik je odjavljen sa profila";

                }
                else if (req.Operation == Operation.OdjaviSeAdmin)
                {
                    Administrator a = (Administrator)req.Body;
                    this.administrator = null;
                    res.Message = "Administrator je odjavljen sa profila";

                }
                #endregion

                #region Program treninga
                else if (req.Operation == Operation.VratiSveProgrameTreninga)
                {
                    res.Data = Controller.Instance.VratiSveProgrameTreninga();
                    res.Message = "Uspesno vraceni programi treninga";
                }
                else if (req.Operation == Operation.PretraziProgramTreninga)
                {
                    res.Data = Controller.Instance.PretraziProgramTreninga((ProgramTreninga)req.Body);
                    res.Message = "Uspesno vraceni programi treninga";
                }
                else if (req.Operation == Operation.VratiProgramTreninga)
                {
                    res.Data = Controller.Instance.VratiProgramTreninga((ProgramTreninga)req.Body);
                    res.Message = "Uspesno vracen program treninga";
                }
                else if (req.Operation == Operation.IzmeniProgramTreninga)
                {
                    Controller.Instance.IzmeniProgramTreninga((ProgramTreninga)req.Body);
                    res.Message = "Uspesno update-ovan";
                }
                else if (req.Operation == Operation.ObrisiProgramTreninga)
                {
                    Controller.Instance.ObrisiProgramTreninga((ProgramTreninga)req.Body);
                    res.Message = "Uspesno obrisan";
                }
                else if (req.Operation == Operation.KreirajProgramTreninga)
                {
                    Controller.Instance.KreirajProgramTreninga((ProgramTreninga)req.Body);
                    res.Message = "Uspesno napravljen";
                }

                #endregion

                #region Trening
                else if (req.Operation == Operation.VratiTreninge)
                {
                    res.Data = Controller.Instance.VratiTreninge((ProgramTreninga)req.Body);
                    res.Message = "Uspesno vraceni treninzi";
                }
                #endregion

                #region Prijava
                else if (req.Operation == Operation.VratiPrijavuZaProgramTreninga)
                {
                    res.Data = Controller.Instance.VratiPrijavuZaProgramTreninga((Prijava)req.Body);
                    res.Message = "Uspesno vracena prijava";
                }
                else if (req.Operation == Operation.PosaljiPrijavuZaProgramTreninga)
                {
                    Controller.Instance.PosaljiPrijavuZaProgramTreninga((Prijava)req.Body);
                    res.Message = "Uspesno poslata prijava";
                }
                else if (req.Operation == Operation.VratiPrijaveZaKorisnika)
                {
                    res.Data = Controller.Instance.VratiPrijaveZaKorisnuka((Korisnik)req.Body);
                    res.Message = "Uspesno vracene prijave";
                }
                else if (req.Operation == Operation.VratiPrijaveZaGrupu)
                {
                    res.Data = Controller.Instance.VratiPrijavezaGrupu((Grupa)req.Body);
                    res.Message = "Uspesno vracene prijave";
                }
                else if (req.Operation == Operation.VratiPrijaveVanGrupe)
                {
                    res.Data = Controller.Instance.VratiPrijaveVanGrupe((Grupa)req.Body);
                    res.Message = "Uspesno vracene prijave";
                }
                else if (req.Operation == Operation.VratiPrijaveZaProgramTreninga)
                {
                    res.Data = Controller.Instance.VratiPrijaveZaProgramTreninga((ProgramTreninga)req.Body);
                    res.Message = "Uspesno vracena grupa";
                }
                #endregion

                #region Grupa
                else if (req.Operation == Operation.KreirajGrupu)
                {
                    Controller.Instance.KreirajGrupu((Grupa)req.Body);
                    res.Message = "Uspesno napravljena grupa";
                }
                else if (req.Operation == Operation.VratiSveGrupe)
                {
                    res.Data = Controller.Instance.VratiSveGrupe();
                    res.Message = "Uspesno vracene grupe";
                }
                else if (req.Operation == Operation.PretraziGrupe)
                {
                    res.Data = Controller.Instance.PretraziGrupe((Grupa)req.Body);
                    res.Message = "Uspesno vracene grupe";
                }
                else if (req.Operation == Operation.VratiGrupu)
                {
                    res.Data = Controller.Instance.VratiGrupu((Grupa)req.Body);
                    res.Message = "Uspesno vracena grupa";
                }
                else if (req.Operation == Operation.IzmeniGrupu)
                {
                    Controller.Instance.IzmeniGrupu((Grupa)req.Body);
                    res.Message = "Uspesno update-ovana grupa";
                }
                else if (req.Operation == Operation.ObrisiGrupu)
                {
                    Controller.Instance.ObrisiGrupu((Grupa)req.Body);
                    res.Message = "Uspesno obrisana grupa";
                }
                #endregion
            }
            catch (Exception ex)
            {
                res.Success = false;
                res.Exception = new Exception(ex.Message);
            }
            return res;
        }


    }
}
