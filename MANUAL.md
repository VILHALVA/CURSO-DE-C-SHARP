# MANUAL

## 1. INSTALAÇÃO DO .NET SDK
Para desenvolver em C#, você precisa instalar o .NET SDK, que inclui o compilador e ferramentas necessárias.

### WINDOWS:
1. Acesse o [site oficial do .NET](https://dotnet.microsoft.com/download).
2. Baixe o instalador do .NET SDK para Windows.
3. Execute o instalador e siga as instruções na tela para concluir a instalação.

Para verificar se a instalação foi bem-sucedida, abra o Prompt de Comando e execute:
```sh
dotnet --version
```

### MACOS:
1. Acesse o [site oficial do .NET](https://dotnet.microsoft.com/download).
2. Baixe o instalador do .NET SDK para macOS.
3. Execute o instalador e siga as instruções na tela para concluir a instalação.

Para verificar se a instalação foi bem-sucedida, abra o Terminal e execute:
```sh
dotnet --version
```

### LINUX:
1. Abra um terminal.
2. Execute os seguintes comandos para instalar o .NET SDK:
   ```sh
   wget https://packages.microsoft.com/config/ubuntu/$(lsb_release -rs)/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
   sudo dpkg -i packages-microsoft-prod.deb
   sudo apt-get update
   sudo apt-get install -y apt-transport-https
   sudo apt-get update
   sudo apt-get install -y dotnet-sdk-7.0
   ```

Para verificar se a instalação foi bem-sucedida, abra um terminal e execute:
```sh
dotnet --version
```

## 2. CONFIGURAÇÃO DA IDE (INTEGRATED DEVELOPMENT ENVIRONMENT):
Usar uma IDE facilita muito o desenvolvimento em C#. A IDE mais popular para C# é o Visual Studio, mas você também pode usar o Visual Studio Code.

### VISUAL STUDIO:
1. Acesse o [site do Visual Studio](https://visualstudio.microsoft.com/).
2. Baixe o instalador do Visual Studio para o seu sistema operacional.
3. Execute o instalador e siga as instruções na tela para instalar a edição Community (gratuita) ou outra edição de sua escolha.
4. Durante a instalação, selecione a carga de trabalho "Desenvolvimento em .NET" para incluir as ferramentas necessárias para C#.

### VISUAL STUDIO CODE:
1. Baixe e instale o Visual Studio Code no [site oficial](https://code.visualstudio.com/).
2. Abra o Visual Studio Code.
3. Instale as extensões C#:
   1. Clique no ícone de Extensões no lado esquerdo.
   2. Pesquise por "C#" e instale a extensão oficial da Microsoft.

## 3. CRIANDO O PRIMEIRO PROJETO EM C#:

### PASSO A PASSO PARA CRIAR UM PROJETO NO VISUAL STUDIO:
1. Abra o Visual Studio.
2. Clique em "Criar um novo projeto".
3. Selecione "Aplicativo de Console" em C# e clique em "Avançar".
4. Nomeie seu projeto, escolha o local onde ele será salvo e clique em "Criar".

### CRIANDO UM ARQUIVO C#:
1. O Visual Studio criará automaticamente um arquivo `Program.cs` no novo projeto.

### ESCREVENDO O CÓDIGO:
No arquivo `Program.cs`, escreva o seguinte código:
```csharp
using System;

class Program {
    static void Main() {
        Console.WriteLine("Hello, World!");
    }
}
```

### EXECUTANDO O PROJETO NO VISUAL STUDIO:
1. Clique no botão de execução (um triângulo verde) na barra de ferramentas superior ou pressione `F5`.
2. O console do Visual Studio irá abrir e mostrar a mensagem `Hello, World!`.

### PASSO A PASSO PARA CRIAR UM PROJETO NO VISUAL STUDIO CODE:
1. Abra o Visual Studio Code.
2. Abra o terminal integrado (View > Terminal).
3. No terminal, navegue até o diretório onde deseja criar o projeto.
4. Execute o comando:
   ```sh
   dotnet new console -o HelloWorld
   cd HelloWorld
   ```

### ESCREVENDO O CÓDIGO:
1. No Visual Studio Code, abra o arquivo `Program.cs` que foi criado.
2. Substitua o conteúdo por:
   ```csharp
   using System;

   class Program {
       static void Main() {
           Console.WriteLine("Hello, World!");
       }
   }
   ```

### EXECUTANDO O PROJETO NO VISUAL STUDIO CODE:
1. No terminal integrado, certifique-se de que está no diretório do projeto (`HelloWorld`).
2. Execute o comando:
   ```sh
   dotnet run
   ```

Você verá a mensagem `Hello, World!` impressa no terminal.

## CONCLUSÃO:
Agora você tem o .NET SDK instalado e configurado, além de um ambiente de desenvolvimento C# pronto com o Visual Studio ou Visual Studio Code. Você criou e executou seu primeiro projeto C#. A partir daqui, você pode explorar mais sobre a linguagem C#, bibliotecas e frameworks para expandir suas habilidades de programação.