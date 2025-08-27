namespace NinjaKiwi.Common;

public abstract class PlayerPrefWrapper
{
	protected string key; //Field offset: 0x0
	private bool initialised; //Field offset: 0x0
	private T _accessor_value; //Field offset: 0x0

	public bool Exists
	{
		 get { } //Length: 11
	}

	public T Value
	{
		 get { } //Length: 79
		 set { } //Length: 432
	}

	public PlayerPrefWrapper`1(string key, T defaultValue) { }

	public bool get_Exists() { }

	public T get_Value() { }

	protected abstract T GetPref() { }

	public void set_Value(T value) { }

	protected abstract void SetPref(T value) { }

}

