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
using System.Windows.Forms.DataVisualization.Charting;

namespace TaskManager
{
    public partial class GenerateReportsForm : Form
    {
        TaskManagerContext context = new TaskManagerContext();
        public GenerateReportsForm()
        {
            InitializeComponent();
            label1.Text = "";
            var completedTasks = context.TaskItems.Where(t => t.Status == Status.Completed).ToList();
            if (completedTasks.Any())
            {
                TimeSpan totalCompletionTime = TimeSpan.Zero;
                foreach (var item in completedTasks) totalCompletionTime += item.CompletionTime - item.setDate ?? TimeSpan.Zero;
                double completiontime = totalCompletionTime.TotalHours / completedTasks.Count;
                label1.Text = $"average task completion time is {Math.Round(completiontime)} hours";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerateReportsForm_Load(object sender, EventArgs e)
        {
            var tasks = context.TaskItems.ToList();
            chart1.Series.Clear();
            var series = new Series
            {
                Name = "Tasks",
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie
            };

            // Example data
            series.Points.AddXY("Completed", tasks.Where(t=>t.Status==Status.Completed).Count());
            series.Points.AddXY("Pending", tasks.Where(t => t.Status == Status.Pending).Count());
            series.Points.AddXY("In Progress", tasks.Where(t => t.Status == Status.InProgress).Count());

            chart1.Series.Add(series);


        }
    }
}
