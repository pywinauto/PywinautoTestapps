using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public class Item
        {
            public string Code { get; set; }
            public string Description { get; set; }
        }
        public ObservableCollection<Item> Items = new ObservableCollection<Item>();
        public Form1()
        {
            InitializeComponent();
        }

        private void updateContent()
        {
            for (int i = 0; i < dataGridView1.RowCount; ++i)
                for (int j = 0; j < dataGridView1.ColumnCount; ++j)
                    dataGridView1.Rows[i].Cells[j].Value = i * dataGridView1.RowCount + j;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(new DataGridViewRow());
            updateContent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            updateContent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = !dataGridView1.RowHeadersVisible;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersVisible = !dataGridView1.ColumnHeadersVisible;
        }
    }
}
