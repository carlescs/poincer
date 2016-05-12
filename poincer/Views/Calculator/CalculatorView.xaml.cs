using System;
using poincer.ViewModels.Calculator;
using Xamarin.Forms;

namespace poincer.Views.Calculator
{
    public partial class CalculatorView
    {
        public CalculatorView()
        {
            InitializeComponent();
            //Menu.List.ItemSelected += CalculatorView_ItemSelected;
        }

        private void CalculatorView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            NavigateTo(e.SelectedItem as MyMenuItem);
        }

        private void NavigateTo(MyMenuItem menuItem)
        {
            Page displayPage = (Page) Activator.CreateInstance(menuItem.TargetType);
            Detail = displayPage;
            IsPresented = false;
        }
    }
}
