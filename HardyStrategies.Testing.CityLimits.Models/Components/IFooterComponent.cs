namespace HardyStrategies.Testing.CityLimits.Models.Components
{
	public interface IFooterComponent
	{
		void NavigateToFacebook();
		void NavigateToYelp();
		string GetPhoneNumberTarget();
		string GetCellPhoneNumberTarget();
		string GetEmailTarget();
	}
}