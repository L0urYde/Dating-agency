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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbGender.SelectedItem == null) return;

            myProfile = new Client(
                cmbGender.SelectedItem.ToString(),
                txtAboutMe.Text,
                txtRequirements.Text
            );

            database.Add(myProfile);
            UpdateUI();
        }

        private void UpdateUI()
        {
            dgvClients.DataSource = null;
            dgvClients.DataSource = database.Where(c => !c.IsArchived).ToList();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (cmbGender.SelectedItem == null)
            {
                MessageBox.Show("Оберіть стать!");
                return;
            }

            myProfile = new Client(
                cmbGender.SelectedItem.ToString(),
                txtAboutMe.Text,
                txtRequirements.Text
            );

            database.Add(myProfile);

            UpdateUI();

            txtAboutMe.Clear();
            txtRequirements.Clear();
            cmbGender.SelectedIndex = -1;
        }
    }
}