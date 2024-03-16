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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace mebel
{
    /// <summary>
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        private mebels Mebel = new mebels();
        public Edit(mebels selectedMebel)
        {
            InitializeComponent();
            if (selectedMebel != null)
            {
                Mebel = selectedMebel;

            }
            DataContext = Mebel;
            mebels item = DataContext as mebels;
            if (item != null)
            {
                articul.Text = item.artikul;
                names.Text = item.name;
                kolichestvos.Text = item.kolichestvo;
            }
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationConnect db = new ApplicationConnect())
            {
                mebels mebel = DataContext as mebels;
                if (mebel != null)
                {
                    mebel.kolichestvo = kolichestvos.Text;
                    mebel.name = names.Text;
                    mebel.artikul = articul.Text;

                    db.mebels.Update(Mebel);
                    db.SaveChanges();
                    MessageBox.Show("Информация сохранена");
                    Win_Mebel menu = new Win_Mebel();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    //movies movie = new movies();
                    mebel.artikul = articul.Text;
                    mebel.name = names.Text;
                    mebel.kolichestvo = kolichestvos.Text;
                    db.Add(mebel);
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
