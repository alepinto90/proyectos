using WinFormsApp2.database;
using WinFormsApp2.models;

namespace WinFormsApp2
{
    public partial class dgvCliente : Form
    {
        public dgvCliente()
        {
            InitializeComponent();
        }

        public static bool AutoGenerateColumns { get; private set; }
        public static List<Cliente> DataSource { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            var db = new DatabaseContext();

            var clientes = db.Clientes
                .OrderBy(b => b.id)
                .ToList();
            dgvCliente.AutoGenerateColumns = true;
            dgvCliente.DataSource = clientes;

        }
    }
}
