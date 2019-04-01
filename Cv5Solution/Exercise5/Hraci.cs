using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    //public delegate int Pocetzmen(object sender, EventArgs e);
    

    class Hraci
    {
        public event PocetZmenenEventHandler PocetZmenen;
        private readonly Hrac[] field;
        public int Pocet { get; private set; }

        private bool registration = false;
       

        private int Zmena(int pocet)
        {
            Console.WriteLine("Pocet hracu: " + pocet);
            return pocet;
        }

        public Hraci()
        {
            field = new Hrac[100];
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
            OnPocetZmenen(Pocet - 1);
        }

        public void Pridej(Hrac hrac)
        {
            field[Pocet++] = hrac;
            OnPocetZmenen(Pocet + 1);
        }

        public void SetRegistration(bool registration)
        {
            this.registration = registration;
        }

        public Hrac this[int index]
        {
            get => field[index];
            set => field[index] = value;
        }

        public void NajdiNejlepsiKluby(out FotbalovyKlub[] kluby, out int countOfGoals)
        {
            countOfGoals = 0;
            int pocet = 0;
            
            for (int i = 0; i < Pocet; i++)
            {
                if(field[i].GolPocet >= countOfGoals)
                {
                    pocet++;
                    countOfGoals = field[i].GolPocet;
                }
            }
            kluby = new FotbalovyKlub[pocet];
            int index = 0;
            for (int i = 0; i < Pocet; i++)
            {
                if(field[i].GolPocet == countOfGoals)
                {
                    for (int j = 0; j < kluby.Length; j++)
                    {
                        if(kluby[i] != field[i].Klub)
                        {
                            kluby[index++] = field[i].Klub;
                        }
                    }
                }
            }
        }

        private void OnPocetZmenen(int puvodniPocetHracu)
        {
            PocetZmenen?.Invoke(this, new PocetZmenenEventArgs()
            {
                PuvodniPocet = puvodniPocetHracu
            });
        }

    }
}
