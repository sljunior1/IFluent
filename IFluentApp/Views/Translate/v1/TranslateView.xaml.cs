namespace IFluentApp.Views.Translate.v1;

public partial class TranslateView : ContentPageBase
{
	public TranslateView()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		var first = lblFirst.Text;
		var second = lblSecond.Text;

		lblFirst.Text = second;
        lblSecond.Text = first;
    }
}