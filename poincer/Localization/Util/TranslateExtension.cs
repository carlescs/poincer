using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace poincer.Localization.Util
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        private const string ResourceId = "poincer.Localization.AppResources";
        private readonly CultureInfo _ci;

        public TranslateExtension()
        {
            _ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
        }

        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
                return "";

            var resmgr = new ResourceManager(ResourceId
                , typeof(TranslateExtension).GetTypeInfo().Assembly);

            var translation = resmgr.GetString(Text, _ci);

            if (translation == null)
            {
#if DEBUG
                throw new ArgumentException($"Key '{Text}' was not found in resources '{ResourceId}' for culture '{_ci.Name}'.", nameof(Text));
#else
				translation = Text; // HACK: returns the key, which GETS DISPLAYED TO THE USER
#endif
            }
            return translation;
        }
    }
}