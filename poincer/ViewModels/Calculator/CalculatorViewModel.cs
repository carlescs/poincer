using System.ComponentModel;
using System.Runtime.CompilerServices;
using poincer.Annotations;

namespace poincer.ViewModels.Calculator
{
    public class CalculatorViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}