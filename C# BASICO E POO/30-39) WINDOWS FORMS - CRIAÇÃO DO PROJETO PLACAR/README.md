# WINDOWS FORMS - CRIAÇÃO DO PROJETO PLACAR
## CRIAÇÃO:
Para criar um projeto Windows Forms em C# para um aplicativo de placar simples, siga os passos abaixo usando o Visual Studio:

1. Abra o Visual Studio (certifique-se de que você tem o Visual Studio Community, Professional ou Enterprise instalado).

2. Clique em "Arquivo" (File) no menu superior e selecione "Novo" (New) e depois "Projeto" (Project).

3. Na janela "Novo Projeto" (New Project), escolha "Aplicativo Windows Forms (.NET Framework)".

4. Dê um nome ao seu projeto, como "PlacarApp", escolha um local para salvar e clique em "Criar" (Create).

5. Na janela de design do formulário (Form Designer), você pode criar a interface do usuário para o aplicativo de placar. Por exemplo, adicione Label(s) para exibir o placar e Botão(ões) para aumentar e diminuir o placar.

6. Dê um duplo clique nos botões para adicionar código de manipulação de eventos. Por exemplo, se você tem um botão "Aumentar Placar", o código pode ser semelhante ao seguinte:

```csharp
private int placar = 0;

private void btnAumentarPlacar_Click(object sender, EventArgs e)
{
    placar++;
    AtualizarPlacar();
}

private void AtualizarPlacar()
{
    lblPlacar.Text = "Placar: " + placar.ToString();
}
```

7. Repita o passo 6 para outros botões ou elementos da interface do usuário que você deseja adicionar, como um botão para diminuir o placar ou redefinir o placar.

8. Depois de projetar a interface do usuário e adicionar o código necessário, você pode compilar e executar o aplicativo clicando no botão "Iniciar" (Start) ou pressionando F5.

Isso cria um aplicativo Windows Forms simples para um placar, onde você pode aumentar ou diminuir o valor do placar ao clicar nos botões correspondentes. Você pode personalizar a interface e a lógica do aplicativo de acordo com suas necessidades específicas.

## ETAPAS:
Vamos criar um projeto Windows Forms de um contador de pontos com as funcionalidades. Vou dividir o processo em etapas e fornecer explicações e códigos para cada parte.

### Etapa 1: Construção do Layout

1. Abra o Visual Studio e crie um novo projeto Windows Forms com o nome "PlacarApp" como descrito anteriormente.

2. No formulário padrão (Form1), construa o layout com os seguintes elementos:

   - Um `Label` para exibir o placar.
   - Dois `Button`s com os textos "+" e "-" para aumentar e diminuir o placar.
   - Dois `Button`s com os textos "Iniciar" e "Pausar" para controlar o temporizador.
   - Um `Timer` da caixa de ferramentas (Toolbox) para atualizar automaticamente o placar.

   O layout pode ser construído arrastando e soltando esses elementos da caixa de ferramentas para o formulário.

3. Dê nomes significativos aos elementos, como `lblPlacar`, `btnAumentar`, `btnDiminuir`, `btnIniciar`, `btnPausar` e `timerAtualizar`.

### Etapa 2: Programação dos Botões

Agora, vamos programar os botões para aumentar, diminuir e controlar o placar.

```csharp
using System;
using System.Windows.Forms;

namespace PlacarApp
{
    public partial class Form1 : Form
    {
        private int placar = 0;
        private bool temporizadorAtivo = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            placar++;
            AtualizarPlacar();
        }

        private void btnDiminuir_Click(object sender, EventArgs e)
        {
            if (placar > 0)
            {
                placar--;
                AtualizarPlacar();
            }
        }

        private void AtualizarPlacar()
        {
            lblPlacar.Text = "Placar: " + placar;
        }
    }
}
```

Nesta etapa, programamos os botões de aumento e diminuição do placar. Quando o botão "+" é clicado, o placar é incrementado, e quando o botão "-" é clicado, o placar é diminuído. O método `AtualizarPlacar` é usado para atualizar a exibição do placar no `Label`.

### Etapa 3: Timer

Agora, vamos programar o temporizador para atualizar o placar automaticamente.

```csharp
using System;
using System.Windows.Forms;

namespace PlacarApp
{
    public partial class Form1 : Form
    {
        // Código anterior

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            temporizadorAtivo = true;
            timerAtualizar.Start();
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            temporizadorAtivo = false;
            timerAtualizar.Stop();
        }

        private void timerAtualizar_Tick(object sender, EventArgs e)
        {
            if (temporizadorAtivo)
            {
                placar++;
                AtualizarPlacar();
            }
        }
    }
}
```

Aqui, criamos eventos para os botões "Iniciar" e "Pausar" e configuramos um temporizador (`timerAtualizar`) para atualizar o placar automaticamente. Quando o botão "Iniciar" é clicado, o temporizador é iniciado e o placar é incrementado a cada intervalo do temporizador. Quando o botão "Pausar" é clicado, o temporizador é parado.

### Etapa 4: Utilizador Controla o Timer

Agora, os botões "Iniciar" e "Pausar" permitem ao usuário controlar o temporizador.

### Etapa 5: Ler e Gravar Ficheiros

Para ler e gravar o placar em um arquivo, você pode adicionar dois botões, "Guardar" e "Carregar". Vamos implementar isso usando `SaveFileDialog` e `OpenFileDialog`.

```csharp
private void btnGuardar_Click(object sender, EventArgs e)
{
    SaveFileDialog salvarDialog = new SaveFileDialog();
    salvarDialog.Filter = "Arquivos de Texto|*.txt";
    if (salvarDialog.ShowDialog() == DialogResult.OK)
    {
        string arquivo = salvarDialog.FileName;
        System.IO.File.WriteAllText(arquivo, placar.ToString());
    }
}

private void btnCarregar_Click(object sender, EventArgs e)
{
    OpenFileDialog abrirDialog = new OpenFileDialog();
    abrirDialog.Filter = "Arquivos de Texto|*.txt";
    if (abrirDialog.ShowDialog() == DialogResult.OK)
    {
        string arquivo = abrirDialog.FileName;
        if (System.IO.File.Exists(arquivo))
        {
            string conteudo = System.IO.File.ReadAllText(arquivo);
            if (int.TryParse(conteudo, out int novoPlacar))
            {
                placar = novoPlacar;
                AtualizarPlacar();
            }
        }
    }
}
```

Nesta etapa, adicionamos os botões "Guardar" e "Carregar" e implementamos as operações de gravação e leitura de arquivos de texto. O `SaveFileDialog` é usado para salvar o placar em um arquivo, enquanto o `OpenFileDialog` é usado para carregar um placar de um arquivo.

Lembre-se de adicionar esses dois botões à interface do usuário.

Agora você tem um aplicativo de placar completo em Windows Forms que permite ao usuário aumentar, diminuir, controlar o placar com um temporizador, salvar o placar em um arquivo e carregar o placar de um arquivo. Certifique-se de configurar os eventos dos botões "Guardar" e "Carregar" em seu formulário.