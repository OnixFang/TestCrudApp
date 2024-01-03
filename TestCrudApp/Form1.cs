using TestCrudApp.BLL;

namespace TestCrudApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            txtId.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtPhone.Clear();
            txtSearch.Clear();
        }

        private void RenderResults()
        {
            dgvResults.DataSource = SynergiesLogic.GetEmployees();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RenderResults();
        }

        private void dgvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }

            int row = e.RowIndex;

            txtId.Text = dgvResults[0, row].Value.ToString();
            txtName.Text = dgvResults[1, row].Value.ToString();
            txtAge.Text = dgvResults[2, row].Value.ToString();
            txtPhone.Text = dgvResults[3, row].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SynergiesLogic.AddEmployee(txtName.Text, int.Parse(txtAge.Text), txtPhone.Text));
            ClearForm();
            RenderResults();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SynergiesLogic.UpdateEmployee(int.Parse(txtId.Text), txtName.Text, int.Parse(txtAge.Text), txtPhone.Text));
            ClearForm();
            RenderResults();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SynergiesLogic.DeleteEmployee(int.Parse(txtId.Text), txtName.Text, int.Parse(txtAge.Text), txtPhone.Text));
            ClearForm();
            RenderResults();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvResults.DataSource = SynergiesLogic.SearchEmployee(txtSearch.Text);
        }
    }
}
