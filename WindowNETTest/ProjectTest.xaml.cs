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
using System.Windows.Shapes;

namespace WindowNETTest
{
    /// <summary>
    /// ProjectTest.xaml 的交互逻辑
    /// </summary>
    public partial class ProjectTest : Window
    {
        public ProjectTest()
        {
            InitializeComponent();

            new Label().Content = new Button();
        }

        private void TextBox_TextChange(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("First you having change this Text");
            MessageBox.Show(TB.Text);
        }

        private void TextBox_TextChangeTwo(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Second you having change this Text");
            MessageBox.Show(Tb.Text);
        }
    }
}
