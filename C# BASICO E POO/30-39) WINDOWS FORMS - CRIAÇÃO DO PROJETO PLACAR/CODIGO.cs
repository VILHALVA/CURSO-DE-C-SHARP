using System;
using System.Windows.Forms;
using System.IO;

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvarDialog = new SaveFileDialog();
            salvarDialog.Filter = "Arquivos de Texto|*.txt";
            if (salvarDialog.ShowDialog() == DialogResult.OK)
            {
                string arquivo = salvarDialog.FileName;
                File.WriteAllText(arquivo, placar.ToString());
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirDialog = new OpenFileDialog();
            abrirDialog.Filter = "Arquivos de Texto|*.txt";
            if (abrirDialog.ShowDialog() == DialogResult.OK)
            {
                string arquivo = abrirDialog.FileName;
                if (File.Exists(arquivo))
                {
                    string conteudo = File.ReadAllText(arquivo);
                    if (int.TryParse(conteudo, out int novoPlacar))
                    {
                        placar = novoPlacar;
                        AtualizarPlacar();
                    }
                }
            }
        }
    }
}
