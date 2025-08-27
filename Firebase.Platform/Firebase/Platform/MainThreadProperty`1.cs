namespace Firebase.Platform;

internal class MainThreadProperty
{
	private Func<T> getPropertyDelegate; //Field offset: 0x0
	private int lastGetPropertyTickCount; //Field offset: 0x0
	private T cachedValue; //Field offset: 0x0

	public T Value
	{
		 get { } //Length: 817
	}

	public MainThreadProperty`1(Func<T> getPropertyDelegate) { }

	[CompilerGenerated]
	private T <get_Value>b__5_0() { }

	public T get_Value() { }

}

