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

namespace Example13Project
{
    /// <summary>
    /// Interaction logic for SquareOrCubeCalc.xaml
    /// </summary>
    public partial class SquareOrCubeCalc : Window
    {
        public SquareOrCubeCalc()
        {
            InitializeComponent();
        }
        private bool IsNum(string numStr)
        {
            try
            {
                int.Parse(numStr);
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        private void btnSquare_Click(object sender, RoutedEventArgs e)
        {
            if (!IsNum(txtNumber.Text))
            {
                MessageBox.Show("Please enter a number");
                txtNumber.Focus();
                txtNumber.SelectAll();
                return;
            }

            int number = int.Parse(txtNumber.Text);
            int square = number * number;
            lblResult.Text = "Square";
            txtResult.Text = square.ToString();
        }

        private void btnCube_Click(object sender, RoutedEventArgs e)
        {
            if (!IsNum(txtNumber.Text))
            {
                MessageBox.Show("Please enter a number");
                txtNumber.Focus();
                txtNumber.SelectAll();
                return;
            }

            int number = int.Parse(txtNumber.Text);
            int cube = number * number * number;
            lblResult.Text = "Cube";
            txtResult.Text = cube.ToString();
        }
    }
}
