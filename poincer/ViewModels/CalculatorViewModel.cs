using System;
using System.ComponentModel;
using poincer.Settings;
using Xamarin.Forms;

namespace poincer.ViewModels
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        private decimal _carbohydrates;
        private decimal _fat;
        private decimal _fibre;
        private Page _page;
        private decimal _protein;

        public CalculatorViewModel()
        {
            InitCommand = new Command(Init);
            SettingsCommand=new Command(async ()=>await References.NavigationPage.PushAsync(new SettingsView()));
            MessagingCenter.Subscribe<Page>(this, "BindingContext.CalculatorViewModel", page => _page = page);
        }

        private void Init()
        {
            _carbohydrates = 0;
            _fat = 0;
            _fibre = 0;
            _protein = 0;
            OnPropertyChanged(nameof(Carbohydrates));
            OnPropertyChanged(nameof(Fat));
            OnPropertyChanged(nameof(Fibre));
            OnPropertyChanged(nameof(Protein));
            OnPropertyChanged(nameof(Points));
        }

        public decimal Fat
        {
            get { return _fat; }
            set
            {
                if (_fat != value)
                {
                    _fat = value;
                    OnPropertyChanged(nameof(Fat));
                    OnPropertyChanged(nameof(Points));
                }
            }
        }

        public decimal Carbohydrates
        {
            get { return _carbohydrates; }
            set
            {
                if (_carbohydrates != value)
                {
                    _carbohydrates = value;
                    OnPropertyChanged(nameof(Carbohydrates));
                    OnPropertyChanged(nameof(Points));
                }
            }
        }

        public decimal Fibre
        {
            get { return _fibre; }
            set
            {
                if (_fibre != value)
                {
                    _fibre = value;
                    OnPropertyChanged(nameof(Fibre));
                    OnPropertyChanged(nameof(Points));
                }
            }
        }

        public decimal Protein
        {
            get { return _protein; }
            set
            {
                if (_protein != value)
                {
                    _protein = value;
                    OnPropertyChanged(nameof(Protein));
                    OnPropertyChanged(nameof(Points));
                }
            }
        }

        public decimal Points => Math.Max((16m*Protein + 19m*Carbohydrates + 45m*Fat + 5m*Fibre)/175m, 0);

        public Command InitCommand { get; private set; }
        public Command SettingsCommand { get; private set; }

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}