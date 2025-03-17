using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Domain.Model
{
  
        public class TaskM:BaseDomainModel
        {
        
            public string Title { get; set; }
            public string Description { get; set; }
            public bool Completed { get; set; }
        }

    
}
