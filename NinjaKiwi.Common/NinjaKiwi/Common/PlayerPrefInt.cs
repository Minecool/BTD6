namespace NinjaKiwi.Common;

public class PlayerPrefInt : PlayerPrefWrapper<Int32>
{

	public PlayerPrefInt(string key, int defaultValue = 0) { }

	protected virtual int GetPref() { }

	protected virtual void SetPref(int value) { }

}

