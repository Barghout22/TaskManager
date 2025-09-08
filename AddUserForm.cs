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
    public partial class AddUserForm : Form
    {
        TaskManagerContext context = new TaskManagerContext();
        public string NewName { get; set; }
        public string NewEmail { get; set; }
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NewName = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            NewEmail = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NewName) || string.IsNullOrWhiteSpace(NewEmail)) {
                MessageBox.Show("the name and email fields cannot be blanks.Please make sure to fill them out");
            
            }
            else {
                var users = context.Users.Add(new User() { Name = NewName, Email = NewEmail });
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
