using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dating_agency
{
    public partial class ArchiveForm : Form
    {
        public ArchiveForm(List<Client> dataClients)
        {
            InitializeComponent();

            dgvArchive.DataSource = dataClients.Where(c => c.IsArchived).ToList();
            dgvArchive.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
