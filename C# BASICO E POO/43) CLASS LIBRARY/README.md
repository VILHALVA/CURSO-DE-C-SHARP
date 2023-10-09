# CLASS LIBRARY
Uma Class Library (ou Biblioteca de Classes) em C# é um projeto que contém classes, tipos, interfaces, métodos e outros componentes reutilizáveis que podem ser compartilhados entre diferentes aplicativos ou projetos. Essa abordagem facilita a organização e reutilização de código em diversos projetos, promovendo a modularidade e a manutenção eficiente.

Aqui estão os passos básicos para criar e usar uma Class Library em C#:

1. **Criar uma Class Library**:
   - Abra o Visual Studio.
   - Selecione "Arquivo" > "Novo" > "Projeto...".
   - Escolha o modelo "Biblioteca de Classes (.NET Framework)" ou "Biblioteca de Classes (.NET Core/.NET 5+)" dependendo da versão do .NET que você está usando.
   - Dê um nome ao projeto e clique em "Criar".

2. **Adicionar Classes e Código**:
   - Dentro do projeto da Biblioteca de Classes, você pode adicionar classes, interfaces e métodos que deseja compartilhar com outros projetos.
   - Escreva seu código normalmente, como faria em qualquer projeto C#.

3. **Compilar a Biblioteca**:
   - Certifique-se de que o projeto da Biblioteca de Classes seja compilado com sucesso. Isso criará um arquivo de assembly (.dll) que pode ser referenciado por outros projetos.

4. **Referenciar a Biblioteca**:
   - Em seu projeto principal (ou qualquer outro projeto que deseja usar a biblioteca), clique com o botão direito no nó "Referências" no Solution Explorer.
   - Escolha "Adicionar Referência...".
   - Selecione o projeto da Biblioteca de Classes na guia "Projetos" ou procure o arquivo .dll gerado pela biblioteca na guia "Procurar" (dependendo de como você deseja referenciar a biblioteca).

5. **Usar a Biblioteca**:
   - Agora, você pode usar as classes e métodos da Biblioteca de Classes em seu projeto principal como faria com qualquer outro código.

6. **Compilar e Executar**:
   - Compile e execute seu projeto principal. Ele agora deve ser capaz de acessar e usar o código da Biblioteca de Classes.

As Bibliotecas de Classes são frequentemente usadas para encapsular lógica comum ou funcionalidades compartilhadas em um único local, facilitando a manutenção e a reutilização de código. Isso é especialmente útil em cenários de desenvolvimento de software onde você tem vários aplicativos que compartilham funcionalidades semelhantes.