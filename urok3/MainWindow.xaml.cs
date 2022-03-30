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
using urok3.Pages;

namespace urok3
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text == a & password.Text == b)
            {
                Users users = new Users();
                users.Show();
            }
            else MessageBox.Show("Неверный логин и пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        string a = "admin";
        string b = "admin";
    }
}
