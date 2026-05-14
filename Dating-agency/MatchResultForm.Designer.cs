namespace Dating_agency
{
    partial class MatchResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvMatches = new DataGridView();
            btnSendInvite = new Button();
            txtInviteMessage = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMatches).BeginInit();
            SuspendLayout();
            // 
            // dgvMatches
            // 
            dgvMatches.BackgroundColor = SystemColors.Window;
            dgvMatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatches.Location = new Point(12, 12);
            dgvMatches.Name = "dgvMatches";
            dgvMatches.Size = new Size(467, 150);
            dgvMatches.TabIndex = 0;
            // 
            // btnSendInvite
            // 
            btnSendInvite.Location = new Point(12, 293);
            btnSendInvite.Name = "btnSendInvite";
            btnSendInvite.Size = new Size(168, 23);
            btnSendInvite.TabIndex = 0;
            btnSendInvite.Text = "Сформувати запрошення";
            btnSendInvite.Click += this.btnSendInvite_Click;
            // 
            // txtInviteMessage
            // 
            txtInviteMessage.Location = new Point(12, 190);
            txtInviteMessage.Multiline = true;
            txtInviteMessage.Name = "txtInviteMessage";
            txtInviteMessage.Size = new Size(286, 97);
            txtInviteMessage.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 172);
            label1.Name = "label1";
            label1.Size = new Size(187, 15);
            label1.TabIndex = 2;
            label1.Text = "Ваше персональне запрошення:";
            // 
            // MatchResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtInviteMessage);
            Controls.Add(btnSendInvite);
            Controls.Add(dgvMatches);
            Name = "MatchResultForm";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvMatches).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMatches;
        private Button btnSendInvite;
        private TextBox txtInviteMessage;
        private Label label1;
    }
}