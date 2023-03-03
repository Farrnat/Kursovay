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

namespace AutoParts
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            string login = tbLogin.Text.Trim();
            string pass = pbPass.Password.Trim();
            
            if (login.Length < 5)
            {
                tbLogin.ToolTip = "Логин должен быть больше 5 символов";
                tbLogin.Background = Brushes.LightCoral;
            }
            else if (pass.Length < 5)
            {
                pbPass.ToolTip = "Пароль должен быть больше 5 символов";
                pbPass.Background = Brushes.LightCoral;
            }
            else
            {
                tbLogin.ToolTip = "";
                tbLogin.Background = Brushes.Transparent;

                pbPass.ToolTip = "";
                pbPass.Background = Brushes.Transparent;

                User authUser = null;
                using (AppContext db = new AppContext())
                    authUser = db.Users.Where(b => b.login == login && b.pass == pass).FirstOrDefault();

                if (authUser != null)
                {
                    //MessageBox.Show("Пользователь найден");

                    UserPageWindow userPageWindow = new UserPageWindow();
                    userPageWindow.Show();
                    Hide();

                }
                    
                else
                    MessageBox.Show("Пользователь не найден");

            }
        }

        private void Button_Window_Reg_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
    }
}
