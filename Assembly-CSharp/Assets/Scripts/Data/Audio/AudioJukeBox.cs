namespace Assets.Scripts.Data.Audio;

public class AudioJukeBox : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MusicItem, Task> <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Task <LoadAsync>b__6_0(MusicItem t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public string trackName; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <IsLegendsTrack>b__0(MusicItem musicItem) { }

	}

	[CompilerGenerated]
	private struct <LoadAsync>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AudioJukeBox <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private MusicItem mainTitleBGM; //Field offset: 0x18
	[SerializableDictionary]
	[SerializeField]
	private SerializableDictionary<LegendsType, MusicItem> legendsTitleBGM; //Field offset: 0x20
	public List<MusicItem> musicTrackData; //Field offset: 0x28

	public AudioClip GetTitleTheme
	{
		 get { } //Length: 34
	}

	public AudioJukeBox() { }

	public AudioClip get_GetTitleTheme() { }

	public int GetIndexFromName(string trackName) { }

	public AudioClip GetLegendsTheme(LegendsType legendsType) { }

	public string GetLegendsTitleBGM(LegendsType legendsType) { }

	public string GetMainTitleBGM() { }

	public MusicItem GetMusicItem(string trackName) { }

	public AudioClip GetTrackByName(string trackName) { }

	private bool HasPurchasedLegendsTrack(string trackName) { }

	public bool HasPurchasedTrack(string trackName) { }

	public bool IsFreeTrack(string trackName) { }

	public bool IsLegendsTrack(string trackName) { }

	[AsyncStateMachine(typeof(<LoadAsync>d__6))]
	public Task LoadAsync() { }

}

