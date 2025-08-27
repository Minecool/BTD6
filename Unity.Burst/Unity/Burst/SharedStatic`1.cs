namespace Unity.Burst;

[IsReadOnly]
public struct SharedStatic
{
	private readonly Void* _buffer; //Field offset: 0x0

	public T Data
	{
		 get { } //Length: 36
	}

	public Void* UnsafeDataPointer
	{
		 get { } //Length: 4
	}

	private SharedStatic`1(Void* buffer) { }

	public T get_Data() { }

	public Void* get_UnsafeDataPointer() { }

	public static SharedStatic<T> GetOrCreate(uint alignment = 0) { }

	public static SharedStatic<T> GetOrCreateUnsafe(uint alignment, long hashCode, long subHashCode) { }

}

