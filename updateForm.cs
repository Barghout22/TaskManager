using Microsoft.Identity.Client;
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

    public partial class updateForm : Form
    {
        TaskManagerContext context = new TaskManagerContext();
        confirmDelete confirmForm = new confirmDelete();
        public int TaskID { get; set; }
        public updateForm(int taskId)
        {
            InitializeComponent();
            TaskID = taskId;
            var task = context.TaskItems.FirstOrDefault(t => t.Id == taskId);
            var cats = context.Categories.ToList();
            textBox1.Text = task.Title;
            richTextBox1.Text = task.Description;
            dateTimePicker1.Value = task.DueDate;
            
            comboBox2.Items.Add(Status.Pending);
            comboBox2.Items.Add(Status.InProgress);
            comboBox2.Items.Add(Status.Completed);
            foreach (var cat in cats) comboBox3.Items.Add(cat.Name);

            comboBox1.Text = task.Priority;
            comboBox2.SelectedValue = task.Status;
            comboBox3.SelectedValue = task.Categ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            confirmForm.ShowDialog();
            if (confirmForm.DialogResult == DialogResult.OK)
            {
                var task = context.TaskItems.FirstOrDefault(t => t.Id == TaskID);
                context.TaskItems.Remove(task);
                context.SaveChanges();
                this.Close();

            }

        }
    }
}
