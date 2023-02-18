using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            /*Person pepi=new Person()
            {
                Name = "Peter",
                Age = 20
            
            };
            Person gogi = new Person()
            {
                Name = "George",
                Age = 18

            };
            Person jose = new Person()
            {
                Name = "Jose",
                Age = 43

            };
            */
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] person = Console.ReadLine().Split(' ');
                Person member = new Person();
                member.Name = person[0];
                member.Age = int.Parse(person[1]);
                family.AddMember(member);
            }
            
            family.Print();
        }
    }
}
