namespace NinjaKiwi.LiNK.Client;

public class DataConflict
{
	public readonly DataT localData; //Field offset: 0x0
	public readonly DataT remoteData; //Field offset: 0x0
	public readonly bool isFirstSync; //Field offset: 0x0
	public readonly Exception remoteDataError; //Field offset: 0x0
	private readonly Task resolveTask; //Field offset: 0x0
	private readonly TaskCompletionSource<Boolean> dataChoiceTaskCompletionSource; //Field offset: 0x0

	internal Task<Boolean> LocalOrRemoteChoice
	{
		internal get { } //Length: 61
	}

	internal DataConflict`1(DataT localData, DataT remoteData, bool isFirstSync, Exception remoteDataError, Task resolveTask) { }

	internal Task<Boolean> get_LocalOrRemoteChoice() { }

	public Task UseLocal() { }

	public Task UseRemote() { }

}

