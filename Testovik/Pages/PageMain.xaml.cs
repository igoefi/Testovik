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
using Testovik.Classes.Helpers;

namespace Testovik.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private void BtnClickCompleteTest(object sender, RoutedEventArgs e) =>
            FrameNav.Frame.Navigate(new PageCompleteTest());
        private void BtnClickCreateTest(object sender, RoutedEventArgs e) =>
            FrameNav.Frame.Navigate(new PageCreateTest());
    }
}
