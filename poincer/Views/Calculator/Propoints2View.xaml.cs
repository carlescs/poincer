using System;
using Xamarin.Forms;

namespace poincer.Views
{
	public partial class Propoints2View
	{
		public Propoints2View ()
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

