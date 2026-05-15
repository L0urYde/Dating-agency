namespace Dating_agency
{
    partial class ArchiveForm
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
            dgvArchive = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArchive).BeginInit();
            SuspendLayout();
            // 
            // dgvArchive
            // 
            dgvArchive.BackgroundColor = SystemColors.Window;
            dgvArchive.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArchive.Location = new Point(12, 12);
            dgvArchive.Name = "dgvArchive";
            dgvArchive.Size = new Size(462, 173);
            dgvArchive.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(141, 415);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 1;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += this.btnBack_Click;
            // 
            // ArchiveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(dgvArchive);
            Name = "ArchiveForm";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvArchive).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvArchive;
        private Button btnBack;
    }
}