namespace NinjaKiwi.Common;

public class PlayerPrefString : PlayerPrefWrapper<String>
{

	public PlayerPrefString(string key, string defaultValue = "") { }

	protected virtual string GetPref() { }

	protected virtual void SetPref(string value) { }

}

