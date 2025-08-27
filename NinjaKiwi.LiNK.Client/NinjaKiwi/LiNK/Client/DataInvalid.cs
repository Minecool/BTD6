namespace NinjaKiwi.LiNK.Client;

public class DataInvalid
{
	private readonly Task resolveTask; //Field offset: 0x10
	private readonly TaskCompletionSource<Boolean> proceedTaskCompletionSource; //Field offset: 0x18

	internal Task CanProceed
	{
		internal get { } //Length: 61
	}

	internal DataInvalid(Task resolveTask) { }

	internal Task get_CanProceed() { }

	public Task Proceed() { }

}

