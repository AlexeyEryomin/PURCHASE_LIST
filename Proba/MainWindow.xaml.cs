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

namespace Proba
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Получаем размеры рабочей области экрана
            double screenWidth = SystemParameters.WorkArea.Width;
            double screenHeight = SystemParameters.WorkArea.Height;

            // Получаем размеры окна
            double windowWidth = this.Width;
            double windowHeight = this.Height;

            // Вычисляем координаты для правого нижнего угла
            this.Left = screenWidth - windowWidth;
            this.Top = screenHeight - windowHeight;
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Add entrance = new Add();
            entrance.Show();
            this.Close();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Search entrance = new Search();
            entrance.Show();
            this.Close();
        }
    }
}
