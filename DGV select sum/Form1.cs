using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DGV_select_sum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Product ID";
            dataGridView1.Columns[1].Name = "Product Name";
            for (int i = 1; i <= 10; i++)
            {
                dataGridView1.Rows.Add(i.ToString(),"abc");
                dataGridView1.Rows.Add(null,"null");

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var dgv = sender as DataGridView;
            lbCount.Text = dgv.SelectedCells.Count.ToString();
            decimal sum = 0;
            decimal temp = 0;
            foreach (DataGridViewCell item in dgv.SelectedCells)
            {
                if (item.Value != null)
                {
                    if (decimal.TryParse(item.Value.ToString(),out temp))
                    {
                        sum += temp;
                    }
                }
            }

            lbSum.Text = sum.ToString();
            //for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
            //{
            //    if (true)
            //    {

            //    }
            //}
        }
    }
}
