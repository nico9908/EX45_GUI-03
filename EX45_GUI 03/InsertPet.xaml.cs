﻿using System;
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
    /// Interaction logic for InsertPet.xaml
    /// </summary>
    public partial class InsertPet : Page
    {
        public InsertPet()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainMenu = new MainWindow();
            this.Content = mainMenu;
        }
    }
}
