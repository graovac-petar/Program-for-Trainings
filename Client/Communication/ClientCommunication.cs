using Client.GuiController;
using Common;
using Common.Communication;
using Common.Model;
using System;
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
    }
    #endregion
}
