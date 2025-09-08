using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Models;

namespace TaskManager
{

    public partial class CustomDialogForm : Form
    {
        TaskManagerContext context = new TaskManagerContext();
        public string taskTitle { get; set; }
        public string taskBody { get; set; }
        public DateTime taskDueDate { get; set; }
        public Status status { get; set; }
        public string Priorty { get; set; }
        public string Category { get; set; }

        public CustomDialogForm()
        {
            InitializeComponent();

            comboBox2.Items.Add("Pending");
            comboBox2.Items.Add("In Progress");
            var categories = context.Categories.ToList();

            foreach (var cat in categories) comboBox3.Items.Add(cat.Name);

            comboBox3.Text = "select a category";
           


        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            taskBody = textBox1.Text;
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            taskBody = richTextBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Pending") status = Status.Pending;
            else if (comboBox2.Text == "In Progress") status = Status.InProgress;
        }
    }
}
