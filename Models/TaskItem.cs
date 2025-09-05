using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    internal enum Status { Pending,InProgress,Completed}
    internal class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; } // Low, Medium, High
        public Status Status { get; set; } // Pending, In Progress, Completed
        public int UsrId{get;set;}
        public int CategId { get; set; }

        public virtual User Usr { get; set; }
        public virtual Category Categ { get; set; }
    }
}
