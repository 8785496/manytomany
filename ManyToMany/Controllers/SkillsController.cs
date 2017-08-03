using ManyToMany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ManyToMany.Context;

namespace ManyToMany.Controllers
{
    public class SkillsController : ApiController
    {
        public IEnumerable<Skill> Get()
        {
            using (var context = new MyContext("ManyToMany"))
            {
                try
                {
                    //var groups = new HashSet<Group> {
                    //        new Group { GroupName = "BackEnd" }
                    //};
                    //context.Skills.Add(new Skill
                    //{
                    //    SkillName = "C#",
                    //    Groups = groups
                    //});

                    //context.SaveChanges();

                    var query = from skill in context.Skills.Include("Groups")
                                select skill;

                    IEnumerable<Skill> skills = query.ToList();

                    return skills;
                }
                catch (Exception)
                {
                    throw;
                }


            }
        }

        public Skill Get(int id)
        {
            using (var context = new MyContext("ManyToMany"))
            {
                var query = from skill in context.Skills.Include("Groups")
                            where skill.Id == id
                            select skill;

                return query.First();
            }
        }

        public void Post([FromBody]Skill skill)
        {
            using (var context = new MyContext("ManyToMany"))
            {
                context.Skills.Add(skill);
                context.SaveChanges();
            }
        }

        public void Put(int id, [FromBody]Skill skill)
        {
            using (var context = new MyContext("ManyToMany"))
            {
                context.Skills.Add(skill);
                // context.SaveChanges();
            }
        }

    }
}
