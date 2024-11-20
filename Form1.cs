using Second.Data;

namespace Second
{
    public partial class Form1 : Form
    {
        private readonly MyDbContext _dbContext;
        public Form1(MyDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            LoadData();
        }

        private void LoadData()
        {
            var data = _dbContext.Data.ToList();
            dataGridView1.DataSource = data;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (var addForm = new Form2(_dbContext))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            var sortedData = _dbContext.Data.OrderBy(d => d.Name).ToList();
            dataGridView1.DataSource = sortedData;
        }

        private void Sort2Btn_Click(object sender, EventArgs e)
        {
            var sortedData = _dbContext.Data.OrderBy(d => d.Price).ToList();
            dataGridView1.DataSource = sortedData;
        }

        private void Sort3Btn_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
