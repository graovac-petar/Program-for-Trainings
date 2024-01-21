using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    public class Server
    {

        private static Server instance;
        public static Server Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Server();
                }
                return instance;
            }
        }

        private Socket serverSocket;
        public bool pokrenutServer = false;
        public List<ClientHandler> ListaKlijenata = new List<ClientHandler>();

        public Action<ClientHandler> AddKlijenata;
        public Action<ClientHandler> RemoveKlijenata;

        public Server()
        {

        }

        public void PokreniServer()
        {
            try
            {
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"])));
                serverSocket.Listen(10);

                pokrenutServer = true;

                Thread t = new Thread(() => OsluskujKlijente());
                t.IsBackground = true;
                t.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ZaustaviServer()
        {
            try
            {
                serverSocket.Close();
                pokrenutServer = false;

                //zaustavi klijente
                foreach (ClientHandler handler in ListaKlijenata)
                {
                    handler.StopSocket();
                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void OsluskujKlijente()
        {
            try
            {
                while (pokrenutServer)
                {
                    Socket clientSocket = serverSocket.Accept();

                    ClientHandler clientHandler = new ClientHandler(clientSocket);

                    ListaKlijenata.Add(clientHandler);
                    AddKlijenata(clientHandler);

                    Thread t = new Thread(() => clientHandler.HandlerRequests());
                    t.IsBackground = true;
                    t.Start();

                }
            }
            catch (System.Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
