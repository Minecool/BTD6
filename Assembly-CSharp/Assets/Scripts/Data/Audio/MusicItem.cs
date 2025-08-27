namespace Assets.Scripts.Data.Audio;

public class MusicItem : AssetChangeItem
{
	[CompilerGenerated]
	private struct <PreloadAsync>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MusicItem <>4__this; //Field offset: 0x20
		private TaskAwaiter<AudioClip> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private AudioClip <Clip>k__BackingField; //Field offset: 0x20
	[SerializeField]
	private AudioClipReference clip; //Field offset: 0x28
	public string locKey; //Field offset: 0x30
	public bool freeTrack; //Field offset: 0x38
	public bool unavailableInJukeBox; //Field offset: 0x39

	public private AudioClip Clip
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public MusicItem() { }

	[CompilerGenerated]
	public AudioClip get_Clip() { }

	[AsyncStateMachine(typeof(<PreloadAsync>d__8))]
	public Task PreloadAsync() { }

	[CompilerGenerated]
	private void set_Clip(AudioClip value) { }

}

