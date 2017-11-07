using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_17_TsN
{
    enum country { Египет, Тайланд, Греция, Болгария, Румыния }
    enum type { Отдых, Экскурсия, Лечение, Шопинг, Круиз }
    enum transport { Автобус, Самолёт, Корабль, Поезд }
    enum eating { ВсёВкл, НеВсёВкл }
    enum days { days5 = 5, days10 = 10, days12 = 12, days14 = 14, days20 = 20 }
    class Client
    {
        public country c;
        public type t;
        public transport tr;
        public eating e;
        public days d;

        public void enterCountry(country c)
        {
            this.c = c;
        }
        public void enterType(type t)
        {
            this.t = t;
        }
        public void enterTransport(transport tr)
        {
            this.tr = tr;
        }
        public void enterEating(eating e)
        {
            this.e = e;
        }
        public void enterDays(days d)
        {
            this.d = d;
        }
        public void print()
        {
            Console.WriteLine("Вы выбрали страну " + c);
            Console.WriteLine("Это будет " + t);
            Console.WriteLine("И отправитесь вы туда на {0}е" , tr);
            Console.WriteLine("Питание у вас будет " + e);
            Console.WriteLine("Едите вы туда на {0} дней" , d);
            Console.WriteLine("Приятного путешествия :)");
        }
        public Client(country c, type t, transport tr, eating e, days d)
        {
            this.c = c;
            this.t = t;
            this.tr = tr;
            this.e = e;
            this.d = d;
        }
    }

    class Program
    {
        static country Country(int j)
        {
            switch (j)
            {
                case 1:
                    return country.Болгария;
                case 2:
                    return country.Греция;
                case 3:
                    return country.Египет;
                case 4:
                    return country.Румыния;
                case 5:
                    return country.Тайланд;
            }
            return country.Болгария;
        }
        static type Type(int j)
        {
            switch (j)
            {
                case 1:
                    return type.Круиз;
                case 2:
                    return type.Лечение;
                case 3:
                    return type.Отдых;
                case 4:
                    return type.Шопинг;
                case 5:
                    return type.Экскурсия;
            }
            return type.Отдых;
        }
        static transport Transport(int j)
        {
            switch (j)
            {
                case 1:
                    return transport.Автобус;
                case 2:
                    return transport.Корабль;
                case 3:
                    return transport.Самолёт;
                case 4:
                    return transport.Поезд;
            }
            return transport.Самолёт;
        }
        static eating Eat(int j)
        {
            switch (j)
            {
                case 1:
                    return eating.ВсёВкл;
                case 2:
                    return eating.НеВсёВкл;
            }
            return eating.ВсёВкл;
        }
        static days Days(int j)
        {
            switch (j)
            {
                case 1:
                    return days.days5;
                case 2:
                    return days.days10;
                case 3:
                    return days.days12;
                case 4:
                    return days.days14;
                case 5:
                    return days.days20;
            }

            return days.days12;
        }


        static void Main(string[] args)
        {

            country c;
            type t;
            transport tr;
            eating e;
            days d;
            Console.WriteLine("Здравствуйте, вы пришли в тур фирму \" АланДеГранЭль Тур \"");
            Console.WriteLine("Давайте подберём вам какойнить интересный тур, и так: ");
            Console.WriteLine("Куда бы вы хотели съездить? \n1)Болгария\n2)Греция\n3)Египет\n4)Румыния\n5)Тайланд");
            int n1 = int.Parse(Console.ReadLine());
            c = Country(n1);
            Console.WriteLine("Отличный выбор");
            Console.WriteLine("Какой тип свободного времяпрепроваждения предпочетайте? \n1)Круиз\n2)Лечение\n3)Отдых\n4)Шопинг\n5)Экскурсия");
            int n2 = int.Parse(Console.ReadLine());
            t = Type(n2);
            Console.WriteLine("Так, хорошо, дальше!");
            Console.WriteLine("Каким транспортом вы бы хотели отправится в приключение? \n1)Автобус\n2)Корабль\n3)Самолёт\n4)Поезд");
            int n3 = int.Parse(Console.ReadLine());
            tr = Transport(n3);
            Console.WriteLine("Ясненько.");
            Console.WriteLine("Вы хотите чтоб было всё включено или сами будете где то хавчик искать? \n1)Всё вкл\n2)Не всё вкл");
            int n4 = int.Parse(Console.ReadLine());
            e = Eat(n4);
            Console.WriteLine("Так, окей.");
            Console.WriteLine("И последнее. На сколько дней вы хотите отправится в приключение? \n1)5 дней\n2)10 дней\n3)12 дней\n4)14 дней\n5)20 дней");
            int n5 = int.Parse(Console.ReadLine());
            d = Days(n5);
            Console.WriteLine("Хорошо.");
            Console.WriteLine("И так...");
            Client cl = new Client(c,t,tr,e,d);
            cl.print();
            Console.ReadKey();
        }
    }
}
