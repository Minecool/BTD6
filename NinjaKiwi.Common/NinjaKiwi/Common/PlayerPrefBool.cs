namespace NinjaKiwi.Common;

public class PlayerPrefBool : PlayerPrefWrapper<Boolean>
{

	public PlayerPrefBool(string key, bool defaultValue = false) { }

	protected virtual bool GetPref() { }

	protected virtual void SetPref(bool value) { }

}

