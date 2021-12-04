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

namespace Practice_7G
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FindHypotenuse_Click(object sender, RoutedEventArgs e)
        {
            RightAngled delta = new RightAngled(int.Parse(firstP1.Text), int.Parse(secondP1.Text));
            result.Text = delta.GetHypotenuse(delta).ToString();
        }

        private void FindArea_Click(object sender, RoutedEventArgs e)
        {
            RightAngled delta = new RightAngled(int.Parse(firstP1.Text), int.Parse(secondP1.Text));
            result.Text = delta.GetArea(delta).ToString();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дроздов Г.", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
