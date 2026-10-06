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

namespace LetHimCook
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            MainFrame.NavigationService.Navigate(new Pages.MainPage());
        }

        private bool IsDarkTheme = false;

        private void StyleButton_Click(object sender, RoutedEventArgs e)
        {
            IsDarkTheme = !IsDarkTheme;

            string theme = "";
            if (IsDarkTheme) theme = "Dark.xaml";
            else theme = "Light.xaml";

            var dictionary = new ResourceDictionary
            {
                Source = new Uri($"Styles/{theme}", UriKind.Relative)
            };
            Application.Current.Resources[0] = dictionary;
        }

        private void MainButt_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button button)
            {
                if (button.Tag != null)
                {

                    if (button.Tag != null)
                    {
                        switch (button.Tag)
                        {
                            case "1":
                                MainFrame.Navigate(new Pages.MainPage());
                                break;
                            case "2":
                                MainFrame.Navigate(new Pages.CreatePage());
                                break;
                            case "3":
                                MainFrame.Navigate(new Pages.UserPage());
                                break;
                        }

                    }
                }

            }
        }

        
    }
}
