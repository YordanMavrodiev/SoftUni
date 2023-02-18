using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; set; }
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
        }
        public bool AddChild(Child child)
        {
            if (Registry.Count<Capacity)
            {
                Registry.Add(child);
                return true;
            }
        return false;
        }
        public bool RemoveChild(string childFullName)
        {
            string[] names = childFullName.Split(" ");
            string firstName = names[0];
            string lastName = names[1];
            Child ch = null;
            foreach (var child in Registry)
            {
                if (child.FirstName==firstName&&child.LastName==lastName)
                {
                    ch= child;
                }
            }
            
            if (ch != null)
            {
                Registry.Remove(ch);
                return true;
            }
            else return false;
        }
        public int ChildrenCount => Registry.Count;
        public Child GetChild(string childFullName)
        {
            string[] names = childFullName.Split(" ");
            string firstName = names[0];
            string lastName = names[1];
            Child ch = null;
            foreach (var child in Registry)
            {
                if (child.FirstName == firstName && child.LastName == lastName)
                {
                    ch = child;
                }
            }

            if (ch != null)
            {
                
                return ch;
            }
            else return null;
        }
        public string RegistryReport()
        { 
        var order=Registry.OrderByDescending(x=>x.Age).ThenBy(x=>x.LastName).ThenBy(x=>x.FirstName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Registered children in {Name}:");
            foreach (var child in order)
            {
                sb.AppendLine(child.ToString());
            }
            return sb.ToString().TrimEnd();
        
        }
    }
}
