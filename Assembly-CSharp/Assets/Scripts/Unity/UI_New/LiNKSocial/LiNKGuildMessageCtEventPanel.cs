namespace Assets.Scripts.Unity.UI_New.LiNKSocial;

public class LiNKGuildMessageCtEventPanel : LiNKGuildMessagePanel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static ReturnCallback <>9__21_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <OnClickGoToTileAsync>b__21_0() { }

	}

	[CompilerGenerated]
	private struct <Bind>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKGuildMessageCtEventPanel <>4__this; //Field offset: 0x20
		public GuildMessage messageModel; //Field offset: 0x28
		public TeamsScreen screen; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <BindData>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKGuildMessageCtEventPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private CtTileType <tileType>5__2; //Field offset: 0x30
		private TaskAwaiter<GuildModel> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <BindSetCtTileFocus>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKGuildMessageCtEventPanel <>4__this; //Field offset: 0x28
		public DateTime createdAt; //Field offset: 0x30
		public TeamsScreen screen; //Field offset: 0x38
		public int tileId; //Field offset: 0x40
		public string eventId; //Field offset: 0x48
		public string selectedMap; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnClickGoToTileAsync>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKGuildMessageCtEventPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public GameObject panel; //Field offset: 0x58
	public GameObject bannerClaimedBgImage; //Field offset: 0x60
	public GameObject bannerLostBgImage; //Field offset: 0x68
	public GameObject relicClaimedBgImage; //Field offset: 0x70
	public GameObject relicLostBgImage; //Field offset: 0x78
	public GameObject focusMarkerSetPanel; //Field offset: 0x80
	public GameObject scorePanel; //Field offset: 0x88
	public Image mapImage; //Field offset: 0x90
	public GameObject goToImage; //Field offset: 0x98
	public Button goToButton; //Field offset: 0xA0
	public NK_TextMeshProUGUI scoreText; //Field offset: 0xA8
	public NK_TextMeshProUGUI focusMarkerText; //Field offset: 0xB0
	public NK_TextMeshProUGUI loadingText; //Field offset: 0xB8
	protected GuildMessageCtEvent eventData; //Field offset: 0xC0
	private string eventId; //Field offset: 0xC8
	private int tileId; //Field offset: 0xD0

	public LiNKGuildMessageCtEventPanel() { }

	[CompilerGenerated]
	private void <OnClickGoToTileAsync>b__21_1() { }

	[AsyncStateMachine(typeof(<Bind>d__17))]
	public virtual Task Bind(TeamsScreen screen, GuildMessage messageModel) { }

	[AsyncStateMachine(typeof(<BindData>d__19))]
	private Task BindData() { }

	[AsyncStateMachine(typeof(<BindSetCtTileFocus>d__18))]
	public void BindSetCtTileFocus(TeamsScreen screen, string eventId, int tileId, string selectedMap, DateTime createdAt) { }

	public void OnClickGoToTile() { }

	[AsyncStateMachine(typeof(<OnClickGoToTileAsync>d__21))]
	private Task OnClickGoToTileAsync() { }

	public virtual void SetInteractable(bool isInteractable) { }

	private void Setup() { }

}

