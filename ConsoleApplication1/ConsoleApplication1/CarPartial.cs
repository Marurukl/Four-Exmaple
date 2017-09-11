using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public partial class Car
    {
        public void Show()
        {
            Console.WriteLine("Название - {0}", name);
            Console.WriteLine("Модель - {0}", carModel);
            Console.WriteLine("Стоимость - {0}", salary);
            Console.WriteLine("Год выпуска - {0}", releaseYear);
            Console.WriteLine("Цвет машины - {0}",color);
            Console.WriteLine("категория - {0}", category);
            Console.WriteLine("Количество колес - {0}", wheels);
        }
        public void Init()
        {
            Console.WriteLine("Введите название машины : ");
            name = Console.ReadLine();

            Console.WriteLine("Введите модель машины : ");
            carModel = Console.ReadLine();

            Console.WriteLine("Введите цвет машины : ");
            Console.WriteLine("0 - Black , 1 - White , 2 - Blue , 3 - Red");
            int num;
            Int32.TryParse(Console.ReadLine(), out num);
            CheckColor(num);

            Console.WriteLine("Введите год выпуска машины : ");
            Int32.TryParse( Console.ReadLine(),out releaseYear);

            Console.WriteLine("Введите год стоимость машины : ");
            Int32.TryParse(Console.ReadLine(), out salary);

        }
        public void CheckColor(int value)
        {
            if (value == 0 )
            {
                color = Color.Black;
            }
            else if (value == 1)
            {
                color = Color.White;

            }
            else if (value == 2)
            {
                color = Color.Blue;
            }
            else if (value == 3)
            {
                color = Color.Red;
            }
            else
            {
                Console.WriteLine("Был введен непральный цвет , цвет был поставлен по умолчанию!");
                color = Color.Black;
            }
        }
    }
}
