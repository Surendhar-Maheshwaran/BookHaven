using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;

namespace BookHaven
{
    public partial class MainDashboard : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        static string connectionString = "Data Source=SURENS;Initial Catalog=BookHaven;Integrated Security=True;Encrypt=False";
        SqlConnection connection = new SqlConnection(connectionString);
        String query = "";

        public MainDashboard()
        {
            InitializeComponent();
            LoadCustomers();

            // Apply Material Design Theme
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;  // Use .DARK for dark mode

            // Customize color scheme
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.DeepOrange900, Accent.DeepOrange400,
                TextShade.WHITE
            );
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();


        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }


        // Customer Tab Code
        private void clearBtn_Click(object sender, EventArgs e)
        {
            reset();
        }



        private void reset()
        {
            txtCustomerName.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtPhoneNo.Clear();
        }

        private void txtAddCustomer_Click(object sender, EventArgs e)
        {
            query = "INSERT INTO Customers (name, email,phone, address) VALUES" +
                "(@Name, @email, @phone, @address)";
            SqlCommand cmd = new SqlCommand(query,connection);
            cmd.Parameters.AddWithValue("@Name", txtCustomerName.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhoneNo.Text);
            cmd.Parameters.AddWithValue("@address",txtAddress.Text);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();   
            }  catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                LoadCustomers();
                reset();
            }


        }

        private void LoadCustomers()
        {
            query = "SELECT CustomerID, Name FROM customers";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            customerListView.Items.Clear();

            while (reader.Read())
            {
                
                ListViewItem item = new ListViewItem(reader["customerID"].ToString());
                item.SubItems.Add(reader["Name"].ToString());
                customerListView.Items.Add(item);
            }
            reader.Close();
            connection.Close();
        }


    }
}
