namespace Assets.Scripts.Utils;

public class Cache : GenericCache
{
	private T value; //Field offset: 0x0
	private bool isValid; //Field offset: 0x0
	private Func<T> calculation; //Field offset: 0x0
	public Action<T> onUpdate; //Field offset: 0x0
	public Action<T> onInvalidate; //Field offset: 0x0

	public Cache`1(Func<T> calculation) { }

	public void AddDependant(GenericCache cache) { }

	public void ClearDependants() { }

	public T GetValue() { }

	public void Invalidate() { }

	public static T op_Implicit(Cache<T> cache) { }

	private void Update() { }

}

