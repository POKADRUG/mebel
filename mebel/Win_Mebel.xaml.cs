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
    /// Логика взаимодействия для Win_Mebel.xaml
    /// </summary>
    public partial class Win_Mebel : Window
    {
        public Win_Mebel()
        {
            InitializeComponent();
            using (ApplicationConnect context = new ApplicationConnect())
            {
                DGrid.ItemsSource = context.mebels.ToList();
            }

        }
        private void Button_Redact(object sender, RoutedEventArgs e)
        {
            using (ApplicationConnect db = new ApplicationConnect())
            {
                Edit redact = new Edit((sender as Button).DataContext as mebels);
                redact.Show();
                this.Hide();
            }
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            Edit edit = new Edit(null);
            edit.Show();
            this.Hide();
        }

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить предмет?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                using (ApplicationConnect db = new ApplicationConnect())
                {
                    var сurrentUser1 = DGrid.SelectedItem as mebels;
                    db.mebels.Remove(сurrentUser1);
                    db.SaveChanges();
                    DGrid.ItemsSource = db.mebels.ToList();
                    MessageBox.Show("Удалено");
                }

            }

        }


        private void DGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_firm(object sender, RoutedEventArgs e)
        {
            Win_firm firm = new Win_firm();
            firm.Show();
            this.Hide();
        }
    }
}
    
