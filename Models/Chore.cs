using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chore_list.Models
{
    public class Chore
    {
        public Chore(string name, string description, int id, bool isDone){
            Name = name;
            Description = description;
            Id = id;
            IsDone = isDone;
        }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public bool IsDone { get; set; }
}
}