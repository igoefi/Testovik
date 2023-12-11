using System.Windows;
using System.Windows.Controls;
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
