using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar4_1048
{
    [Serializable]
    public class Student : ICalculeazaMedia
    {
        private string nume;
        private int matricol;
        private string facultate;
        private int[] note;
        private float medie;

        public float Medie{
            get { return medie; }
        }

        public string Nume
        {
            get { return nume; }
        }

        public string Facultate
        {
            get => facultate;
        }

        public Student(string nume, int matricol, string facultate, int[] note)
        {
            this.nume = nume;
            this.matricol = matricol;
            this.facultate = facultate;
            this.note = new int[note.Length];
            for(int i=0;i<note.Length;i++)
            {
                this.note[i] = note[i];
            }
        }

        public override string ToString()
        {
            string mesajAfis = "Studentul "+nume+" are matricol:"+matricol
                +" studiaza la:"+facultate+", are notele:\n";
            for(int i=0;i<note.Length;i++)
            {
                mesajAfis += note[i] + " ";
            }
            mesajAfis += ". Media: " + medie;
            return mesajAfis;
        }

        public void calculeazaMedia()
        {
            medie = 0;
            for(int i=0;i<note.Length;i++)
            {
                medie += note[i];
            }
            medie /= note.Length;
        }

    }
}
