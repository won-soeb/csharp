//서버

using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;

class Server
    {
        static void Main(string[] args)
        {
        NetworkStream stream = null;
        TcpListener tcpListener = null;
        Socket clientsocket = null;
        StreamReader reader = null;

        try
        {
            IPAddress ipAd = IPAddress.Parse("192.168.0.220");
            tcpListener = new TcpListener(ipAd, 5001);
            tcpListener.Start();
            clientsocket = tcpListener.AcceptSocket();

            stream = new NetworkStream(clientsocket);
            Encoding encode = Encoding.GetEncoding("utf-8");

            reader = new StreamReader(stream, encode);

            while (true)
            {
                string str = reader.ReadLine();
                Console.WriteLine(str);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
        finally
        {
            clientsocket.Close();
        }      
    }
}
