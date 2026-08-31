namespace Testepesqord
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(
            bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnSelecionarArquivo =
                new System.Windows.Forms.Button();

            this.lblArquivoSelecionado =
                new System.Windows.Forms.Label();

            this.btnBubbleSort =
                new System.Windows.Forms.Button();

            this.btnInsertionSort =
                new System.Windows.Forms.Button();

            this.btnSelectionSort =
                new System.Windows.Forms.Button();

            this.btnShellSort =
                new System.Windows.Forms.Button();

            this.btnLimparTeste =
                new System.Windows.Forms.Button();

            this.txtResultados =
                new System.Windows.Forms.TextBox();

            this.openFileDialog1 =
                new System.Windows.Forms.OpenFileDialog();

            this.grpParametros =
                new System.Windows.Forms.GroupBox();

            this.rbOrdenados =
                new System.Windows.Forms.RadioButton();

            this.rbInvertidos =
                new System.Windows.Forms.RadioButton();

            this.rbRandomicos =
                new System.Windows.Forms.RadioButton();

            this.grpTamanho =
                new System.Windows.Forms.GroupBox();

            this.rb700k =
                new System.Windows.Forms.RadioButton();

            this.rb750k =
                new System.Windows.Forms.RadioButton();

            this.rb800k =
                new System.Windows.Forms.RadioButton();

            this.rb850k =
                new System.Windows.Forms.RadioButton();

            this.rb900k =
                new System.Windows.Forms.RadioButton();

            this.rb1M =
                new System.Windows.Forms.RadioButton();

            this.txtNomeTeste =
                new System.Windows.Forms.TextBox();

            this.lblNomeTeste =
                new System.Windows.Forms.Label();

            this.btnSalvarResultados =
                new System.Windows.Forms.Button();

            this.grpResultados =
                new System.Windows.Forms.GroupBox();

            this.lblStatusGeracao =
                new System.Windows.Forms.Label();

            this.grpStatus =
                new System.Windows.Forms.GroupBox();

            this.btnCancelar =
                new System.Windows.Forms.Button();

            this.grpStatus.SuspendLayout();
            this.grpParametros.SuspendLayout();
            this.grpTamanho.SuspendLayout();
            this.grpResultados.SuspendLayout();
            this.SuspendLayout();

            // ============================================================
            // btnSelecionarArquivo
            // ============================================================

            this.btnSelecionarArquivo.Location =
                new System.Drawing.Point(12, 12);

            this.btnSelecionarArquivo.Name =
                "btnSelecionarArquivo";

            this.btnSelecionarArquivo.Size =
                new System.Drawing.Size(150, 30);

            this.btnSelecionarArquivo.TabIndex = 0;

            this.btnSelecionarArquivo.Text =
                "Selecionar Arquivo .txt";

            this.btnSelecionarArquivo.UseVisualStyleBackColor =
                true;

            this.btnSelecionarArquivo.Click +=
                new System.EventHandler(
                    this.btnSelecionarArquivo_Click);

            // ============================================================
            // lblArquivoSelecionado
            // ============================================================

            this.lblArquivoSelecionado.AutoSize =
                true;

            this.lblArquivoSelecionado.Location =
                new System.Drawing.Point(168, 20);

            this.lblArquivoSelecionado.Name =
                "lblArquivoSelecionado";

            this.lblArquivoSelecionado.Size =
                new System.Drawing.Size(180, 15);

            this.lblArquivoSelecionado.TabIndex = 1;

            this.lblArquivoSelecionado.Text =
                "Nenhum arquivo selecionado";

            // ============================================================
            // btnBubbleSort
            // ============================================================

            this.btnBubbleSort.Location =
                new System.Drawing.Point(12, 280);

            this.btnBubbleSort.Name =
                "btnBubbleSort";

            this.btnBubbleSort.Size =
                new System.Drawing.Size(150, 30);

            this.btnBubbleSort.TabIndex = 2;

            this.btnBubbleSort.Text =
                "Executar Bubble Sort";

            this.btnBubbleSort.UseVisualStyleBackColor =
                true;

            this.btnBubbleSort.Click +=
                new System.EventHandler(
                    this.btnBubbleSort_Click);

            // ============================================================
            // btnInsertionSort
            // ============================================================

            this.btnInsertionSort.Location =
                new System.Drawing.Point(12, 316);

            this.btnInsertionSort.Name =
                "btnInsertionSort";

            this.btnInsertionSort.Size =
                new System.Drawing.Size(150, 30);

            this.btnInsertionSort.TabIndex = 3;

            this.btnInsertionSort.Text =
                "Executar Insertion Sort";

            this.btnInsertionSort.UseVisualStyleBackColor =
                true;

            this.btnInsertionSort.Click +=
                new System.EventHandler(
                    this.btnInsertionSort_Click);

            // ============================================================
            // btnSelectionSort
            // ============================================================

            this.btnSelectionSort.Location =
                new System.Drawing.Point(12, 352);

            this.btnSelectionSort.Name =
                "btnSelectionSort";

            this.btnSelectionSort.Size =
                new System.Drawing.Size(150, 30);

            this.btnSelectionSort.TabIndex = 4;

            this.btnSelectionSort.Text =
                "Executar Selection Sort";

            this.btnSelectionSort.UseVisualStyleBackColor =
                true;

            this.btnSelectionSort.Click +=
                new System.EventHandler(
                    this.btnSelectionSort_Click);

            // ============================================================
            // btnShellSort
            // ============================================================

            this.btnShellSort.Location =
                new System.Drawing.Point(12, 388);

            this.btnShellSort.Name =
                "btnShellSort";

            this.btnShellSort.Size =
                new System.Drawing.Size(150, 30);

            this.btnShellSort.TabIndex = 5;

            this.btnShellSort.Text =
                "Executar Shell Sort";

            this.btnShellSort.UseVisualStyleBackColor =
                true;

            this.btnShellSort.Click +=
                new System.EventHandler(
                    this.btnShellSort_Click);

            // ============================================================
            // txtResultados
            // ============================================================

            this.txtResultados.Location =
                new System.Drawing.Point(6, 22);

            this.txtResultados.Multiline =
                true;

            this.txtResultados.Name =
                "txtResultados";

            this.txtResultados.ReadOnly =
                true;

            this.txtResultados.ScrollBars =
                System.Windows.Forms.ScrollBars.Vertical;

            this.txtResultados.Size =
                new System.Drawing.Size(580, 370);

            this.txtResultados.TabIndex = 6;

            this.txtResultados.Font =
                new System.Drawing.Font(
                    "Consolas",
                    9F);

            // ============================================================
            // openFileDialog1
            // ============================================================

            this.openFileDialog1.FileName =
                "openFileDialog1";

            this.openFileDialog1.Filter =
                "Arquivos de texto (*.txt)|*.txt|" +
                "Todos os arquivos (*.*)|*.*";

            this.openFileDialog1.Title =
                "Selecione um arquivo .txt";

            // ============================================================
            // grpParametros
            // ============================================================

            this.grpParametros.Controls.Add(
                this.rbOrdenados);

            this.grpParametros.Controls.Add(
                this.rbInvertidos);

            this.grpParametros.Controls.Add(
                this.rbRandomicos);

            this.grpParametros.Location =
                new System.Drawing.Point(12, 70);

            this.grpParametros.Name =
                "grpParametros";

            this.grpParametros.Size =
                new System.Drawing.Size(150, 100);

            this.grpParametros.TabIndex = 7;

            this.grpParametros.TabStop = false;

            this.grpParametros.Text =
                "Estado do Arquivo";

            // ============================================================
            // rbOrdenados
            // ============================================================

            this.rbOrdenados.AutoSize =
                true;

            this.rbOrdenados.Location =
                new System.Drawing.Point(6, 22);

            this.rbOrdenados.Name =
                "rbOrdenados";

            this.rbOrdenados.Size =
                new System.Drawing.Size(81, 19);

            this.rbOrdenados.TabIndex = 0;

            this.rbOrdenados.Text =
                "Ordenados";

            this.rbOrdenados.UseVisualStyleBackColor =
                true;

            // ============================================================
            // rbInvertidos
            // ============================================================

            this.rbInvertidos.AutoSize =
                true;

            this.rbInvertidos.Location =
                new System.Drawing.Point(6, 47);

            this.rbInvertidos.Name =
                "rbInvertidos";

            this.rbInvertidos.Size =
                new System.Drawing.Size(79, 19);

            this.rbInvertidos.TabIndex = 1;

            this.rbInvertidos.Text =
                "Invertidos";

            this.rbInvertidos.UseVisualStyleBackColor =
                true;

            // ============================================================
            // rbRandomicos
            // ============================================================

            this.rbRandomicos.AutoSize =
                true;

            this.rbRandomicos.Checked =
                true;

            this.rbRandomicos.Location =
                new System.Drawing.Point(6, 72);

            this.rbRandomicos.Name =
                "rbRandomicos";

            this.rbRandomicos.Size =
                new System.Drawing.Size(87, 19);

            this.rbRandomicos.TabIndex = 2;

            this.rbRandomicos.TabStop =
                true;

            this.rbRandomicos.Text =
                "Randômicos";

            this.rbRandomicos.UseVisualStyleBackColor =
                true;

            // ============================================================
            // grpTamanho
            // ============================================================

            this.grpTamanho.Controls.Add(
                this.rb700k);

            this.grpTamanho.Controls.Add(
                this.rb750k);

            this.grpTamanho.Controls.Add(
                this.rb800k);

            this.grpTamanho.Controls.Add(
                this.rb850k);

            this.grpTamanho.Controls.Add(
                this.rb900k);

            this.grpTamanho.Controls.Add(
                this.rb1M);

            this.grpTamanho.Location =
                new System.Drawing.Point(12, 176);

            this.grpTamanho.Name =
                "grpTamanho";

            this.grpTamanho.Size =
                new System.Drawing.Size(150, 98);

            this.grpTamanho.TabIndex = 8;

            this.grpTamanho.TabStop = false;

            this.grpTamanho.Text =
                "Tamanho do Arquivo";

            // ============================================================
            // rb700k
            // ============================================================

            this.rb700k.AutoSize =
                true;

            this.rb700k.Location =
                new System.Drawing.Point(6, 22);

            this.rb700k.Name =
                "rb700k";

            this.rb700k.Size =
                new System.Drawing.Size(65, 19);

            this.rb700k.TabIndex = 0;

            this.rb700k.Text =
                "700.000";

            this.rb700k.UseVisualStyleBackColor =
                true;

            // ============================================================
            // rb750k
            // ============================================================

            this.rb750k.AutoSize =
                true;

            this.rb750k.Location =
                new System.Drawing.Point(77, 22);

            this.rb750k.Name =
                "rb750k";

            this.rb750k.Size =
                new System.Drawing.Size(65, 19);

            this.rb750k.TabIndex = 1;

            this.rb750k.Text =
                "750.000";

            this.rb750k.UseVisualStyleBackColor =
                true;

            // ============================================================
            // rb800k
            // ============================================================

            this.rb800k.AutoSize =
                true;

            this.rb800k.Location =
                new System.Drawing.Point(6, 47);

            this.rb800k.Name =
                "rb800k";

            this.rb800k.Size =
                new System.Drawing.Size(65, 19);

            this.rb800k.TabIndex = 2;

            this.rb800k.Text =
                "800.000";

            this.rb800k.UseVisualStyleBackColor =
                true;

            // ============================================================
            // rb850k
            // ============================================================

            this.rb850k.AutoSize =
                true;

            this.rb850k.Location =
                new System.Drawing.Point(77, 47);

            this.rb850k.Name =
                "rb850k";

            this.rb850k.Size =
                new System.Drawing.Size(65, 19);

            this.rb850k.TabIndex = 3;

            this.rb850k.Text =
                "850.000";

            this.rb850k.UseVisualStyleBackColor =
                true;

            // ============================================================
            // rb900k
            // ============================================================

            this.rb900k.AutoSize =
                true;

            this.rb900k.Location =
                new System.Drawing.Point(6, 72);

            this.rb900k.Name =
                "rb900k";

            this.rb900k.Size =
                new System.Drawing.Size(65, 19);

            this.rb900k.TabIndex = 4;

            this.rb900k.Text =
                "900.000";

            this.rb900k.UseVisualStyleBackColor =
                true;

            // ============================================================
            // rb1M
            // ============================================================

            this.rb1M.AutoSize =
                true;

            this.rb1M.Checked =
                true;

            this.rb1M.Location =
                new System.Drawing.Point(77, 72);

            this.rb1M.Name =
                "rb1M";

            this.rb1M.Size =
                new System.Drawing.Size(73, 19);

            this.rb1M.TabIndex = 5;

            this.rb1M.TabStop =
                true;

            this.rb1M.Text =
                "1.000.000";

            this.rb1M.UseVisualStyleBackColor =
                true;

            // ============================================================
            // txtNomeTeste
            // ============================================================

            this.txtNomeTeste.Location =
                new System.Drawing.Point(168, 70);

            this.txtNomeTeste.Name =
                "txtNomeTeste";

            this.txtNomeTeste.Size =
                new System.Drawing.Size(200, 23);

            this.txtNomeTeste.TabIndex = 9;

            // ============================================================
            // lblNomeTeste
            // ============================================================

            this.lblNomeTeste.AutoSize =
                true;

            this.lblNomeTeste.Location =
                new System.Drawing.Point(168, 52);

            this.lblNomeTeste.Name =
                "lblNomeTeste";

            this.lblNomeTeste.Size =
                new System.Drawing.Size(90, 15);

            this.lblNomeTeste.TabIndex = 10;

            this.lblNomeTeste.Text =
                "Nome do Teste:";

            // ============================================================
            // btnSalvarResultados
            // ============================================================

            this.btnSalvarResultados.Location =
                new System.Drawing.Point(168, 316);

            this.btnSalvarResultados.Name =
                "btnSalvarResultados";

            this.btnSalvarResultados.Size =
                new System.Drawing.Size(150, 30);

            this.btnSalvarResultados.TabIndex = 11;

            this.btnSalvarResultados.Text =
                "Salvar Resultados";

            this.btnSalvarResultados.UseVisualStyleBackColor =
                true;

            this.btnSalvarResultados.Click +=
                new System.EventHandler(
                    this.btnSalvarResultados_Click);

            // ============================================================
            // btnLimparTeste
            // ============================================================

            this.btnLimparTeste.Location =
                new System.Drawing.Point(168, 352);

            this.btnLimparTeste.Name =
                "btnLimparTeste";

            this.btnLimparTeste.Size =
                new System.Drawing.Size(150, 30);

            this.btnLimparTeste.TabIndex = 12;

            this.btnLimparTeste.Text =
                "Limpar Teste";

            this.btnLimparTeste.UseVisualStyleBackColor =
                true;

            this.btnLimparTeste.Click +=
                new System.EventHandler(
                    this.btnLimparTeste_Click);

            // ============================================================
            // grpResultados
            // ============================================================

            this.grpResultados.Controls.Add(
                this.txtResultados);

            this.grpResultados.Location =
                new System.Drawing.Point(374, 12);

            this.grpResultados.Name =
                "grpResultados";

            this.grpResultados.Size =
                new System.Drawing.Size(600, 400);

            this.grpResultados.TabIndex = 13;

            this.grpResultados.TabStop = false;

            this.grpResultados.Text =
                "Resultados";

            // ============================================================
            // lblStatusGeracao
            // ============================================================

            this.lblStatusGeracao.AutoSize =
                true;

            this.lblStatusGeracao.Location =
                new System.Drawing.Point(6, 22);

            this.lblStatusGeracao.Name =
                "lblStatusGeracao";

            this.lblStatusGeracao.Size =
                new System.Drawing.Size(117, 15);

            this.lblStatusGeracao.TabIndex = 0;

            this.lblStatusGeracao.Text =
                "Aguardando execução...";

            this.lblStatusGeracao.ForeColor =
                System.Drawing.Color.Black;

            // ============================================================
            // grpStatus
            // ============================================================

            this.grpStatus.Controls.Add(
                this.lblStatusGeracao);

            this.grpStatus.Controls.Add(
                this.btnCancelar);

            this.grpStatus.Location =
                new System.Drawing.Point(168, 100);

            this.grpStatus.Name =
                "grpStatus";

            this.grpStatus.Size =
                new System.Drawing.Size(200, 100);

            this.grpStatus.TabIndex = 14;

            this.grpStatus.TabStop = false;

            this.grpStatus.Text =
                "Status da Execução";

            // ============================================================
            // btnCancelar
            // ============================================================

            this.btnCancelar.Location =
                new System.Drawing.Point(6, 50);

            this.btnCancelar.Name =
                "btnCancelar";

            this.btnCancelar.Size =
                new System.Drawing.Size(100, 30);

            this.btnCancelar.TabIndex = 15;

            this.btnCancelar.Text =
                "Cancelar";

            this.btnCancelar.UseVisualStyleBackColor =
                true;

            this.btnCancelar.Visible =
                false;

            // ============================================================
            // Form1
            // ============================================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(990, 470);

            this.Controls.Add(
                this.grpStatus);

            this.Controls.Add(
                this.grpResultados);

            this.Controls.Add(
                this.btnLimparTeste);

            this.Controls.Add(
                this.btnSalvarResultados);

            this.Controls.Add(
                this.lblNomeTeste);

            this.Controls.Add(
                this.txtNomeTeste);

            this.Controls.Add(
                this.grpTamanho);

            this.Controls.Add(
                this.grpParametros);

            this.Controls.Add(
                this.btnShellSort);

            this.Controls.Add(
                this.btnSelectionSort);

            this.Controls.Add(
                this.btnInsertionSort);

            this.Controls.Add(
                this.btnBubbleSort);

            this.Controls.Add(
                this.lblArquivoSelecionado);

            this.Controls.Add(
                this.btnSelecionarArquivo);

            this.Name =
                "Form1";

            this.Text =
                "Sistema de Ordenação - " +
                "Bubble Sort vs Insertion Sort";

            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();

            this.grpParametros.ResumeLayout(false);
            this.grpParametros.PerformLayout();

            this.grpTamanho.ResumeLayout(false);
            this.grpTamanho.PerformLayout();

            this.grpResultados.ResumeLayout(false);
            this.grpResultados.PerformLayout();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // ============================================================
        // CONTROLES
        // ============================================================

        private System.Windows.Forms.Button
            btnSelecionarArquivo;

        private System.Windows.Forms.Label
            lblArquivoSelecionado;

        private System.Windows.Forms.Button
            btnBubbleSort;

        private System.Windows.Forms.Button
            btnInsertionSort;

        private System.Windows.Forms.Button
            btnSelectionSort;

        private System.Windows.Forms.Button
            btnShellSort;

        private System.Windows.Forms.Button
            btnLimparTeste;

        private System.Windows.Forms.TextBox
            txtResultados;

        private System.Windows.Forms.OpenFileDialog
            openFileDialog1;

        private System.Windows.Forms.GroupBox
            grpParametros;

        private System.Windows.Forms.RadioButton
            rbOrdenados;

        private System.Windows.Forms.RadioButton
            rbInvertidos;

        private System.Windows.Forms.RadioButton
            rbRandomicos;

        private System.Windows.Forms.GroupBox
            grpTamanho;

        private System.Windows.Forms.RadioButton
            rb700k;

        private System.Windows.Forms.RadioButton
            rb750k;

        private System.Windows.Forms.RadioButton
            rb800k;

        private System.Windows.Forms.RadioButton
            rb850k;

        private System.Windows.Forms.RadioButton
            rb900k;

        private System.Windows.Forms.RadioButton
            rb1M;

        private System.Windows.Forms.TextBox
            txtNomeTeste;

        private System.Windows.Forms.Label
            lblNomeTeste;

        private System.Windows.Forms.Button
            btnSalvarResultados;

        private System.Windows.Forms.GroupBox
            grpResultados;

        private System.Windows.Forms.GroupBox
            grpStatus;

        private System.Windows.Forms.Label
            lblStatusGeracao;

        private System.Windows.Forms.Button
            btnCancelar;
    }
}