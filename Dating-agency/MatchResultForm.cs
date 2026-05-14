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
    }
}
