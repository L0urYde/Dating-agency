using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dating_agency
{
    public partial class MatchResultForm : Form
    {
        List<Client> _matches;
        Client _currentUser;

        public MatchResultForm(List<Client> matches, Client currentUser)
        {
            InitializeComponent();
            _matches = matches;
            _currentUser = currentUser;
            dgvMatches.DataSource = _matches;
        }

        private void btnSendInvite_Click(object sender, EventArgs e)
        {
            if (dgvMatches.CurrentRow == null)
            {
                MessageBox.Show("Оберіть кандидатуру зі списку!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtInviteMessage.Text))
            {
                MessageBox.Show("Будь ласка, напишіть хоча б кілька слів для знайомства.");
                return;
            }

            var selectedPartner = (Client)dgvMatches.CurrentRow.DataBoundItem;

            string finalLetter = $"--- ОФІЦІЙНЕ ЗАПРОШЕННЯ ВІД БЮРО ---\n\n" +
                                 $"Відправник: {_currentUser.Name} (ID: {_currentUser.RegNumber})\n" +
                                 $"Отримувач: {selectedPartner.Name}\n" +
                                 $"----------------------------------\n" +
                                 $"Текст повідомлення:\n\"{txtInviteMessage.Text}\"\n" +
                                 $"----------------------------------\n" +
                                 $"Дата формування: {DateTime.Now:f}";

            MessageBox.Show(finalLetter, "Запрошення успішно сформовано!");

            _currentUser.IsArchived = true;
            selectedPartner.IsArchived = true;

            this.Close();
        }
    }
}
