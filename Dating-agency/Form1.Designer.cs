namespace Dating_agency
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvClients = new DataGridView();
            label2 = new Label();
            cmbGender = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtAboutMe = new TextBox();
            txtRequirements = new TextBox();
            btnAdd = new Button();
            btnMatch = new Button();
            btnArchive = new Button();
            btnDelete = new Button();
            txtName = new TextBox();
            numAge = new NumericUpDown();
            label1 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            SuspendLayout();
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClients.BackgroundColor = SystemColors.Window;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(12, 12);
            dgvClients.MultiSelect = false;
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.RowHeadersVisible = false;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClients.Size = new Size(397, 150);
            dgvClients.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(415, 89);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "Стать";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Чоловік", "Жінка" });
            cmbGender.Location = new Point(506, 86);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(121, 23);
            cmbGender.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(415, 118);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Про себе";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(415, 147);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Вимоги";
            // 
            // txtAboutMe
            // 
            txtAboutMe.Location = new Point(506, 115);
            txtAboutMe.Multiline = true;
            txtAboutMe.Name = "txtAboutMe";
            txtAboutMe.Size = new Size(100, 23);
            txtAboutMe.TabIndex = 7;
            // 
            // txtRequirements
            // 
            txtRequirements.Location = new Point(506, 144);
            txtRequirements.Multiline = true;
            txtRequirements.Name = "txtRequirements";
            txtRequirements.Size = new Size(100, 23);
            txtRequirements.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(58, 389);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 23);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Зареєструватися";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnMatch
            // 
            btnMatch.Location = new Point(194, 389);
            btnMatch.Name = "btnMatch";
            btnMatch.Size = new Size(124, 23);
            btnMatch.TabIndex = 10;
            btnMatch.Text = "Підібрати пару";
            btnMatch.UseVisualStyleBackColor = true;
            btnMatch.Click += btnMatch_Click;
            // 
            // btnArchive
            // 
            btnArchive.Location = new Point(324, 389);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(75, 23);
            btnArchive.TabIndex = 11;
            btnArchive.Text = "В архів";
            btnArchive.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(405, 389);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Видалити клієнта";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(506, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 14;
            // 
            // numAge
            // 
            numAge.Location = new Point(506, 57);
            numAge.Name = "numAge";
            numAge.Size = new Size(120, 23);
            numAge.TabIndex = 15;
            numAge.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(415, 31);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 16;
            label1.Text = "Імя";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(415, 57);
            label5.Name = "label5";
            label5.Size = new Size(23, 15);
            label5.TabIndex = 17;
            label5.Text = "Вік";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(numAge);
            Controls.Add(txtName);
            Controls.Add(btnDelete);
            Controls.Add(btnArchive);
            Controls.Add(btnMatch);
            Controls.Add(btnAdd);
            Controls.Add(txtRequirements);
            Controls.Add(txtAboutMe);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbGender);
            Controls.Add(label2);
            Controls.Add(dgvClients);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClients;
        private Label label2;
        private ComboBox cmbGender;
        private Label label3;
        private Label label4;
        private TextBox txtAboutMe;
        private TextBox txtRequirements;
        private Button btnAdd;
        private Button btnMatch;
        private Button btnArchive;
        private Button btnDelete;
        private TextBox txtName;
        private NumericUpDown numAge;
        private Label label1;
        private Label label5;
    }
}
