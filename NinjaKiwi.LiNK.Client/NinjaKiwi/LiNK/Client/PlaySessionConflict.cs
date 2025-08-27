namespace NinjaKiwi.LiNK.Client;

public class PlaySessionConflict
{
	private readonly Task resolveTask; //Field offset: 0x10
	private readonly TaskCompletionSource<Boolean> playHereTaskCompletionSource; //Field offset: 0x18

	internal Task CanProceed
	{
		internal get { } //Length: 61
	}

	public PlaySessionConflict(Task resolveTask) { }

	internal Task get_CanProceed() { }

	public Task PlayHere() { }

}

