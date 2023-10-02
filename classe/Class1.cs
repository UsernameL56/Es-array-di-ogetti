using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe
{
    public class Class1
    {
    }

    public class Studenti
    {
        // attributi
        private string nome;
        private int età;
        private int voto;

        // costruttore senza parametri
        public Studenti() 
        {
            nome = "";
            età = 0;
            voto = 0;
        }

        // costruttore con parametri
        public Studenti(string nome, int età, int voto)
        {
            Name = nome;
            Age = età;
            Grade = voto;
        }

        // metodi accessor
        public string Name 
        { 
            get { return nome; } 
            set { nome = value; }
        }
        public int Age
        {
            get { return età; }
            set { età = value; }
        }
        public int Grade
        {
            get { return voto; }
            set { voto = value; }
        }

        // metodi
        public double Media(Studenti[] array)
        {
            double temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                temp += array[i].Grade;
            }
            return (temp/array.Length);
        }

        public string Elenco(Studenti[] array)
        {
            string temp = "";
            for (int i = 0; i < array.Length; i++)
            {
                temp += array[i].Name + "; ";
            }
            return temp;
        }
    }
}
