namespace NinjaKiwi.Common;

public class PlayerPrefFloat : PlayerPrefWrapper<Single>
{

	public PlayerPrefFloat(string key, float defaultValue = 0) { }

	protected virtual float GetPref() { }

	protected virtual void SetPref(float value) { }

}

