using MaterialSkin;
using MaterialSkin.Controls;

namespace BookHaven
{
    public partial class LoginForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public LoginForm()
        {
            InitializeComponent();

            // Apply Material Design Theme
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;  // Use .DARK for dark mode

            // Customize color scheme
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Console.WriteLine(username + ":" + password);
        }
    }
}
