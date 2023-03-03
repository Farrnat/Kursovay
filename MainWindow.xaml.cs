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

namespace AutoParts
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AppContext db;

        public MainWindow()
        {
            InitializeComponent();

            db = new AppContext();


        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = tbLogin.Text.Trim();
            string pass = pbPass.Password.Trim();
            string passCheck = pbPassCheck.Password.Trim();
            string email = tbEmail.Text.Trim().ToLower();
            
            if(login.Length < 5)
            {
                tbLogin.ToolTip = "Логин должен быть больше 5 символов";
                tbLogin.Background = Brushes.LightCoral;
            }
            else if(pass.Length < 5)
            {
                pbPass.ToolTip = "Пароль должен быть больше 5 символов";
                pbPass.Background = Brushes.LightCoral;
            }
            else if (pass != passCheck)
            {
                pbPassCheck.ToolTip = "Пароли не совпадают";
                pbPassCheck.Background = Brushes.LightCoral;
            }
            else if (email.Length<4 || !email.Contains("@") || !email.Contains("."))
            {
                tbEmail.ToolTip = "Некорректный email";
                tbEmail.Background = Brushes.LightCoral;
            }
            else
            {
                tbLogin.ToolTip = "";
                tbLogin.Background = Brushes.Transparent;

                pbPass.ToolTip = "";
                pbPass.Background = Brushes.Transparent;

                pbPassCheck.ToolTip = "";
                pbPassCheck.Background = Brushes.Transparent;

                tbEmail.ToolTip = "";
                tbEmail.Background = Brushes.Transparent;

                MessageBox.Show("Пользователь зарегистрирован");

                User user =new User(login, pass, email);
                db.Users.Add(user);
                db.SaveChanges();

                AuthWindow authWindow = new AuthWindow();
                authWindow.Show();
                Hide();

            }

        }

        private void Button_Window_Auth_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            Hide();
        }
    }
}
