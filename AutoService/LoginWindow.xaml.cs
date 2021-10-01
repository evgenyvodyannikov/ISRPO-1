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

namespace AutoService
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public MainWindow mainWindow;
        DataBase dataBase = new DataBase();
        public LoginWindow()
        {
            mainWindow = new MainWindow();
            InitializeComponent();
        }
        private void CloseBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
            mainWindow.Show();
        }

        


        public void GoToAdminPage()
        {
            mainWindow.MainFrame.Content = new Pages.AdminUC();
            this.Close();
            mainWindow.Show();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            if(dataBase.Login(LoginTB.Text, PasswordB.Password))
            {
                GoToAdminPage();
            }
        }
    }
}
