using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Robot :ICheck
    {
        public Robot(string name, string id)
        {
            this.Name = name;
            
            this.ID = id;
        }
        public string ID { get; set; }

        public string Name { get; set; }
        

        public void Check(string lastdigits)
        {
            string last=string.Join("", ID.TakeLast(4));
            char[] digits = lastdigits.ToCharArray();
            char[] idDigits = ID.ToCharArray();
            Array.Reverse(digits);
            Array.Reverse(idDigits);
            bool check = true;
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] != idDigits[i])
                {
                    check = false;
                }
            }
            if (check != false)
            {
                Console.WriteLine(ID);
                Console.WriteLine(last);
            }

        }
    }
}
