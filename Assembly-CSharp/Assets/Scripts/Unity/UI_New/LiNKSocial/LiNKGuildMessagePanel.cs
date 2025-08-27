namespace Assets.Scripts.Unity.UI_New.LiNKSocial;

public abstract class LiNKGuildMessagePanel : MonoBehaviour
{
	[CompilerGenerated]
	private struct <TryLoadAppropriateDisplayName>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKGuildMessagePanel <>4__this; //Field offset: 0x20
		private TaskAwaiter<String> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public GameObject loadingPanel; //Field offset: 0x20
	public NK_TextMeshProUGUI text; //Field offset: 0x28
	public NK_TextMeshProUGUI timestamp; //Field offset: 0x30
	protected GuildMessage messageModel; //Field offset: 0x38
	protected TeamsScreen screen; //Field offset: 0x40
	[CompilerGenerated]
	private string <AppropriateDisplayName>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private DateTime <CreatedAt>k__BackingField; //Field offset: 0x50

	protected private string AppropriateDisplayName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public DateTime CreatedAt
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	protected LocalizationManager Locs
	{
		 get { } //Length: 48
	}

	protected LiNKGuildMessagePanel() { }

	public abstract Task Bind(TeamsScreen screen, GuildMessage messageModel) { }

	[CompilerGenerated]
	protected string get_AppropriateDisplayName() { }

	[CompilerGenerated]
	public DateTime get_CreatedAt() { }

	protected LocalizationManager get_Locs() { }

	[CompilerGenerated]
	private void set_AppropriateDisplayName(string value) { }

	[CompilerGenerated]
	protected void set_CreatedAt(DateTime value) { }

	public override void SetInteractable(bool isInteractable) { }

	[AsyncStateMachine(typeof(<TryLoadAppropriateDisplayName>d__16))]
	protected Task TryLoadAppropriateDisplayName() { }

}

