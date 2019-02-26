using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fei.BaseLib;

namespace UlohyZadani
{


    class Program
    {

        public static void WriteField(int[] field)
        {
            for (int i = 0; i < field.Length; i++)
            {
                Console.Write("Obsah pole je: " + field[i] + " ");
            }
        }

        public static int GetMinimumValue(int[] field)
        {
            int minimum = Int32.MaxValue;

            for (int i = 0; i < field.Length; i++)
            {
                if(field[i] < minimum)
                {
                    minimum = field[i];
                }
            }

            return minimum;
        }

        public static int SearchFirstValue(int[] field, int value)
        {
            int index = 0;
            for (int i = 0; i < field.Length; i++)
            {
                if(field[i] == value)
                {
                    break;
                }
                index++;
            }

            return index;
        }

        public static int? SearchLastValue(int[] field, int value)
        {
            int index = 0;
            int? lastIndexSeen = null;

            for (int i = 0; i < field.Length; i++)
            {
                if(field[i] == value)
                {
                    lastIndexSeen = index;
                }
                index++;
            }

            return lastIndexSeen;
        }

        public static int[] GetField()
        {
            List<int> list = new List<int>();
            int[] field = null;
            


            return field;
        }


        static void Main(string[] args)
        {
            int[] pole = null;
            int volba;
            do
            {
                Console.WriteLine("Zadeh svoji volbu: ");
                int.TryParse(Console.ReadLine(), out volba);

                switch (volba)
                {
                    case 1:
                        break;
                    case 2:
                        WriteField(pole);
                        break;
                    case 3:
                        break;
                    case 4:
                        GetMinimumValue(pole);
                        break;
                    case 5:
                        SearchFirstValue(pole, 5);
                        break;
                    case 6:
                        SearchLastValue(pole, 5);
                        break;
                }
            } while (volba != 7);
        }
    }
}
