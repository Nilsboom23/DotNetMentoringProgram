namespace Reflection.Interfaces
{
	interface IConfigurationProvider
    {
        object GetValue(string settingName);
        void SetValue(string settingName, object value);
    }
}
