using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF9
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {   /*
             ЗАДАНИЕ 9. СТИЛИ, ТРИГГЕРЫ И ТЕМЫ
                Доработать проект текстового редактора из задания 8, добавив возможность выбора светлой и темной темы
                (учесть, что после задания 8 приложение содержит словарь ресурсов со списками названий шрифтов и размеров.
                Следует быть внимательным, чтобы его случайно не потерять).
             */
            InitializeComponent();
            FillFontComboBox(comboBoxFonts);
            textBox.TextDecorations = null;
            List<string> styles = new List<string>() {"Светлая тема", "Тёмная тема"};
            styleBox.ItemsSource = styles;
            styleBox.SelectionChanged += ThemeChange;
            styleBox.SelectedIndex = 0;
        }

        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            int styleIndex = styleBox.SelectedIndex;
            Uri uri = new Uri("DictStyleWhite.xaml", UriKind.Relative);
            if (styleIndex == 1)
            {
                uri = new Uri("DictStyleDark.xaml", UriKind.Relative);
            }
            ResourceDictionary resourse = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourse);
            bool f = (bool)rbtnRed.IsChecked;
            if (styleIndex == 0)
            {
                if(!f)
                    textBox.Foreground = Brushes.Black;
                else
                    textBox.Foreground = Brushes.Red;
            }
            if (styleIndex == 1)
            {
                if (!f)
                    textBox.Foreground = Brushes.White;
                else
                    textBox.Foreground = Brushes.Red;
            }
        }

        public void FillFontComboBox(ComboBox comboBoxFonts)
        {
            foreach (FontFamily fontsFamily in Fonts.SystemFontFamilies)
            {
                comboBoxFonts.Items.Add(fontsFamily.Source);
            }
            comboBoxFonts.SelectedIndex = 0;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = (sender as ComboBox).SelectedItem as String;
            if (textBox != null)
                textBox.FontFamily = new FontFamily(fontName);
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            double fontSize = Convert.ToDouble(((sender as ComboBox).SelectedItem as String));
            if (textBox != null)
                textBox.FontSize = fontSize;
        }

        private void btnBold_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.FontWeight == FontWeights.Normal)
                textBox.FontWeight = FontWeights.Bold;
            else
                textBox.FontWeight = FontWeights.Normal;
        }

        private void btnItalic_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.FontStyle == FontStyles.Normal)
                textBox.FontStyle = FontStyles.Italic;
            else
                textBox.FontStyle = FontStyles.Normal;
        }

        private void btnUnderLine_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.TextDecorations == null)
            {
                textBox.TextDecorations = TextDecorations.Underline;
            }
            else
                textBox.TextDecorations = null;
        }

        private void rbtnRed_Click(object sender, RoutedEventArgs e)
        {
            textBox.Foreground = Brushes.Red;
        }

        private void rbtnBlack_Click(object sender, RoutedEventArgs e)
        {
            int styleIndex = styleBox.SelectedIndex;
            if (styleIndex == 1)
                textBox.Foreground = Brushes.White;
            if (styleIndex == 0)
                textBox.Foreground = Brushes.Black;
        }

        private void ExitExecuted(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OpenExecuted(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openDialog.ShowDialog() == true)
                textBox.Text = File.ReadAllText(openDialog.FileName);
        }

        private void SaveExecuted(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveDialog.ShowDialog() == true)
                File.WriteAllText(saveDialog.FileName, textBox.Text);
        }
    }
}
