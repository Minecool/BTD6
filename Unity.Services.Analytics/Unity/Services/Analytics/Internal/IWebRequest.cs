namespace Unity.Services.Analytics.Internal;

internal interface IWebRequest
{

	public bool IsNetworkError
	{
		 get { } //Length: 0
	}

	public void Dispose() { }

	public bool get_IsNetworkError() { }

	public UnityWebRequestAsyncOperation SendWebRequest() { }

	public void SetRequestHeader(string key, string value) { }

}

