namespace Assets.Scripts.Unity.Audio;

public class MiniJukeBoxPlayer : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Start>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public MiniJukeBoxPlayer <>4__this; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public NK_TextMeshProUGUI currentTrackTxt; //Field offset: 0x20
	public Animator equalizerAnimator; //Field offset: 0x28
	public Image trackLength; //Field offset: 0x30
	public GameObject controls; //Field offset: 0x38
	public Button prevTrackBtn; //Field offset: 0x40
	public Button nextTrackBtn; //Field offset: 0x48
	public Toggle loopTrackBtn; //Field offset: 0x50
	public Toggle shufflePlaylistBtn; //Field offset: 0x58
	private TrackItemData currentTrack; //Field offset: 0x60

	private AudioFactory AudioFactory
	{
		private get { } //Length: 68
	}

	private InGameMusicFactory MusicFactory
	{
		private get { } //Length: 77
	}

	public MiniJukeBoxPlayer() { }

	[CompilerGenerated]
	private bool <GetTrackData>b__21_0(TrackItemData x) { }

	[CompilerGenerated]
	private void <Start>b__13_0() { }

	[CompilerGenerated]
	private void <Start>b__13_1() { }

	private void ChangeTrack(int move) { }

	private AudioFactory get_AudioFactory() { }

	private InGameMusicFactory get_MusicFactory() { }

	private TrackItemData GetTrackData() { }

	private int GetTrackIndex(TrackItemData trackItemData) { }

	private List<TrackItemData> GetTrackList() { }

	private void LoopTrackClicked(bool isOn) { }

	private void PlayNewTrack(TrackItemData trackData) { }

	private void ShufflePlaylistClicked(bool isOn) { }

	[AsyncStateMachine(typeof(<Start>d__13))]
	private void Start() { }

	private void StopCurrentTrack() { }

	private void Update() { }

	private void UpdateDisplay() { }

	private void UpdateTrackPosition() { }

}

