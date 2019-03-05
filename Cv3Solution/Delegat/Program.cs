using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    class Program
    {
        public static void InputData(Studenti field, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("Jmeno: ");
                string name = Console.ReadLine();
                int number;
                Console.Write("Cislo: ");
                int.TryParse(Console.ReadLine(), out number);
                Console.Write("Fakulta: ");
                string faculty = Console.ReadLine();

                Student stud = new Student(name, number, GetFaculty(faculty));
                field.addStudent(stud);
            }
        }

        public static Fakulta GetFaculty(string faculty)
        {
            switch (faculty)
            {
                case "fes":
                    return Fakulta.FES;
                case "fei":
                    return Fakulta.FEI;
                case "ff":
                    return Fakulta.FF;
                case "fcht":
                    return Fakulta.FCHT;
            }
            return 0;
        }

        public static void WriteAll(Studenti field)
        {
            Student[] pom = field.Students;
            for (int i = 0; i < field.Students.Length; i++)
            {
                Console.WriteLine(pom[i].ToString());
            }
        }
        static void Main(string[] args)
        {
            int choise = 0;
            Studenti field = null;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1 - Nacteni studentu");
                Console.WriteLine("2 - Vypis studentu");
                Console.WriteLine("3 - Serazeni studentu podle cisla");
                Console.WriteLine("4 - Serazeni studentu podle jmena");
                Console.WriteLine("5 - Serazeni studentu podle fakulty");
                Console.WriteLine("0 - Ukonceni programu");
                Console.Write("Co si prijete provest? ");
                int.TryParse(Console.ReadLine(), out choise);
                int count;

                switch (choise)
                {
                    case 1:
                        Console.Write("Pocet studentu bude: ");
                        int.TryParse(Console.ReadLine(), out count);

                        field = new Studenti(count);
                        InputData(field, count);
                        break;
                    case 2:
                        WriteAll(field);
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;

                }

            } while (choise != 0);
        }
    }
}
