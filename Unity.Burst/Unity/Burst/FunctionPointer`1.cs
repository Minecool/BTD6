namespace Unity.Burst;

[IsReadOnly]
public struct FunctionPointer
{
	[NativeDisableUnsafePtrRestriction]
	private readonly IntPtr _ptr; //Field offset: 0x0

	public T Invoke
	{
		 get { } //Length: 118
	}

	public IntPtr Value
	{
		 get { } //Length: 4
	}

	public FunctionPointer`1(IntPtr ptr) { }

	public T get_Invoke() { }

	public IntPtr get_Value() { }

}

