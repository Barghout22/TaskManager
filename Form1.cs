using TaskManager.Models;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        new CustomDialogForm AddForm;
        TaskManagerContext context = new TaskManagerContext();
        new AddUserForm UserForm = new AddUserForm();
        new AddCategoryForm CatForm = new AddCategoryForm();
        public Form1()
        {
            InitializeComponent();
            var tasks = context.TaskItems.OrderBy(task => task.DueDate).ToList();
            dataGridView1.DataSource = tasks;
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
                var currentUser = context.Users.FirstOrDefault(user => user.Email == comboBox1.Text);
                AddForm = new CustomDialogForm(currentUser);
                AddForm.ShowDialog();
                if (AddForm.DialogResult == DialogResult.Cancel) AddForm.Close();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedText != "no users to show")
            {
                var tasks = context.TaskItems.Where(task => task.Usr.Email == comboBox1.SelectedText)
                    .OrderBy(task => task.DueDate).ToList();
                dataGridView1.DataSource = tasks;
            }

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedText != "no users to show")
            {
                var tasks = context.TaskItems
              .Where(task => task.Status == Status.Pending && task.Usr.Email == comboBox1.SelectedText)
              .OrderBy(task => task.DueDate).ThenBy(task => task.Priority)
              .ToList();
                dataGridView1.DataSource = tasks;

            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedText != "no users to show")
            {
                var tasks = context.TaskItems
              .Where(task => task.Status == Status.InProgress && task.Usr.Email == comboBox1.SelectedText)
              .OrderBy(task => task.DueDate).ThenBy(task => task.Priority)
              .ToList();
                dataGridView1.DataSource = tasks;
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedText != "no users to show")
            {
                var tasks = context.TaskItems
             .Where(task => task.Status == Status.Completed && task.Usr.Email == comboBox1.SelectedText)
             .OrderBy(task => task.DueDate).ThenBy(task => task.Priority)
             .ToList();
                dataGridView1.DataSource = tasks;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CatForm.ShowDialog();
        }
    }
}
