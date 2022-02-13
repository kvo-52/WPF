using System;
using System.Collections.Generic;
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

namespace WPF17
{
    /*ЗАДАНИЕ 17. РАЗРАБОТКА ПОЛЬЗОВАТЕЛЬСКОГО ЭЛЕМЕНТА УПРАВЛЕНИЯ
        Разработать пользовательский элемент управления «Указатель цвета».
        Цвет определяется состоянием ползунков, отвечающих за интенсивность красной, зеленой и синей составляющей цвета.
        */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmdGet_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(colorPicker.Color.ToString(), "Выбран цвет:");
        }

        private void cmdSet_Click(object sender, RoutedEventArgs e)
        {
            colorPicker.Color = Colors.Green;
        }

        private void colorPicker_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {
            if (lblColor != null)
            {
                lblColor.Text = "Новый цвет: " + e.NewValue.ToString();
            }
        }
    }
}