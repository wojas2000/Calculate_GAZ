using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Calculate_GAZ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double GasInm3;
        public double multi, PGN_factor;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GasReadTextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void GasShowTextkWh(object sender, TextCompositionEventArgs e)
        {

        }

        private void GasShowTextkWhCalculation(object sender, TextCompositionEventArgs e)
        {

        }

        private void CalculateButtonClick(object sender, RoutedEventArgs e) //Input, check and calculate m3 to kWh and read a factor in PGNiG
        {
            GasInm3 = double.Parse(GasReadText.Text);
            if (PGN_factor != 0)
            {
                PGN_factor = double.Parse(FactorReadText.Text);
            }
            else
            {
                PGN_factor = 11.319;
            }

            if (GasInm3 >= 0)
            {
                multi = GasInm3 * PGN_factor; //factor for gas in PGNiG default 11.319
                GasShowText.Content = multi;
            }
            else
            {
                MessageBox.Show("Are You reset counter?");
            }

            double PayMonth = 0;
            double GasConsumption = 0;
            double DistributionConstantPay = 0;
            double DistributionVariable = 0;
            double x = double.Parse(MonthReadText.Text);

            GasConsumption = multi * 24.62 * 0.01;

            PayMonth = x * 6.30;
            MonthPayShow.Content = "Months constant pay for Gas Company:" + PayMonth;


            DistributionConstantPay = x * 36.75;  //calculation constant distribution
            DistributionPayShow.Content = "Distribution constant: " + DistributionConstantPay;

            DistributionVariable = multi * 3.69 * 0.01; //calculation variable distribution 
            DistributionVariableShow.Content = "Distribution variable: " + Math.Round((double)DistributionVariable, 2); //show price for variable distribution and round a number

            double wynik = GasConsumption + x + DistributionConstantPay + DistributionVariable;
            double wynikpoint2 = Math.Round(wynik, 2); //round a number
            TotalShowPay.Content = "Gas bill for all months: " + wynikpoint2;
        }

        private void MonthReadTextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MonthPayChanged(object sender, TextCompositionEventArgs e)
        {

        }

        private void LabelProbaChanged(object sender, TextCompositionEventArgs e)
        {

        }

        private void DistributionPayChanged(object sender, TextCompositionEventArgs e)
        {

        }

        private void DistributionVariableShowChanged(object sender, TextCompositionEventArgs e)
        {

        }

        private void FactorReadTextChange(object sender, TextChangedEventArgs e)
        {

        }

        private void TotalShowPayChanged(object sender, TextCompositionEventArgs e)
        {

        }
    }
}
