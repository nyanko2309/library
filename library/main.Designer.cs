
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
            
            view = new Button();
            insert = new Button();
            panel1 = new Panel();
            sort = new Button();
            SuspendLayout();
            // 
            // sort
            // 
            sort.BackColor = SystemColors.WindowText;
            sort.BackgroundImage = Properties.Resources.dark_wood_background_1920_x_1080_wdj1vph19bm5vqaj;
            sort.BackgroundImageLayout = ImageLayout.Zoom;
            sort.FlatAppearance.BorderSize = 0;
            sort.FlatStyle = FlatStyle.Popup;
            sort.Font = new Font("Calibri", 20F, FontStyle.Italic);
            sort.ForeColor = Color.Wheat;
            sort.Location = new Point(12, 247);
            sort.Name = "sort";
            sort.Size = new Size(122, 55);
            sort.TabIndex = 3;
            sort.Text = "sort";
            sort.UseVisualStyleBackColor = false;
            sort.Visible = false;
            sort.Click += sort_Click;
            // 
            // view
            // 
            view.BackColor = SystemColors.WindowText;
            view.BackgroundImage = Properties.Resources.dark_wood_background_1920_x_1080_wdj1vph19bm5vqaj;
            view.BackgroundImageLayout = ImageLayout.Zoom;
            view.FlatAppearance.BorderSize = 0;
            view.FlatStyle = FlatStyle.Popup;
            view.Font = new Font("Calibri", 20F, FontStyle.Italic, GraphicsUnit.Point, 0);
            view.ForeColor = Color.Wheat;
            view.Location = new Point(12, 67);
            view.Name = "view";
            view.Size = new Size(122, 55);
            view.TabIndex = 2;
            view.Text = "view ";
            view.UseVisualStyleBackColor = false;
            view.Click += view_Click;
            // 
            // insert
            // 
            insert.BackColor = SystemColors.WindowText;
            insert.BackgroundImage = Properties.Resources.dark_wood_background_1920_x_1080_wdj1vph19bm5vqaj;
            insert.BackgroundImageLayout = ImageLayout.Zoom;
            insert.FlatAppearance.BorderSize = 0;
            insert.FlatStyle = FlatStyle.Popup;
            insert.Font = new Font("Calibri", 20F, FontStyle.Italic);
            insert.ForeColor = Color.Wheat;
            insert.Location = new Point(12, 157);
            insert.Name = "insert";
            insert.Size = new Size(122, 55);
            insert.TabIndex = 4;
            insert.Text = "insert book";
            insert.UseVisualStyleBackColor = false;
            insert.Click += insert_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Location = new Point(140, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 550);
            panel1.TabIndex = 7;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            BackgroundImage = Properties.Resources.dark_wood_background_1920_x_1080_wdj1vph19bm5vqaj;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1000, 600);
            Controls.Add(panel1);
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
        private Panel panel1;
    }
}