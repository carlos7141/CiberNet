using System.Net.Sockets;
using System.Net;
namespace CapaClases
{
    public class ClassGetIP
    {
        public string GetLocalIpAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No se encontro una IP valida!");
        }
    }
}
