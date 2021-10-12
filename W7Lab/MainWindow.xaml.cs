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

namespace W7Lab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculationButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Operation = listBox.SelectedIndex;
                decimal leftHand = Convert.ToDecimal(leftTextBox.Text);
                decimal rightHand = Convert.ToDecimal(rightTextBox.Text);
                decimal result = 0;
                switch (Operation)
                {
                    case 0:
                        result = leftHand + rightHand;
                        resultTextBox.Text = result.ToString();
                        break;
                    case 1:
                        result = leftHand - rightHand;
                        resultTextBox.Text = result.ToString();
                        break;
                    case 2:
                        result = leftHand * rightHand;
                        resultTextBox.Text = result.ToString();
                        break;
                    case 3:
                        result = leftHand / rightHand;
                        resultTextBox.Text = result.ToString();
                        break;
                    case 4:
                        result = leftHand % rightHand;
                        resultTextBox.Text = result.ToString();
                        break;
                    default:
                        result = 0;
                        MessageBox.Show("No operation selected");
                        break;
                }
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("error : Can not divide by zero");
            }
        }
    }
}
