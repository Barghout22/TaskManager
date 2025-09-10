namespace TaskManager
{
    partial class updateForm
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 38);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "title";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 116);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "body";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(31, 150);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(243, 194);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(31, 381);
            button1.Name = "button1";
            button1.Size = new Size(135, 37);
            button1.TabIndex = 4;
            button1.Text = "update";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(202, 381);
            button2.Name = "button2";
            button2.Size = new Size(138, 37);
            button2.TabIndex = 5;
            button2.Text = "delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(387, 381);
            button3.Name = "button3";
            button3.Size = new Size(140, 37);
            button3.TabIndex = 6;
            button3.Text = "cancel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(327, 38);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 7;
            label3.Text = "due date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(327, 116);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 8;
            label4.Text = "priorty";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(327, 195);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 9;
            label5.Text = "status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(327, 271);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 10;
            label6.Text = "category";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(327, 321);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(327, 223);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 23);
            comboBox2.TabIndex = 12;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(327, 150);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(200, 23);
            comboBox3.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(327, 71);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // updateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "updateForm";
            Text = "updateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private DateTimePicker dateTimePicker1;
    }
}