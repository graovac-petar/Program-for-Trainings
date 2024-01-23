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

        //zaustavi soket
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
