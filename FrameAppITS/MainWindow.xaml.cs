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
using FrameAppITS.Class;
using FrameAppITS.PagesMain;

namespace FrameAppITS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            ClassFrame.FrameMenu = FrameMenuMain;
            FrameMenuMain.Navigate(new PagesMain.PageMenu());

            ClassFrame.FrameBody = FrameBodyMain;
            FrameBodyMain.Navigate( new PagesMain.PageBody());

            ClassFrame.FrameTitle = FrameTitleMain;
            FrameTitleMain.Navigate(new PagesMain.PageTitle());

            ClassFrame.FrameLogo = FrameLogoMain;
            FrameLogoMain.Navigate(new PagesMain.PageLogo());
        }
    }
}
