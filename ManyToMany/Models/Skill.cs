using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManyToMany.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}