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

namespace SpotifyGold.MVVM.View
{
    /// <summary>
    /// Lógica de interacción para LeaveView.xaml
    /// </summary>
    public partial class LeaveView : UserControl
    {
        public LeaveView()
        {
            InitializeComponent();
        }

        private void Yes(object sender, RoutedEventArgs e)
        {

            Application.Current.Shutdown();
        }
    }
}
