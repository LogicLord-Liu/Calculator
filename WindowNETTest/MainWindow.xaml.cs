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

namespace WindowNETTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Hanler(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("You click this grid");
        }

        private void Rec_Hanler(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("You click this Rectangle");
        }

        private void Click_Hanler(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You click this button");
        }
    }
}
