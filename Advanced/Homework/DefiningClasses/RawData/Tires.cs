using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tires
    {
        private int age;

        private float pressure;


        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public float Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }
        public Tires(int age, float pressure)
        {
            Age = age;
            Pressure = pressure;
        }


    }
}
