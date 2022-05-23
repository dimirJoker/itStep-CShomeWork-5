using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//вариант 1 - создать массив случайных не повторяющихся значений равный длине массива для перемешивания
//а затем копировать элементы изначального массива на индексы из случайного массива в новый перемешанный массив
//а)в цикле создать эелемент, проверить что таких элементов еще нет в массиве и в след цикле создать след элемент и проверить...
//вариант 2 - создавать рандомное значение индекса в цикле и затем поменять местами значение массива с индексом текущей итерации цикла
//и элементом рандомного индекса. 
namespace HomeWork5
{
    internal class HomeWork5
    {
        static void Main(string[] args)
        {
            MyList<int> list0 = new MyList<int>();

            while (true)
            {
                Console.WriteLine("___________________________________________");
                var rand = new Random();
                var bytes = new byte[10];
                rand.NextBytes(bytes);
                var randBytes = rand.Next(bytes.Length);
                Console.WriteLine(randBytes);
            }
        }
    }
}
