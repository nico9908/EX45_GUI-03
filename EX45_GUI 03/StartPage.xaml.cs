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

namespace EX45_GUI_03
{
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }
        private void Btn_InsertPet(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = new InsertPet();
        }

        private void Btn_InsertOwner(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_ShowPets(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_FindOwner(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_ExitProgram(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit this program?", "Warning!", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No) == MessageBoxResult.No)
            {
                StartPage startPage = new StartPage();
                
            }
            else
            {
                Application.Current.Shutdown();
            }
        }
    }
}
