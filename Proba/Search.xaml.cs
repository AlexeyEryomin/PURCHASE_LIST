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
using System.Windows.Shapes;

namespace Proba
{
    /// <summary>
    /// Логика взаимодействия для Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        public Search()
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
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow entrance = new MainWindow();
            entrance.Show();
            this.Close();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Устанавливаем фокус на поле ввода пароля
            SearchBox.Focus();
        }

    }
}
