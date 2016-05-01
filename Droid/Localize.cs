using System;
using Xamarin.Forms;

[assembly:Dependency (typeof(poincer.Droid.Localize))]
namespace poincer.Droid
{
	public class Localize : poincer.Localization.Util.ILocalize
	{
		public System.Globalization.CultureInfo GetCurrentCultureInfo ()
		{
			var androidLocale = Java.Util.Locale.Default;
			var netLanguage = androidLocale.ToString ().Replace ("_", "-"); // turns pt_BR into pt-BR
			return new System.Globalization.CultureInfo (netLanguage);
		}
	}
}

