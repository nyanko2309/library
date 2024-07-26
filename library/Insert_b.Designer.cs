namespace library
{
    partial class Insert_b
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
            name = new TextBox();
            author = new TextBox();
            category = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            Yearlist = new ListBox();
            SuspendLayout();
            // 
            // name
            // 
            name.Cursor = Cursors.IBeam;
            name.Location = new Point(159, 53);
            name.Name = "name";
            name.Size = new Size(287, 31);
            name.TabIndex = 1;
            // 
            // author
            // 
            author.Location = new Point(159, 121);
            author.Name = "author";
            author.Size = new Size(287, 31);
            author.TabIndex = 2;
            // 
            // category
            // 
            category.Location = new Point(159, 243);
            category.Name = "category";
            category.Size = new Size(287, 31);
            category.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 53);
            label2.Name = "label2";
            label2.Size = new Size(69, 27);
            label2.TabIndex = 6;
            label2.Text = "NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 11F, FontStyle.Italic);
            label3.Location = new Point(26, 117);
            label3.Name = "label3";
            label3.Size = new Size(89, 27);
            label3.TabIndex = 7;
            label3.Text = "AUTHOR";
          
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 11F, FontStyle.Italic);
            label4.Location = new Point(26, 185);
            label4.Name = "label4";
            label4.Size = new Size(59, 27);
            label4.TabIndex = 8;
            label4.Text = "YEAR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 11F, FontStyle.Italic);
            label5.Location = new Point(12, 243);
            label5.Name = "label5";
            label5.Size = new Size(108, 27);
            label5.TabIndex = 9;
            label5.Text = "CATEGORY";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 11F, FontStyle.Italic);
            label6.Location = new Point(26, 309);
            label6.Name = "label6";
            label6.Size = new Size(77, 27);
            label6.TabIndex = 11;
            label6.Text = "STATUS";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(159, 309);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(97, 29);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "avilable";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 11F, FontStyle.Italic);
            button1.Location = new Point(159, 365);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 13;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Yearlist
            // 
            Yearlist.AllowDrop = true;
            Yearlist.FormattingEnabled = true;
            Yearlist.ItemHeight = 25;
            Yearlist.Location = new Point(159, 181);
            Yearlist.Name = "Yearlist";
            Yearlist.Size = new Size(180, 29);
            Yearlist.TabIndex = 14;
            // 
            // Insert_b
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(800, 450);
            Controls.Add(Yearlist);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(category);
            Controls.Add(author);
            Controls.Add(name);
            Name = "Insert_b";
            Text = "Insert";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox name;
        public TextBox author;
        public  TextBox category;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        public CheckBox checkBox1;
        private Button button1;
        public ListBox Yearlist;
    }
}