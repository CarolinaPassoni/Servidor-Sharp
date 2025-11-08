Funcionamento

Inicialização do Servidor:
O servidor é iniciado e fica em escuta em uma porta específica (ex: porta 5000), aguardando conexões de clientes.

Conexão do Cliente:
O cliente se conecta ao servidor utilizando o endereço IP e a porta definidos.
Assim que a conexão é estabelecida, o servidor cria uma sessão dedicada para aquele cliente.

Envio da Requisição:
O cliente envia uma mensagem ou comando (ex: texto ou dados formatados) para o servidor através do socket.

Processamento da Requisição:
O servidor recebe a mensagem, exibe no console e pode processar a informação — como interpretar comandos, armazenar dados, ou responder ao cliente.

Resposta do Servidor:
Após processar, o servidor envia uma resposta ao cliente confirmando o recebimento ou retornando um resultado.

Encerramento:
A conexão é encerrada após o envio e recebimento da resposta, podendo o servidor continuar disponível para novos clientes.

🧩 Tecnologias Utilizadas

Linguagem: C# (.NET 8.0 ou superior)

Biblioteca: System.Net.Sockets

Arquitetura: Cliente-Servidor

Protocolo: TCP/IP
