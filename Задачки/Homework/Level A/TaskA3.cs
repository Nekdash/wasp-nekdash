using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А3.
    // Кол-во стингеров: ⅓🔹
    //
    // Напишите функцию SumCube(int n, int m), которая будет вычислять сумму кубов чисел в заданном диапазоне, 
    // начиная с меньшего (но не включая его) до большего (включая). Первый аргумент не обязательно
    // должен быть большим числом. Если оба числа совпадают, тогда диапазон пуст и результат должен быть 0.
    //
    // Примеры:
    // sum_cube(2,3) => 27 -> 3^3 = 27;
    // sum_cube(3,2) => 27 -> 3^3 = 27;
    // sum_cube(0,4) => 100 -> 1^3+2^3+3^3+4^3 = 100;
    // sum_cube(17, 14) => 12384 -> 15^3+16^3+17^3 = 12384.
    public static class TaskA3
    {
        public static int SumCube(int n, int m)
        {
            int sum = 0;
            if ( n == m)
            {
                return 0;
            }
            int n_temp = n;
            int m_temp = m;
            n = Math.Min(n_temp, m_temp);
            m = Math.Max(n_temp, m_temp);
            for (int i = n + 1; i <= m; i++)
            {
                sum += i * i * i;
            }
            return sum;

            return 0;
        }
    }
}
