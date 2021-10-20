using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание и вызов метода класса Кот
            Cat cat = new Cat();
            cat.ShowInfo();

            
            //Создание и вызов метода класса Пёс
            Dog dog = new Dog();
            dog.ShowInfo();
             

            Console.ReadKey();
        }
    }


    abstract class Animal
    {
        //Абстрактное свойство
        public abstract string Naming { set; get; }
        //Конструктор для значения по умолчанию
        public Animal()
        {
            this.Naming = "Животное";
        }
        //Абстрактный метод голоса
        public abstract void Say();
        //Метод обычный
        public void ShowInfo()
        {
            Console.Write("{0} говорит: ", Naming);
            Say();
            Console.Write("!");
            Console.WriteLine("");
        }           
    }

    class Cat : Animal
    {
        public override string Naming 
        { 
            set
            {
                value = "Кот";
            }
            get
            {
                return "Кот";
            }
        }

        public override void Say()
        {
            Console.Write("Мяу");
        }
    }
    class Dog : Animal
    {
        public override string Naming { get => "Пёс"; set => value = "Пёс"; }

        public override void Say()
        {
            Console.Write("Гав");
        }
    }

}

