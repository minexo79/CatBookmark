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
using Microsoft.Web.WebView2.Wpf;

namespace CatBookmark
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            tabItemHackMD.Content   = new WebView2() { Source = new Uri("https://hackmd.io") };
            tabItemMiro.Content     = new WebView2() { Source = new Uri("https://miro.com") };
            tabItemChatGPT.Content  = new WebView2() { Source = new Uri("https://chat.openai.com") };
            tabItemClaude.Content   = new WebView2() { Source = new Uri("https://claude.ai") };
        }
    }
}
