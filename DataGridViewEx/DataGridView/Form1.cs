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
            comboRowType.Text = "Numbers";
        }

        private void updateContent()
        {
            for (int i = 0; i < dataGridView1.RowCount; ++i)
                for (int j = 0; j < dataGridView1.ColumnCount; ++j)
                    if (comboRowType.Text == "Numbers")
                        dataGridView1.Rows[i].Cells[j].Value = i * dataGridView1.RowCount + j;
                    else if (comboRowType.Text == "Letters")
                        dataGridView1.Rows[i].Cells[j].Value = "ABCDEFG"[j % 7];
                    else if (comboRowType.Text == "Special symbols")
                        dataGridView1.Rows[i].Cells[j].Value = "!@#$%^&"[j % 7];
                    else
                        dataGridView1.Rows[i].Cells[j].Value = "FAIL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.ColumnCount > 0)
            {
                dataGridView1.Rows.Add(new DataGridViewRow());
                updateContent();
            }
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

        private void itemToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            updateContent();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            dataGridView1.Rows.Add(new DataGridViewRow());
            updateContent();
        }
    }
}
