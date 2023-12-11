using System.Windows;
using Testovik.Classes.Helpers;
using Testovik.Pages;

namespace Testovik
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameNav.Frame = frmMain;
            frmMain.Navigate(new PageMain());
        }
    }
}
