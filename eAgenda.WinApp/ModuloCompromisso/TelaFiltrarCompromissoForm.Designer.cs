namespace eAgenda.WinApp.ModuloCompromisso
{
    partial class TelaFiltrarCompromissoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancelar = new Button();
            btnGravar = new Button();
            groupBox1 = new GroupBox();
            rdbCompromissosPorPeriodo = new RadioButton();
            rdbCompromissosPassados = new RadioButton();
            rdbCompromissosFuturos = new RadioButton();
            rdbTodosOsCompromissos = new RadioButton();
            dtInicio = new DateTimePicker();
            lblInicio = new Label();
            dtTermino = new DateTimePicker();
            lblTermino = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(301, 251);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 51);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(211, 251);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 51);
            btnGravar.TabIndex = 10;
            btnGravar.Text = "Filtrar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbCompromissosPorPeriodo);
            groupBox1.Controls.Add(rdbCompromissosPassados);
            groupBox1.Controls.Add(rdbCompromissosFuturos);
            groupBox1.Controls.Add(rdbTodosOsCompromissos);
            groupBox1.Location = new Point(16, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 128);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtro de Compromissos";
            // 
            // rdbCompromissosPorPeriodo
            // 
            rdbCompromissosPorPeriodo.AutoSize = true;
            rdbCompromissosPorPeriodo.Location = new Point(19, 94);
            rdbCompromissosPorPeriodo.Name = "rdbCompromissosPorPeriodo";
            rdbCompromissosPorPeriodo.Size = new Size(170, 19);
            rdbCompromissosPorPeriodo.TabIndex = 0;
            rdbCompromissosPorPeriodo.TabStop = true;
            rdbCompromissosPorPeriodo.Text = "Compromissos por período";
            rdbCompromissosPorPeriodo.UseVisualStyleBackColor = true;
            rdbCompromissosPorPeriodo.CheckedChanged += rdbCompromissosPorPeriodo_CheckedChanged;
            // 
            // rdbCompromissosPassados
            // 
            rdbCompromissosPassados.AutoSize = true;
            rdbCompromissosPassados.Location = new Point(19, 69);
            rdbCompromissosPassados.Name = "rdbCompromissosPassados";
            rdbCompromissosPassados.Size = new Size(156, 19);
            rdbCompromissosPassados.TabIndex = 0;
            rdbCompromissosPassados.TabStop = true;
            rdbCompromissosPassados.Text = "Compromissos Passados";
            rdbCompromissosPassados.UseVisualStyleBackColor = true;
            // 
            // rdbCompromissosFuturos
            // 
            rdbCompromissosFuturos.AutoSize = true;
            rdbCompromissosFuturos.Location = new Point(19, 44);
            rdbCompromissosFuturos.Name = "rdbCompromissosFuturos";
            rdbCompromissosFuturos.Size = new Size(148, 19);
            rdbCompromissosFuturos.TabIndex = 0;
            rdbCompromissosFuturos.TabStop = true;
            rdbCompromissosFuturos.Text = "Compromissos Futuros";
            rdbCompromissosFuturos.UseVisualStyleBackColor = true;
            // 
            // rdbTodosOsCompromissos
            // 
            rdbTodosOsCompromissos.AutoSize = true;
            rdbTodosOsCompromissos.Location = new Point(19, 19);
            rdbTodosOsCompromissos.Name = "rdbTodosOsCompromissos";
            rdbTodosOsCompromissos.Size = new Size(152, 19);
            rdbTodosOsCompromissos.TabIndex = 0;
            rdbTodosOsCompromissos.TabStop = true;
            rdbTodosOsCompromissos.Text = "Todos os compromissos";
            rdbTodosOsCompromissos.UseVisualStyleBackColor = true;
            // 
            // dtInicio
            // 
            dtInicio.Enabled = false;
            dtInicio.Format = DateTimePickerFormat.Short;
            dtInicio.Location = new Point(64, 181);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(100, 23);
            dtInicio.TabIndex = 12;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Enabled = false;
            lblInicio.Location = new Point(77, 163);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(75, 15);
            lblInicio.TabIndex = 13;
            lblInicio.Text = "Perído Inicial";
            // 
            // dtTermino
            // 
            dtTermino.Enabled = false;
            dtTermino.Format = DateTimePickerFormat.Short;
            dtTermino.Location = new Point(211, 181);
            dtTermino.Name = "dtTermino";
            dtTermino.Size = new Size(100, 23);
            dtTermino.TabIndex = 12;
            // 
            // lblTermino
            // 
            lblTermino.AutoSize = true;
            lblTermino.Enabled = false;
            lblTermino.Location = new Point(224, 163);
            lblTermino.Name = "lblTermino";
            lblTermino.Size = new Size(69, 15);
            lblTermino.TabIndex = 13;
            lblTermino.Text = "Perído Final";
            // 
            // TelaFiltrarCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 314);
            Controls.Add(lblTermino);
            Controls.Add(dtTermino);
            Controls.Add(lblInicio);
            Controls.Add(dtInicio);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "TelaFiltrarCompromissoForm";
            Text = "TelaFiltrarCompromissoForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private GroupBox groupBox1;
        private RadioButton rdbTodosOsCompromissos;
        private RadioButton rdbCompromissosPassados;
        private RadioButton rdbCompromissosFuturos;
        private RadioButton rdbCompromissosPorPeriodo;
        private DateTimePicker dtInicio;
        private Label lblInicio;
        private DateTimePicker dtTermino;
        private Label lblTermino;
    }
}