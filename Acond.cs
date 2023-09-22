using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Acond
    {
        private string Name;
        private string Password;

        private decimal Money;

        public Acond(string name, string password, decimal money)
        {
            Name = name;
            Password = password;
            Money= money; 
        }

        public void GetName(string name)//tashqaridan olingan malumotlarga
        {
            Name=name;

        }
        public string SetName()//olingan malumotni ichkariga uzlashtirish ga
        {
            return Name;    

        }
        public void GetPassword(string password)
        {
            Password = password;
        }
        public string SetPassword()
        {
            return Password;
        }

        public void SetMoney(decimal money)
        {
            Money += money;
        }
        public string GetMoney(string parol)
        {
            if(Password==parol)
                return Money.ToString(); 
            else return  "xato parol kiritildi";
        }


    }
}
