using eAgenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoForm : Form
    {
        private Compromisso compromisso;
        public Compromisso Compromisso
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtAssunto.Text = value.Assunto;
                dtData.Value = value.Data;
                dtHoraInicio.Value = value.Data.Date + value.HoraInicio;
                dtHoraTermino.Value = value.Data.Date + value.HoraTermino;

                chkContato.Checked = value.Contato != null;

                cmbContato.Enabled = value.Contato != null;
                cmbContato.SelectedItem = value.Contato;

                if (value.TipoCompromisso == TipoCompromissoEnum.Presencial)
                {
                    txtPresencial.Enabled = true;
                    txtLink.Text = value.Local;
                }
                else
                {
                    txtLink.Enabled = true;
                    txtLink.Text = value.Link;
                }
            }
            get { return compromisso; }
        }
        public TelaCompromissoForm()
        {
            InitializeComponent();
        }
        public void CarregarContatos(List<Contato> contatos)
        {
            cmbContato.Items.Clear();

            foreach (Contato c in contatos)
                cmbContato.Items.Add(c);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string assunto = txtAssunto.Text;
            DateTime data = dtData.Value;
            TimeSpan horaInicio = dtHoraInicio.Value.TimeOfDay;
            TimeSpan horaTermino = dtHoraTermino.Value.TimeOfDay;
            Contato contato = (Contato)cmbContato.SelectedItem;

            string local = txtPresencial.Text;
            string link = txtLink.Text;

            compromisso = new Compromisso(assunto, local, link, data, horaInicio, horaTermino, contato);
        }

        private void chkContato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContato.Checked)
                cmbContato.Enabled = true;
            else
            {
                cmbContato.SelectedItem = null;
                cmbContato.Enabled = false;
            }
        }

        private void rdbPresencial_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPresencial.Checked)
            {
                txtLink.Text = string.Empty;
                txtLink.Enabled = false;
                txtPresencial.Enabled = true;
            }
            else
            {
                txtLink.Enabled = true;
            }

        }

        private void rdbRemoto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRemoto.Checked)
            {
                txtPresencial.Text = string.Empty;
                txtLink.Enabled = true;
                txtPresencial.Enabled = false;
            }
            else
            {
                txtPresencial.Enabled = true;
            }
        }
    }
}

