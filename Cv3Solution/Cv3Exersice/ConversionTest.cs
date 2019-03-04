using System;

namespace Cv3Exersice.Cv3Library
{
    internal class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Person(int id)
        {
            ID = id;
        }

        public override string ToString()
        {
            return ID + Name;
        }

        public static implicit operator int(Person p)
        {
            return p.ID;
        }


        public static implicit operator Person(int v)
        {
            return new Person(v);
        }
    }
    public static class ConversionTest
    {
        public static void DoIt()
        {
            Double realNumber = 3.14;
            realNumber = Math.PI;
            realNumber = 10;
            realNumber = 10.0;
            realNumber = (double)10;

            int integerNumber = 3;
            integerNumber = (int)3.14;
            integerNumber = (int)Math.Floor(Math.PI);

            Person person = new Person(1);
            Person person02 = integerNumber;
            int integerNumber2 = person02;

            Object person2 = new Person(2);
            
            (person as Person).Name = "Jarda";

            if(person2.GetType() == typeof(Person))
            {

            }
        }
    }
}
