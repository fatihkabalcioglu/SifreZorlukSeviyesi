namespace SifreZorlukSeviyesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            string pass = txtPass.Text;

            if (pass.Length < 6)
            {
                lblLevel.Text = "Minimum 6 character";
                lblLevel.ForeColor = Color.Red;
            }
            else if (pass.Length >= 6)
            {
                bool specialChar = pass.Any(c => !char.IsLetterOrDigit(c));
                bool digit = pass.Any(char.IsDigit);
                if (specialChar && digit)
                {
                    lblLevel.Text = "High";
                    lblLevel.ForeColor = Color.Green;
                }
                else if (specialChar || digit)
                {
                    lblLevel.Text = "Normal";
                    lblLevel.ForeColor = Color.Yellow;
                }
                else
                {
                    lblLevel.Text = "Low";
                    lblLevel.ForeColor = Color.OrangeRed;
                }
            }
        }
    }
}