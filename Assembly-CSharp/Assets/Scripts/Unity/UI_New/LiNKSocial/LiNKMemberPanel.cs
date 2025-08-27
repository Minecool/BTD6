namespace Assets.Scripts.Unity.UI_New.LiNKSocial;

public abstract class LiNKMemberPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public LiNKMemberPanel <>4__this; //Field offset: 0x10
		public GameMenu screen; //Field offset: 0x18

		public <>c__DisplayClass34_0() { }

		internal void <Setup>b__0() { }

	}

	[CompilerGenerated]
	private struct <SetName>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string LiNKID; //Field offset: 0x20
		public GameMenu screen; //Field offset: 0x28
		public LiNKMemberPanel <>4__this; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Setup>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKMemberPanel <>4__this; //Field offset: 0x20
		public GameMenu screen; //Field offset: 0x28
		public string LiNKID; //Field offset: 0x30
		private <>c__DisplayClass34_0 <>8__1; //Field offset: 0x38
		public FriendModel friendModel; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter<Btd6FriendsData> <>u__2; //Field offset: 0x50
		private TaskAwaiter<Btd6PlayerStats> <>u__3; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class ButtonsInteractableCallback : MulticastDelegate
	{

		public ButtonsInteractableCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool interactable, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool interactable) { }

	}

	public Button declineFriendButton; //Field offset: 0x20
	public Button removeFriendButton; //Field offset: 0x28
	public Button acceptFriendButton; //Field offset: 0x30
	public Button blockFriendButton; //Field offset: 0x38
	public Button showProfileButton; //Field offset: 0x40
	public Image avatarImg; //Field offset: 0x48
	public Image bannerImg; //Field offset: 0x50
	public NK_TextMeshProUGUI nameText; //Field offset: 0x58
	public NK_TextMeshProUGUI onlineOfflineText; //Field offset: 0x60
	public GameObject onlineContainer; //Field offset: 0x68
	public GameObject onlinePip; //Field offset: 0x70
	public GameObject invisibleStatus; //Field offset: 0x78
	public GameObject requestsPanel; //Field offset: 0x80
	public GameObject acceptedPanel; //Field offset: 0x88
	public GameObject isTeamMemberImg; //Field offset: 0x90
	protected GameMenu screen; //Field offset: 0x98
	[CompilerGenerated]
	private bool <IsFriend>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private LocalizationManager <Locs>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private bool <Interactable>k__BackingField; //Field offset: 0xB0

	public string DisplayName
	{
		 get { } //Length: 42
	}

	protected private bool Interactable
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool IsFriend
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public private LocalizationManager Locs
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public Btd6Player Player
	{
		 get { } //Length: 7
	}

	protected LiNKMemberPanel() { }

	protected abstract Task Bind(GameMenu screen, object data) { }

	public override void ClosePopups() { }

	public string get_DisplayName() { }

	[CompilerGenerated]
	protected bool get_Interactable() { }

	[CompilerGenerated]
	public bool get_IsFriend() { }

	[CompilerGenerated]
	public LocalizationManager get_Locs() { }

	public Btd6Player get_Player() { }

	public abstract string GetLiNKID() { }

	[CompilerGenerated]
	private void set_Interactable(bool value) { }

	[CompilerGenerated]
	protected void set_IsFriend(bool value) { }

	[CompilerGenerated]
	private void set_Locs(LocalizationManager value) { }

	public override void SetInteractable(bool interactable) { }

	[AsyncStateMachine(typeof(<SetName>d__39))]
	protected Task SetName(GameMenu screen, string LiNKID) { }

	[AsyncStateMachine(typeof(<Setup>d__34))]
	protected override Task Setup(GameMenu screen, string LiNKID, FriendModel friendModel = null) { }

	public abstract void ToggleParentInteractable(bool interactable) { }

	public abstract void UpdatePanelAsync() { }

}

