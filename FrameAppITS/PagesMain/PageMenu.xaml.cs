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
using FrameAppITS.PagesMain;
using FrameAppITS.Class;

namespace FrameAppITS.PagesMain
{
    /// <summary>
    /// Логика взаимодействия для PageMenu.xaml
    /// </summary>
    public partial class PageMenu : Page
    {
        public PageMenu()
        {
            InitializeComponent();
        }

        private void UristHL_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameLogo.Navigate(new PagesMain.LogoUristPage());
            ClassFrame.FrameBody.Navigate(new PagesMain.UristPage());
        }

        private void DirHL_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameLogo.Navigate(new PagesMain.LogoDirPage());
            ClassFrame.FrameBody.Navigate(new PagesMain.PageDir());
        }

        private void BuhHL_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameLogo.Navigate(new PagesMain.LogoBuhPage());
            ClassFrame.FrameBody.Navigate(new PagesMain.BuhPage());
        }

        private void InjHL_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameLogo.Navigate(new PagesMain.LogoInjPage());
            ClassFrame.FrameBody.Navigate(new PagesMain.InjPage());
        }

        private void MeneHL_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameLogo.Navigate(new PagesMain.LogoMenegerPage());
            ClassFrame.FrameBody.Navigate(new PagesMain.MenegerPage());
        }

        private void SysHL_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameLogo.Navigate(new PagesMain.LogoSysPae());
            ClassFrame.FrameBody.Navigate(new PagesMain.SysPage());
        }
    }
}
