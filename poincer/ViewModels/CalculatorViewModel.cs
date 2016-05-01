using System;
using System.ComponentModel;

namespace poincer.ViewModels
{
	public class CalculatorViewModel:INotifyPropertyChanged
	{
		public CalculatorViewModel ()
		{
			
		}

		decimal fat;
		public decimal Fat {
			get {
				return fat;
			}
			set {
				if (fat != value) {
					fat = value;
					OnPropertyChanged (nameof (Fat));
					OnPropertyChanged (nameof (Points));
				}
			}
		}

		decimal carbohydrates;
		public decimal Carbohydrates {
			get {
				return carbohydrates;
			}
			set {
				if (carbohydrates != value) {
					carbohydrates = value;
					OnPropertyChanged (nameof (Carbohydrates));
					OnPropertyChanged (nameof (Points));
				}
			}
		}

		decimal fibre;
		public decimal Fibre {
			get {
				return fibre;
			}
			set {
				if (fibre != value) {
					fibre = value;
					OnPropertyChanged (nameof (Fibre));
					OnPropertyChanged (nameof (Points));
				}
			}
		}

		decimal protein;
		public decimal Protein {
			get {
				return protein;
			}
			set {
				if (protein != value) {
					protein = value;
					OnPropertyChanged (nameof (Protein));
					OnPropertyChanged (nameof (Points));
				}
			}
		}

		public decimal Points {
			get {
				return Math.Max((16m * Protein + 19m * Carbohydrates + 45m * Fat + 5m * Fibre) / 175m, 0);
			}
		}


		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;


		protected virtual void OnPropertyChanged (string propertyName)
		{
			var handler = PropertyChanged;
			if (handler != null)
				handler (this, new PropertyChangedEventArgs(propertyName));
		}
		#endregion
	}
}

