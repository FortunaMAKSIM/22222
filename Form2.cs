using Microsoft.EntityFrameworkCore;
using Second.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Second
{
    public partial class Form2 : Form
    {
        private readonly MyDbContext _dbContext;
        private int? _DataNum;
        public Form2(MyDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }
        public void LoadNewData(MainData data)
        {
            NameTb.Text = data.Name;
            DescTb.Text = data.Desc;


            PriceNum.Maximum = 100000;
            PriceNum.Minimum = 0;

            decimal execCostValue = (decimal)data.Price.GetValueOrDefault(100);
            PriceNum.Value = execCostValue < PriceNum.Minimum ? PriceNum.Minimum :
                             execCostValue > PriceNum.Maximum ? PriceNum.Maximum :
                             execCostValue;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                MainData data = new MainData
                {
                    Name = NameTb.Text,
                    Desc = DescTb.Text,
                    Price = (int)PriceNum.Value
                };

                _dbContext.Add(data);
                
                _dbContext.SaveChanges();

                MessageBox.Show("Заявка сохранена! Номер заявки: " + data.Id, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.InnerException?.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неизвестная ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
