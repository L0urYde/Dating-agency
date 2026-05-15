using System.Text.RegularExpressions;

namespace Dating_agency
{
    public partial class Form1 : Form
    {
        List<Client> database = new List<Client>();
        Client myProfile = null;

        public Form1()
        {
            InitializeComponent();
            SeedData();
            UpdateUI();
        }

        private void SeedData()
        {
            database.Add(new Client("Артем", 25, "Чоловік", "Люблю каву", "Спорт"));
            database.Add(new Client("Ірина", 22, "Жінка", "Займаюсь спортом з дитинства", "Кіно"));
            database.Add(new Client("Ольга", 24, "Жінка", "Ранковий спорт — це моє життя", "Музика"));
            database.Add(new Client("Анна", 23, "Жінка", "Професійний спорт та йога", "Подорожі"));
            database.Add(new Client("Богдан", 29, "Чоловік", "Шукаю серйозні стосунки", "Квантова фізика"));
            database.Add(new Client("Ігор", 27, "Чоловік", "Танці — моє хобі", "Дизайн"));
            database.Add(new Client("Катерина", 25, "Жінка", "Працюю лікарем", "Танці"));
            database.Add(new Client("Віталій", 31, "Чоловік", "Поціновувач авто", "Фото"));
            database.Add(new Client("Оксана", 28, "Жінка", "Люблю подорожі", "Бізнес"));
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
                MessageBox.Show("Будь ласка, введіть ім'я та оберіть стать.");
                return;
            }

            if (numAge.Value < 18)
            {
                MessageBox.Show("Реєстрація доступна тільки для осіб старше 18 років!");
                return;
            }

            if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Zа-яА-ЯіїєґІЇЄҐ\s-]+$"))
            {
                MessageBox.Show("Ім'я може містити тільки літери!");
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
            if (dgvClients.CurrentRow == null)
            {
                MessageBox.Show("Будь ласка, оберіть клієнта у списку, якого ви хочете видалити.");
                return;
            }

            Client selectedForDelete = (Client)dgvClients.CurrentRow.DataBoundItem;

            var confirmResult = MessageBox.Show(
                $"Ви впевнені, що хочете видалити анкету клієнта {selectedForDelete.Name} (ID: {selectedForDelete.RegNumber})?",
                "Підтвердження видалення",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                database.Remove(selectedForDelete);

                if (myProfile == selectedForDelete)
                {
                    myProfile = null;
                }

                UpdateUI();

                MessageBox.Show($"Клієнта {selectedForDelete.Name} успішно видалено.");
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
                MessageBox.Show($"На жаль, підходящих кандидатур для клієнта {selectedUser.Name} поки що не знайдено.");
            }
        }

        private void btnOpenArchive_Click(object sender, EventArgs e)
        {
            ArchiveForm archiveWindow = new ArchiveForm(database);
            archiveWindow.ShowDialog();
        }
    }
}