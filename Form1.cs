using System.Linq;
using TaskManager.Models;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        new CustomDialogForm AddForm;
        TaskManagerContext context = new TaskManagerContext();
        new AddUserForm UserForm = new AddUserForm();
        new AddCategoryForm CatForm = new AddCategoryForm();
        int pageNum = 1;
        int pageSize = 5;
        public Form1()
        {
            InitializeComponent();
            button5.Enabled = false;

            var users = context.Users.ToList();
            if (users.Count() == 0) comboBox1.Text = "no users to show";
            else
            {
                foreach (var user in users)
                {
                    comboBox1.Items.Add(user.Email);
                }

                comboBox1.Text = users[0].Email;
                comboBox1.SelectedText = users[0].Email;
                var tasks = context.TaskItems.Where(task => task.Usr.Email == comboBox1.Text)
                    .OrderBy(task => task.DueDate)
                    .Select(task => new { task.Id, task.Title, task.Description, task.Categ.Name, task.Status, task.Priority, task.DueDate });
                label2.Text = $"showing {pageNum * pageSize} out of {tasks.ToList().Count} tasks";

                dataGridView1.DataSource = tasks.Skip((pageNum - 1) * pageSize).Take(pageSize).ToList();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var catCount = context.Categories.Count();
            if (comboBox1.Text == "no users to show")
            {
                MessageBox.Show("You must select or add a user before you can create tasks");

            }
            else if (catCount == 0) MessageBox.Show("You must add some categories before you can add tasks");
            else
            {
                var currentUserId = context.Users.FirstOrDefault(user => user.Email == comboBox1.Text).Id;
                AddForm = new CustomDialogForm(currentUserId);
                AddForm.ShowDialog();
                var tasks = context.TaskItems.Where(task => task.Usr.Email == comboBox1.Text)
                    .OrderBy(task => task.DueDate)
                    .Select(task => new { task.Id, task.Title, task.Description, task.Categ.Name, task.Status, task.Priority, task.DueDate }).ToList();
                dataGridView1.DataSource = tasks;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedText != "no users to show")
            {
                var tasks = context.TaskItems.Where(task => task.Usr.Email == comboBox1.Text)
                    .OrderBy(task => task.DueDate)
                    .Select(task => new { task.Id, task.Title, task.Description, task.Categ.Name, task.Status, task.Priority, task.DueDate }).ToList();
                dataGridView1.DataSource = tasks;
            }

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedText != "no users to show")
            {
                var tasks = context.TaskItems
              .Where(task => task.Status == Status.Pending && task.Usr.Email == comboBox1.Text)
              .OrderBy(task => task.DueDate)
             .Select(task => new { task.Id, task.Title, task.Description, task.Categ.Name, task.Priority, task.DueDate }).ToList();
                dataGridView1.DataSource = tasks;

            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedText != "no users to show")
            {
                var tasks = context.TaskItems
              .Where(task => task.Status == Status.InProgress && task.Usr.Email == comboBox1.Text)
              .OrderBy(task => task.DueDate).ThenBy(task => task.Priority)
              .Select(task => new { task.Id, task.Title, task.Description, task.Categ.Name, task.Priority, task.DueDate }).ToList();

                dataGridView1.DataSource = tasks;
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedText != "no users to show")
            {
                var tasks = context.TaskItems
             .Where(task => task.Status == Status.Completed && task.Usr.Email == comboBox1.Text)
             .OrderBy(task => task.DueDate)
             .Select(task => new { task.Id, task.Title, task.Description, task.Categ.Name, task.Priority, task.DueDate }).ToList();
                dataGridView1.DataSource = tasks;
            }
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            var tasks = context.TaskItems
           .Where(task => task.Usr.Email == comboBox1.Text)
           .OrderBy(task => task.Priority).ThenBy(task => task.DueDate)
           .Select(task => new { task.Id, task.Title, task.Description, task.Categ.Name, task.Status, task.DueDate }).ToList();
            dataGridView1.DataSource = tasks;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tasks = context.TaskItems
             .Where(task => task.Usr.Email == comboBox1.Text)
             .OrderBy(task => task.DueDate)
             .Select(task => new { task.Id, task.Title, task.Description, task.Categ.Name, task.Status, task.Priority, task.DueDate }).ToList();
            dataGridView1.DataSource = tasks;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserForm.ShowDialog();
            if (UserForm.DialogResult == DialogResult.OK)
            {
                var newUser = context.Users.Last();
                comboBox1.Items.Add(newUser.Email);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CatForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pageNum++;


            var tasks = context.TaskItems.Where(task => task.Usr.Email == comboBox1.Text)
                   .OrderBy(task => task.DueDate).Select(task => new { task.Id, task.Title, task.Description, task.Categ.Name, task.Status, task.Priority, task.DueDate });

            if (pageNum * pageSize < tasks.ToList().Count)
            {
                button5.Enabled = true;
                label2.Text = $"showing {pageNum * pageSize} out of {tasks.ToList().Count} tasks";

                dataGridView1.DataSource = tasks.Skip((pageNum - 1) * pageSize).Take(pageSize).ToList();

            }
            else if (pageNum * pageSize - tasks.ToList().Count < pageSize)
            {
                button5.Enabled = true;
                label2.Text = $"showing {tasks.ToList().Count - (pageNum - 1) * pageSize} out of {tasks.ToList().Count} tasks";

                dataGridView1.DataSource = tasks.Skip((pageNum - 1) * pageSize).Take(tasks.ToList().Count - (pageNum - 1) * pageSize).ToList();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var tasks = context.TaskItems.Where(task => task.Usr.Email == comboBox1.Text)
                  .OrderBy(task => task.DueDate).Select(task => new { task.Id, task.Title, task.Description, task.Categ.Name, task.Status, task.Priority, task.DueDate });
           


            if (pageNum > 1)
            {
                pageNum--;
                label2.Text = $"showing {pageNum * pageSize} out of {tasks.ToList().Count} tasks";

                dataGridView1.DataSource = tasks.Skip((pageNum - 1) * pageSize).Take(pageSize).ToList();

            }
            if (pageNum == 1) button5.Enabled = false;
        }
    }
}
