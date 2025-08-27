namespace Assets.Scripts.Utils;

public struct Optional
{
	public static Optional<T> Invalid; //Field offset: 0x0
	public readonly bool isValid; //Field offset: 0x0
	private readonly T value; //Field offset: 0x0

	private Optional`1(T value) { }

	public static T op_Implicit(Optional<T> optional) { }

	public static Optional<T> op_Implicit(T value) { }

	public T Unwrap() { }

}

