using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B4.
    // Кол-во стингеров: 🔷
    //
    // Написать функцию CheckBrackets(string s), которая определяет,
    // правильно ли расставлены скобки () {} [] <> в предложении.
    //
    // Примеры:
    // CheckBrackets("(abc)[]{0:1}") ==> true;
    // CheckBrackets("(abc)]{0:1}[") ==> false.
    public static class TaskB4
    {
        public static bool CheckBrackets(string s)
        {
            int[][] counter = new int[4][2]();
            for (int i = 0; i < s.Length; i++)
            {
                //(5+5)/[4+4]*{2*2}
                switch (s[i]){
                    case '(':
                        counter[0][0] += 1;
                        break;
                    case ')':
                        counter[0][1] += 1;
                        break;
                    case '{':
                        counter[1][0] += 1;
                        break;
                    case '}':
                        counter[1][1] += 1;
                        break;
                    case '[':
                        counter[2][0] += 1;
                        break;
                    case ']':
                        counter[2][1] += 1;
                        break;
                    case '<':
                        counter[3][0] += 1;
                        break;
                    case '>':
                        counter[3][1] += 1;
                        break;

                }
                if (counter[0][0] < counter[0][1] || counter[1][0] < counter[1][1] || counter[2][0] < counter[2][1] || counter[3][0] < counter[3][1])
                {
                    return false;
                   
                }

            }
            if (counter[0][0] == counter[0][1] && counter[1][0] == counter[1][1] && counter[2][0] == counter[2][1] && counter[3][0] == counter[3][1])
            {
                return true;
            }
            return true;
            return false;
        }
    }
}
