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
    /// Логика взаимодействия для PageMenuAdmin.xaml
    /// </summary>
    public partial class PageMenuAdmin : Page
    {
        public PageMenuAdmin()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.GoBack();
        }

        private void BtnPageItem_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageItem());
        }
    }
}
