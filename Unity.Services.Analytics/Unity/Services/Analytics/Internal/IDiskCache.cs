namespace Unity.Services.Analytics.Internal;

internal interface IDiskCache
{

	public void Clear() { }

	public void Write(List<Int32> eventEndIndices, Stream payload) { }

}

