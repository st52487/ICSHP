using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public delegate int Pocetzmen(int pocetHracu);
   
    class Hraci
    {
        private Hrac[] field;
        public int Pocet { get; set; }

        public event Pocetzmen Udalost;
       

        private int Zmena(int pocet)
        {
            return 0;
        }

        public Hraci()
        {
            field = new Hrac[100];
            Udalost += Zmena;
        }

        public void Vymaz(int index)
        {
            Hrac[] pom = new Hrac[100];
            int indexPom = 0;
            for (int i = 0; i < Pocet; i++)
            {
                if(i != index)
                {
                    pom[indexPom++] = field[i];
                }
            }
            for (int i = 0; i < --Pocet; i++)
            {
                field[i] = pom[i];
            }
        }

        public void Pridej(Hrac hrac)
        {
            field[Pocet++] = hrac;
            //Udalost(Pocet);
        }

        public Hrac this[int index]
        {
            get => field[index];
        }

        public void NajdiNejlepsiKluby(out FotbalovyKlub[] kluby, out int countOfGoals)
        {
            kluby = null;
            countOfGoals = 0;
        }

    }
}
