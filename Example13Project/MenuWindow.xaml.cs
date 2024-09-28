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
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }
        private SumCalcWindow sumCalcWindow = new SumCalcWindow();
        private SquareOrCubeCalc squareOrCubeCalc = new SquareOrCubeCalc();
        private MainWindow mainWindow = new MainWindow();

        /*public void ShowChild()
        {
            e.Cancel = true;
            this.Hide();
        }*/
        private void btnSquareOrCalculator_Click(object sender, RoutedEventArgs e)
        {
            squareOrCubeCalc.Show();
            squareOrCubeCalc.Activate();
        }

        private void btnSumCalculator_Click(object sender, RoutedEventArgs e)
        {
            sumCalcWindow.Show();
            sumCalcWindow.Activate();
        }

       

        private void btnCounter_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Show();
            mainWindow.Activate();
        }
    }
}
