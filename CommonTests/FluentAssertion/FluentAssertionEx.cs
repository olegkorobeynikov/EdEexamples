using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTests.FluentAssertion
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Skill> Skills { get; set; }

        public User(string name, List<Skill> skills) 
        { 
            Name = name;
            Skills = skills;
            Id = Guid.NewGuid();
        }
    }

    public class Skill
    { 
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

        public Skill(string name, string description)
        {
            Name = name;
            Description = description;
            Id = new Guid();
            CreationDate = DateTime.UtcNow;
        }
    }

    internal class FluentAssertionEx
    {
        [Test]
        public void SpecificFieldAssertion()
        {
            var skils1 = new List<Skill>()
            { 
                new Skill("skill11", "blabla11"),
                new Skill("skill12", "blabla12"),
                new Skill("skill13", "blabla13"),
            };
            var user1 = new User("user1", skils1);

            var users1 = new List<User>() { user1 };
            var users2 = new List<User>() { user1 };

            users1.Should().BeEquivalentTo(users2, options => options
                .Using<DateTime>(ctx => ctx.Subject.Should().BeAfter(DateTime.UtcNow.AddDays(-1), ctx.Because, ctx.BecauseArgs))
                .When(x => x.Path.EndsWith(nameof(Skill.CreationDate)))
            );
        }
    }
}
