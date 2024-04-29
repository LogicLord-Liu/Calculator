using System;
using System.Collections.Generic;
using System.Data;
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
    /// calculator.xaml 的交互逻辑
    /// </summary>
    public partial class calculator : Window
    {
        public calculator()
        {
            InitializeComponent();
        }
        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = "0";
        }

        private void BtnInput_click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                txtInput.Text += button.Content.ToString();
            }
        }

        private void BtnOperator_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                txtInput.Text += button.Content.ToString();
            }
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string input = txtInput.Text;
                var result = new DataTable().Compute(input, null);
                txtInput.Text = result.ToString();
            }
            catch (Exception ex)
            {
                txtInput.Text = "Error";
            }
        }
    }
}
