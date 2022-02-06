using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF14
{
    /*ЗАДАНИЕ 14. ШАБЛОНЫ ДАННЫХ
        Определить класс Product для хранения информации о товаре. Класс должен содержать характеристики Название товара (строка), Цена (число),
        Изображение (строка - путь к файлу с изображением), Категория (перечисление, возможные значения – Еда, Бытовая техника).
        Разработать шаблон данных для отображения списка товаров в компоненте ListBox. 
        При помощи триггеров определите разный шаблон для товаров категории Еда и категории Бытовая техника. 
     */
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName = "Яблоки",
                ProdPrice = 170,
                ProdImage = "Data/Яблоки.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            { 
                ProdName = "Клубника",
                ProdPrice = 320,
                ProdImage = "Data/Клубника.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Бананы",
                ProdPrice = 60,
                ProdImage = "Data/Бананы.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Холодильник",
                ProdPrice = 70000,
                ProdImage = "Data/Холодильник.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            products.Add(new Product()
            {
                ProdName = "Утюг",
                ProdPrice = 6500,
                ProdImage = "Data/Утюг.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            products.Add(new Product()
            {
                ProdName = "Плита",
                ProdPrice = 45000,
                ProdImage = "Data/Плита.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            listBox.ItemsSource = products; 
        }
    }
}
