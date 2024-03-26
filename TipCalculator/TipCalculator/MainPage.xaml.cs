namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        double valor = 0;
        double porcentagem = 0;
        double gorj = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void PercentageSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            TipPercentageLabel.Text = $"{PercentageSlider.Value.ToString()}%";
        }

        private void Button15Percent_Clicked(object sender, EventArgs e)
        {
            PercentageSlider.Value= 15 ;
        }

        private void Button30Percent_Clicked(object sender, EventArgs e)
        {
            PercentageSlider.Value = 30;
        }

        private void ButtonRoundUp_Clicked(object sender, EventArgs e)
        {
            double tip = CalculateTip();
            tip = Math.Ceiling(tip);
            TipLabel.Text = Convert.ToString(tip);
            double valorRefeicao = tip + Convert.ToDouble(ValueEntry.Text);
            PriceLabel.Text = valorRefeicao.ToString("C2");

        }

        private void ButtonRoundDown_Clicked(object sender, EventArgs e)
        {
            

        }
        private double CalculateTip()
        {
            valor = Convert.ToDouble(ValueEntry.Text);
            porcentagem = PercentageSlider.Value;
            gorj = valor * (porcentagem / 100);
            return (gorj);

        }
    }

}
