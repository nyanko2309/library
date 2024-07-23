
using System.Windows.Forms;
using System.Xml.Linq;

namespace library
{
    partial class main
    {
        
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button sort;
            view = new Button();
            insert = new Button();
            Main_page = new Button();
            panel1 = new Panel();
            sort = new Button();
            SuspendLayout();
            // 
            // sort
            // 
            sort.BackgroundImageLayout = ImageLayout.Zoom;
            sort.FlatAppearance.BorderSize = 0;
            sort.FlatStyle = FlatStyle.Flat;
            sort.Font = new Font("Alef", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sort.Location = new Point(12, 134);
            sort.Name = "sort";
            sort.Size = new Size(139, 55);
            sort.TabIndex = 3;
            sort.Text = "sort";
            sort.UseVisualStyleBackColor = true;
            sort.Click += sort_Click;
            // 
            // view
            // 
            view.BackgroundImageLayout = ImageLayout.Zoom;
            view.FlatAppearance.BorderSize = 0;
            view.FlatStyle = FlatStyle.Flat;
            view.Font = new Font("Alef", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            view.Location = new Point(12, 267);
            view.Name = "view";
            view.Size = new Size(139, 55);
            view.TabIndex = 2;
            view.Text = "view books";
            view.UseVisualStyleBackColor = true;
            view.Click += view_Click;
            // 
            // insert
            // 
            insert.BackgroundImageLayout = ImageLayout.Zoom;
            insert.FlatAppearance.BorderSize = 0;
            insert.FlatStyle = FlatStyle.Flat;
            insert.Font = new Font("Alef", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insert.Location = new Point(12, 206);
            insert.Name = "insert";
            insert.Size = new Size(139, 55);
            insert.TabIndex = 4;
            insert.Text = "insert book";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // Main_page
            // 
            Main_page.BackgroundImageLayout = ImageLayout.Zoom;
            Main_page.FlatAppearance.BorderSize = 0;
            Main_page.FlatStyle = FlatStyle.Flat;
            Main_page.Font = new Font("Alef", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Main_page.Location = new Point(12, 73);
            Main_page.Name = "Main_page";
            Main_page.Size = new Size(139, 55);
            Main_page.TabIndex = 5;
            Main_page.Text = "main";
            Main_page.UseVisualStyleBackColor = true;
            Main_page.Click += Main_page_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(171, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 398);
            panel1.TabIndex = 7;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(Main_page);
            Controls.Add(insert);
            Controls.Add(sort);
            Controls.Add(view);
            Name = "main";
            Text = "Register";
            ResumeLayout(false);
        }

        #endregion
        private Button view;
        private Button sort;
        private Button insert;
        private Button Main_page;
        private Panel panel1;
    }
}