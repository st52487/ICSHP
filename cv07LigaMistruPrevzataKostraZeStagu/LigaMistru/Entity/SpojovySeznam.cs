using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaMistru
{
    // Spojový seznam by měl realizovat rozhraní IEnumerable, ICollection a IList
    // Shoddu prvků testujte pomocí metody Equals
    // Doplňte Equals do třídy Hrac

    public class SpojovySeznam : IEnumerable, ICollection, IList
    {
        private PrvekSeznamu prvni;
        private PrvekSeznamu posledni;
        private int pocetPrvku;


        private class PrvekSeznamu
        {
            object data;
            PrvekSeznamu dalsi;
            PrvekSeznamu predchozi;

            public PrvekSeznamu(object data)
            {
                this.data = data;
                this.dalsi = null;
            }

            public object Data { get => data; set => data = value; }
            public PrvekSeznamu Dalsi { get => dalsi; set => dalsi = value; }
            public PrvekSeznamu Predchozi { get => predchozi; set => predchozi = value; }
        }
        public object this[int index] {
            get => getPrvek(index); set => getPrvek(index); }

        private object getPrvek(int index)
        {
            PrvekSeznamu prvek = prvni;
            for (int i = 0; i < pocetPrvku; i++)
            {
                prvek = prvek.Dalsi;
            }
            return prvek;
        }

        public bool IsReadOnly => false;

        public bool IsFixedSize => false;

        public int Count => pocetPrvku;

        public object SyncRoot => this;

        public bool IsSynchronized => false;

        public int Add(object value)
        {
            PrvekSeznamu prvek = prvni;
            PrvekSeznamu pom = new PrvekSeznamu(value);
            if(pocetPrvku == 0)
            {
                prvni = pom;
                posledni = pom;
                return ++pocetPrvku;
            }
            for (int i = 0; i < pocetPrvku; i++)
            {
                prvek = prvek.Dalsi;
            }
            prvek.Dalsi = pom;
            posledni = pom;
            return ++pocetPrvku;
        }

        public void Clear()
        {
            pocetPrvku = 0;
            prvni = null;
            posledni = null;
        }

        public bool Contains(object value)
        {
            for (int i = 0; i < pocetPrvku; i++)
            {
                if (this.Equals(value))
                    return true;
            }
            return false;
        }

        public void CopyTo(Array array, int index)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (index < 0)
                throw new ArgumentOutOfRangeException();
            if (array.Rank > 1 || array.Length < pocetPrvku)
                throw new ArgumentException();
            PrvekSeznamu prvek = prvni;
            for (int i = 0; i < index; i++)
            {
                prvek = prvek.Dalsi;
            }
            for (int i = 0; i < pocetPrvku - index; i++)
            {
               

            }
        }

        public IEnumerator GetEnumerator()
        {
            PrvekSeznamu prvek = prvni;
            while (prvek != null)
            {
                yield return prvek.Data;
                prvek = prvek.Dalsi;
            }
        }

        public int IndexOf(object value)
        {
            int index = 0;
            PrvekSeznamu pom = prvni;
            for (int i = 0; i < pocetPrvku; i++)
            {
                index = i;
                if (pom.Data == value)
                    break;
                pom = pom.Dalsi;
            }
            return index;
        }

        public void Insert(int index, object value)
        {
            if (index > pocetPrvku)
                throw new ArgumentOutOfRangeException();
            if (value == null)
                throw new NullReferenceException();

            if(index == 0)
            {
                PrvekSeznamu prvek = new PrvekSeznamu(value);
                PrvekSeznamu pom = prvni;
                prvni = prvek;
                prvek.Dalsi = pom;
            }
            else
            {
                PrvekSeznamu pom = prvni;
                PrvekSeznamu prvek = new PrvekSeznamu(value);
                for (int i = 0; i < index-1; i++)
                {
                    pom = pom.Dalsi;
                }
                PrvekSeznamu nasledujici = pom.Dalsi.Dalsi;
                pom.Dalsi = prvek;
                prvek.Dalsi = nasledujici;
            }

        }

        public void Remove(object value)
        {
            PrvekSeznamu pom = prvni;
            PrvekSeznamu prvekPredchazejici = null;
            for (int i = 0; i < pocetPrvku; i++)
            {
                prvekPredchazejici = pom;
                if (pom.Data == value)
                    break;
                pom = pom.Dalsi;
            }
            prvekPredchazejici.Dalsi = pom.Dalsi;
        }

        public void RemoveAt(int index)
        {
            PrvekSeznamu pom = prvni;
            PrvekSeznamu prvekPredchazejici = null;
            for (int i = 0; i < pocetPrvku; i++)
            {
                prvekPredchazejici = pom;
                if (i == index)
                    break;
                pom = pom.Dalsi;
            }
            prvekPredchazejici.Dalsi = pom.Dalsi;
            if (index == 0)
                prvni = prvekPredchazejici;
        }
    }
}
