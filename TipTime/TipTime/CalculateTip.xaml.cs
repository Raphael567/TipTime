namespace TipTime;

public partial class CalculateTip : ContentPage
{
	public CalculateTip()
	{
		InitializeComponent();
	}
    void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
    {
        double value = args.NewValue;
        rotatingLabel.Rotation = value;
        displayLabel.Text = String.Format("The Slider value is {0}", value);
    }
}