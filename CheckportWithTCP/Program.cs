using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CheckportWithTCP
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ipSever = new IPEndPoint(IPAddress.Parse("125.253.118.38"),8330);
            TcpClient c = new TcpClient();
            c.SendTimeout = 1000;
            c.ReceiveTimeout = 1000;
            try
            {
                c.Connect(ipSever);
                Console.WriteLine(ipSever.ToString() + "is opened");
                c.Close();

            }
            catch
            {
                Console.WriteLine(ipSever.ToString() + "is closed");
            }
        }
    }
}
