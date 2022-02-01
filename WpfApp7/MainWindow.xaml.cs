using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF7
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
                textBox.FontFamily = new FontFamily(fontName);
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            double fontSize = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
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
