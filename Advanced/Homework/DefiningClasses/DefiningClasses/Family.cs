using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> familyMembers { get; set; }
        public Family()
        {
            this.familyMembers = new List<Person>();
        }
        public void AddMember(Person member)
        {
            familyMembers.Add(member);
        
        }
        public void Print()
        {
            List<Person> list = new List<Person>();
            list = this.familyMembers.OrderBy(s => s.Name).Where(s => s.Age > 30).ToList();
            foreach (var member in list)
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
            

        }


    }
}
