namespace BorderControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<ICheck> checks = new List<ICheck>();
            while (input[0]!="End")
            {
                ICheck newcheck = null;
                if (input.Length==3)
                {
                    newcheck = new Citizen(input[0], int.Parse(input[1]), input[2]);
                }
                if (input.Length == 2)
                {
                    newcheck = new Robot(input[0], input[1]);
                }
                checks.Add(newcheck);
                input = Console.ReadLine().Split();
            }
            string lastdigits = Console.ReadLine();
            foreach (var item in checks)
            {
                item.Check(lastdigits);
            }
        }
    }
}