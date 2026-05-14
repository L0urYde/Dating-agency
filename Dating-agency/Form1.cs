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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (myProfile == null)
            {
                MessageBox.Show("Ви ще не створили заявку, яку можна видалити!");
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Ви впевнені, що хочете видалити анкету користувача {myProfile.Name}?",
                "Підтвердження видалення",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                database.Remove(myProfile);
                myProfile = null;

                UpdateUI();

                MessageBox.Show("Вашу заявку успішно видалено з бази бюро.");
            }
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow == null)
            {
                return;
            }

            Client selectedUser = (Client)dgvClients.CurrentRow.DataBoundItem;

            var matches = database.Where(c =>
        c != selectedUser &&
        c.Gender != selectedUser.Gender &&
        !c.IsArchived &&
        (c.AboutMe.ToLower().Contains(selectedUser.Requirements.ToLower()) ||
         selectedUser.AboutMe.ToLower().Contains(c.Requirements.ToLower()))
    ).ToList();

            if (matches.Count > 0)
            {
                MatchResultForm resultForm = new MatchResultForm(matches, selectedUser);
                resultForm.ShowDialog();

                UpdateUI();
            }
            else
            {
                MessageBox.Show($"На жаль, підходящих кандидатур для клієнта {selectedUser.Name} поки що не знайдено");
            }
        }
    }
}