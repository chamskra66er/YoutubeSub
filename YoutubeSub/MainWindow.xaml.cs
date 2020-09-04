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

namespace YoutubeSub
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string language=null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LeftGrid.Visibility == Visibility.Hidden) LeftGrid.Visibility = Visibility.Visible;
            else LeftGrid.Visibility = Visibility.Hidden;
        }

        private void btnEn_Click(object sender, RoutedEventArgs e)
        {
            lbLang.Text = "EN";
            language = "en";
        }

        private void btnFr_Click(object sender, RoutedEventArgs e)
        {
            lbLang.Text = "FR";
            language = "fr";
        }

        private void btnRu_Click(object sender, RoutedEventArgs e)
        {
            lbLang.Text = "RU";
            language = "ru";
        }

        private void btnEs_Click(object sender, RoutedEventArgs e)
        {
            lbLang.Text = "ES";
            language = "es";
        }

        private void btnIt_Click(object sender, RoutedEventArgs e)
        {
            lbLang.Text = "IT";
            language = "it";
        }

        private void btnZh_Click(object sender, RoutedEventArgs e)
        {
            lbLang.Text = "ZH";
            language = "zh";
        }

        private void btnJa_Click(object sender, RoutedEventArgs e)
        {
            lbLang.Text = "JA";
            language = "ja";
        }
    }
}
