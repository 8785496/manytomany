using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManyToMany.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        [JsonIgnore]
        public ICollection<Skill> Skills { get; set; }
    }
}