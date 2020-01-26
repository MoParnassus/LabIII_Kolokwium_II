using System;
using System.Collections;
using System.Linq;

namespace Kolokwium
{
    class Zadanie_1
    {
       public class Post: IEnumerable
        {
            public Post(string title, string author, string text, int date)
            {
                this.tytul = title;
                this.autor = author;
                this.tresc = text;
                this.datadodania = date;
            }

            public string tytul;
            public string autor;
            public string tresc;
            public int datadodania;
        }

        
    }
