using Npgsql;

namespace SmartFarmingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usernamelabel_Click(object sender, EventArgs e)
        {

  

       using Npgsql;

private void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string password = txtPassword.Text;

        string connString = "Host=db.ejkekkoynvhewhmxolqy.supabase.co;Database=postgres;Username=postgres;Password=BURAYA_SIFRE;SSL Mode=Require;Trust Server Certificate=true";

        using (var conn = new NpgsqlConnection(connString))
        {
            conn.Open();

            string query = "SELECT * FROM \"Users\" WHERE username=@u AND password=@p";

            using (var cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("u", username);
                cmd.Parameters.AddWithValue("p", password);

                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Giriş başarılı!");
                }
                else
                {
                    MessageBox.Show("Hatalı giriş");
                }
            }
        }
    }
}
}
