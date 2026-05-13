namespace Dating_agency
{
    public partial class Form1 : Form
    {
        List<Client> database = new List<Client>();
        Client myProfile = null;

        public Form1()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void UpdateUI()
        {
            dgvClients.DataSource = null;
            dgvClients.DataSource = database.Where(c => !c.IsArchived).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || cmbGender.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, введіть ім'я та оберіть стать!");
                return;
            }

            myProfile = new Client(
                txtName.Text,
                (int)numAge.Value,
                cmbGender.SelectedItem.ToString(),
                txtAboutMe.Text,
                txtRequirements.Text
            );

            database.Add(myProfile);
            UpdateUI();

            txtName.Clear();
            numAge.Value = 18;
            txtAboutMe.Clear();
            txtRequirements.Clear();
            cmbGender.SelectedIndex = -1;
        }
    }
}