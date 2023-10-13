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

namespace WPFHomework1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void changeButtonColor(object sender, MouseButtonEventArgs e)
        {
            Button btn = sender as Button;
            int r = new Random().Next(0,256);
            int g = new Random().Next(0,256);
            int b = new Random().Next(0,256);

            btn.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
            MessageBox.Show($"This button name: {btn.Name}\nButton text: {btn.Content}\nButton Background {btn.Background.ToString()}" +
                $"\nButton foreground: {btn.Foreground}\n Button fontsize: {btn.FontSize}");

        }

        private void deleteButton(object sender, MouseButtonEventArgs e)
        {
            Button button = sender as Button;
            this.Title = button.Content.ToString();
            Grid grid = (Grid)button.Parent;
           
            grid.Children.Remove(button);
        }
    }
}
