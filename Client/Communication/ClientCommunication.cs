using Client.GuiController;
using Common;
using Common.Communication;
using Common.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;

namespace Client.Communication
{
    public class ClientCommunication
    {
        public static ClientCommunication instance;
        private ClientCommunication()
        {

        }
        public static ClientCommunication Instance
        {
            get
            {
                if (instance == null) instance = new ClientCommunication();
                return instance;
            }
        }

        private Socket socket;
        private Sender sender;
        private Receiver receiver;

        #region Konekcija
        public bool konektovanNaServer = false;
        public void KonektujSeNaServer()
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9000);
                sender = new Sender(socket);
                receiver = new Receiver(socket);

                konektovanNaServer = true;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }

        public bool SocketConnected()
        {
            if (!konektovanNaServer) return false;
            if (socket == null) return false;
            if (socket.Connected == false) return false;
            bool part1 = socket.Poll(1000, SelectMode.SelectRead);
            bool part2 = (socket.Available == 0);
            if (part1 && part2)
                return false;
            else
                return true;
        }

        public void DisconnectedCloseApp()
        {
            if (!SocketConnected())
            {
                System.Windows.Forms.MessageBox.Show("Niste konektovani na server. Restartovanje aplikacije.");
                MainCoordinator.Instance.frmPrijavljivanje.Close();
            }
        }
        #endregion

        #region Korisnik
        public Korisnik PrijavljivanjeKorisnik(Korisnik k)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Body = k,
                    Operation = Operation.PrijaviSeKorisnik
                };
                sender.Send(req);
                Response res = receiver.Receive<Response>();

                k = res.ConvertResponse<Korisnik>();

                return k;
            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        internal void Registracija(Korisnik k)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Body = k,
                    Operation = Operation.RegistrujSe
                };
                sender.Send(req);
                Response res = receiver.Receive<Response>();

                k = res.ConvertResponse<Korisnik>();

                System.Windows.Forms.MessageBox.Show(res.Message);

            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        internal void OdjaviSeKorisnik(Korisnik ulogovaniKorisnik)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Body = ulogovaniKorisnik,
                    Operation = Operation.OdjaviSeKorisnik
                };
                sender.Send(req);

                receiver.Receive<object>();
            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Administrator
        internal Administrator PrijavljivanjeAdministrator(Administrator admin)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Body = admin,
                    Operation = Operation.PrijaviSeAdmin
                };
                sender.Send(req);
                Response res = receiver.Receive<Response>();

                admin = res.ConvertResponse<Administrator>();

                return admin;
            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        internal void OdjaviSeAdministrator(Administrator ulogovaniAdministrator)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Body = ulogovaniAdministrator,
                    Operation = Operation.OdjaviSeAdmin
                };
                sender.Send(req);

                receiver.Receive<object>();
            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region ProgramTreninga
        internal List<ProgramTreninga> VratiSveProgrameTreninga()
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Operation = Operation.VratiSveProgrameTreninga
                };
                sender.Send(req);

                Response res = receiver.Receive<Response>();

                List<ProgramTreninga> programiTreninga = res.ConvertResponse<List<ProgramTreninga>>();

                if (!res.Success) throw new Exception(res.Message);

                return programiTreninga;


            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        internal List<ProgramTreninga> PretraziProgrameTreninga(ProgramTreninga pt)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Body = pt,
                    Operation = Operation.PretraziProgramTreninga
                };
                sender.Send(req);

                Response res = receiver.Receive<Response>();

                List<ProgramTreninga> pronadjeniProgramiTreninga = res.ConvertResponse<List<ProgramTreninga>>();

                if (!res.Success) throw new Exception(res.Message);

                return pronadjeniProgramiTreninga;
            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        internal ProgramTreninga VratiProgramTreninga(ProgramTreninga programTreninga)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Body = programTreninga,
                    Operation = Operation.VratiProgramTreninga
                };

                sender.Send(req);

                Response res = receiver.Receive<Response>();

                ProgramTreninga programtreninga = res.ConvertResponse<ProgramTreninga>();
                if (!res.Success) throw new Exception(res.Message);

                return programtreninga;
            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        internal List<Trening> VratiSveTreningeZaProgramTreninga(ProgramTreninga pt)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Body = pt,
                    Operation = Operation.VratiTreninge
                };

                sender.Send(req);

                Response res = receiver.Receive<Response>();

                List<Trening> trening = res.ConvertResponse<List<Trening>>();
                if (!res.Success) throw new Exception(res.Message);

                return trening;
            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        internal void IzmeniProgramTreninga(ProgramTreninga pt)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Body = pt,
                    Operation = Operation.IzmeniProgramTreninga
                };
                sender.Send(req);

                Response res = receiver.Receive<Response>();

                List<Prijava> prijave = res.ConvertResponse<List<Prijava>>();

                if (!res.Success) throw new Exception(res.Message);
                if (res.Success) System.Windows.Forms.MessageBox.Show(res.Message);
            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        internal void KreirajProgramTreninga(ProgramTreninga pt)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Body = pt,
                    Operation = Operation.KreirajProgramTreninga
                };
                sender.Send(req);

                Response res = receiver.Receive<Response>();

                if (!res.Success) throw new Exception(res.Message);
                if (res.Success) System.Windows.Forms.MessageBox.Show(res.Message);
            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        internal void ObrisiProgramTreninga(object pt)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Body = pt,
                    Operation = Operation.ObrisiProgramTreninga
                };
                sender.Send(req);

                Response res = receiver.Receive<Response>();

                if (!res.Success) throw new Exception(res.Message);
                if (res.Success) System.Windows.Forms.MessageBox.Show(res.Message);
            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Prijava
        internal object VratiPrijavu(Prijava p)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Body = p,
                    Operation = Operation.VratiPrijavuZaProgramTreninga
                };
                sender.Send(req);

                Response res = receiver.Receive<Response>();

                Prijava prijava = res.ConvertResponse<Prijava>();

                if (!res.Success) throw new Exception(res.Message);

                return prijava;
            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        internal void PosaljiPrijavu(Prijava p)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Body = p,
                    Operation = Operation.PosaljiPrijavuZaProgramTreninga
                };
                sender.Send(req);

                Response res = receiver.Receive<Response>();

                Prijava prijava = res.ConvertResponse<Prijava>();

                if (!res.Success) throw new Exception(res.Message);

                if (res.Success) System.Windows.Forms.MessageBox.Show(res.Message);
            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        internal List<Prijava> VratiPrijaveZaKorisnika(Korisnik ulogovaniKorisnik)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Body = ulogovaniKorisnik,
                    Operation = Operation.VratiPrijaveZaKorisnika
                };
                sender.Send(req);

                Response res = receiver.Receive<Response>();

                List<Prijava> prijave = res.ConvertResponse<List<Prijava>>();

                if (!res.Success) throw new Exception(res.Message);

                return prijave;
            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        internal List<Prijava> VratiPrijaveZaGrupu(Grupa g)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Body = g,
                    Operation = Operation.VratiPrijaveZaGrupu
                };
                sender.Send(req);

                Response res = receiver.Receive<Response>();

                List<Prijava> prijave = res.ConvertResponse<List<Prijava>>();

                if (!res.Success) throw new Exception(res.Message);

                return prijave;
            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        internal List<Prijava> VratiPrijaveVanGrupe(Grupa g)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Body = g,
                    Operation = Operation.VratiPrijaveVanGrupe
                };
                sender.Send(req);

                Response res = receiver.Receive<Response>();

                List<Prijava> prijave = res.ConvertResponse<List<Prijava>>();

                if (!res.Success) throw new Exception(res.Message);

                return prijave;
            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        internal List<Prijava> VratiPrijaveZaProgramTreninga(ProgramTreninga pt)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Body = pt,
                    Operation = Operation.VratiPrijaveZaProgramTreninga
                };
                sender.Send(req);

                Response res = receiver.Receive<Response>();

                List<Prijava> prijave = res.ConvertResponse<List<Prijava>>();

                if (!res.Success) throw new Exception(res.Message);

                return prijave;
            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Grupa
        internal List<Grupa> VratiSveGrupe()
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Operation = Operation.VratiSveGrupe
                };
                sender.Send(req);

                Response res = receiver.Receive<Response>();

                List<Grupa> grupe = res.ConvertResponse<List<Grupa>>();

                if (!res.Success) throw new Exception(res.Message);

                return grupe;
            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        internal List<Grupa> PretraziGrupe(Grupa g)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Body = g,
                    Operation = Operation.PretraziGrupe
                };
                sender.Send(req);

                Response res = receiver.Receive<Response>();

                List<Grupa> pronadjeneGrupe = res.ConvertResponse<List<Grupa>>();

                if (!res.Success) throw new Exception(res.Message);

                return pronadjeneGrupe;
            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        internal Grupa VratiGrupu(Grupa g)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Body = g,
                    Operation = Operation.VratiGrupu
                };

                sender.Send(req);

                Response res = receiver.Receive<Response>();

                Grupa grupa = res.ConvertResponse<Grupa>();
                if (!res.Success) throw new Exception(res.Message);

                return grupa;
            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        internal void ObrisiGrupu(Grupa grupa)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Body = grupa,
                    Operation = Operation.ObrisiGrupu
                };
                sender.Send(req);

                Response res = receiver.Receive<Response>();

                if (!res.Success) throw new Exception(res.Message);
                if (res.Success) System.Windows.Forms.MessageBox.Show(res.Message);
            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        internal void IzmeniGrupu(Grupa g)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Body = g,
                    Operation = Operation.IzmeniGrupu
                };
                sender.Send(req);

                Response res = receiver.Receive<Response>();

                if (!res.Success) throw new Exception(res.Message);
                if (res.Success) System.Windows.Forms.MessageBox.Show(res.Message);
            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        internal void KreirajGrupu(Grupa g)
        {
            try
            {
                if (!SocketConnected()) throw new IOException("Niste konektovani na server");

                Request req = new Request()
                {
                    Body = g,
                    Operation = Operation.KreirajGrupu
                };
                sender.Send(req);

                Response res = receiver.Receive<Response>();

                if (!res.Success) throw new Exception(res.Message);
                if (res.Success) System.Windows.Forms.MessageBox.Show(res.Message);
            }
            catch (IOException ex)
            {
                DisconnectedCloseApp();
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }

}
