using Npgsql;

namespace Roteiro_0009
{
    public partial class Form1 : Form
    {

        private string connString = "Host=localhost;Username=postgres;Password=asd456;Database=pooRoteiro9";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(sobrenome))
            {
                MessageBox.Show("Digite um nome e o Sobrenome");
                return;
            }

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string insertSql = "INSERT INTO pessoa (nome,sobrenome) VALUES(@nome,@sobrenome)";


                using (var cmd = new NpgsqlCommand(insertSql, conn))
                {
                    cmd.Parameters.AddWithValue("nome", nome);
                    cmd.Parameters.AddWithValue("sobrenome", sobrenome);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Nome salvo com sucesso!");
            btnListar_Click(null, null);
            txtNome.Clear();
            txtSobrenome.Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listUsuarios.Items.Clear();
            using (var conn = new
            NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT nome || ' ' || sobrenome AS NomeCompleto FROM pessoa";
                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listUsuarios.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item para excluir.");
                return;
            }

            string nomeCompleto = listUsuarios.SelectedItem.ToString();

            using (var conn = new Npgsql.NpgsqlConnection(connString))
            {
                conn.Open();

                string sql = "DELETE FROM pessoa WHERE nome || ' ' || sobrenome = @nomeCompleto";

                using (var cmd = new Npgsql.NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("nomeCompleto", nomeCompleto);
                    cmd.ExecuteNonQuery();
                }

                btnListar_Click(null, null);
                MessageBox.Show("Usuario excluido com sucesso!");
            }
       
        }
    }
}
