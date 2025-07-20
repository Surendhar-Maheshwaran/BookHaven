using Microsoft.Data.SqlClient;

namespace BookHaven
{
    internal static class Program
    {
        static string connectionString = "Data Source=SURENS;Initial Catalog=BookHaven;Integrated Security=True;Encrypt=False";

        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            if (!IsUserExists())
            {
                Application.Run(new MainDashboard());
            }

        }

        static bool IsUserExists()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT COUNT(*) FROM Users";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int count = (int)command.ExecuteScalar();
            return count > 0;
        }
    }
}