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
using YoutubeSub.Service;

namespace YoutubeSub
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string language=null;
        private ISender _sender;

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
            LeftGrid.Visibility = Visibility.Hidden;
        }

        private void btnFr_Click(object sender, RoutedEventArgs e)
        {
            lbLang.Text = "FR";
            language = "fr";
            LeftGrid.Visibility = Visibility.Hidden;
        }

        private void btnRu_Click(object sender, RoutedEventArgs e)
        {
            lbLang.Text = "RU";
            language = "ru";
            LeftGrid.Visibility = Visibility.Hidden;
        }

        private void btnEs_Click(object sender, RoutedEventArgs e)
        {
            lbLang.Text = "ES";
            language = "es";
            LeftGrid.Visibility = Visibility.Hidden;
        }

        private void btnIt_Click(object sender, RoutedEventArgs e)
        {
            lbLang.Text = "IT";
            language = "it";
            LeftGrid.Visibility = Visibility.Hidden;
        }

        private void btnZh_Click(object sender, RoutedEventArgs e)
        {
            lbLang.Text = "ZH";
            language = "zh";
            LeftGrid.Visibility = Visibility.Hidden;
        }

        private void btnJa_Click(object sender, RoutedEventArgs e)
        {
            lbLang.Text = "JA";
            language = "ja";
            LeftGrid.Visibility = Visibility.Hidden;
        }
        private void btnDe_Click(object sender, RoutedEventArgs e)
        {
            lbLang.Text = "DE";
            language = "de";
            LeftGrid.Visibility = Visibility.Hidden;
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbId.Text) && language!=null) 
            {
                _sender = new SenderService();

                string uri =$"http://video.google.com/timedtext?lang={language}&v={tbId.Text}";
                try
                {
                    string text = _sender.Send(uri);
                    textBody.Text = text;
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed request...", "Exception");
                }
            }           
        }

    }
}
