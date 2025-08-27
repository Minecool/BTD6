namespace UnityEngine.ResourceManagement.Util;

internal sealed class IdCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey>
{
	public string ID; //Field offset: 0x10

	public IdCacheKey(string id) { }

	private bool Equals(IdCacheKey other) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(IOperationCacheKey other) { }

	public virtual int GetHashCode() { }

}

