using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<TaskItem> TaskItems { get; set; } = new List<TaskItem>();

    }
}
