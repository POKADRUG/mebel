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
    /// Логика взаимодействия для Edit2.xaml
    /// </summary>
    public partial class Edit2 : Window
    {
        private firma Firma = new firma();
        public Edit2(firma selectedFirm)
        {
            InitializeComponent();
            if (selectedFirm != null)
            {
                Firma = selectedFirm;

            }
            DataContext = Firma;
            firma item = DataContext as firma;
            if (item != null)
            {
                names_firms.Text = item.name_firm;
                count.Text = item.country;

            }
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationConnect db = new ApplicationConnect())
            {
                firma firm = DataContext as firma;
                if (firm != null)
                {
                    firm.country = count.Text;
                    firm.name_firm = names_firms.Text;

                    db.firma.Update(Firma);
                    db.SaveChanges();
                    MessageBox.Show("Информация сохранена");
                    Win_firm menu = new Win_firm();
                    menu.Show();
                    this.Hide();
                }
                else
                {

                    firm.name_firm = names_firms.Text;
                    firm.country = count.Text;
                    db.Add(firm);
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
                }



            }



        }
    }
}
