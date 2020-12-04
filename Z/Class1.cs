using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z
{
    public class ClassOne
    {
        int per1 = 5;
        int per2 = 50;

        public void Out()
        {
            System.Windows.MessageBox.Show($"Новые значения: {per1}, {per2}");
        }

        public void Change(int oneArgue, int twoArgue)
        {
            per1 = oneArgue;
            per2 = twoArgue;
        }

        int Sum()
        {
            int sum = per1 + per2;
            return sum;
        }

        int Greatest()
        {
            return per1>per2?per1:per2; //Не совсем понятно, что нужно возвращать, если они одинаковые, посему пусть выводится значение обоих
        }
    }
}
