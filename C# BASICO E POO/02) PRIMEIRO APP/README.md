# PRIMEIRO APP
Vou guiá-lo através da criação de um simples programa "Hello World" em C# usando o Visual Studio Community. Siga estas etapas:

1. **Abra o Visual Studio Community**:

   Inicie o Visual Studio Community que você instalou seguindo as etapas mencionadas anteriormente.

2. **Crie um Novo Projeto**:

   - Clique em "Arquivo" (File) no menu superior.
   - Selecione "Novo" (New) e, em seguida, escolha "Projeto" (Project).

3. **Selecione um Modelo de Projeto**:

   Na janela "Novo Projeto" (New Project), você verá várias opções de modelos de projeto. Para criar um programa "Hello World", você pode escolher um aplicativo de console simples:

   - No campo de pesquisa, digite "console".
   - Selecione "Aplicativo de Console (.NET Core)" ou "Aplicativo de Console (.NET Framework)" com base na versão do Visual Studio Community que você está usando.
   - Clique no botão "Avançar" (Next).

4. **Configure o Projeto**:

   - Dê um nome ao seu projeto. Por exemplo, você pode nomeá-lo como "HelloWorld".
   - Escolha o local onde deseja salvar o projeto.
   - Certifique-se de selecionar a versão do framework .NET apropriada para o seu projeto. A versão mais recente é geralmente uma boa escolha.
   - Clique no botão "Criar" (Create).

5. **Edite o Código-fonte**:

   O Visual Studio criará automaticamente um arquivo chamado `Program.cs` com um código inicial. Abra este arquivo.

   O código inicial será semelhante a este:

   ```csharp
   using System;

   namespace HelloWorld
   {
       class Program
       {
           static void Main(string[] args)
           {
               Console.WriteLine("Hello, World!");
           }
       }
   }
   ```

6. **Execute o Programa**:

   - Para executar o programa, pressione a tecla F5 ou clique em "Depurar" (Debug) > "Iniciar Depuração" (Start Debugging) no menu superior.
   - Você verá a saída "Hello, World!" no console.

Você acabou de criar e executar seu primeiro programa "Hello World" em C# usando o Visual Studio Community. Parabéns! Agora você pode começar a explorar e experimentar mais com a linguagem C# e o ambiente de desenvolvimento do Visual Studio.