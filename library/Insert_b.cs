using BookLibrary;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using System;
using System.Collections.Generic;
using System.Drawing;
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
                checkBox1.Text = "available";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Yearlist.SelectedItem != null && !string.IsNullOrEmpty(name.Text) && !string.IsNullOrEmpty(author.Text) && !string.IsNullOrEmpty(category.Text))
            {
                if (int.TryParse(name.Text, out _) || int.TryParse(author.Text, out _) || int.TryParse(category.Text, out _))
                {
                    MessageBox.Show("Please enter valid (not numbered) credentials.");
                    return;
                }

                int r;
                int selectedYear = (int)Yearlist.SelectedItem;
                if (mainForm.currentBookISBN != null)
                    r = (int)mainForm.currentBookISBN;
                else
                {
                    r = new Random().Next(1, 15000);
                    while (Dbcode.Newr(r)) r = new Random().Next(1, 15000);
                }

                Book n = new Book(r, name.Text, author.Text, selectedYear, category.Text, checkBox1.Checked);

                Dbcode.UpdateBook(n);

                // Hide the form instead of closing it
                this.Hide();


            }
            else
            {
                MessageBox.Show(Yearlist.SelectedItem == null ? "Please fill all the fields." : "Please select a book name.");
            }
        }


    }
}
