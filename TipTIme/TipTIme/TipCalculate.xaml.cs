namespace TipTIme;

public partial class TipCalculate : ContentPage
{
	public TipCalculate()
	{
		InitializeComponent();
	}

    private void Button15Percentage_Clicked(object sender, EventArgs e)
    {
        TipPercentageSlider.Value = 15;
    }

    private void Button20Percentage_Clicked(object sender, EventArgs e)
    {
        TipPercentageSlider.Value = 20;
    }

    private void RoundDownButton_Clicked(object sender, EventArgs e)
    {
        // Arredondar o n�mero para o intei8ro menor ao valor
        // Pegar o valor da refei��o
        // Pegar a porcentagem que o usu�rio selecionou
        // Calcular o valor da gorjeta
        // Arredondar
        // Calcular o total
        // Exibir

        double valorDaRefei��o = Convert.ToDouble(ValueEntry.Text);
        double porcentagemDaGorjeta = TipPercentageSlider.Value/100;
        double valorDaGorjeta = valorDaRefei��o * porcentagemDaGorjeta;
        valorDaGorjeta = Math.Floor(valorDaGorjeta);
        double totalRefei��o = valorDaGorjeta + valorDaRefei��o;

        TotalLabel.Text = totalRefei��o.ToString();
        TipLabel.Text = valorDaGorjeta.ToString();
    }

    private void RoundUpButton_Clicked(object sender, EventArgs e)
    {
        double valorDaRefei��o = Convert.ToDouble(ValueEntry.Text);
        double porcentagemDaGorjeta = TipPercentageSlider.Value / 100;
        double valorDaGorjeta = valorDaRefei��o * porcentagemDaGorjeta;
        valorDaGorjeta = Math.Ceiling(valorDaGorjeta);
        double totalRefei��o = valorDaGorjeta + valorDaRefei��o;

        TotalLabel.Text = totalRefei��o.ToString();
        TipLabel.Text = valorDaGorjeta.ToString();

    }

    private void TipPercentageSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double valorDoSlider = TipPercentageSlider.Value;
        PercentageLabel.Text = valorDoSlider.ToString() + "%"; 
    }
}