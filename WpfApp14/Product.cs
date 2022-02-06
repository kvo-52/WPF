using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF14
{    /*ЗАДАНИЕ 14. ШАБЛОНЫ ДАННЫХ
        Определить класс Product для хранения информации о товаре. Класс должен содержать характеристики Название товара (строка), Цена (число),
        Изображение (строка - путь к файлу с изображением), Категория (перечисление, возможные значения – Еда, Бытовая техника).
        Разработать шаблон данных для отображения списка товаров в компоненте ListBox. 
        При помощи триггеров определите разный шаблон для товаров категории Еда и категории Бытовая техника. 
     */
    public enum ProductCategorys
    {
        Food,
        Appliances
    }
    
    public class Product
    {
        public string ProdName{ get; set; }
        public decimal ProdPrice{ get; set; }
        public string ProdImage{ get; set; }
        public ProductCategorys ProductCategory{ get; set; }

        public override string ToString()
        {
            return ProdName;
        }
    }


}
