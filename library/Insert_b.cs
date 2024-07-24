using BookLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class Insert_b : Form
    {
        public Insert_b()
        {
            InitializeComponent();
            for (int year = 1900; year <= 2023; year++)
            {
                Yearlist.Items.Add(year);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                checkBox1.Text = "taken";
            else
                checkBox1.Text = "avilable";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Yearlist.SelectedItem != null)
            {
                int selectedYear = (int)Yearlist.SelectedItem;
                int r = new Random().Next(1, 15000);
                Book n = new Book(r.ToString(), name.Text, author.Text, selectedYear, category.Text, checkBox1.Checked);

                Dbcode.UpdateBook(n);
                MessageBox.Show(name.Text + author.Text + selectedYear + category.Text + checkBox1.Checked);

            }



            else
            {
                MessageBox.Show("Please select a year.");
            }
        }

        private void category_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
