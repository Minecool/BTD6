namespace UnityEngine;

[Extension]
public static class AsyncOperationAwaitableExtensions
{

	[ExcludeFromDocs]
	[Extension]
	public static Awaiter GetAwaiter(AsyncOperation op) { }

}

