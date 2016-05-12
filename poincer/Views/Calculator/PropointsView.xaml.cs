using System;
using Xamarin.Forms;

namespace poincer.Views.Calculator
{
	public partial class PropointsView:ContentPage
	{
		public PropointsView ()
		{
			InitializeComponent ();

            BindingContextChanged += CalculatorView_BindingContextChanged;
            MessagingCenter.Send<Page>(this, "BindingContext.CalculatorViewModel");
        }

        private void CalculatorView_BindingContextChanged(object sender, EventArgs e)
        {
            MessagingCenter.Send<Page>(this, "BindingContext.CalculatorViewModel");
        }
    }
}

