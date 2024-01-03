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
            btnCreate = new Button();
            label5 = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvResults.Location = new Point(12, 262);
            dgvResults.MultiSelect = false;
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersWidth = 51;
            dgvResults.Size = new Size(597, 241);
            dgvResults.TabIndex = 0;
            dgvResults.CellClick += dgvResults_CellClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(112, 78);
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
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 114);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 5;
            label2.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(112, 111);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(194, 27);
            txtAge.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 147);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(112, 144);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(194, 27);
            txtPhone.TabIndex = 6;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 177);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(212, 177);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(312, 177);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(390, 228);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(219, 27);
            txtSearch.TabIndex = 11;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(331, 231);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 12;
            label4.Text = "Search";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(112, 177);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 13;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 48);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 15;
            label5.Text = "ID";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(112, 45);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(194, 27);
            txtId.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 515);
            Controls.Add(label5);
            Controls.Add(txtId);
            Controls.Add(btnCreate);
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
        private Button btnCreate;
        private Label label5;
        private TextBox txtId;
    }
}
