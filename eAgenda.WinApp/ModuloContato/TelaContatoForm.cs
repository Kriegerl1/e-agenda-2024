namespace eAgenda.WinApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        ListagemContatoControl contatoControl;

        private Contato contato;
        public Contato Contato
        {
            set
            {

                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
                txtTelefone.Text = value.Telefone;
                txtEmail.Text = value.Email;
                txtCargo.Text = value.Cargo;
                txtEmpresa.Text = value.Empresa;

            }
            get { return contato; }
        }

        public TelaContatoForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string telefone = txtTelefone.Text;
            string cargo = txtCargo.Text;
            string empresa = txtEmpresa.Text;

            contato = new Contato(nome, telefone, email, empresa, cargo);
        }
    }
}
