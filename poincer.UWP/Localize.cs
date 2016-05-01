using System.Globalization;
using Xamarin.Forms;

[assembly: Dependency(typeof(poincer.UWP.Localize))]
namespace poincer.UWP
{
    public class Localize : Localization.Util.ILocalize
    {
        public CultureInfo GetCurrentCultureInfo()
        {
            return CultureInfo.DefaultThreadCurrentCulture;
        }
    }
}