using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {   bool continuar = false; 
        while (!continuar)
        {
             Console.WriteLine("Verificador de portas abertas");
             Console.WriteLine("exemplos de portas para teste :\n 22, 80, 443, 8080, 8443, 445, 21, 25, 53, 135, 137, 139, 23, 69");
            
             Console.WriteLine("Digite o site para analizar: ");
             string host = Console.ReadLine(); 
             Console.WriteLine("Digite o porta para analizar: ");
            int porta = Convert.ToInt32(Console.ReadLine());
            
            bool isPortOpen = IsPortOpen(host, porta);
            if (isPortOpen)
            {
                Console.WriteLine($"A porta {porta} está aberta em {host}.");
            }
            else
            {
                Console.WriteLine($"A porta {porta} está fechada em {host}.");
            }
        }
    }

    static bool IsPortOpen(string host, int porta)
    {
        try
        {
            using (TcpClient client = new TcpClient())
            {
      
                client.Connect(host, porta);
                return true;
            }
        }
        catch (SocketException)
        {
            return false; 
        }
    }
}