using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.SolievAH.Sprint7.Project.V10.Lib
{
    public class DataService
    {
        public int FindMinPrice(int[] products)
        {
            // Проверяем, есть ли хотя бы один товар в массиве
            if (products.Any())
            {
                // Инициализируем переменную для хранения максимальной цены
                int minPrice = products.First();

                // Проходим по всем товарам в массиве
                foreach (var product in products.Skip(1))
                {
                    // Сравниваем с текущей максимальной ценой
                    if (product <= minPrice)
                    {
                        minPrice = product;
                    }
                }

                return minPrice;
            }

            return 0;
        }

    }
}
