namespace TestCrudApp
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
            dgvResults = new DataGridView();
            txtName = new TextBox();
            lblSynergiesDb = new Label();
            label1 = new Label();
            label2 = new Label();
            txtAge = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // dgvResults
            // 
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(12, 197);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersWidth = 51;
            dgvResults.Size = new Size(597, 241);
            dgvResults.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(112, 63);
            txtName.Name = "txtName";
            txtName.Size = new Size(194, 27);
            txtName.TabIndex = 1;
            // 
            // lblSynergiesDb
            // 
            lblSynergiesDb.AutoSize = true;
            lblSynergiesDb.Location = new Point(12, 9);
            lblSynergiesDb.Name = "lblSynergiesDb";
            lblSynergiesDb.Size = new Size(96, 20);
            lblSynergiesDb.TabIndex = 2;
            lblSynergiesDb.Text = "Synergies DB";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 5;
            label2.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(112, 96);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(194, 27);
            txtAge.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 132);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(112, 129);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(194, 27);
            txtPhone.TabIndex = 6;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 162);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(112, 162);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(212, 162);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(390, 163);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(219, 27);
            txtSearch.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(331, 166);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 12;
            label4.Text = "Search";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 450);
            Controls.Add(label4);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(txtAge);
            Controls.Add(label1);
            Controls.Add(lblSynergiesDb);
            Controls.Add(txtName);
            Controls.Add(dgvResults);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvResults;
        private TextBox txtName;
        private Label lblSynergiesDb;
        private Label label1;
        private Label label2;
        private TextBox txtAge;
        private Label label3;
        private TextBox txtPhone;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtSearch;
        private Label label4;
    }
}
