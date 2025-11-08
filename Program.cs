using System;
using System.Net.Sockets;
using System.Text;

class Cliente
{
    static void Main()
    {
        TcpClient cliente = new TcpClient("127.0.0.1", 5000);
        NetworkStream stream = cliente.GetStream();

        Console.Write("Digite uma mensagem para o servidor: ");
        string mensagem = Console.ReadLine();

        // Envia mensagem
        byte[] dados = Encoding.UTF8.GetBytes(mensagem);
        stream.Write(dados, 0, dados.Length);

        // Recebe resposta
        byte[] buffer = new byte[1024];
        int bytesLidos = stream.Read(buffer, 0, buffer.Length);
        string resposta = Encoding.UTF8.GetString(buffer, 0, bytesLidos);
        Console.WriteLine("Resposta do servidor: " + resposta);

        cliente.Close();
    }
}
