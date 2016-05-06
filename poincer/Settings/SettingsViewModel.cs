using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using poincer.Annotations;
using poincer.Helpers;

namespace poincer.Settings
{
    public class SettingsViewModel:INotifyPropertyChanged
    {
        public SettingsViewModel()
        {
            MainText = "Hola";
        }

        private readonly Dictionary<string, CalculatorType> _calculatorTypes = new Dictionary<string, CalculatorType>
        {
            {"Propoints", CalculatorType.Propoints},
            {"Propoints 2", CalculatorType.Propoints2}
        };

        private string _calculatorTypeText;

        public IEnumerable<string> CalculatorsTypeText => _calculatorTypes.Select(t => t.Key);

        public string CalculatorTypeText
        {
            get
            {
                if (_calculatorTypeText == null)
                {
                    CalculatorTypeText = _calculatorTypes.SingleOrDefault(t => t.Value == Helpers.Settings.CalculatorType).Key;
                }
                return _calculatorTypeText;
            }
            set
            {
                if (_calculatorTypeText != value)
                {
                    _calculatorTypeText = value;
                    Helpers.Settings.CalculatorType = _calculatorTypes[value];
                    OnPropertyChanged(nameof(CalculatorTypeText));
                }
            }
        }

        public string MainText { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}