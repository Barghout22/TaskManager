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
        public string taskTitle { get; set; }
        public string taskBody { get; set; }
        public DateTime taskDueDate { get; set; }
        public Status status { get; set; }
        public string Priorty { get; set; }
        public string Category { get; set; }

        public CustomDialogForm()
        {
            InitializeComponent();
            
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
