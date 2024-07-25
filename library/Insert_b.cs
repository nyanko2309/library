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
        private main mainForm;
        public Insert_b(main form)
        {
            InitializeComponent();
            mainForm = form;
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
                int r;
                int selectedYear = (int)Yearlist.SelectedItem;
                if (mainForm.currentBookISBN!= null)
                    r =int.Parse(mainForm.currentBookISBN);
                else
                 r = new Random().Next(1, 15000);
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
