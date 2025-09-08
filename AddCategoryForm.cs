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
    public partial class AddCategoryForm : Form
    {
        TaskManagerContext context = new TaskManagerContext();
        public String CatName { get; set; }
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CatName = textBox1.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CatName)) {
                MessageBox.Show("The new category name cannot be a blank");
            
            }
            else {
                var cats = context.Categories.Add(new Category { Name = CatName });
                context.SaveChanges();
                MessageBox.Show("category added successfully");
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
