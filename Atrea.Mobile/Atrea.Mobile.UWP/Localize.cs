using System.Globalization;
using Xamarin.Forms;

[assembly: Dependency(typeof(Atrea.Mobile.UWP.Localize))]
namespace Atrea.Mobile.UWP
{
	public class Localize : ILocalize
	{
		public System.Globalization.CultureInfo GetCurrentCultureInfo()
		{
			return CultureInfo.CurrentUICulture;
		}
	}
}
