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
    /// Interaction logic for ShowPets.xaml
    /// </summary>
    public partial class ShowPets : Page
    {
        Controller cont = new Controller();
        public ShowPets()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = new StartPage();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cont.ShowPets();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cont.ShowPets();
        }
    }
}
