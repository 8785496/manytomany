using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ManyToMany.Models
{
    public class Skill
    {
        public int Id { get; set; }
        [MaxLength(32)]
        [Index(IsUnique=true)]
        public string SkillName { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
    }
}