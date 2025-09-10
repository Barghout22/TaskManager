namespace TaskManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label1 = new Label();
            button2 = new Button();
            comboBox1 = new ComboBox();
            button3 = new Button();
            radioButton5 = new RadioButton();
            textBox1 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            label2 = new Label();
            button10 = new Button();
            radioButton6 = new RadioButton();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(612, 372);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(665, 284);
            button1.Name = "button1";
            button1.Size = new Size(106, 43);
            button1.TabIndex = 1;
            button1.Text = "Add Task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(29, 41);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(68, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "All tasks";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(120, 41);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(69, 19);
            radioButton2.TabIndex = 3;
            radioButton2.Text = "Pending";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(227, 41);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(83, 19);
            radioButton3.TabIndex = 4;
            radioButton3.Text = "In Progress";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(348, 41);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(115, 19);
            radioButton4.TabIndex = 5;
            radioButton4.Text = "Completed Tasks";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(650, 80);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 6;
            label1.Text = "current user";
            // 
            // button2
            // 
            button2.Location = new Point(665, 157);
            button2.Name = "button2";
            button2.Size = new Size(106, 46);
            button2.TabIndex = 8;
            button2.Text = "Add new user";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(650, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(665, 221);
            button3.Name = "button3";
            button3.Size = new Size(106, 42);
            button3.TabIndex = 10;
            button3.Text = "Add Categories";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(506, 41);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(99, 19);
            radioButton5.TabIndex = 11;
            radioButton5.TabStop = true;
            radioButton5.Text = "sort by priorty";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 89);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "search tasks by name/description";
            textBox1.Size = new Size(458, 23);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new Point(193, 557);
            button5.Name = "button5";
            button5.Size = new Size(117, 48);
            button5.TabIndex = 15;
            button5.Text = "Previous";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(348, 557);
            button6.Name = "button6";
            button6.Size = new Size(130, 48);
            button6.TabIndex = 16;
            button6.Text = "Next";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 133);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 18;
            label2.Text = "showing 0 out of 0 tasks";
            // 
            // button10
            // 
            button10.Location = new Point(665, 357);
            button10.Name = "button10";
            button10.Size = new Size(106, 41);
            button10.TabIndex = 21;
            button10.Text = "generate task report";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(621, 45);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(128, 19);
            radioButton6.TabIndex = 22;
            radioButton6.TabStop = true;
            radioButton6.Text = "show overdue tasks";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 617);
            Controls.Add(radioButton6);
            Controls.Add(button10);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(radioButton5);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label1;
        private Button button2;
        private ComboBox comboBox1;
        private Button button3;
        private RadioButton radioButton5;
        private TextBox textBox1;
        private Button button5;
        private Button button6;
        private Label label2;
        private Button button10;
        private RadioButton radioButton6;
        private ColorDialog colorDialog1;
    }
}
