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
using WpfApp3.AppData;

namespace WpfApp3.PageAdmin
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        public Item _currentItem = new Item(); 
        public AddEditPage(Item selectedItem)
        {
            InitializeComponent();
            if (selectedItem != null)
            {
                _currentItem = selectedItem;
            }
            DataContext = _currentItem;

            CmbCategoryItem.ItemsSource = AppConnect.GetContext().ItemCategory.ToList();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.GoBack();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (_currentItem.ItemID == 0)
                AppConnect.GetContext().Item.Add(_currentItem);
            {
                AppConnect.GetContext().SaveChanges();
                MessageBox.Show("Данные добавлены!");
                AppFrame.FrameMain.GoBack();
            }
        }
    }
}
