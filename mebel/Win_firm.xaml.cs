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
    /// Логика взаимодействия для Win_firm.xaml
    /// </summary>
    public partial class Win_firm : Window
    {
        public Win_firm()
        {
            InitializeComponent();
            using (ApplicationConnect context = new ApplicationConnect())
            {
                DGrid2.ItemsSource = context.firma.ToList();
            }
        }

       
        private void Button_Redact(object sender, RoutedEventArgs e)
        {
            using (ApplicationConnect db = new ApplicationConnect())
            {
                Edit2 redact = new Edit2((sender as Button).DataContext as firma);
                redact.Show();
                this.Hide();
            }
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            Edit2 edit = new Edit2(null);
            edit.Show();
            this.Hide();
        }

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить фирму?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                using (ApplicationConnect db = new ApplicationConnect())
                {
                    var сurrentUser2 = DGrid2.SelectedItem as firma;
                    db.firma.Remove(сurrentUser2);
                    db.SaveChanges();
                    DGrid2.ItemsSource = db.firma.ToList();
                    MessageBox.Show("Удалено");
                }

            }

        }


        private void DGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void btn_mebel(object sender, RoutedEventArgs e)
        {
            Win_Mebel win_Mebel = new Win_Mebel();
            win_Mebel.Show();
            this.Close();
        }

    }
}
    

