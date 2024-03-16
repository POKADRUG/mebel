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

namespace mebel
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void registration(object sender, RoutedEventArgs e)
        {
            using (ApplicationConnect db = new ApplicationConnect())
            {
                Cinema cinema = new Cinema();
                cinema.Name = text_name.Text;
                cinema.Login = text_login.Text;
                cinema.Password = text_password.Password;

                db.Add(cinema);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Информация сохранена");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

                MainWindow avtoriz = new MainWindow();
                avtoriz.Show();
                this.Hide();
            }
        }
    }
}
