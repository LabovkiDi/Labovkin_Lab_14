using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labovkin_Lab_14
{
    class Program
    {
        // АБСТРАКТНЫЙ КЛАСС - ЖИВОТНОЕ
        abstract class ANIMAL
        {
            // поле класса
            public abstract string Name { get; set; } /*асбтрактно свойство имя животного*/

            public ANIMAL(string name)
            {
                this.Name = name;
            }

            // объявление абстрактного метода (чистовиртуальный метод)
            public abstract void Say(); /*голос животного*/

            public void ShowInfo()
            {
                Console.WriteLine(this.Name);
                Say();
            }
        }

        // наследуемый класс КОТ 
        class CAT : ANIMAL
        {
            string name;
            // поля класса
            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            // конструктор класса с параметрами
            public CAT(string name) : base(name)
            {// присвоить значение в поле класса
                this.Name = name;
            }

            // перегруженный метод абстрактного класса
            public override void Say()
            {// вывод информации
                Console.WriteLine("Голос: Мяу!\n");
            }
        }

        // наследуемый класс СОБАКА 
        class DOG : ANIMAL
        {
            // поля класса
            string name;
            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            // конструктор класса с параметрами
            public DOG(string name) : base(name)
            {// присвоить значение в поле класса
                this.Name = name;
            }

            // перегруженный метод абстрактного класса
            public override void Say()
            {// вывод информации
                Console.WriteLine("Голос: Гав!\n");
            }
        }

        static void Main(string[] args)
        {
            List<ANIMAL> obj = new List<ANIMAL>();
            // заполнение списка типа ANIMAL объектами классов наследников
            obj.Add(new CAT("Фантик"));
            obj.Add(new DOG("Молли"));
            obj.Add(new CAT("Милка"));
            obj.Add(new DOG("Билли"));


            // вывод информации
            Console.WriteLine("Информация:");
            // обход всех записей списка
            foreach (ANIMAL ani in obj)
               ani.ShowInfo();
            
            Console.ReadKey();
        }
    }
}
