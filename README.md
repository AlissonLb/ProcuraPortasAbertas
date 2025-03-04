# Verificador de Portas Abertas

Este é um simples aplicativo de console em C# que permite verificar se uma porta específica está aberta em um determinado host. O programa utiliza a classe `TcpClient` do namespace `System.Net.Sockets` para tentar se conectar à porta especificada e determinar seu estado.

## Funcionalidades

- Verifica se uma porta específica está aberta em um host fornecido pelo usuário.
- Suporte para uma variedade de portas comuns, como 22 (SSH), 80 (HTTP), 443 (HTTPS), entre outras.
- Interface de linha de comando simples e interativa.

## Pré-requisitos

- .NET SDK instalado (versão 5.0 ou superior recomendada).
- Um ambiente de desenvolvimento C# (como Visual Studio, Visual Studio Code ou qualquer editor de sua escolha).

## Como Usar

1. Clone o repositório ou crie um novo projeto no seu ambiente de desenvolvimento.
2. Copie o código fornecido para o arquivo `Program.cs`.
3. Compile e execute o programa.
4. Siga as instruções na tela:
   - Digite o nome do host ou endereço IP que deseja analisar.
   - Digite o número da porta que deseja verificar.
5. O programa informará se a porta está aberta ou fechada.

## Exemplo de Uso
Verificador de portas abertas exemplos de portas para teste: 22, 80, 443, 8080, 8443, 445, 21, 25, 53, 135, 137, 139, 23, 69 Digite o site para analizar: example.com Digite o porta para analizar: 80 A porta 80 está aberta em example.com.

## Observações

- O programa pode não funcionar corretamente se o host estiver configurado para bloquear conexões de entrada ou se houver um firewall ativo.
- Certifique-se de ter permissão para verificar portas em hosts que não são de sua propriedade, pois isso pode ser considerado uma atividade invasiva.

## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir um problema ou enviar um pull request.

## Licença

Este projeto está licenciado sob a MIT License.

