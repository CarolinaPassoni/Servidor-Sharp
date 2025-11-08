using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Servidor
{
    static void Main()
    {
        // Define o IP e a porta
        IPAddress ip = IPAddress.Parse("127.0.0.1");
        int porta = 5000;
       

        // Cria o servidor TCP
        TcpListener servidor = new TcpListener(ip, porta);
        servidor.Start();
        Console.WriteLine("Servidor iniciado em " + ip + ":" + porta);
        Console.WriteLine("Aguardando conexões...");

        // Aceita o cliente
        TcpClient cliente = servidor.AcceptTcpClient();
        Console.WriteLine("Cliente conectado!");

        // Lê a mensagem enviada pelo cliente
        NetworkStream stream = cliente.GetStream();
        byte[] buffer = new byte[1024];
        int bytesLidos = stream.Read(buffer, 0, buffer.Length);
        string mensagem = Encoding.UTF8.GetString(buffer, 0, bytesLidos);
        Console.WriteLine("Mensagem recebida: " + mensagem);

        // Envia uma resposta
        string resposta = "Olá, cliente! Mensagem recebida com sucesso.";
        byte[] respostaBytes = Encoding.UTF8.GetBytes(resposta);
        stream.Write(respostaBytes, 0, respostaBytes.Length);

        // Encerra a conexão
        cliente.Close();
        servidor.Stop();
        Console.WriteLine("Servidor finalizado.");
    }
}
