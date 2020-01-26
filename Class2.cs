using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium
{
    public class Uzytkownik
    {
        public Uzytkownik(string login, string haslo, string dataurdzenia, string iloscpostow)
        {
            Login = login;
            Haslo = haslo;
            Data = dataurdzenia;
            IlPostow = iloscpostow;
            
        }
        
        private string Login;
        private string Haslo;
        private string Data;
        private string IlPostow;
    
        private static ()
    }
    class zadanie_3
    {
        static void Main()
        {
            var uzytkownik = new Uzytkownik("Login", "haslo" , "12.1.2001","100");
            Console.WriteLine(uzytkownik);
        }
    }
}
