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

            comboBox1.Items.Add("Low");
            comboBox1.Items.Add("Medium");
            comboBox1.Items.Add("High");
            comboBox2.Items.Add(Status.Pending);
            comboBox2.Items.Add(Status.InProgress);
            comboBox2.Items.Add(Status.Completed);

            foreach (var cat in cats) comboBox3.Items.Add(cat.Name);

            comboBox1.Text = task.Priority;
            comboBox2.SelectedValue = task.Status;
            comboBox2.Text = task.Status.ToString();
            comboBox3.SelectedValue = task.Categ;
            comboBox3.Text = task.Categ.Name;
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

        private void button1_Click(object sender, EventArgs e)
        {
            var task = context.TaskItems.FirstOrDefault(t => t.Id == TaskID);
            if (task.Title != textBox1.Text) task.Title = textBox1.Text;
            if (task.Description != richTextBox1.Text) task.Description = richTextBox1.Text;
            if (task.DueDate != dateTimePicker1.Value) task.DueDate = dateTimePicker1.Value;
            if (task.Priority != comboBox1.Text) task.Priority = comboBox1.Text;
            if (task.Status.ToString() != comboBox2.Text) {
                if (comboBox2.Text == "Completed") {
                    task.CompletionTime = DateTime.Now;
                    task.Status = Status.Completed;
                }
                else if (comboBox2.Text == "Pending")
                {
                    task.Status = Status.Pending;
                }
                else task.Status = Status.InProgress;
                }
            if (task.Categ.Name != comboBox3.Text){
                task.CategId = context.Categories.FirstOrDefault(c=>c.Name==comboBox3.Text).Id; 
            }
            context.TaskItems.Update(task);
            context.SaveChanges();
            this.Close();
        }
    }
}
