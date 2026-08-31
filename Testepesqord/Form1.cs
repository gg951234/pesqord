using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Testepesqord
{
    public partial class Form1 : Form
    {
        private List<int> dadosArquivo;

        private Dictionary<string, string> resultadosSalvos =
            new Dictionary<string, string>();

        // Guarda a lista completa depois da ordenação
        private Dictionary<string, List<int>> dadosOrdenadosSalvos =
            new Dictionary<string, List<int>>();

        private bool executando = false;

        private System.Windows.Forms.Timer timerProgresso;

        private DateTime inicioExecucao;

        private int progressoAtual;

        private int totalElementos;

        private string algoritmoAtual;

        public Form1()
        {
            InitializeComponent();

            txtNomeTeste.Text =
                "teste-" + DateTime.Now.ToString("yyyyMMdd-HHmmss");

            timerProgresso =
                new System.Windows.Forms.Timer();

            timerProgresso.Interval = 500;

            timerProgresso.Tick += TimerProgresso_Tick;
        }

        // ============================================================
        // SELECIONAR ARQUIVO
        // ============================================================

        private void btnSelecionarArquivo_Click(
            object sender,
            EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dadosArquivo =
                        File.ReadAllLines(openFileDialog1.FileName)
                            .Where(line => !string.IsNullOrWhiteSpace(line))
                            .Select(int.Parse)
                            .ToList();

                    lblArquivoSelecionado.Text =
                        Path.GetFileName(openFileDialog1.FileName);

                    totalElementos =
                        dadosArquivo.Count;

                    AtualizarTamanhoSelecionado(
                        totalElementos);

                    txtResultados.Text =
                        "Arquivo carregado com " +
                        totalElementos +
                        " linhas.\n\n";

                    txtResultados.Text +=
                        "Conteúdo original (primeiras 10 linhas):\n" +
                        string.Join(
                            "\n",
                            dadosArquivo.Take(10));

                    if (totalElementos > 10)
                    {
                        txtResultados.Text +=
                            "\n... (mostrando apenas as 10 primeiras linhas)";
                    }

                    if (totalElementos > 100000)
                    {
                        txtResultados.Text +=
                            $"\n\n⚠️ ATENÇÃO: {totalElementos:N0} elementos!\n";

                        txtResultados.Text +=
                            "Bubble Sort, Insertion Sort e Selection Sort " +
                            "podem levar MINUTOS ou HORAS.\n";
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show(
                        "Erro: O arquivo contém dados que não são números inteiros!\n" +
                        "Verifique se o arquivo tem apenas números.",
                        "Erro de Formato",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Erro ao ler o arquivo: " +
                        ex.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        // ============================================================
        // ATUALIZAR TAMANHO
        // ============================================================

        private void AtualizarTamanhoSelecionado(
            int tamanho)
        {
            rb700k.Checked = false;
            rb750k.Checked = false;
            rb800k.Checked = false;
            rb850k.Checked = false;
            rb900k.Checked = false;
            rb1M.Checked = false;

            if (tamanho <= 700000)
                rb700k.Checked = true;

            else if (tamanho <= 750000)
                rb750k.Checked = true;

            else if (tamanho <= 800000)
                rb800k.Checked = true;

            else if (tamanho <= 850000)
                rb850k.Checked = true;

            else if (tamanho <= 900000)
                rb900k.Checked = true;

            else
                rb1M.Checked = true;
        }

        // ============================================================
        // BUBBLE SORT - BOTÃO
        // ============================================================

        private void btnBubbleSort_Click(
            object sender,
            EventArgs e)
        {
            if (executando)
            {
                MessageBox.Show(
                    "Uma ordenação já está em execução!",
                    "Aguarde",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            algoritmoAtual =
                "Bubble Sort";

            ExecutarOrdenacao(
                "Bubble Sort",
                BubbleSortComProgresso);
        }

        // ============================================================
        // INSERTION SORT - BOTÃO
        // ============================================================

        private void btnInsertionSort_Click(
            object sender,
            EventArgs e)
        {
            if (executando)
            {
                MessageBox.Show(
                    "Uma ordenação já está em execução!",
                    "Aguarde",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            algoritmoAtual =
                "Insertion Sort";

            ExecutarOrdenacao(
                "Insertion Sort",
                InsertionSortComProgresso);
        }

        // ============================================================
        // SELECTION SORT - BOTÃO
        // ============================================================

        private void btnSelectionSort_Click(
            object sender,
            EventArgs e)
        {
            if (executando)
            {
                MessageBox.Show(
                    "Uma ordenação já está em execução!",
                    "Aguarde",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            algoritmoAtual =
                "Selection Sort";

            ExecutarOrdenacao(
                "Selection Sort",
                SelectionSortComProgresso);
        }

        // ============================================================
        // SHELL SORT - BOTÃO
        // ============================================================

        private void btnShellSort_Click(
            object sender,
            EventArgs e)
        {
            if (executando)
            {
                MessageBox.Show(
                    "Uma ordenação já está em execução!",
                    "Aguarde",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            algoritmoAtual =
                "Shell Sort";

            ExecutarOrdenacao(
                "Shell Sort",
                ShellSortComProgresso);
        }

        // ============================================================
        // LIMPAR TESTE
        // ============================================================

        private void btnLimparTeste_Click(
            object sender,
            EventArgs e)
        {
            if (executando)
            {
                MessageBox.Show(
                    "Não é possível limpar enquanto uma ordenação está em execução.",
                    "Ordenação em andamento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            dadosArquivo = null;

            resultadosSalvos.Clear();

            dadosOrdenadosSalvos.Clear();

            progressoAtual = 0;

            totalElementos = 0;

            algoritmoAtual = null;

            lblArquivoSelecionado.Text =
                "Nenhum arquivo selecionado";

            txtNomeTeste.Text =
                "teste-" +
                DateTime.Now.ToString("yyyyMMdd-HHmmss");

            txtResultados.Clear();

            lblStatusGeracao.Text =
                "Aguardando execução...";

            lblStatusGeracao.ForeColor =
                System.Drawing.Color.Black;

            rb700k.Checked = false;
            rb750k.Checked = false;
            rb800k.Checked = false;
            rb850k.Checked = false;
            rb900k.Checked = false;
            rb1M.Checked = true;

            rbRandomicos.Checked = true;

            this.Text =
                "Sistema de Ordenação - Bubble Sort vs Insertion Sort";

            MessageBox.Show(
                "Dados do último teste foram limpos.",
                "Teste limpo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ============================================================
        // TIMER DE PROGRESSO
        // ============================================================

        private void TimerProgresso_Tick(
            object sender,
            EventArgs e)
        {
            if (!executando)
                return;

            var tempoDecorrido =
                DateTime.Now - inicioExecucao;

            double percentual =
                GetProgressoPercentual();

            var estimativa =
                EstimarTempoRestante(
                    progressoAtual,
                    totalElementos,
                    tempoDecorrido);

            if (lblStatusGeracao != null)
            {
                string barraProgresso =
                    CriarBarraProgresso(
                        percentual,
                        30);

                lblStatusGeracao.Text =
                    $"🔵 {algoritmoAtual}\n" +
                    $"Progresso: {progressoAtual:N0}/" +
                    $"{totalElementos:N0} " +
                    $"({percentual:F1}%)\n" +
                    $"{barraProgresso}\n" +
                    $"⏱️ Tempo decorrido: " +
                    $"{FormatarTempo(tempoDecorrido)}\n" +
                    $"⏳ Estimativa restante: " +
                    $"{FormatarTempo(estimativa)}";

                lblStatusGeracao.ForeColor =
                    System.Drawing.Color.Blue;

                Application.DoEvents();
            }

            this.Text =
                $"Teste Ordenação - " +
                $"{algoritmoAtual} - " +
                $"{percentual:F1}%";
        }

        // ============================================================
        // BARRA DE PROGRESSO
        // ============================================================

        private string CriarBarraProgresso(
            double percentual,
            int tamanho)
        {
            int preenchido =
                (int)((percentual / 100) * tamanho);

            if (preenchido > tamanho)
                preenchido = tamanho;

            if (preenchido < 0)
                preenchido = 0;

            int vazio =
                tamanho - preenchido;

            return
                "[" +
                new string('█', preenchido) +
                new string('░', vazio) +
                "]";
        }

        // ============================================================
        // FORMATAR TEMPO
        // ============================================================

        private string FormatarTempo(
            TimeSpan tempo)
        {
            if (tempo.TotalHours >= 1)
            {
                return
                    $"{(int)tempo.TotalHours}h " +
                    $"{tempo.Minutes}m " +
                    $"{tempo.Seconds}s";
            }

            if (tempo.TotalMinutes >= 1)
            {
                return
                    $"{tempo.Minutes}m " +
                    $"{tempo.Seconds}s";
            }

            return
                $"{tempo.Seconds}." +
                $"{tempo.Milliseconds:D3}s";
        }

        // ============================================================
        // PERCENTUAL
        // ============================================================

        private double GetProgressoPercentual()
        {
            if (totalElementos == 0)
                return 0;

            return
                (progressoAtual /
                (double)totalElementos) * 100;
        }

        // ============================================================
        // ESTIMATIVA
        // ============================================================

        private TimeSpan EstimarTempoRestante(
            int progresso,
            int total,
            TimeSpan tempoDecorrido)
        {
            if (progresso == 0)
                return TimeSpan.FromSeconds(30);

            double progressoPercentual =
                progresso /
                (double)total;

            if (progressoPercentual == 0)
                return TimeSpan.FromMinutes(10);

            double tempoTotalEstimado =
                tempoDecorrido.TotalSeconds /
                progressoPercentual;

            double tempoRestante =
                tempoTotalEstimado -
                tempoDecorrido.TotalSeconds;

            return TimeSpan.FromSeconds(
                Math.Max(
                    tempoRestante,
                    1));
        }

        // ============================================================
        // EXECUTAR ORDENAÇÃO
        // ============================================================

        private void ExecutarOrdenacao(
            string nomeAlgoritmo,
            Action<List<int>, Action<int, int>> algoritmo)
        {
            if (!ValidarDados())
                return;

            if (totalElementos > 50000)
            {
                string mensagem =
                    $"⚠️ ATENÇÃO: {totalElementos:N0} elementos!\n\n" +
                    $"O {nomeAlgoritmo} pode levar muito tempo.\n\n" +
                    $"Deseja continuar?";

                var result =
                    MessageBox.Show(
                        mensagem,
                        "Aviso de Performance",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    return;
            }

            try
            {
                executando = true;

                progressoAtual = 0;

                inicioExecucao =
                    DateTime.Now;

                this.Cursor =
                    Cursors.WaitCursor;

                timerProgresso.Start();

                txtResultados.Text =
                    $"=== {nomeAlgoritmo} ===\n";

                txtResultados.Text +=
                    $"Iniciando em: " +
                    $"{DateTime.Now:HH:mm:ss}\n";

                txtResultados.Text +=
                    $"Elementos: " +
                    $"{totalElementos:N0}\n";

                txtResultados.Text +=
                    $"Tipo: " +
                    $"{ObterTipoSelecionado()}\n";

                txtResultados.Text +=
                    new string('=', 50) +
                    "\n\n";

                txtResultados.Text +=
                    "⏳ Executando...\n";

                txtResultados.Text +=
                    "Status: Processando...\n";

                Application.DoEvents();

                // ====================================================
                // IMPORTANTE:
                // Cria uma cópia para preservar o arquivo original.
                // ====================================================

                var dadosCopia =
                    new List<int>(dadosArquivo);

                Action<int, int> atualizarProgresso =
                    (progresso, total) =>
                    {
                        progressoAtual =
                            progresso;

                        totalElementos =
                            total;
                    };

                // ====================================================
                // INÍCIO DA MEDIÇÃO
                // ====================================================

                var watch =
                    Stopwatch.StartNew();

                // ====================================================
                // EXECUTA O ALGORITMO ESCOLHIDO
                // ====================================================

                algoritmo(
                    dadosCopia,
                    atualizarProgresso);

                watch.Stop();

                // ====================================================
                // FINALIZA
                // ====================================================

                timerProgresso.Stop();

                executando = false;

                this.Cursor =
                    Cursors.Default;

                this.Text =
                    "Teste Ordenação";

                // ====================================================
                // VERIFICAÇÃO DE SEGURANÇA
                // ====================================================

                if (!ListaEstaOrdenada(dadosCopia))
                {
                    throw new Exception(
                        "O algoritmo terminou, mas a lista não está " +
                        "corretamente ordenada.");
                }

                // ====================================================
                // CRIAR RESULTADO
                // ====================================================

                var resultado =
                    new ResultadoOrdenacao
                    {
                        NomeAlgoritmo =
                            nomeAlgoritmo,

                        TempoSegundos =
                            watch.Elapsed.TotalSeconds,

                        Tamanho =
                            dadosCopia.Count,

                        TipoOrdenacao =
                            ObterTipoSelecionado(),

                        NomeTeste =
                            txtNomeTeste.Text,

                        Arquivo =
                            lblArquivoSelecionado.Text,

                        // PRIMEIROS 10 DEPOIS DA ORDENAÇÃO
                        PrimeirosElementos =
                            dadosCopia
                                .Take(10)
                                .ToList()
                    };

                // ====================================================
                // MOSTRAR RESULTADO
                // ====================================================

                txtResultados.Text =
                    resultado.ToString();

                // ====================================================
                // GUARDAR RELATÓRIO
                // ====================================================

                resultadosSalvos[nomeAlgoritmo] =
                    resultado.ToString();

                // ====================================================
                // GUARDAR TODOS OS NÚMEROS ORDENADOS
                // ====================================================

                dadosOrdenadosSalvos[nomeAlgoritmo] =
                    new List<int>(dadosCopia);

                if (lblStatusGeracao != null)
                {
                    lblStatusGeracao.Text =
                        $"✅ Concluído em " +
                        $"{watch.Elapsed.TotalSeconds:F3}s";

                    lblStatusGeracao.ForeColor =
                        System.Drawing.Color.Green;
                }
            }
            catch (Exception ex)
            {
                executando = false;

                timerProgresso.Stop();

                this.Cursor =
                    Cursors.Default;

                this.Text =
                    "Teste Ordenação";

                if (lblStatusGeracao != null)
                {
                    lblStatusGeracao.Text =
                        "❌ Erro na execução!";

                    lblStatusGeracao.ForeColor =
                        System.Drawing.Color.Red;
                }

                MessageBox.Show(
                    $"Erro ao executar {nomeAlgoritmo}: " +
                    $"{ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // BUBBLE SORT
        // ============================================================

        private void BubbleSortComProgresso(
            List<int> lista,
            Action<int, int> atualizarProgresso)
        {
            int n =
                lista.Count;

            for (int i = 0; i < n - 1; i++)
            {
                bool trocado =
                    false;

                for (int j = 0;
                     j < n - i - 1;
                     j++)
                {
                    // COMPARAÇÃO NUMÉRICA
                    if (lista[j] >
                        lista[j + 1])
                    {
                        int temp =
                            lista[j];

                        lista[j] =
                            lista[j + 1];

                        lista[j + 1] =
                            temp;

                        trocado =
                            true;
                    }
                }

                if (i % 1000 == 0)
                {
                    atualizarProgresso(
                        i + 1,
                        n);

                    Application.DoEvents();
                }

                // Otimização tradicional:
                // se não houve troca, já está ordenado.
                if (!trocado)
                    break;
            }

            atualizarProgresso(
                n,
                n);
        }

        // ============================================================
        // INSERTION SORT
        // ============================================================

        private void InsertionSortComProgresso(
            List<int> lista,
            Action<int, int> atualizarProgresso)
        {
            int n =
                lista.Count;

            int ultimoProgresso =
                0;

            for (int i = 1;
                 i < n;
                 i++)
            {
                int chave =
                    lista[i];

                int j =
                    i - 1;

                while (j >= 0 &&
                       lista[j] > chave)
                {
                    lista[j + 1] =
                        lista[j];

                    j--;
                }

                lista[j + 1] =
                    chave;

                int progressoPercentual =
                    (int)(
                        (i /
                        (double)n) *
                        100);

                if (progressoPercentual >
                    ultimoProgresso + 1 ||
                    i % 1000 == 0)
                {
                    ultimoProgresso =
                        progressoPercentual;

                    atualizarProgresso(
                        i,
                        n);

                    if (i % 10000 == 0)
                        Application.DoEvents();
                }
            }

            atualizarProgresso(
                n,
                n);
        }

        // ============================================================
        // SELECTION SORT
        // ============================================================

        private void SelectionSortComProgresso(
            List<int> lista,
            Action<int, int> atualizarProgresso)
        {
            int n =
                lista.Count;

            for (int i = 0;
                 i < n - 1;
                 i++)
            {
                int indiceMenor =
                    i;

                // Procura o menor elemento
                // na parte ainda não ordenada.
                for (int j = i + 1;
                     j < n;
                     j++)
                {
                    if (lista[j] <
                        lista[indiceMenor])
                    {
                        indiceMenor =
                            j;
                    }
                }

                // Troca
                if (indiceMenor != i)
                {
                    int temp =
                        lista[i];

                    lista[i] =
                        lista[indiceMenor];

                    lista[indiceMenor] =
                        temp;
                }

                if (i % 1000 == 0)
                {
                    atualizarProgresso(
                        i + 1,
                        n);

                    Application.DoEvents();
                }
            }

            atualizarProgresso(
                n,
                n);
        }

        // ============================================================
        // SHELL SORT
        // ============================================================

        private void ShellSortComProgresso(
            List<int> lista,
            Action<int, int> atualizarProgresso)
        {
            int n =
                lista.Count;

            // Sequência de gaps:
            // n/2, n/4, n/8, ... , 1
            for (int gap = n / 2;
                 gap > 0;
                 gap /= 2)
            {
                // Insertion Sort com intervalo
                for (int i = gap;
                     i < n;
                     i++)
                {
                    int valor =
                        lista[i];

                    int j =
                        i;

                    while (j >= gap &&
                           lista[j - gap] >
                           valor)
                    {
                        lista[j] =
                            lista[j - gap];

                        j -= gap;
                    }

                    lista[j] =
                        valor;
                }

                atualizarProgresso(
                    n - gap,
                    n);

                Application.DoEvents();
            }

            atualizarProgresso(
                n,
                n);
        }

        // ============================================================
        // VERIFICAR SE ESTÁ ORDENADO
        // ============================================================

        private bool ListaEstaOrdenada(
            List<int> lista)
        {
            for (int i = 1;
                 i < lista.Count;
                 i++)
            {
                if (lista[i - 1] >
                    lista[i])
                {
                    return false;
                }
            }

            return true;
        }

        // ============================================================
        // VALIDAR DADOS
        // ============================================================

        private bool ValidarDados()
        {
            if (dadosArquivo == null ||
                dadosArquivo.Count == 0)
            {
                MessageBox.Show(
                    "Por favor, selecione um arquivo primeiro!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        // ============================================================
        // TAMANHO SELECIONADO
        // ============================================================

        private int ObterTamanhoSelecionado()
        {
            if (rb700k.Checked)
                return 700000;

            if (rb750k.Checked)
                return 750000;

            if (rb800k.Checked)
                return 800000;

            if (rb850k.Checked)
                return 850000;

            if (rb900k.Checked)
                return 900000;

            if (rb1M.Checked)
                return 1000000;

            return 1000000;
        }

        // ============================================================
        // TIPO SELECIONADO
        // ============================================================

        private string ObterTipoSelecionado()
        {
            if (rbOrdenados.Checked)
                return "Ordenados";

            if (rbInvertidos.Checked)
                return "Invertidos";

            if (rbRandomicos.Checked)
                return "Randômicos";

            return "Randômicos";
        }

        // ============================================================
        // SALVAR RESULTADOS
        // ============================================================

        private void btnSalvarResultados_Click(
            object sender,
            EventArgs e)
        {
            if (resultadosSalvos.Count == 0)
            {
                MessageBox.Show(
                    "Não há resultados para salvar!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (var saveFileDialog =
                       new SaveFileDialog())
                {
                    saveFileDialog.Filter =
                        "Arquivos de texto (*.txt)|*.txt";

                    saveFileDialog.Title =
                        "Salvar Resultados";

                    saveFileDialog.FileName =
                        $"{txtNomeTeste.Text}-resultados.txt";

                    if (saveFileDialog.ShowDialog() ==
                        DialogResult.OK)
                    {
                        using (var writer =
                               new StreamWriter(
                                   saveFileDialog.FileName,
                                   false,
                                   Encoding.UTF8))
                        {
                            // ==================================================
                            // RELATÓRIO
                            // ==================================================

                            writer.WriteLine(
                                "=== RELATÓRIO DE TESTES ===");

                            writer.WriteLine(
                                $"Nome do Teste: " +
                                $"{txtNomeTeste.Text}");

                            writer.WriteLine(
                                $"Data/Hora: " +
                                $"{DateTime.Now:dd/MM/yyyy HH:mm:ss}");

                            writer.WriteLine(
                                $"Arquivo: " +
                                $"{lblArquivoSelecionado.Text}");

                            writer.WriteLine(
                                $"Tamanho: " +
                                $"{dadosArquivo.Count:N0}");

                            writer.WriteLine(
                                $"Tipo: " +
                                $"{ObterTipoSelecionado()}");

                            writer.WriteLine(
                                new string('=', 50));

                            writer.WriteLine();

                            // ==================================================
                            // RESULTADOS
                            // ==================================================

                            foreach (var resultado
                                in resultadosSalvos)
                            {
                                writer.WriteLine(
                                    resultado.Value);

                                writer.WriteLine();

                                // ==================================================
                                // TODOS OS NÚMEROS ORDENADOS
                                // ==================================================

                                if (dadosOrdenadosSalvos.ContainsKey(
                                    resultado.Key))
                                {
                                    writer.WriteLine(
                                        new string('=', 50));

                                    writer.WriteLine(
                                        $"NÚMEROS ORDENADOS - " +
                                        $"{resultado.Key}");

                                    writer.WriteLine(
                                        new string('=', 50));

                                    foreach (int numero
                                        in dadosOrdenadosSalvos[
                                            resultado.Key])
                                    {
                                        writer.WriteLine(
                                            numero);
                                    }

                                    writer.WriteLine();

                                    writer.WriteLine(
                                        new string('=', 50));

                                    writer.WriteLine();
                                }
                            }
                        }

                        MessageBox.Show(
                            "Resultados e números ordenados " +
                            "salvos com sucesso!",
                            "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao salvar: " +
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // CLASSE DO RESULTADO
        // ============================================================

        private class ResultadoOrdenacao
        {
            public string NomeAlgoritmo { get; set; }

            public double TempoSegundos { get; set; }

            public int Tamanho { get; set; }

            public string TipoOrdenacao { get; set; }

            public string NomeTeste { get; set; }

            public string Arquivo { get; set; }

            public List<int> PrimeirosElementos { get; set; }

            public override string ToString()
            {
                var sb =
                    new StringBuilder();

                sb.AppendLine(
                    $"=== {NomeAlgoritmo} ===");

                sb.AppendLine(
                    $"Nome do Teste: " +
                    $"{NomeTeste}");

                sb.AppendLine(
                    $"Arquivo: " +
                    $"{Arquivo}");

                // ====================================================
                // TEMPO
                // ====================================================

                if (TempoSegundos < 60)
                {
                    sb.AppendLine(
                        $"Tempo de execução: " +
                        $"{TempoSegundos:F3} segundos");
                }
                else if (TempoSegundos < 3600)
                {
                    int minutos =
                        (int)(
                            TempoSegundos /
                            60);

                    double segundos =
                        TempoSegundos %
                        60;

                    sb.AppendLine(
                        $"Tempo de execução: " +
                        $"{minutos}m " +
                        $"{segundos:F1}s " +
                        $"({TempoSegundos:F1}s)");
                }
                else
                {
                    int horas =
                        (int)(
                            TempoSegundos /
                            3600);

                    int minutos =
                        (int)(
                            (TempoSegundos %
                            3600) /
                            60);

                    double segundos =
                        TempoSegundos %
                        60;

                    sb.AppendLine(
                        $"Tempo de execução: " +
                        $"{horas}h " +
                        $"{minutos}m " +
                        $"{segundos:F1}s");
                }

                sb.AppendLine(
                    $"Total de registros: " +
                    $"{Tamanho:N0}");

                sb.AppendLine(
                    $"Tipo: " +
                    $"{TipoOrdenacao}");

                sb.AppendLine(
                    "Primeiros 10 elementos ordenados:");

                if (PrimeirosElementos != null &&
                    PrimeirosElementos.Any())
                {
                    sb.AppendLine(
                        string.Join(
                            "\n",
                            PrimeirosElementos
                                .Take(10)
                                .Select(
                                    x => x.ToString())));
                }

                return sb.ToString();
            }
        }
    }
}