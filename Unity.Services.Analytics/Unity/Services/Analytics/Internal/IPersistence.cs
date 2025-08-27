namespace Unity.Services.Analytics.Internal;

internal interface IPersistence
{

	public int LoadValue(string key) { }

	public void SaveValue(string key, int value) { }

}

