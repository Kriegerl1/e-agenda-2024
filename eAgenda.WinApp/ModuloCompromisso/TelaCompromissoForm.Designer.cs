namespace eAgenda.WinApp.ModuloCompromisso
{
    partial class TelaCompromissoForm
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
            lblId = new Label();
            txtId = new TextBox();
            lblAssunto = new Label();
            txtAssunto = new TextBox();
            lblHoraInicio = new Label();
            lblData = new Label();
            lblTermino = new Label();
            dtData = new DateTimePicker();
            dtHoraInicio = new DateTimePicker();
            dtHoraTermino = new DateTimePicker();
            lblContato = new Label();
            cmbContato = new ComboBox();
            rdbPresencial = new RadioButton();
            txtPresencial = new TextBox();
            rdbRemoto = new RadioButton();
            txtLink = new TextBox();
            chkContato = new CheckBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(56, 28);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.Menu;
            txtId.ForeColor = SystemColors.InactiveCaption;
            txtId.Location = new Point(81, 24);
            txtId.Name = "txtId";
            txtId.Size = new Size(33, 23);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // lblAssunto
            // 
            lblAssunto.AutoSize = true;
            lblAssunto.Location = new Point(24, 66);
            lblAssunto.Name = "lblAssunto";
            lblAssunto.Size = new Size(50, 15);
            lblAssunto.TabIndex = 0;
            lblAssunto.Text = "Assunto";
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(80, 62);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(334, 23);
            txtAssunto.TabIndex = 1;
            // 
            // lblHoraInicio
            // 
            lblHoraInicio.AutoSize = true;
            lblHoraInicio.Location = new Point(43, 183);
            lblHoraInicio.Name = "lblHoraInicio";
            lblHoraInicio.Size = new Size(36, 15);
            lblHoraInicio.TabIndex = 0;
            lblHoraInicio.Text = "Início";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(43, 110);
            lblData.Name = "lblData";
            lblData.Size = new Size(31, 15);
            lblData.TabIndex = 0;
            lblData.Text = "Data";
            // 
            // lblTermino
            // 
            lblTermino.AutoSize = true;
            lblTermino.Location = new Point(261, 183);
            lblTermino.Name = "lblTermino";
            lblTermino.Size = new Size(50, 15);
            lblTermino.TabIndex = 0;
            lblTermino.Text = "Término";
            // 
            // dtData
            // 
            dtData.Format = DateTimePickerFormat.Short;
            dtData.Location = new Point(81, 106);
            dtData.Name = "dtData";
            dtData.Size = new Size(97, 23);
            dtData.TabIndex = 2;
            // 
            // dtHoraInicio
            // 
            dtHoraInicio.Format = DateTimePickerFormat.Custom;
            dtHoraInicio.Location = new Point(81, 177);
            dtHoraInicio.Name = "dtHoraInicio";
            dtHoraInicio.Size = new Size(97, 23);
            dtHoraInicio.TabIndex = 2;
            // 
            // dtHoraTermino
            // 
            dtHoraTermino.Format = DateTimePickerFormat.Custom;
            dtHoraTermino.Location = new Point(317, 177);
            dtHoraTermino.Name = "dtHoraTermino";
            dtHoraTermino.Size = new Size(97, 23);
            dtHoraTermino.TabIndex = 2;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Location = new Point(193, 142);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(50, 15);
            lblContato.TabIndex = 3;
            lblContato.Text = "Contato";
            // 
            // cmbContato
            // 
            cmbContato.Enabled = false;
            cmbContato.FormattingEnabled = true;
            cmbContato.Location = new Point(249, 138);
            cmbContato.Name = "cmbContato";
            cmbContato.Size = new Size(165, 23);
            cmbContato.TabIndex = 4;
            // 
            // rdbPresencial
            // 
            rdbPresencial.AutoSize = true;
            rdbPresencial.Location = new Point(43, 225);
            rdbPresencial.Name = "rdbPresencial";
            rdbPresencial.Size = new Size(78, 19);
            rdbPresencial.TabIndex = 5;
            rdbPresencial.TabStop = true;
            rdbPresencial.Text = "Presencial";
            rdbPresencial.UseVisualStyleBackColor = true;
            rdbPresencial.CheckedChanged += rdbPresencial_CheckedChanged;
            // 
            // txtPresencial
            // 
            txtPresencial.Enabled = false;
            txtPresencial.Location = new Point(131, 225);
            txtPresencial.Name = "txtPresencial";
            txtPresencial.Size = new Size(283, 23);
            txtPresencial.TabIndex = 6;
            // 
            // rdbRemoto
            // 
            rdbRemoto.AutoSize = true;
            rdbRemoto.Location = new Point(54, 258);
            rdbRemoto.Name = "rdbRemoto";
            rdbRemoto.Size = new Size(67, 19);
            rdbRemoto.TabIndex = 5;
            rdbRemoto.TabStop = true;
            rdbRemoto.Text = "Remoto";
            rdbRemoto.UseVisualStyleBackColor = true;
            rdbRemoto.CheckedChanged += rdbRemoto_CheckedChanged;
            // 
            // txtLink
            // 
            txtLink.Enabled = false;
            txtLink.Location = new Point(131, 254);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(283, 23);
            txtLink.TabIndex = 6;
            // 
            // chkContato
            // 
            chkContato.AutoSize = true;
            chkContato.Location = new Point(239, 108);
            chkContato.Name = "chkContato";
            chkContato.RightToLeft = RightToLeft.Yes;
            chkContato.Size = new Size(175, 19);
            chkContato.TabIndex = 7;
            chkContato.Text = "?Deseja vincular um contato";
            chkContato.TextAlign = ContentAlignment.BottomCenter;
            chkContato.UseVisualStyleBackColor = true;
            chkContato.CheckedChanged += chkContato_CheckedChanged;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(249, 312);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 51);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(339, 312);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 51);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 375);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(chkContato);
            Controls.Add(txtLink);
            Controls.Add(rdbRemoto);
            Controls.Add(txtPresencial);
            Controls.Add(rdbPresencial);
            Controls.Add(cmbContato);
            Controls.Add(lblContato);
            Controls.Add(dtHoraTermino);
            Controls.Add(dtHoraInicio);
            Controls.Add(dtData);
            Controls.Add(txtAssunto);
            Controls.Add(lblTermino);
            Controls.Add(lblData);
            Controls.Add(lblHoraInicio);
            Controls.Add(lblAssunto);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Name = "TelaCompromissoForm";
            Text = "TelaCompromissoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private Label lblAssunto;
        private TextBox txtAssunto;
        private Label lblHoraInicio;
        private Label lblData;
        private Label lblTermino;
        private DateTimePicker dtData;
        private DateTimePicker dtHoraInicio;
        private DateTimePicker dtHoraTermino;
        private Label lblContato;
        private ComboBox cmbContato;
        private RadioButton rdbPresencial;
        private TextBox txtPresencial;
        private RadioButton rdbRemoto;
        private TextBox txtLink;
        private CheckBox chkContato;
        private Button btnGravar;
        private Button btnCancelar;
    }
}