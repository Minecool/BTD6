namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class CurationVoteInfo : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<RejectionReason, String> <>9__9_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <SetText>b__9_1(RejectionReason x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public CurationVote curationVote; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal bool <SetText>b__0(RejectionReason x) { }

	}

	[CompilerGenerated]
	private struct <SetText>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CurationVoteInfo <>4__this; //Field offset: 0x20
		private <>c__DisplayClass9_0 <>8__1; //Field offset: 0x28
		public bool isAdmin; //Field offset: 0x30
		public bool isValidation; //Field offset: 0x31
		private TaskAwaiter<String> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Image validatedIcon; //Field offset: 0x20
	[SerializeField]
	private Image rejectedIcon; //Field offset: 0x28
	[SerializeField]
	private Image reportedIcon; //Field offset: 0x30
	[SerializeField]
	private NK_TextMeshProUGUI validatedText; //Field offset: 0x38
	[SerializeField]
	private NK_TextMeshProUGUI rejectedText; //Field offset: 0x40
	private CurationVote curationVote; //Field offset: 0x48

	private static LocalizationManager Locs
	{
		private get { } //Length: 48
	}

	public CurationVoteInfo() { }

	private static LocalizationManager get_Locs() { }

	private static ValueTuple<Boolean, Int32> GetTimeAgo(DateTime voteTime) { }

	public void Load(CurationVote curationVote) { }

	public void LoadReports(int reportCount) { }

	[AsyncStateMachine(typeof(<SetText>d__9))]
	private Task SetText(bool isValidation, bool isAdmin) { }

}

