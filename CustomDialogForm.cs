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
        public Status taskStatus { get; set; }
        public string TaskPriorty { get; set; }
        public string TaskCategory { get; set; }
        public int UserIdent { get; set; }

        public CustomDialogForm(int userId)
        {
            InitializeComponent();
            UserIdent = userId;

            comboBox2.Items.Add("Pending");
            comboBox2.Items.Add("In Progress");
            var categories = context.Categories.ToList();

            foreach (var cat in categories) comboBox3.Items.Add(cat.Name);

            comboBox3.Text = "select a category";



        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            taskTitle = textBox1.Text;
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            taskBody = richTextBox1.Text;
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            taskDueDate = dateTimePicker1.Value;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskPriorty = comboBox1.Text;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Pending") taskStatus = Status.Pending;
            else if (comboBox2.Text == "In Progress") taskStatus = Status.InProgress;
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskCategory = comboBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(taskTitle) || string.IsNullOrWhiteSpace(taskBody)
                || string.IsNullOrWhiteSpace(TaskCategory)
                || string.IsNullOrWhiteSpace(TaskPriorty) || taskStatus ==Status.Undefined || taskDueDate == DateTime.Now.Date)
            {
                MessageBox.Show("please make sure to fill out all the required fields to create a new task");

            }
            else
            {
                var CatId = context.Categories.FirstOrDefault(cat => cat.Name == TaskCategory).Id;
                context.TaskItems.Add(new TaskItem
                {
                    Title = taskTitle,
                    Description = taskBody,
                    setDate = DateTime.Now,
                    DueDate = taskDueDate,
                    Priority=TaskPriorty,
                    Status=taskStatus,
                    CategId= CatId,
                    UsrId=UserIdent

                });
                context.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}
