namespace NinjaKiwi.LiNK.Client.Timing;

internal sealed class BackupTimer
{
	internal sealed class OnTimeUp : MulticastDelegate
	{

		public OnTimeUp(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool needToBackup, int count, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool needToBackup, int count) { }

	}

	private readonly PlayerOptions options; //Field offset: 0x10
	private AsyncTimer timer; //Field offset: 0x18
	private OnTimeUp onCompleteAction; //Field offset: 0x20

	public TimeSpan Period
	{
		 get { } //Length: 171
	}

	public BackupTimer(PlayerOptions options, OnTimeUp onCompleteAction) { }

	public void Cancel() { }

	public void Deactivate() { }

	public TimeSpan get_Period() { }

	private void OnTimer(int count) { }

	public void ResetCounter() { }

	public void Start() { }

}

